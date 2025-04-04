<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseForm
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
        pnlEntryDisplay = New Panel()
        lblEntry = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        btnResetFilters = New Button()
        btnApplyFilter = New Button()
        nudYearTo = New NumericUpDown()
        nudYearFrom = New NumericUpDown()
        lblYearPublished = New Label()
        cmbBoxSubject = New ComboBox()
        lblSubject = New Label()
        lblTitle = New Label()
        txtBoxTitle = New TextBox()
        lblAuthor = New Label()
        txtBoxAuthor = New TextBox()
        btnReturn = New Button()
        btnRefresh = New Button()
        Label3 = New Label()
        pnlEntryDisplay.SuspendLayout()
        Panel2.SuspendLayout()
        CType(nudYearTo, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudYearFrom, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlEntryDisplay
        ' 
        pnlEntryDisplay.AutoScroll = True
        pnlEntryDisplay.BackColor = Color.Peru
        pnlEntryDisplay.Controls.Add(lblEntry)
        pnlEntryDisplay.Location = New Point(12, 66)
        pnlEntryDisplay.Name = "pnlEntryDisplay"
        pnlEntryDisplay.Size = New Size(752, 454)
        pnlEntryDisplay.TabIndex = 0
        ' 
        ' lblEntry
        ' 
        lblEntry.AutoSize = True
        lblEntry.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEntry.ForeColor = Color.MintCream
        lblEntry.Location = New Point(3, 3)
        lblEntry.Name = "lblEntry"
        lblEntry.Size = New Size(0, 18)
        lblEntry.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Baskerville Old Face", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(770, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 54)
        Label1.TabIndex = 1
        Label1.Text = "Filters"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel2.BackColor = Color.Peru
        Panel2.Controls.Add(btnResetFilters)
        Panel2.Controls.Add(btnApplyFilter)
        Panel2.Controls.Add(nudYearTo)
        Panel2.Controls.Add(nudYearFrom)
        Panel2.Controls.Add(lblYearPublished)
        Panel2.Controls.Add(cmbBoxSubject)
        Panel2.Controls.Add(lblSubject)
        Panel2.Controls.Add(lblTitle)
        Panel2.Controls.Add(txtBoxTitle)
        Panel2.Controls.Add(lblAuthor)
        Panel2.Controls.Add(txtBoxAuthor)
        Panel2.Location = New Point(770, 66)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(226, 454)
        Panel2.TabIndex = 2
        ' 
        ' btnResetFilters
        ' 
        btnResetFilters.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        btnResetFilters.Location = New Point(99, 414)
        btnResetFilters.Name = "btnResetFilters"
        btnResetFilters.Size = New Size(90, 35)
        btnResetFilters.TabIndex = 12
        btnResetFilters.Text = "Reset"
        btnResetFilters.UseVisualStyleBackColor = True
        ' 
        ' btnApplyFilter
        ' 
        btnApplyFilter.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        btnApplyFilter.Location = New Point(3, 414)
        btnApplyFilter.Name = "btnApplyFilter"
        btnApplyFilter.Size = New Size(90, 35)
        btnApplyFilter.TabIndex = 4
        btnApplyFilter.Text = "Apply"
        btnApplyFilter.UseVisualStyleBackColor = True
        ' 
        ' nudYearTo
        ' 
        nudYearTo.Location = New Point(108, 224)
        nudYearTo.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        nudYearTo.Name = "nudYearTo"
        nudYearTo.Size = New Size(80, 23)
        nudYearTo.TabIndex = 9
        nudYearTo.Value = New Decimal(New Integer() {1800, 0, 0, 0})
        ' 
        ' nudYearFrom
        ' 
        nudYearFrom.Location = New Point(3, 224)
        nudYearFrom.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        nudYearFrom.Name = "nudYearFrom"
        nudYearFrom.Size = New Size(80, 23)
        nudYearFrom.TabIndex = 8
        nudYearFrom.Value = New Decimal(New Integer() {1800, 0, 0, 0})
        ' 
        ' lblYearPublished
        ' 
        lblYearPublished.AutoSize = True
        lblYearPublished.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold)
        lblYearPublished.Location = New Point(3, 203)
        lblYearPublished.Name = "lblYearPublished"
        lblYearPublished.Size = New Size(119, 18)
        lblYearPublished.TabIndex = 7
        lblYearPublished.Text = "Year Published"
        ' 
        ' cmbBoxSubject
        ' 
        cmbBoxSubject.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBoxSubject.FormattingEnabled = True
        cmbBoxSubject.Items.AddRange(New Object() {"Fantasy", "Science Fiction", "Mystery or Crime", "Thriller or Suspense", "Romance", "Horror", "Historical Fiction", "Action Adventure", "Dystopian", "Literary Fiction", "Graphic Novel", "Memoir", "History", "Biography", "Autobiography", "Self-Help", "True Crime", "Travel", "Science", "Pop Culture", "Politics", "Business", "Sports"})
        cmbBoxSubject.Location = New Point(3, 158)
        cmbBoxSubject.Name = "cmbBoxSubject"
        cmbBoxSubject.Size = New Size(185, 23)
        cmbBoxSubject.TabIndex = 6
        ' 
        ' lblSubject
        ' 
        lblSubject.AutoSize = True
        lblSubject.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold)
        lblSubject.Location = New Point(3, 137)
        lblSubject.Name = "lblSubject"
        lblSubject.Size = New Size(60, 18)
        lblSubject.TabIndex = 5
        lblSubject.Text = "Subject"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold)
        lblTitle.Location = New Point(3, 74)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(43, 18)
        lblTitle.TabIndex = 3
        lblTitle.Text = "Title"
        ' 
        ' txtBoxTitle
        ' 
        txtBoxTitle.Location = New Point(3, 95)
        txtBoxTitle.Name = "txtBoxTitle"
        txtBoxTitle.Size = New Size(185, 23)
        txtBoxTitle.TabIndex = 2
        ' 
        ' lblAuthor
        ' 
        lblAuthor.AutoSize = True
        lblAuthor.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold)
        lblAuthor.Location = New Point(3, 17)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(59, 18)
        lblAuthor.TabIndex = 1
        lblAuthor.Text = "Author"
        ' 
        ' txtBoxAuthor
        ' 
        txtBoxAuthor.Location = New Point(3, 38)
        txtBoxAuthor.Name = "txtBoxAuthor"
        txtBoxAuthor.Size = New Size(185, 23)
        txtBoxAuthor.TabIndex = 0
        ' 
        ' btnReturn
        ' 
        btnReturn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnReturn.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        btnReturn.Location = New Point(808, 526)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(188, 23)
        btnReturn.TabIndex = 3
        btnReturn.Text = "Return To Main Menu"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRefresh.Font = New Font("Baskerville Old Face", 11.25F, FontStyle.Bold)
        btnRefresh.Location = New Point(698, 526)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(104, 23)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkSlateGray
        Label3.Location = New Point(15, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(424, 22)
        Label3.TabIndex = 1
        Label3.Text = "ID | Title | Author | Subject | Year Published"
        ' 
        ' BrowseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        BackgroundImage = My.Resources.Resources.wallpaper
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1008, 561)
        Controls.Add(btnRefresh)
        Controls.Add(Label3)
        Controls.Add(btnReturn)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(pnlEntryDisplay)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "BrowseForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Browse"
        pnlEntryDisplay.ResumeLayout(False)
        pnlEntryDisplay.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(nudYearTo, ComponentModel.ISupportInitialize).EndInit()
        CType(nudYearFrom, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlEntryDisplay As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbBoxSubject As ComboBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtBoxTitle As TextBox
    Friend WithEvents lblAuthor As Label
    Friend WithEvents txtBoxAuthor As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblYearPublished As Label
    Friend WithEvents nudYearTo As NumericUpDown
    Friend WithEvents nudYearFrom As NumericUpDown
    Friend WithEvents btnApplyFilter As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblEntry As Label
    Friend WithEvents btnResetFilters As Button
    Friend WithEvents Label3 As Label
End Class
