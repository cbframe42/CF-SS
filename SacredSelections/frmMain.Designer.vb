<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.msClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.msLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msNewDonor = New System.Windows.Forms.ToolStripMenuItem()
        Me.msNewEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.msNewFamily = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMailer = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.msEmployeeManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NewToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "msTools"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msClose, Me.msLogout})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'msClose
        '
        Me.msClose.Name = "msClose"
        Me.msClose.Size = New System.Drawing.Size(152, 22)
        Me.msClose.Text = "&Close"
        '
        'msLogout
        '
        Me.msLogout.Name = "msLogout"
        Me.msLogout.Size = New System.Drawing.Size(152, 22)
        Me.msLogout.Text = "&Logout"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msNewDonor, Me.msNewEmployee, Me.msNewFamily})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'msNewDonor
        '
        Me.msNewDonor.Name = "msNewDonor"
        Me.msNewDonor.Size = New System.Drawing.Size(152, 22)
        Me.msNewDonor.Text = "Donor"
        '
        'msNewEmployee
        '
        Me.msNewEmployee.Name = "msNewEmployee"
        Me.msNewEmployee.Size = New System.Drawing.Size(152, 22)
        Me.msNewEmployee.Text = "Employee"
        '
        'msNewFamily
        '
        Me.msNewFamily.Name = "msNewFamily"
        Me.msNewFamily.Size = New System.Drawing.Size(152, 22)
        Me.msNewFamily.Text = "Family"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msMailer, Me.msSettings, Me.msEmployeeManagement})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'msMailer
        '
        Me.msMailer.Name = "msMailer"
        Me.msMailer.Size = New System.Drawing.Size(242, 22)
        Me.msMailer.Text = "&Mailer"
        '
        'msSettings
        '
        Me.msSettings.Name = "msSettings"
        Me.msSettings.Size = New System.Drawing.Size(242, 22)
        Me.msSettings.Text = "Se&ttings                               Ctrl+S"
        '
        'msEmployeeManagement
        '
        Me.msEmployeeManagement.Name = "msEmployeeManagement"
        Me.msEmployeeManagement.Size = New System.Drawing.Size(242, 22)
        Me.msEmployeeManagement.Text = "Employee Management   Ctrl+E"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(911, 543)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msNewDonor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msNewEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msNewFamily As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msMailer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msEmployeeManagement As System.Windows.Forms.ToolStripMenuItem
End Class
