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
        Dim bookID As Integer
        Dim newBook As New Dictionary(Of String, String)

        newBook("bookName") = txtBoxBookName.Text
        newBook("bookAuthor") = txtBoxAuthor.Text
        If cmbBoxSubject.SelectedIndex > -1 Then
            newBook("bookSubject") = cmbBoxSubject.Items(cmbBoxSubject.SelectedIndex)
        End If
        bookID = Val(txtBoxBookID.Text)
        newBook("yearPublished") = nudYearPublished.Value.ToString

        If Val(txtBoxBookID.Text) > 0 Then
            If Not GlobalVariables.Books.ContainsKey(bookID) Then
                Dim result = MessageBox.Show("Are you sure you want to register this book?", "Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    GlobalVariables.Books(bookID) = newBook
                    MessageBox.Show("Book Registered.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Registration Canceled.")
                End If
            Else
                MessageBox.Show("There is already a book with this ID!", "Invalid ID.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter an ID greater than 0, or without incompatible symbols!", "Invalid ID.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If






    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Me.Dispose()
        BrowseForm.Activate()
        BrowseForm.Show()
        If Me.WindowState = FormWindowState.Maximized Then
            BrowseForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim userID = Val(tbUserIdRent.Text)
        Dim bookID = Val(tbBookIdRent.Text)

        If GlobalVariables.Users.ContainsKey(userID) Then
            If GlobalVariables.Books.ContainsKey(bookID) Then
                If Not GlobalVariables.Users(userID).ContainsValue(bookID.ToString) Then
                    If GlobalVariables.Users(userID)("userRentedBook") = Nothing Then
                        GlobalVariables.Users(userID)("userRentedBook") = bookID.ToString
                        MessageBox.Show("Successfully Rented Book.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("User is already renting a different book!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Book is already rented by this user.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            Else
                MessageBox.Show("Book does not exist or is not registered!", "Invalid Book ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("User does not exist or is not registered!", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim userID = Val(tbUserIdRent.Text)
        Dim bookID = Val(tbBookIdRent.Text)

        If GlobalVariables.Users.ContainsKey(userID) Then
            If GlobalVariables.Books.ContainsKey(bookID) Then
                If GlobalVariables.Users(userID).ContainsValue(bookID.ToString) Then
                    GlobalVariables.Users(userID)("userRentedBook") = Nothing
                    MessageBox.Show("Successfully Returned Book.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Book is not rented by this user.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Book does not exist or is not registered!", "Invalid Book ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("User does not exist or is not registered!", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class