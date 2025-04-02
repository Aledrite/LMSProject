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
        btnRented = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Font = New Font("Prestige Elite Std", 15.7499981F, FontStyle.Bold)
        btnBrowse.ForeColor = Color.DarkSlateGray
        btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), Image)
        btnBrowse.Location = New Point(16, 193)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(240, 240)
        btnBrowse.TabIndex = 0
        btnBrowse.Text = "Browse Books"
        btnBrowse.TextAlign = ContentAlignment.BottomCenter
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnUsers
        ' 
        btnUsers.Font = New Font("Prestige Elite Std", 15.7499981F, FontStyle.Bold)
        btnUsers.ForeColor = Color.DarkSlateGray
        btnUsers.Location = New Point(262, 193)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(240, 240)
        btnUsers.TabIndex = 1
        btnUsers.Text = "User List"
        btnUsers.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Prestige Elite Std", 15.7499981F, FontStyle.Bold)
        btnRegister.ForeColor = Color.DarkSlateGray
        btnRegister.Location = New Point(508, 193)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(240, 240)
        btnRegister.TabIndex = 2
        btnRegister.Text = "Register Book"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Prestige Elite Std", 36F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(197, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 54)
        Label1.TabIndex = 3
        Label1.Text = "Hermes' Archive"
        ' 
        ' btnRented
        ' 
        btnRented.Font = New Font("Prestige Elite Std", 15.7499981F, FontStyle.Bold)
        btnRented.ForeColor = Color.DarkSlateGray
        btnRented.Location = New Point(754, 193)
        btnRented.Name = "btnRented"
        btnRented.Size = New Size(240, 240)
        btnRented.TabIndex = 4
        btnRented.Text = "Check Rented Books"
        btnRented.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.IconLogo
        PictureBox1.Location = New Point(16, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(175, 175)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(1008, 561)
        Controls.Add(PictureBox1)
        Controls.Add(btnRented)
        Controls.Add(Label1)
        Controls.Add(btnRegister)
        Controls.Add(btnUsers)
        Controls.Add(btnBrowse)
        Name = "Form1"
        Text = "MainMenu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRented As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
