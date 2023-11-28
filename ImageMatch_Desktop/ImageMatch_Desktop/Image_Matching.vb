Imports System.ComponentModel
Imports System.Threading
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports MySql.Data.MySqlClient
Public Class Image_Matching
    Dim jewelryImages As List(Of KeyValuePair(Of String, Byte()))
    Dim image_to_find_match As Image(Of Gray, Byte)
    Dim newSize As New Size(100, 100)

    Private Sub Image_Matching_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        LoadJewelryImages()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles image_browse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            jewelry_image.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Sub LoadJewelryImages()
        jewelryImages = DatabaseModule.GetResizedJewelryImages(newSize)
        found_images.Text = "Found " & jewelryImages.Count & " Images"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox4.Visible = True
        find_match_worker.RunWorkerAsync()
    End Sub

    Private Sub find_match_worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles find_match_worker.DoWork
#Region "old code"
        'Try
        '    TextBox1.Text = ""
        '    TextBox4.Text = ""
        '    TextBox3.Text = ""

        '    Dim imagelist As List(Of Image(Of Gray, Byte)) = New List(Of Image(Of Gray, Byte))()
        '    Dim labellist As List(Of String) = New List(Of String)()

        '    For Each pair As KeyValuePair(Of String, Byte()) In jewelryImages
        '        Dim ImgStream As New IO.MemoryStream(CType(pair.Value, Byte()))
        '        Dim tempimage As Bitmap = (New Bitmap(Image.FromStream(ImgStream)))
        '        imagelist.Add(New Image(Of Gray, Byte)(tempimage))
        '        labellist.Add(pair.Key)
        '        tempimage.Dispose()
        '        ImgStream.Close()
        '        ImgStream.Dispose()
        '    Next

        '    If imagelist.Count = 1 Then Exit Sub
        '    Dim TermCrit As MCvTermCriteria = New MCvTermCriteria(imagelist.Count, 0.001)
        '    Dim recognizer As EigenObjectRecognizer = New EigenObjectRecognizer(imagelist.ToArray(), labellist.ToArray(), 1500, TermCrit)

        '    For i As Integer = 0 To imagelist.Count - 1
        '        Dim recognitionValue As EigenObjectRecognizer.RecognitionResult = recognizer.Recognize(image_to_find_match)
        '        Thread.Sleep(100)
        '        If recognitionValue.Label = labellist(i) Then
        '            MsgBox(1)
        '            TextBox1.Text = TextBox1.Text & ";" & recognizer.Recognize(image_to_find_match).Label
        '            TextBox3.Text = TextBox3.Text & ";" & recognizer.Recognize(image_to_find_match).Distance

        '            Dim foundimage As Image(Of Gray, Byte) = imagelist(recognizer.Recognize(image_to_find_match).Index)
        '            Dim difference As Image(Of Gray, Byte) = foundimage.AbsDiff(image_to_find_match)

        '            Dim sum As Double = 0

        '            For t As Integer = 0 To difference.Height - 1
        '                For j As Integer = 0 To difference.Width - 1
        '                    sum += difference(t, j).Intensity
        '                Next
        '            Next

        '            Dim totalPixels As Double = difference.Height * difference.Width
        '            Dim percentageMatch As Double = 100 - (sum / totalPixels * 100)

        '            e.Result = percentageMatch

        '            Dim percentageMatch2 As Double = DirectCast(e.Result, Double)

        '            PictureBox2.Image = imagelist(recognizer.Recognize(image_to_find_match).Index).ToBitmap
        '            Label5.Text = percentageMatch2 & "%"

        '            'imagelist.RemoveAt(i)
        '            'labellist.RemoveAt(i)
        '            'Exit For

        '            imagelist.RemoveAt(recognitionValue.Index)
        '            labellist.RemoveAt(recognitionValue.Index)
        '        Else

        '        End If
        '    Next

        '    Thread.Sleep(10)

        'Catch ex As System.NullReferenceException
        '    MessageBox.Show("No Object Detected", "", MessageBoxButtons.OK)
        'End Try
