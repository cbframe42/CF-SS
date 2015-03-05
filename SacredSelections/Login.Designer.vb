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
        Me.lblYouMust = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(9, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&UserName"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 119)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(199, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 175)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(199, 20)
        Me.txtPassword.TabIndex = 4
        '
        'lblOldPassword
        '
        Me.lblOldPassword.AutoSize = True
        Me.lblOldPassword.Location = New System.Drawing.Point(9, 159)
        Me.lblOldPassword.Name = "lblOldPassword"
        Me.lblOldPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblOldPassword.TabIndex = 3
        Me.lblOldPassword.Text = "&Password"
        '
        'lblYouMust
        '
        Me.lblYouMust.AutoSize = True
        Me.lblYouMust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYouMust.Location = New System.Drawing.Point(9, 209)
        Me.lblYouMust.Name = "lblYouMust"
        Me.lblYouMust.Size = New System.Drawing.Size(205, 16)
        Me.lblYouMust.TabIndex = 5
        Me.lblYouMust.Text = "You must change your password."
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 240)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(84, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(124, 240)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(752, 290)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Tan
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.SelectionColor = System.Drawing.Color.Tan
        Me.LineShape3.X1 = 423
        Me.LineShape3.X2 = 648
        Me.LineShape3.Y1 = 102
        Me.LineShape3.Y2 = 102
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Tan
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.Color.Tan
        Me.LineShape1.X1 = 423
        Me.LineShape1.X2 = 648
        Me.LineShape1.Y1 = 11
        Me.LineShape1.Y2 = 11
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(460, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 80)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "- Use both UPPER and lower case" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Use numbers and letters " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Use symbols" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Use" & _
    " a minimum of 8 characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Don't use your username!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Don't share your passw" & _
    "ord!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tips:"
        '
        'pnlNewPassword
        '
        Me.pnlNewPassword.Controls.Add(Me.lblPasswordsMatching)
        Me.pnlNewPassword.Controls.Add(Me.Label3)
        Me.pnlNewPassword.Controls.Add(Me.Label6)
        Me.pnlNewPassword.Controls.Add(Me.txtNewPassword)
        Me.pnlNewPassword.Controls.Add(Me.txtNewPasswordCheck)
        Me.pnlNewPassword.Location = New System.Drawing.Point(423, 107)
        Me.pnlNewPassword.Name = "pnlNewPassword"
        Me.pnlNewPassword.Size = New System.Drawing.Size(243, 131)
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
        Me.btnAltCancel.Location = New System.Drawing.Point(553, 244)
        Me.btnAltCancel.Name = "btnAltCancel"
        Me.btnAltCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnAltCancel.TabIndex = 16
        Me.btnAltCancel.Text = "&Cancel"
        Me.btnAltCancel.UseVisualStyleBackColor = True
        '
        'btnAltOK
        '
        Me.btnAltOK.Location = New System.Drawing.Point(441, 244)
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
        Me.lblNotification.Location = New System.Drawing.Point(9, 211)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(0, 13)
        Me.lblNotification.TabIndex = 17
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.SacredSelections.My.Resources.Resources.SacredSelectionsLogo
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(350, 88)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 290)
        Me.Controls.Add(Me.lblNotification)
        Me.Controls.Add(Me.btnAltCancel)
        Me.Controls.Add(Me.btnAltOK)
        Me.Controls.Add(Me.pnlNewPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblYouMust)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblOldPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Login"
        Me.Text = "Login"
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
    Friend WithEvents lblYouMust As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
