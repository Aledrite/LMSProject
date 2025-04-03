<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnBrowse = New Button()
        btnUsers = New Button()
        btnRegister = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnRegisterUser = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Anchor = AnchorStyles.Right
        btnBrowse.BackColor = Color.Transparent
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Prestige Elite Std", 15.7499981F, FontStyle.Bold)
        btnBrowse.ForeColor = Color.Black
        btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), Image)
        btnBrowse.Location = New Point(482, 296)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(240, 240)
        btnBrowse.TabIndex = 0
        btnBrowse.Text = "Browse Books"
        btnBrowse.TextAlign = ContentAlignment.BottomCenter
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnUsers
        ' 
        btnUsers.Anchor = AnchorStyles.Right
        btnUsers.BackColor = Color.Transparent
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Prestige Elite Std", 15.7499981F, FontStyle.Bold)
        btnUsers.ForeColor = Color.Black
        btnUsers.Image = My.Resources.Resources.UserList
        btnUsers.Location = New Point(745, 288)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(240, 250)
        btnUsers.TabIndex = 1
        btnUsers.Text = "User List"
        btnUsers.TextAlign = ContentAlignment.BottomCenter
        btnUsers.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Right
        btnRegister.BackColor = Color.Transparent
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Prestige Elite Std", 15.7499981F, FontStyle.Bold)
        btnRegister.ForeColor = Color.Black
        btnRegister.Image = My.Resources.Resources.registerbooks
        btnRegister.Location = New Point(482, 9)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(240, 273)
        btnRegister.TabIndex = 2
        btnRegister.Text = "Register And Rent"
        btnRegister.TextAlign = ContentAlignment.BottomCenter
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Prestige Elite Std", 36F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 54)
        Label1.TabIndex = 3
        Label1.Text = "Hermes' Archive"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Left
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.IconLogo
        PictureBox1.Location = New Point(12, 79)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(440, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnRegisterUser
        ' 
        btnRegisterUser.Anchor = AnchorStyles.Right
        btnRegisterUser.BackColor = Color.Transparent
        btnRegisterUser.FlatAppearance.BorderSize = 0
        btnRegisterUser.FlatStyle = FlatStyle.Flat
        btnRegisterUser.Font = New Font("Prestige Elite Std", 15.7499981F, FontStyle.Bold)
        btnRegisterUser.ForeColor = Color.Black
        btnRegisterUser.Image = CType(resources.GetObject("btnRegisterUser.Image"), Image)
        btnRegisterUser.ImageAlign = ContentAlignment.MiddleRight
        btnRegisterUser.Location = New Point(756, 9)
        btnRegisterUser.Name = "btnRegisterUser"
        btnRegisterUser.Size = New Size(240, 273)
        btnRegisterUser.TabIndex = 6
        btnRegisterUser.Text = "Register User"
        btnRegisterUser.TextAlign = ContentAlignment.BottomCenter
        btnRegisterUser.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.wallpaper
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1008, 561)
        Controls.Add(btnRegisterUser)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnRegister)
        Controls.Add(btnUsers)
        Controls.Add(btnBrowse)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainMenu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRegisterUser As Button

End Class
