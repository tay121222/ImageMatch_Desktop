Public Class Dashboard
    Private Sub location_button_Click(sender As Object, e As EventArgs) Handles location_button.Click
        Location_Management_Interface.Close()
        Location_Management_Interface.ShowDialog()
    End Sub

    Private Sub invntory_button_Click(sender As Object, e As EventArgs) Handles invntory_button.Click
        Inventory_Management_Interface.Close()
        Inventory_Management_Interface.ShowDialog()
    End Sub

    Private Sub imageMatch_button_Click(sender As Object, e As EventArgs) Handles imageMatch_button.Click
        Image_Matching.Close()
        Image_Matching.ShowDialog()
    End Sub
End Class
