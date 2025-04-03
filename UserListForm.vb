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
        Dim index As Integer = 0

        For Each iKey In GlobalVariables.Users.Keys

            Dim templateLabel = lblUser
            Dim newLabel As New Label
            Dim userInfo = GlobalVariables.Users(iKey)

            newLabel.Font = templateLabel.Font
            newLabel.ForeColor = templateLabel.ForeColor
            newLabel.Location = startPoint + New Point(0, (20 * index))
            newLabel.AutoSize = True

            newLabel.Text = iKey.ToString & " | " & userInfo("userName")

            pnlUserList.Controls.Add(newLabel)

            index += 1

        Next


    End Sub
End Class