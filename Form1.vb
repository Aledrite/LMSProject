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
        Hide()
        RegisterBookForm.Activate()
        RegisterBookForm.Show()

        If WindowState = FormWindowState.Maximized Then
            RegisterBookForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim exampleBook As New Dictionary(Of String, String)
        exampleBook("bookName") = "Lorem Ipsum"
        exampleBook("bookAuthor") = "Mr. Writer Man"
        exampleBook("bookSubject") = "Fantasy"
        exampleBook("yearPublished") = "1987"

        GlobalVariables.Books(171865) = exampleBook

        Dim exampleUser As New Dictionary(Of String, String)
        exampleUser("userName") = "Ms. Reader Woman"
        exampleUser("rentedBook") = ""

        GlobalVariables.Users(124356) = exampleUser

    End Sub
End Class
