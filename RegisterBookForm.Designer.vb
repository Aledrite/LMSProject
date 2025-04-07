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
        Panel1.Location = New Point(10, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(463, 174)
        Panel1.TabIndex = 0
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegister.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        btnRegister.Location = New Point(320, 133)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(133, 30)
        btnRegister.TabIndex = 5
        btnRegister.Text = "Register Book"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' nudYearPublished
        ' 
        nudYearPublished.Location = New Point(3, 140)
        nudYearPublished.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        nudYearPublished.Minimum = New Decimal(New Integer() {1800, 0, 0, 0})
        nudYearPublished.Name = "nudYearPublished"
        nudYearPublished.Size = New Size(103, 20)
        nudYearPublished.TabIndex = 10
        nudYearPublished.Value = New Decimal(New Integer() {1800, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Baskerville Old Face", 12.0F, FontStyle.Bold)
        Label4.Location = New Point(3, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 18)
        Label4.TabIndex = 9
        Label4.Text = "Date Published"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Baskerville Old Face", 12.0F, FontStyle.Bold)
        Label3.Location = New Point(294, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 18)
        Label3.TabIndex = 8
        Label3.Text = "Book Subject"
        ' 
        ' cmbBoxSubject
        ' 
        cmbBoxSubject.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBoxSubject.FormattingEnabled = True
        cmbBoxSubject.Items.AddRange(New Object() {"Fantasy", "Science Fiction", "Mystery or Crime", "Thriller or Suspense", "Romance", "Horror", "Historical Fiction", "Action Adventure", "Dystopian", "Literary Fiction", "Graphic Novel", "Memoir", "History", "Biography", "Autobiography", "Self-Help", "True Crime", "Travel", "Science", "Pop Culture", "Politics", "Business", "Sports"})
        cmbBoxSubject.Location = New Point(294, 82)
        cmbBoxSubject.Name = "cmbBoxSubject"
        cmbBoxSubject.Size = New Size(159, 21)
        cmbBoxSubject.TabIndex = 7
        ' 
        ' txtBoxBookID
        ' 
        txtBoxBookID.Location = New Point(294, 23)
        txtBoxBookID.MaxLength = 6
        txtBoxBookID.Name = "txtBoxBookID"
        txtBoxBookID.Size = New Size(115, 20)
        txtBoxBookID.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Baskerville Old Face", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(294, 4)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 18)
        Label2.TabIndex = 4
        Label2.Text = "Book ID"
        ' 
        ' txtBoxAuthor
        ' 
        txtBoxAuthor.Location = New Point(3, 82)
        txtBoxAuthor.Name = "txtBoxAuthor"
        txtBoxAuthor.Size = New Size(218, 20)
        txtBoxAuthor.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Baskerville Old Face", 12.0F, FontStyle.Bold)
        Label1.Location = New Point(3, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 18)
        Label1.TabIndex = 2
        Label1.Text = "Author"
        ' 
        ' txtBoxBookName
        ' 
        txtBoxBookName.Location = New Point(3, 29)
        txtBoxBookName.Name = "txtBoxBookName"
        txtBoxBookName.Size = New Size(218, 20)
        txtBoxBookName.TabIndex = 1
        ' 
        ' lblBookName
        ' 
        lblBookName.AutoSize = True
        lblBookName.Font = New Font("Baskerville Old Face", 12.0F, FontStyle.Bold)
        lblBookName.Location = New Point(3, 10)
        lblBookName.Name = "lblBookName"
        lblBookName.Size = New Size(87, 18)
        lblBookName.TabIndex = 0
        lblBookName.Text = "Book Title"
        ' 
        ' btnReturn
        ' 
        btnReturn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnReturn.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        btnReturn.Location = New Point(292, 454)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(185, 22)
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
        Panel2.Location = New Point(10, 262)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(463, 166)
        Panel2.TabIndex = 11
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button5.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        Button5.Location = New Point(261, 133)
        Button5.Name = "Button5"
        Button5.Size = New Size(105, 30)
        Button5.TabIndex = 12
        Button5.Text = "Return Book"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button4.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        Button4.Location = New Point(372, 133)
        Button4.Name = "Button4"
        Button4.Size = New Size(88, 30)
        Button4.TabIndex = 11
        Button4.Text = "Rent Book"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' tbUserIdRent
        ' 
        tbUserIdRent.Location = New Point(3, 82)
        tbUserIdRent.MaxLength = 6
        tbUserIdRent.Name = "tbUserIdRent"
        tbUserIdRent.Size = New Size(115, 20)
        tbUserIdRent.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Baskerville Old Face", 12.0F, FontStyle.Bold)
        Label9.Location = New Point(3, 64)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 18)
        Label9.TabIndex = 8
        Label9.Text = "User ID"
        ' 
        ' tbBookIdRent
        ' 
        tbBookIdRent.Location = New Point(3, 29)
        tbBookIdRent.MaxLength = 6
        tbBookIdRent.Name = "tbBookIdRent"
        tbBookIdRent.Size = New Size(115, 20)
        tbBookIdRent.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Baskerville Old Face", 12.0F, FontStyle.Bold)
        Label8.Location = New Point(3, 10)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 18)
        Label8.TabIndex = 6
        Label8.Text = "Book ID"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(400, 417)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 30)
        Button1.TabIndex = 5
        Button1.Text = "Register Book"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Baskerville Old Face", 26.25F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkSlateGray
        Label5.Location = New Point(13, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 40)
        Label5.TabIndex = 11
        Label5.Text = "Register"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Baskerville Old Face", 26.25F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkSlateGray
        Label6.Location = New Point(10, 224)
        Label6.Name = "Label6"
        Label6.Size = New Size(241, 40)
        Label6.TabIndex = 12
        Label6.Text = "Rent or Return"
        ' 
        ' RegisterBookForm
        ' 
        AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        BackgroundImage = My.Resources.Resources.wallpaper
        ClientSize = New Size(488, 486)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel2)
        Controls.Add(btnReturn)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 8.25F)
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
    Friend WithEvents tbUserIdRent As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbBookIdRent As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
