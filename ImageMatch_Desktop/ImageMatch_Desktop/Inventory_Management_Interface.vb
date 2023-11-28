Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Inventory_Management_Interface
    Private Sub Inventory_Management_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadJewelryItems()
    End Sub

    Sub LoadJewelryItems()
        DatabaseModule.LoadListView(listViewJewelry, "JewelryItems")
    End Sub

    Private Sub add_new_item_btn_Click(sender As Object, e As EventArgs) Handles add_new_item_btn.Click
        Image_Upload_Interface.Close()
        Image_Upload_Interface.ShowDialog()
        LoadJewelryItems()
    End Sub

    Private Sub listViewJewelry_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles listViewJewelry.ItemSelectionChanged
        If e.IsSelected Then
            Dim imagePath As String = e.Item.SubItems(6).Text
            DisplayImage(imagePath)
        End If
    End Sub

    Private Sub DisplayImage(imagePath As String)
        If Not String.IsNullOrEmpty(imagePath) Then
            Try
                Using stream As New FileStream(imagePath, FileMode.Open, FileAccess.Read)
                    Dim imageStream As New MemoryStream()
                    stream.CopyTo(imageStream)
                    pictureBoxJewelry.Image = Image.FromStream(imageStream)
                End Using
            Catch ex As Exception
                pictureBoxJewelry.Image = Nothing
            End Try
        Else
            pictureBoxJewelry.Image = Nothing
        End If
    End Sub

    Private Sub listViewJewelry_MouseUp(sender As Object, e As MouseEventArgs) Handles listViewJewelry.MouseUp
        If (e.Button <> MouseButtons.Left) Then
            Dim itemAt As ListViewItem = listViewJewelry.GetItemAt(e.X, e.Y)
            If listViewJewelry.GetItemAt(e.X, e.Y) IsNot Nothing Then
                listViewJewelry.GetItemAt(e.X, e.Y).Selected = True
                inv_cms.Show(listViewJewelry, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim query As String = "DELETE FROM JewelryItems WHERE ID = @ID"
        Dim parameters As New List(Of MySqlParameter) From
        {
            New MySqlParameter("@ID", listViewJewelry.FocusedItem.SubItems(0).Text)
        }
        Dim success As Boolean = ExecuteQueryWithParameters(query, parameters)
        If success Then
            MessageBox.Show("Jewelry item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            IO.File.Delete(listViewJewelry.FocusedItem.SubItems(6).Text)
            pictureBoxJewelry.Image = Nothing
            LoadJewelryItems()
        Else
            MessageBox.Show("Failed to delete Jewelry item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Image_Upload_Interface.Close()
        Image_Upload_Interface.txtJewelryName.Text = listViewJewelry.FocusedItem.SubItems(1).Text
        Image_Upload_Interface.txtJewelryType.Text = listViewJewelry.FocusedItem.SubItems(2).Text
        Image_Upload_Interface.txtJewelryDescription.Text = listViewJewelry.FocusedItem.SubItems(3).Text
        Image_Upload_Interface.txtJewelryLocationID.Text = listViewJewelry.FocusedItem.SubItems(4).Text
        Image_Upload_Interface.jewelry_image.Image = pictureBoxJewelry.Image
        Image_Upload_Interface.btnAddJewelry.Text = "Update"
        Image_Upload_Interface.Text = listViewJewelry.FocusedItem.SubItems(0).Text
        Image_Upload_Interface.ShowDialog()
        LoadJewelryItems()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchTerm As String = txtSearch.Text.ToLower()
        For Each item As ListViewItem In listViewJewelry.Items
            Dim matchFound As Boolean = False
            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                If subItem.Text.ToLower().Contains(searchTerm) Then
                    matchFound = True
                    Exit For
                End If
            Next
            item.Selected = matchFound
            item.EnsureVisible()
        Next
    End Sub
End Class