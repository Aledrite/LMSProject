Public Class UserListForm
    Private Sub UserListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False



    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        Dispose()
        Form1.Show()
    End Sub

    Private Sub btnRefreshList_Click(sender As Object, e As EventArgs) Handles btnRefreshList.Click
        pnlUserList.Controls.Clear()

        Dim startPoint As New Point(3, 3)
        Dim index = 0

        For Each iKey In GlobalVariables.Users.Keys

            Dim templateLabel = lblUser
            Dim newLabel As New Label
            Dim userInfo = GlobalVariables.Users(iKey)

            newLabel.Font = templateLabel.Font
            newLabel.ForeColor = templateLabel.ForeColor
            newLabel.Location = startPoint + New Point(0, 20 * index)
            newLabel.AutoSize = True

            newLabel.Text = iKey.ToString & " | " & userInfo("userName")

            pnlUserList.Controls.Add(newLabel)

            index += 1

        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheckRented.Click
        If GlobalVariables.Users.ContainsKey(Val(txtBoxUserID.Text)) Then
            If Not GlobalVariables.Users(Val(txtBoxUserID.Text))("userRentedBook") = Nothing Then
                pnlDisplayRented.Controls.Clear()

                Dim templateLabel = lblUser
                Dim newLabel As New Label
                Dim bookID = GlobalVariables.Users(Val(txtBoxUserID.Text))("userRentedBook")


                Dim bookInfo = GlobalVariables.Books(bookID)


                newLabel.Font = templateLabel.Font
                newLabel.ForeColor = templateLabel.ForeColor
                newLabel.Location = New Point(3, 3)
                newLabel.AutoSize = True

                newLabel.Text = bookID.ToString & " | " & bookInfo("bookName") & " | " & bookInfo("bookAuthor") & " | " & bookInfo("yearPublished")


                pnlDisplayRented.Controls.Add(newLabel)
            Else
                MessageBox.Show("User does not rent any books!", "No Books Rented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("User does not exist!", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class