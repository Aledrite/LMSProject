Public Class Register_User
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userID = Val(txtBoxUserID.Text)
        Dim userName = txtBoxUserName.Text

        If Not GlobalVariables.Users.ContainsKey(userID) Then

            If Not userID <= 1 Then
                Dim newUser As New Dictionary(Of String, String)
                newUser("userName") = userName
                newUser("userRentedBook") = Nothing

                GlobalVariables.Users(userID) = newUser
                MessageBox.Show("User registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please input a User ID greater than 0, or without incompatible symbols!", "Invalid ID.", MessageBoxButtons.OK, MessageBoxIcon.Error
                                )
            End If


        Else
            MessageBox.Show("A User with that ID already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        Dispose()
        Form1.Show()
    End Sub

End Class