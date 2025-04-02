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
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.Font = New Font("Prestige Elite Std", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(808, 526)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(188, 23)
        btnReturn.TabIndex = 4
        btnReturn.Text = "Return To Main Menu"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Peru
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(512, 537)
        Panel1.TabIndex = 5
        ' 
        ' UserListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(1008, 561)
        Controls.Add(Panel1)
        Controls.Add(btnReturn)
        Name = "UserListForm"
        Text = "UserListForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents Panel1 As Panel
End Class
