Imports System.Configuration
Imports Emgu.CV
Imports Emgu.CV.Util
Imports Emgu.CV.CvEnum
Imports MySql.Data.MySqlClient
Imports System.IO
Imports Emgu.CV.Structure

Module DatabaseModule
    Public connectionString As String = ConfigurationManager.ConnectionStrings("ImageMatch_Desktop_Context").ConnectionString
    Public Function ExecuteQuery(query As String) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function ExecuteQueryWithParameters(query As String, parameters As List(Of MySqlParameter)) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    command.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            Clipboard.SetText(ex.ToString)
            Return False
        End Try
    End Function
    Public Sub LoadListView(listView As ListView, tableName As String)
        listView.Items.Clear()
        Try
            Dim query As String = $"SELECT * FROM {tableName}"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim listViewItem As New ListViewItem(reader.GetInt32(0).ToString())
                            For i As Integer = 1 To reader.FieldCount - 1
                                listViewItem.SubItems.Add(reader.GetString(i))
                            Next
                            listView.Items.Add(listViewItem)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try

    End Sub




#Region "Old codes"
    '' Method to convert image path to byte array and resize (for EmguCV 2.4.10)
    'Public Function GetResizedImageBytes(ByVal inputImage As Image, ByVal newSize As Size) As Byte()
    '    ' Create a new bitmap with the desired size
    '    Dim resizedImage As New Bitmap(newSize.Width, newSize.Height)

    '    ' Create a graphics object from the new bitmap
    '    Using g As Graphics = Graphics.FromImage(resizedImage)
    '        ' Set the interpolation mode for smoother resizing
    '        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

    '        ' Draw the input image onto the new bitmap with the specified size
    '        g.DrawImage(inputImage, New Rectangle(0, 0, newSize.Width, newSize.Height))
    '    End Using

    '    ' Use a MemoryStream to get the resized image bytes without saving to a file
    '    Using memoryStream As New MemoryStream()
    '        ' Save the resized image to the MemoryStream in a specific format (e.g., JPEG)
    '        resizedImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

    '        ' Get the bytes from the MemoryStream
    '        Return memoryStream.ToArray()
    '    End Using
    'End Function



    'Public Function GetResizedJewelryImages(newSize As Size) As List(Of KeyValuePair(Of String, Byte()))
    '    Dim query As String = "SELECT ID, ImagePath FROM JewelryItems"
    '    Dim resizedJewelryImages As New List(Of KeyValuePair(Of String, Byte()))

    '    Try
    '        Using connection As New MySqlConnection(connectionString)
    '            connection.Open()

    '            Using command As New MySqlCommand(query, connection)
    '                Using reader As MySqlDataReader = command.ExecuteReader()
    '                    While reader.Read()
    '                        Dim jewelryID As Integer = reader.GetInt32("ID")
    '                        Dim originalImage As Image = Image.FromFile(reader.GetString("ImagePath"))
    '                        Dim resizedImageBytes As Byte() = GetResizedImageBytes(originalImage, newSize)
    '                        If resizedImageBytes IsNot Nothing Then
    '                            resizedJewelryImages.Add(New KeyValuePair(Of String, Byte())(jewelryID, resizedImageBytes))
    '                        End If
    '                    End While
    '                End Using
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        ' Handle exceptions (e.g., log or show error message)

    '        MessageBox.Show($"Failed to retrieve resized jewelry images. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    '    Return resizedJewelryImages
    'End Function

#End Region
    Public Function GetResizedJewelryImages(newSize As Size) As List(Of KeyValuePair(Of String, Byte()))
        Dim query As String = "SELECT ID, ImagePath FROM JewelryItems"
        Dim resizedJewelryImages As New List(Of KeyValuePair(Of String, Byte()))

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim jewelryID As Integer = reader.GetInt32("ID")
                            Dim originalImage As Image = Image.FromFile(reader.GetString("ImagePath"))
                            Dim resizedImage As Image = ResizeImage(originalImage)
                            resizedJewelryImages.Add(New KeyValuePair(Of String, Byte())(jewelryID, CType((New ImageConverter()).ConvertTo(resizedImage, GetType(Byte())), Byte())))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to retrieve resized jewelry images. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return resizedJewelryImages
    End Function


    Public Function ResizeImage(inputImage As Bitmap) As Bitmap
        Dim newSize As New Size(100, 100)
        Return New Bitmap(inputImage, newSize)
    End Function


    Public Function ExecuteQueryToGetAdditionalInfo(query As String) As Dictionary(Of String, String)
        Dim additionalInfo As New Dictionary(Of String, String)()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            additionalInfo.Add("Name", reader.GetString("Name"))
                            additionalInfo.Add("Description", reader.GetString("Description"))
                            additionalInfo.Add("Location", reader.GetString("Location"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions, log errors, etc.
        End Try

        Return additionalInfo
    End Function
End Module