#End Region
        image_to_find_match = New Image(Of Gray, Byte)(ResizeImage(New Bitmap(jewelry_image.Image)))
        Try

            Dim imagelist As List(Of Image(Of Gray, Byte)) = New List(Of Image(Of Gray, Byte))()
            Dim labellist As List(Of String) = New List(Of String)()

            For Each pair As KeyValuePair(Of String, Byte()) In jewelryImages
                Dim ImgStream As New IO.MemoryStream(CType(pair.Value, Byte()))
                Dim tempimage As Bitmap = (New Bitmap(Image.FromStream(ImgStream)))
                imagelist.Add(New Image(Of Gray, Byte)(tempimage))
                labellist.Add(pair.Key)
                tempimage.Dispose()
                ImgStream.Close()
                ImgStream.Dispose()
            Next

            Dim recognizer As EigenObjectRecognizer = Nothing
            Dim indicesToRemove As New List(Of Integer)()
            Dim TermCrit As MCvTermCriteria = New MCvTermCriteria(imagelist.Count, 0.001)

            While imagelist.Count > 1

                recognizer = New EigenObjectRecognizer(imagelist.ToArray(), labellist.ToArray(), 1500, TermCrit)

                For i As Integer = 0 To imagelist.Count - 1
                    Dim recognitionValue As EigenObjectRecognizer.RecognitionResult = recognizer.Recognize(image_to_find_match)
                    Thread.Sleep(100)

                    If recognitionValue.Label = labellist(i) Then
                        Dim foundimage As Image(Of Gray, Byte) = imagelist(recognitionValue.Index)
                        Dim difference As Image(Of Gray, Byte) = foundimage.AbsDiff(image_to_find_match)

                        Dim sum As Double = 0

                        For t As Integer = 0 To difference.Height - 1
                            For j As Integer = 0 To difference.Width - 1
                                sum += difference(t, j).Intensity
                            Next
                        Next

                        Dim totalPixels As Double = difference.Height * difference.Width
                        Dim percentageMatch As Double = 100 - (sum / totalPixels * 100)

                        e.Result = percentageMatch

                        Dim percentageMatch2 As Double = DirectCast(e.Result, Double)

                        If percentageMatch2 > 0 Then
                            Dim labelID As String = recognizer.Recognize(image_to_find_match).Label
                            Dim additionalInfoQuery As String = $"SELECT a.Name, a.Description, concat(a.LocationID,'(',b.LocationName,')') as location FROM JewelryItems a, Locations b WHERE ID = '{labelID}' and a.LocationID = b.LocationID"
                            Dim additionalInfo As Dictionary(Of String, String) = ExecuteQueryToGetAdditionalInfo(additionalInfoQuery)
                            match_found_list.Rows.Add()
                            match_found_list.Rows(match_found_list.Rows.Count - 1).Cells(0).Value = imagelist(recognitionValue.Index).ToBitmap
                            match_found_list.Rows(match_found_list.Rows.Count - 1).Height = match_found_list.Columns(0).Width * 0.75
                            match_found_list.Rows(match_found_list.Rows.Count - 1).Cells(1).Value = labelID
                            match_found_list.Rows(match_found_list.Rows.Count - 1).Cells(2).Value = percentageMatch2 & "%"
                            match_found_list.Rows(match_found_list.Rows.Count - 1).Cells(3).Value = additionalInfo("Name")
                            match_found_list.Rows(match_found_list.Rows.Count - 1).Cells(4).Value = additionalInfo("Description")
                            match_found_list.Rows(match_found_list.Rows.Count - 1).Cells(5).Value = additionalInfo("Location")
                        End If
                        indicesToRemove.Add(recognitionValue.Index)
                    End If
                Next

                For Each indexToRemove As Integer In indicesToRemove
                    imagelist.RemoveAt(indexToRemove)
                    labellist.RemoveAt(indexToRemove)
                Next
                indicesToRemove.Clear()
                Thread.Sleep(10)
            End While

        Catch ex As System.NullReferenceException
            MessageBox.Show("Done.. No more matches found", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub find_match_worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles find_match_worker.RunWorkerCompleted
        PictureBox4.Visible = False
    End Sub
End Class