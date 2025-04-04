<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_User
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
        Label5 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        btnRegister = New Button()
        txtBoxUserID = New TextBox()
        Label2 = New Label()
        txtBoxUserName = New TextBox()
        lblBookName = New Label()
        btnReturn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkSlateGray
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(243, 39)
        Label5.TabIndex = 13
        Label5.Text = "Register User"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Peru
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(txtBoxUserID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtBoxUserName)
        Panel1.Controls.Add(lblBookName)
        Panel1.Location = New Point(9, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(540, 201)
        Panel1.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(436, 163)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 35)
        Button1.TabIndex = 6
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegister.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(713, 254)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(155, 35)
        btnRegister.TabIndex = 5
        btnRegister.Text = "Register Book"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' txtBoxUserID
        ' 
        txtBoxUserID.Location = New Point(24, 143)
        txtBoxUserID.MaxLength = 6
        txtBoxUserID.Name = "txtBoxUserID"
        txtBoxUserID.Size = New Size(134, 23)
        txtBoxUserID.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 20)
        Label2.TabIndex = 4
        Label2.Text = "User ID"
        ' 
        ' txtBoxUserName
        ' 
        txtBoxUserName.Location = New Point(24, 47)
        txtBoxUserName.Name = "txtBoxUserName"
        txtBoxUserName.Size = New Size(254, 23)
        txtBoxUserName.TabIndex = 1
        ' 
        ' lblBookName
        ' 
        lblBookName.AutoSize = True
        lblBookName.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookName.Location = New Point(24, 26)
        lblBookName.Name = "lblBookName"
        lblBookName.Size = New Size(98, 20)
        lblBookName.TabIndex = 0
        lblBookName.Text = "User Name"
        ' 
        ' btnReturn
        ' 
        btnReturn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnReturn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(361, 269)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(188, 23)
        btnReturn.TabIndex = 14
        btnReturn.Text = "Return To Main Menu"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' Register_User
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.wallpaper
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(557, 304)
        Controls.Add(btnReturn)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Register_User"
        Text = "Register User"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtBoxUserID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxUserName As TextBox
    Friend WithEvents lblBookName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReturn As Button
End Class
