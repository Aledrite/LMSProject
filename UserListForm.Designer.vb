<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserListForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnReturn = New Button()
        pnlUserList = New Panel()
        lblUser = New Label()
        Label1 = New Label()
        Label2 = New Label()
        pnlCheckRent = New Panel()
        pnlDisplayRented = New Panel()
        btnCheckRented = New Button()
        lblAuthor = New Label()
        txtBoxUserID = New TextBox()
        btnRefreshList = New Button()
        pnlUserList.SuspendLayout()
        pnlCheckRent.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        btnReturn.Location = New Point(697, 526)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(188, 23)
        btnReturn.TabIndex = 4
        btnReturn.Text = "Return To Main Menu"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' pnlUserList
        ' 
        pnlUserList.BackColor = Color.Peru
        pnlUserList.Controls.Add(lblUser)
        pnlUserList.Location = New Point(15, 52)
        pnlUserList.Name = "pnlUserList"
        pnlUserList.Size = New Size(870, 288)
        pnlUserList.TabIndex = 5
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.MintCream
        lblUser.Location = New Point(3, 3)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(0, 18)
        lblUser.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Baskerville Old Face", 26.25F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 40)
        Label1.TabIndex = 6
        Label1.Text = "User List"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baskerville Old Face", 26.25F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(12, 355)
        Label2.Name = "Label2"
        Label2.Size = New Size(318, 40)
        Label2.TabIndex = 8
        Label2.Text = "Check Rented Book"
        ' 
        ' pnlCheckRent
        ' 
        pnlCheckRent.BackColor = Color.Peru
        pnlCheckRent.Controls.Add(pnlDisplayRented)
        pnlCheckRent.Controls.Add(btnCheckRented)
        pnlCheckRent.Controls.Add(lblAuthor)
        pnlCheckRent.Controls.Add(txtBoxUserID)
        pnlCheckRent.Location = New Point(15, 398)
        pnlCheckRent.Name = "pnlCheckRent"
        pnlCheckRent.Size = New Size(870, 122)
        pnlCheckRent.TabIndex = 7
        ' 
        ' pnlDisplayRented
        ' 
        pnlDisplayRented.AutoScroll = True
        pnlDisplayRented.BackColor = Color.SaddleBrown
        pnlDisplayRented.Location = New Point(20, 66)
        pnlDisplayRented.Name = "pnlDisplayRented"
        pnlDisplayRented.Size = New Size(833, 46)
        pnlDisplayRented.TabIndex = 11
        ' 
        ' btnCheckRented
        ' 
        btnCheckRented.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        btnCheckRented.Location = New Point(725, 3)
        btnCheckRented.Name = "btnCheckRented"
        btnCheckRented.Size = New Size(128, 44)
        btnCheckRented.TabIndex = 10
        btnCheckRented.Text = "Check"
        btnCheckRented.UseVisualStyleBackColor = True
        ' 
        ' lblAuthor
        ' 
        lblAuthor.AutoSize = True
        lblAuthor.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAuthor.Location = New Point(20, 5)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(68, 18)
        lblAuthor.TabIndex = 3
        lblAuthor.Text = "User ID"
        ' 
        ' txtBoxUserID
        ' 
        txtBoxUserID.Location = New Point(20, 24)
        txtBoxUserID.MaxLength = 6
        txtBoxUserID.Name = "txtBoxUserID"
        txtBoxUserID.Size = New Size(98, 23)
        txtBoxUserID.TabIndex = 2
        ' 
        ' btnRefreshList
        ' 
        btnRefreshList.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        btnRefreshList.Location = New Point(757, 346)
        btnRefreshList.Name = "btnRefreshList"
        btnRefreshList.Size = New Size(128, 23)
        btnRefreshList.TabIndex = 9
        btnRefreshList.Text = "Refresh List"
        btnRefreshList.UseVisualStyleBackColor = True
        ' 
        ' UserListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        BackgroundImage = My.Resources.Resources.wallpaper
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(897, 561)
        Controls.Add(btnRefreshList)
        Controls.Add(Label2)
        Controls.Add(pnlCheckRent)
        Controls.Add(Label1)
        Controls.Add(pnlUserList)
        Controls.Add(btnReturn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "UserListForm"
        Text = "User List"
        pnlUserList.ResumeLayout(False)
        pnlUserList.PerformLayout()
        pnlCheckRent.ResumeLayout(False)
        pnlCheckRent.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents pnlUserList As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlCheckRent As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents btnRefreshList As Button
    Friend WithEvents pnlDisplayRented As Panel
    Friend WithEvents btnCheckRented As Button
    Friend WithEvents lblAuthor As Label
    Friend WithEvents txtBoxUserID As TextBox
End Class
