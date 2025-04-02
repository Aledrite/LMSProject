Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Me.Hide()
        BrowseForm.Activate()
        BrowseForm.Show()


    End Sub

End Class
