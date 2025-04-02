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
        Panel1.SuspendLayout()
        CType(nudYearPublished, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(586, 427)
        Panel1.TabIndex = 0
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegister.Font = New Font("Prestige Elite Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(428, 389)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(155, 35)
        btnRegister.TabIndex = 5
        btnRegister.Text = "Register Book"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' nudYearPublished
        ' 
        nudYearPublished.Location = New Point(28, 326)
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
        Label4.Location = New Point(28, 305)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 18)
        Label4.TabIndex = 9
        Label4.Text = "Date Published"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 235)
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
        cmbBoxSubject.Location = New Point(28, 256)
        cmbBoxSubject.Name = "cmbBoxSubject"
        cmbBoxSubject.Size = New Size(185, 23)
        cmbBoxSubject.TabIndex = 7
        ' 
        ' txtBoxBookID
        ' 
        txtBoxBookID.Location = New Point(28, 186)
        txtBoxBookID.Name = "txtBoxBookID"
        txtBoxBookID.Size = New Size(134, 23)
        txtBoxBookID.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(28, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 18)
        Label2.TabIndex = 4
        Label2.Text = "Book ID"
        ' 
        ' txtBoxAuthor
        ' 
        txtBoxAuthor.Location = New Point(28, 115)
        txtBoxAuthor.Name = "txtBoxAuthor"
        txtBoxAuthor.Size = New Size(254, 23)
        txtBoxAuthor.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 18)
        Label1.TabIndex = 2
        Label1.Text = "Author"
        ' 
        ' txtBoxBookName
        ' 
        txtBoxBookName.Location = New Point(28, 48)
        txtBoxBookName.Name = "txtBoxBookName"
        txtBoxBookName.Size = New Size(254, 23)
        txtBoxBookName.TabIndex = 1
        ' 
        ' lblBookName
        ' 
        lblBookName.AutoSize = True
        lblBookName.Font = New Font("Prestige Elite Std", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookName.Location = New Point(28, 27)
        lblBookName.Name = "lblBookName"
        lblBookName.Size = New Size(108, 18)
        lblBookName.TabIndex = 0
        lblBookName.Text = "Book Title"
        ' 
        ' btnReturn
        ' 
        btnReturn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnReturn.Font = New Font("Prestige Elite Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(604, 416)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(188, 23)
        btnReturn.TabIndex = 4
        btnReturn.Text = "Return To Main Menu"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' RegisterBookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(804, 451)
        Controls.Add(btnReturn)
        Controls.Add(Panel1)
        Name = "RegisterBookForm"
        Text = "RegisterBookForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(nudYearPublished, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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
End Class
