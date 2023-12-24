Imports MySql.Data.MySqlClient

Public Class Location_Management_Interface

    Private Sub Location_Management_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load list of all location from the DB
        loadlistview()
    End Sub

    Private Sub add_new_location_btn_Click(sender As Object, e As EventArgs) Handles add_new_location_btn.Click
        'Insert a new location
        Dim query As String = $"INSERT INTO Locations (LocationName) VALUES ('{loc_name.Text}')"
        Dim success As Boolean = ExecuteQuery(query)
        If success Then
            MessageBox.Show("Location added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loc_name.Text = Nothing
            loadlistview()
        Else
            MessageBox.Show("Failed to add location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub loadlistview()
        DatabaseModule.LoadListView(location_lv, "Locations")
    End Sub

    Private Sub location_lv_MouseUp(sender As Object, e As MouseEventArgs) Handles location_lv.MouseUp
        'Right click to pop up COntextMenuStrip on selected item
        If (e.Button <> MouseButtons.Left) Then
            Dim itemAt As ListViewItem = location_lv.GetItemAt(e.X, e.Y)
            If location_lv.GetItemAt(e.X, e.Y) IsNot Nothing Then
                location_lv.GetItemAt(e.X, e.Y).Selected = True
                loc_cms.Show(location_lv, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        'Code to delete location form Database
        Dim query As String = "DELETE FROM Locations WHERE LocationID = @ID"
        Dim parameters As New List(Of MySqlParameter) From
        {
            New MySqlParameter("@ID", location_lv.FocusedItem.SubItems(0).Text)
        }
        Dim success As Boolean = ExecuteQueryWithParameters(query, parameters)

        If success Then
            MessageBox.Show("Location deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadlistview()
        Else
            MessageBox.Show("Failed to delete location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class