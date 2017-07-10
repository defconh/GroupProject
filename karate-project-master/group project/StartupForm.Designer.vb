<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembershipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MembershipToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(481, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "E&xit"
        '
        'MembershipToolStripMenuItem
        '
        Me.MembershipToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListAllToolStripMenuItem, Me.FindMemberToolStripMenuItem, Me.AddNewMemberToolStripMenuItem})
        Me.MembershipToolStripMenuItem.Name = "MembershipToolStripMenuItem"
        Me.MembershipToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.MembershipToolStripMenuItem.Text = "&Membership"
        '
        'ListAllToolStripMenuItem
        '
        Me.ListAllToolStripMenuItem.Name = "ListAllToolStripMenuItem"
        Me.ListAllToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ListAllToolStripMenuItem.Text = "&List All"
        '
        'FindMemberToolStripMenuItem
        '
        Me.FindMemberToolStripMenuItem.Name = "FindMemberToolStripMenuItem"
        Me.FindMemberToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FindMemberToolStripMenuItem.Text = "&Find Member"
        '
        'AddNewMemberToolStripMenuItem
        '
        Me.AddNewMemberToolStripMenuItem.Name = "AddNewMemberToolStripMenuItem"
        Me.AddNewMemberToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddNewMemberToolStripMenuItem.Text = "&Add New Member"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Karate School"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(46, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 100)
        Me.Panel1.TabIndex = 2
        '
        'StartupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 226)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StartupForm"
        Me.Text = "Karate School Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembershipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
