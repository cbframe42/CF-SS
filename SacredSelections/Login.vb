Imports System.ComponentModel

Public Class Login
    Public Shared EmployeeLoggedIn As Employee
    Private _empRepo As EmployeeRepo
    Private _valid As New Validator

    'Public Shared _carriersList As List(Of CellCarrier)

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'Test
        _empRepo = New EmployeeRepo()
        EmployeeLoggedIn = New Employee()
        EmployeeLoggedIn = _empRepo.FindOneByUsername(txtUsername.Text.Trim().ToLower)

        If EmployeeLoggedIn.Username = Nothing Then
            lblNotification.Text = "User name not found."
            lblNotification.Visible = True
            txtUsername.Focus()
            txtUsername.SelectAll()
        Else

            lblNotification.Visible = False

            If txtPassword.Text = "" Then
                lblNotification.Text = "Password required."
                lblNotification.Visible = True
                Exit Sub
            End If

            If EmployeeLoggedIn.IsPasswordMatch(txtPassword.Text) Then

                If EmployeeLoggedIn.Active = False Then
                    lblNotification.Text = "Account not active."
                    lblNotification.Visible = True
                    Exit Sub
                End If

                If EmployeeLoggedIn.AccountLocked Then
                    lblNotification.Text = "Account locked by administrator."
                    lblNotification.Visible = True
                    Exit Sub
                End If

                If EmployeeLoggedIn.CheckLogInStatus() = True Then
                    Dim result = MessageBox.Show("User session currently running on another computer." &
                                                 ControlChars.NewLine & "Proceeding to login may cause errors." & ControlChars.NewLine &
                                                 "Do you want to continue anyway?",
                                                 "Multiple sessions", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                    If result = DialogResult.No Then
                        Exit Sub
                    Else
                        EmployeeLoggedIn.LogLogoutTime()
                    End If
                End If

                If EmployeeLoggedIn.ForcePasswordChange Then
                    ForceNewPassword()
                    lblNotification.Visible = False
                Else
                    GoToMain()
                    SetLogin()
                End If
            Else
                lblNotification.Text = "Incorrect password."
                lblNotification.Visible = True
                txtPassword.Focus()
                txtPassword.SelectAll()
            End If

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Expands login form to show more controls for changing password
    Public Sub ForceNewPassword()
        Me.Width = 513
        btnOK.Visible = False
        btnCancel.Visible = False
        txtNewPassword.Focus()
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        lblOldPassword.Text = "Old password:"
        lblYouMust.Visible = True
        AcceptButton = btnAltOK
        CancelButton = btnAltCancel
    End Sub



    'Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    SetLogin()

    '    frmMain.Show() ' needs to eventually removed

    '    If Not BackgroundWorker.IsBusy Then
    '        BackgroundWorker.RunWorkerAsync()
    '    End If

    'End Sub

    Public Sub GoToMain()
        frmMain._employeeLoggedIn = EmployeeLoggedIn
        EmployeeLoggedIn.LogLoginTime()
        txtUsername.Focus()
        Hide()
        frmMain.Show()
    End Sub

    'For resetting the form
    Public Sub SetLogin()
        EmployeeLoggedIn = Nothing
        Width = 255
        txtUsername.Clear()
        txtUsername.Enabled = True
        txtUsername.Focus()
        txtPassword.Clear()
        txtPassword.Enabled = True
        lblOldPassword.Text = "&Password:"
        txtNewPassword.Clear()
        txtNewPasswordCheck.Clear()
        lblNotification.Visible = False
        btnOK.Visible = True
        btnCancel.Visible = True
        lblYouMust.Visible = False
        AcceptButton = btnOK
        CancelButton = btnCancel

        For Each txtbx As Control In Me.Controls
            If TypeOf (txtbx) Is TextBox Then
                txtbx = CType(txtbx, TextBox)
                txtbx.ResetText()
            End If
        Next
    End Sub

    Private Sub NewPasswordCheck()
        If Not _valid.Password(txtNewPassword.Text) Then
            lblPasswordsMatching.ForeColor = Color.Red
            lblPasswordsMatching.Visible = True
            lblPasswordsMatching.Text = "* Password not long enough *"
            btnAltOK.Enabled = False
        Else
            If txtNewPassword.Text <> txtNewPasswordCheck.Text Then
                lblPasswordsMatching.Text = "* Passwords do not match *"
                lblPasswordsMatching.ForeColor = Color.Red
                lblPasswordsMatching.Visible = True
                btnAltOK.Enabled = False
            Else
                lblPasswordsMatching.Visible = True
                lblPasswordsMatching.ForeColor = Color.Green
                lblPasswordsMatching.Text = "Passwords match!"
                btnAltOK.Enabled = True
            End If

        End If

    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        NewPasswordCheck()
    End Sub

    Private Sub txtNewPasswordCheck_TextChanged(sender As Object, e As EventArgs) Handles txtNewPasswordCheck.TextChanged
        NewPasswordCheck()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        lblNotification.Visible = False
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblNotification.Visible = False
    End Sub

    Private Sub btnAltCancel_Click(sender As Object, e As EventArgs) Handles btnAltCancel.Click
        SetLogin()
    End Sub

    Private Sub btnAltOK_Click(sender As Object, e As EventArgs) Handles btnAltOK.Click
        'make certain that password confirmation matches and that the old password hasn't been changed
        If txtNewPassword.Text = txtNewPasswordCheck.Text And txtPassword.Text <> "".Trim() And EmployeeLoggedIn.IsPasswordMatch(txtPassword.Text) Then
            'set new password
            EmployeeLoggedIn.SetNewPassword(txtNewPassword.Text, False)
            _empRepo = New EmployeeRepo()
            'update employee's new password and save to db
            _empRepo.UpdateEmployee(EmployeeLoggedIn)
            GoToMain()
            SetLogin()
        End If
    End Sub

    'Private Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker.DoWork
    '    'Dim dbConnection As New DBExtras
    '    'If Not dbConnection.TestConnection() Then
    '    '    MsgBox("Database connection interrupted. Please contact IT or network administrator.")
    '    '    BackgroundWorker.CancelAsync()
    '    '    Exit Sub
    '    'Else
    '    '    MsgBox("Good")
    '    'End If
    '    Dim cRepo As New CellCarriersRepo
    '    _carriersList = New List(Of CellCarrier)
    '    _carriersList = cRepo.GetAll()
    '    Dim ncell As New CellCarrier
    '    ncell.CarrierName = "Select a carrier..."
    '    _carriersList.Insert(0, ncell)
    'End Sub

End Class
