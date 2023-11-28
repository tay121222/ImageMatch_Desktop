Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Image_Upload_Interface


    Private Sub btnAddJewelry_Click(sender As Object, e As EventArgs) Handles btnAddJewelry.Click
        If btnAddJewelry.Text = "Save" Then
            save_jewelry()
        ElseIf btnAddJewelry.Text = "Update" Then
            update_jewelry()
        End If
    End Sub

    Sub save_jewelry()
        Dim name As String = txtJewelryName.Text
        Dim type As String = txtJewelryType.Text
        Dim getlocationID() As String = txtJewelryLocationID.Text.Split("(")
        Dim locationID As Integer = Integer.Parse(getlocationID(0))
        Dim description As String = txtJewelryDescription.Text
        Dim imagesFolderPath As String = Path.Combine(Application.StartupPath, "JewelryImages")
        If Not Directory.Exists(imagesFolderPath) Then
            Directory.CreateDirectory(imagesFolderPath)
        End If

        Dim imagePath As String = Path.Combine(imagesFolderPath, $"{txtJewelryName.Text}.png")


        Dim query As String = "INSERT INTO JewelryItems (Name, Type, LocationID, Description, ImagePath) VALUES (@Name, @Type, @LocationID, @Description, @ImagePath)"

        Dim parameters As New List(Of MySqlParameter) From
        {
            New MySqlParameter("@Name", name),
            New MySqlParameter("@Type", type),
            New MySqlParameter("@LocationID", locationID),
            New MySqlParameter("@Description", description),
            New MySqlParameter("@ImagePath", imagePath)
        }

        Dim image As Image = jewelry_image.Image
        image.Save(imagePath, Imaging.ImageFormat.Png)
        Dim success As Boolean = ExecuteQueryWithParameters(query, parameters)

        If success Then
            MessageBox.Show("Jewelry item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Failed to add jewelry item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub update_jewelry()
        Dim id As Integer = Integer.Parse(Me.Text)
        Dim name As String = txtJewelryName.Text
        Dim type As String = txtJewelryType.Text
        Dim getlocationID() As String = txtJewelryLocationID.Text.Split("(")
        Dim locationID As Integer = Integer.Parse(getlocationID(0))
        Dim description As String = txtJewelryDescription.Text
        Dim imagesFolderPath As String = Path.Combine(Application.StartupPath, "JewelryImages")
        If Not Directory.Exists(imagesFolderPath) Then
            Directory.CreateDirectory(imagesFolderPath)
        End If

        Dim imagePath As String = Path.Combine(imagesFolderPath, $"{txtJewelryName.Text}.png")

        Dim query As String = "UPDATE JewelryItems SET Name = @Name, Type = @Type, LocationID = @LocationID, Description = @Description, ImagePath = @ImagePath WHERE ID = @ID"

        Dim parameters As New List(Of MySqlParameter) From
        {
            New MySqlParameter("@Name", name),
            New MySqlParameter("@Type", type),
            New MySqlParameter("@LocationID", locationID),
            New MySqlParameter("@Description", description),
            New MySqlParameter("@ImagePath", imagePath),
            New MySqlParameter("@ID", id)
        }

        Dim image As Image = jewelry_image.Image
        image.Save(imagePath, Imaging.ImageFormat.Png)
        Dim success As Boolean = ExecuteQueryWithParameters(query, parameters)

        If success Then
            MessageBox.Show("Jewelry item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Failed to update jewelry item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles browse_Jewelry_image.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtJewelryName.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName)
            jewelry_image.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub Image_Upload_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLocationIDs()
    End Sub

    Public Sub LoadLocationIDS()
        Dim query As String = "SELECT concat(LocationID,'(',LocationName,')') as location FROM Locations"
        Dim parameters As New List(Of MySqlParameter)()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader IsNot Nothing Then
                        While reader.Read()
                            txtJewelryLocationID.Items.Add(reader("location").ToString())
                        End While
                    End If
                    reader.Dispose()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading locations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class