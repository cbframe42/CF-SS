<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblOldPassword = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlNewPassword = New System.Windows.Forms.Panel()
        Me.lblPasswordsMatching = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPasswordCheck = New System.Windows.Forms.TextBox()
        Me.btnAltCancel = New System.Windows.Forms.Button()
        Me.btnAltOK = New System.Windows.Forms.Button()
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.pnlNewPassword.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&UserName"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(96, 119)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(199, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(96, 175)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(199, 20)
        Me.txtPassword.TabIndex = 4
        '
        'lblOldPassword
        '
        Me.lblOldPassword.AutoSize = True
        Me.lblOldPassword.Location = New System.Drawing.Point(93, 159)
        Me.lblOldPassword.Name = "lblOldPassword"
        Me.lblOldPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblOldPassword.TabIndex = 3
        Me.lblOldPassword.Text = "&Password"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(96, 226)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(84, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(208, 226)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlNewPassword
        '
        Me.pnlNewPassword.Controls.Add(Me.lblPasswordsMatching)
        Me.pnlNewPassword.Controls.Add(Me.Label3)
        Me.pnlNewPassword.Controls.Add(Me.Label6)
        Me.pnlNewPassword.Controls.Add(Me.txtNewPassword)
        Me.pnlNewPassword.Controls.Add(Me.txtNewPasswordCheck)
        Me.pnlNewPassword.Location = New System.Drawing.Point(457, 104)
        Me.pnlNewPassword.Name = "pnlNewPassword"
        Me.pnlNewPassword.Size = New System.Drawing.Size(243, 146)
        Me.pnlNewPassword.TabIndex = 14
        '
        'lblPasswordsMatching
        '
        Me.lblPasswordsMatching.AutoSize = True
        Me.lblPasswordsMatching.ForeColor = System.Drawing.Color.Red
        Me.lblPasswordsMatching.Location = New System.Drawing.Point(45, 108)
        Me.lblPasswordsMatching.Name = "lblPasswordsMatching"
        Me.lblPasswordsMatching.Size = New System.Drawing.Size(0, 13)
        Me.lblPasswordsMatching.TabIndex = 8
        Me.lblPasswordsMatching.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Please re-enter your new password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Enter a new password:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(13, 25)
        Me.txtNewPassword.MaxLength = 20
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(216, 20)
        Me.txtNewPassword.TabIndex = 0
        '
        'txtNewPasswordCheck
        '
        Me.txtNewPasswordCheck.Location = New System.Drawing.Point(13, 78)
        Me.txtNewPasswordCheck.MaxLength = 20
        Me.txtNewPasswordCheck.Name = "txtNewPasswordCheck"
        Me.txtNewPasswordCheck.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPasswordCheck.Size = New System.Drawing.Size(216, 20)
        Me.txtNewPasswordCheck.TabIndex = 1
        '
        'btnAltCancel
        '
        Me.btnAltCancel.Location = New System.Drawing.Point(596, 257)
        Me.btnAltCancel.Name = "btnAltCancel"
        Me.btnAltCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnAltCancel.TabIndex = 16
        Me.btnAltCancel.Text = "&Cancel"
        Me.btnAltCancel.UseVisualStyleBackColor = True
        '
        'btnAltOK
        '
        Me.btnAltOK.Location = New System.Drawing.Point(484, 257)
        Me.btnAltOK.Name = "btnAltOK"
        Me.btnAltOK.Size = New System.Drawing.Size(84, 23)
        Me.btnAltOK.TabIndex = 15
        Me.btnAltOK.Text = "&OK"
        Me.btnAltOK.UseVisualStyleBackColor = True
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.ForeColor = System.Drawing.Color.Red
        Me.lblNotification.Location = New System.Drawing.Point(93, 204)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(0, 13)
        Me.lblNotification.TabIndex = 17
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.SacredSelections.My.Resources.Resources.SacredSelectionsLogo
        Me.LogoPictureBox.Location = New System.Drawing.Point(39, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(350, 88)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(798, 290)
        Me.Controls.Add(Me.lblNotification)
        Me.Controls.Add(Me.btnAltCancel)
        Me.Controls.Add(Me.btnAltOK)
        Me.Controls.Add(Me.pnlNewPassword)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblOldPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlNewPassword.ResumeLayout(False)
        Me.pnlNewPassword.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblOldPassword As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents pnlNewPassword As System.Windows.Forms.Panel
    Friend WithEvents lblPasswordsMatching As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPasswordCheck As System.Windows.Forms.TextBox
    Friend WithEvents btnAltCancel As System.Windows.Forms.Button
    Friend WithEvents btnAltOK As System.Windows.Forms.Button
    Friend WithEvents lblNotification As System.Windows.Forms.Label

End Class
