Public Class RegisterBookForm
    Private Sub RegisterBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        Dispose()
        Form1.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim currentBooks As Integer = GlobalVariables.Books.Count
        Dim newBook As New Dictionary(Of String, String)

        newBook("bookName") = txtBoxBookName.Text
        newBook("bookAuthor") = txtBoxAuthor.Text
        If cmbBoxSubject.SelectedIndex > -1 Then
            newBook("bookSubject") = cmbBoxSubject.Items(cmbBoxSubject.SelectedIndex)
        End If
        newBook("bookID") = txtBoxBookID.Text
        newBook("yearPublished") = nudYearPublished.Value.ToString

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to register this book?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            GlobalVariables.Books(currentBooks) = newBook
            MessageBox.Show("Book Registered.")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Registration Canceled.")
        End If


    End Sub
End Class