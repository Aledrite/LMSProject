<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterBookForm
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
        Panel1 = New Panel()
        btnRegister = New Button()
        nudYearPublished = New NumericUpDown()
        Label4 = New Label()
        Label3 = New Label()
        cmbBoxSubject = New ComboBox()
        txtBoxBookID = New TextBox()
        Label2 = New Label()
        txtBoxAuthor = New TextBox()
        Label1 = New Label()
        txtBoxBookName = New TextBox()
        lblBookName = New Label()
        btnReturn = New Button()
        Panel2 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        tbUserIdRent = New TextBox()
        Label9 = New Label()
        tbBookIdRent = New TextBox()
        Label8 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(nudYearPublished, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Peru
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(nudYearPublished)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cmbBoxSubject)
        Panel1.Controls.Add(txtBoxBookID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtBoxAuthor)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtBoxBookName)
        Panel1.Controls.Add(lblBookName)
        Panel1.Location = New Point(12, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(540, 201)
        Panel1.TabIndex = 0
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegister.Font = New Font("Prestige Elite Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(373, 153)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(155, 35)
        btnRegister.TabIndex = 5
        btnRegister.Text = "Register Book"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' nudYearPublished
        ' 
        nudYearPublished.Location = New Point(3, 161)
        nudYearPublished.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        nudYearPublished.Minimum = New Decimal(New Integer() {1800, 0, 0, 0})
        nudYearPublished.Name = "nudYearPublished"
        nudYearPublished.Size = New Size(120, 23)
        nudYearPublished.TabIndex = 10
        nudYearPublished.Value = New Decimal(New Integer() {1800, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 18)
        Label4.TabIndex = 9
        Label4.Text = "Date Published"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(343, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 18)
        Label3.TabIndex = 8
        Label3.Text = "Book Subject"
        ' 
        ' cmbBoxSubject
        ' 
        cmbBoxSubject.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBoxSubject.FormattingEnabled = True
        cmbBoxSubject.Items.AddRange(New Object() {"Fantasy", "Science Fiction", "Mystery or Crime", "Thriller or Suspense", "Romance", "Horror", "Historical Fiction", "Action Adventure", "Dystopian", "Literary Fiction", "Graphic Novel", "Memoir", "History", "Biography", "Autobiography", "Self-Help", "True Crime", "Travel", "Science", "Pop Culture", "Politics", "Business", "Sports"})
        cmbBoxSubject.Location = New Point(343, 95)
        cmbBoxSubject.Name = "cmbBoxSubject"
        cmbBoxSubject.Size = New Size(185, 23)
        cmbBoxSubject.TabIndex = 7
        ' 
        ' txtBoxBookID
        ' 
        txtBoxBookID.Location = New Point(343, 26)
        txtBoxBookID.MaxLength = 6
        txtBoxBookID.Name = "txtBoxBookID"
        txtBoxBookID.Size = New Size(134, 23)
        txtBoxBookID.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(343, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 18)
        Label2.TabIndex = 4
        Label2.Text = "Book ID"
        ' 
        ' txtBoxAuthor
        ' 
        txtBoxAuthor.Location = New Point(3, 95)
        txtBoxAuthor.Name = "txtBoxAuthor"
        txtBoxAuthor.Size = New Size(254, 23)
        txtBoxAuthor.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 18)
        Label1.TabIndex = 2
        Label1.Text = "Author"
        ' 
        ' txtBoxBookName
        ' 
        txtBoxBookName.Location = New Point(3, 33)
        txtBoxBookName.Name = "txtBoxBookName"
        txtBoxBookName.Size = New Size(254, 23)
        txtBoxBookName.TabIndex = 1
        ' 
        ' lblBookName
        ' 
        lblBookName.AutoSize = True
        lblBookName.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookName.Location = New Point(3, 12)
        lblBookName.Name = "lblBookName"
        lblBookName.Size = New Size(108, 18)
        lblBookName.TabIndex = 0
        lblBookName.Text = "Book Title"
        ' 
        ' btnReturn
        ' 
        btnReturn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnReturn.Font = New Font("Prestige Elite Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(369, 526)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(188, 23)
        btnReturn.TabIndex = 4
        btnReturn.Text = "Return To Main Menu"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Left
        Panel2.BackColor = Color.Peru
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(tbUserIdRent)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(tbBookIdRent)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(12, 302)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(540, 192)
        Panel2.TabIndex = 11
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button5.Font = New Font("Prestige Elite Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(305, 154)
        Button5.Name = "Button5"
        Button5.Size = New Size(123, 35)
        Button5.TabIndex = 12
        Button5.Text = "Return Book"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button4.Font = New Font("Prestige Elite Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(434, 154)
        Button4.Name = "Button4"
        Button4.Size = New Size(103, 35)
        Button4.TabIndex = 11
        Button4.Text = "Rent Book"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' tbUserIdRent
        ' 
        tbUserIdRent.Location = New Point(3, 95)
        tbUserIdRent.MaxLength = 6
        tbUserIdRent.Name = "tbUserIdRent"
        tbUserIdRent.Size = New Size(134, 23)
        tbUserIdRent.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(3, 74)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 18)
        Label9.TabIndex = 8
        Label9.Text = "User ID"
        ' 
        ' tbBookIdRent
        ' 
        tbBookIdRent.Location = New Point(3, 33)
        tbBookIdRent.MaxLength = 6
        tbBookIdRent.Name = "tbBookIdRent"
        tbBookIdRent.Size = New Size(134, 23)
        tbBookIdRent.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(3, 12)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 18)
        Label8.TabIndex = 6
        Label8.Text = "Book ID"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Font = New Font("Prestige Elite Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(467, 481)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 35)
        Button1.TabIndex = 5
        Button1.Text = "Register Book"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Prestige Elite Std", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkSlateGray
        Label5.Location = New Point(15, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 40)
        Label5.TabIndex = 11
        Label5.Text = "Register"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Prestige Elite Std", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkSlateGray
        Label6.Location = New Point(12, 259)
        Label6.Name = "Label6"
        Label6.Size = New Size(311, 40)
        Label6.TabIndex = 12
        Label6.Text = "Rent or Return"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button3.Font = New Font("Prestige Elite Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(-427, 526)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 23)
        Button3.TabIndex = 14
        Button3.Text = "Browse Books"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' RegisterBookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        BackgroundImage = My.Resources.Resources.wallpaper
        ClientSize = New Size(569, 561)
        Controls.Add(Button3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel2)
        Controls.Add(btnReturn)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "RegisterBookForm"
        Text = "Register And Rent"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(nudYearPublished, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblBookName As Label
    Friend WithEvents txtBoxBookName As TextBox
    Friend WithEvents txtBoxAuthor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxBookID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBoxSubject As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nudYearPublished As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents tbUserIdRent As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbBookIdRent As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
