Public Class Dashboard
    Private Sub Location_button_Click(sender As Object, e As EventArgs) Handles Location_button.Click
        Location_Management_Interface.Close()
        Location_Management_Interface.ShowDialog()
    End Sub

    Private Sub Invntory_button_Click(sender As Object, e As EventArgs) Handles Invntory_button.Click
        Inventory_Management_Interface.Close()
        Inventory_Management_Interface.ShowDialog()
    End Sub

    Private Sub ImageMatch_button_Click(sender As Object, e As EventArgs) Handles ImageMatch_button.Click
        Image_Matching.Close()
        Image_Matching.ShowDialog()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
