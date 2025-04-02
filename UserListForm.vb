Public Class UserListForm
    Private Sub UserListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False

        Dim exampleUser As New Dictionary(Of String, String)

        exampleUser("userName") = "m"
        exampleUser("userID") = "11111"

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        Dispose()
        Form1.Show()
    End Sub
End Class