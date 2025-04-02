Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Me.Hide()
        BrowseForm.Activate()
        BrowseForm.Show()
        If Me.WindowState = FormWindowState.Maximized Then
            BrowseForm.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Me.Hide()
        UserListForm.Activate()
        UserListForm.Show()
        If Me.WindowState = FormWindowState.Maximized Then
            UserListForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        RegisterBookForm.Activate()
        RegisterBookForm.Show()
        If Me.WindowState = FormWindowState.Maximized Then
            RegisterBookForm.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class
