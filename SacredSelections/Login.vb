Imports System.ComponentModel

Public Class Login

    Public Shared EmployeeLoggedIn As Employee
    Private _empRepo As EmployeeRepo
    Private _valid As New Validator
    Private _logger As New LogRepo
    Private incorrectPasswordCount As Integer = 0

    Public Shared _carriersList As List(Of CellCarrier)

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        _empRepo = New EmployeeRepo()
        EmployeeLoggedIn = New Employee()
        EmployeeLoggedIn = _empRepo.FindOneByUsername(txtUsername.Text.Trim().ToLower)


        If EmployeeLoggedIn.Username = Nothing Then
            lblNotification.Text = "User name not found."
            lblNotification.Visible = True
            txtUsername.Focus()
            txtUsername.SelectAll()
        Else

            If incorrectPasswordCount = 5 Then
                incorrectPasswordCount = 0
                lblNotification.Text = "Account locked - max attempts reached"
                lblNotification.Visible = True

                Dim log As New AppLog
                log.DateTime = DateTime.Now
                log.EID = EmployeeLoggedIn.EID
                log.LogType = "Account locked"
                log.Message = EmployeeLoggedIn.FullNameLastNameFirst() & " - max login attempts reached."
                _logger.Insert(log)
                EmployeeLoggedIn.AccountLocked = True
                _empRepo = New EmployeeRepo()
                _empRepo.UpdateEmployee(EmployeeLoggedIn)
                Exit Sub
            End If

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
                        EmployeeLoggedIn.RemoveCorruptLog()
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
                incorrectPasswordCount += 1
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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' frmMain.Show()
        ' frmLoading.Show()
        If Not BackgroundWorker.IsBusy Then
            BackgroundWorker.RunWorkerAsync()
        End If

        SetLogin()
    End Sub

    Public Sub GoToMain()
        frmMain._employeeLoggedIn = EmployeeLoggedIn
        EmployeeLoggedIn.LogLoginTime()
        txtUsername.Focus()
        If Not BackgroundWorker.IsBusy Then
            BackgroundWorker.RunWorkerAsync()
        End If
        Hide()
        frmLoading.Show()

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

        'For Each txtbx As Control In Me.Controls
        '    If TypeOf (txtbx) Is TextBox Then
        '        txtbx = CType(txtbx, TextBox)
        '        txtbx.clear()
        '    End If
        'Next
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
            Dim log As New AppLog
            log.DateTime = DateTime.Now
            log.EID = EmployeeLoggedIn.EID
            log.LogType = "Forced password change"
            log.Message = EmployeeLoggedIn.FullNameLastNameFirst() & " - password changed at login."
            _logger.Insert(log)
            'update employee's new password and save to db
            _empRepo.UpdateEmployee(EmployeeLoggedIn)
            GoToMain()
            SetLogin()
        End If
    End Sub

    Private Sub CapsLockCheck()
        If Control.IsKeyLocked(Keys.CapsLock) Then
            pbWarning.Visible = True
            lblCapsLock.Visible = True
        Else
            pbWarning.Visible = False
            lblCapsLock.Visible = False
        End If
    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker.DoWork
        'Dim dbConnection As New DBExtras
        'If Not dbConnection.TestConnection() Then
        '    MsgBox("Database connection interrupted. Please contact IT or network administrator.")
        '    BackgroundWorker.CancelAsync()
        '    Exit Sub
        'Else
        '    MsgBox("Good")
        'End If

        RefreshData()

        Dim cRepo As New CellCarriersRepo
        _carriersList = New List(Of CellCarrier)
        _carriersList = cRepo.GetAll()
        Dim ncell As New CellCarrier
        ncell.CarrierName = "Select a carrier..."
        _carriersList.Insert(0, ncell)

        'RUN MAILER SERVICE
        Dim bdayMailer As New BirthdayMailerService
        bdayMailer.RunService()
    End Sub


#Region "bckgroundLoadThreadVariables"
    Public Shared lstYC As List(Of YearCount)
    Public Shared lstZC As List(Of ZipCount)
    Public Shared yearsYC(4), countsYC(4), percentZC(5) As Integer
    Public Shared zipZC(5) As String
    Public Shared areaCodes As List(Of AreaCodeCount)
    Public Shared avgLengthOfEmployment As Decimal
    Public Shared avgHoursOfAllEmployees As Decimal
    Public Shared avgAgeofEmployees As Decimal
    Public Shared avgAgeOfClients As Decimal
    Public Shared avgYearsClients As Decimal
    Public Shared clientsTypesBreakdown As New QuantityClientTypes

#End Region

    'moved this to sub and background worker
    Public Sub RefreshData()
        Try
            Dim compStat As New CompanyStats
            Dim clientstat As New ClientStatistics

            lstZC = New List(Of ZipCount)
            lstYC = New List(Of YearCount)
            areaCodes = New List(Of AreaCodeCount)

            avgLengthOfEmployment = compStat.AverageLengthOfEmployment()
            avgHoursOfAllEmployees = compStat.AverageHoursLoggedInOfAllEmployees()
            avgAgeOfEmployees = compStat.AverageAgeofEmployees()
            clientsTypesBreakdown = compStat.ClientTypesBreakdown()

            lstYC = clientstat.NewClientsForEachYear()
            lstZC = clientstat.NumberClientsPerZipCode(True)
            areaCodes = clientstat.ClientsPerAreaCode(False)

            For i As Integer = 0 To 4
                yearsYC(i) = lstYC(i).Year
                countsYC(i) = lstYC(i).Count
                zipZC(i) = lstZC(i).Zip.ToString()
                percentZC(i) = CInt(lstZC(i).Quantity)
            Next

            zipZC(5) = "Other"
            percentZC(5) = 0
            For i As Integer = 5 To lstZC.Count - 1
                percentZC(5) += CInt(lstZC(i).Quantity)
            Next

            avgAgeOfClients = clientstat.AverageAgeOfClients()
            avgYearsClients = clientstat.AverageYearsClients()
        Catch ex As Exception
            MessageBox.Show("The application failed to initialize properly. Please contact your application administrator.", "Initialization Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CapsLockCheck()
    End Sub
End Class
