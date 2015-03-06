
Public Class frmMain

    Public Shared _employeeLoggedIn As New Employee
    Private _lists As New SelectionLists
    Private _searchcount As Integer = 0
    Public cboIndex As Integer
    Dim employeeMgmtTabPage As TabPage
    Dim lstEmployees As List(Of Employee)
    Dim lstFilteredEmployees As List(Of Employee)

    Private Sub msNewDonor_Click(sender As Object, e As EventArgs) Handles msNewDonor.Click
        frmNewDonor.Show()
    End Sub

    Private Sub msNewEmployee_Click(sender As Object, e As EventArgs) Handles msNewEmployee.Click
        frmNewEmployee.Show()
    End Sub

    'Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    If e.CloseReason = CloseReason.UserClosing Then
    '        Dim result = MessageBox.Show("Are you sure you want to close this application and logout?" &
    '                                           ControlChars.NewLine & "Any unsaved changes will be lost.",
    '                                           "Log out and Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
    '        If result = DialogResult.No Then
    '            e.Cancel = True
    '        Else
    '            _employeeLoggedIn.LogLogoutTime()
    '            Login.Close()
    '        End If
    '    End If
    'End Sub

    Private Sub Logout()
        Dim result = MessageBox.Show("Are you sure you want to logout?" &
                                               ControlChars.NewLine & "Any unsaved changes will be lost.",
                                               "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.No Then
            Exit Sub
        End If
        _employeeLoggedIn.LogLogoutTime()
        Login.Show()
        Dispose() 'test this functionality
    End Sub

    Private Sub msLogout_Click(sender As Object, e As EventArgs) Handles msLogout.Click
        Logout()
    End Sub

    Private Sub msClose_Click(sender As Object, e As EventArgs) Handles msClose.Click
        Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSearchType.DataSource = _lists.SearchTypes
        ZipCode.InitializeZipCodes()

        _employeeLoggedIn.AccessLevel = 3 'to delete after testing

        If _employeeLoggedIn.AccessLevel = 3 Then
            employeeMgmtTabPage = New TabPage()
            employeeMgmtTabPage = tpEmployeeManagement
            tabMain.TabPages.Remove(tpEmployeeManagement)
            EmployeeManagementToolStripMenuItem.Enabled = True

        Else
            tabMain.TabPages.Remove(tpEmployeeManagement)
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        CreateNewTab(txtSearchValue.Text, cboSearchType.SelectedIndex, False)
    End Sub

    Public Sub CreateNewTab(ByVal searchValue As String, ByVal searchType As Integer, replaceCurrentTab As Boolean)
        _searchcount += 1
        Dim custSearchTab As New CustomTabPage 'returns a custom tabpage with controls and handlers
        Dim newSearchTab As TabPage
        'put controls on tab
        newSearchTab = custSearchTab.CreateNewSearchResultPage(searchValue, searchType, _searchcount)

        If replaceCurrentTab Then
            Dim index As Integer
            Dim tp As New TabPage
            tp = tabMain.SelectedTab
            index = tabMain.SelectedIndex
            tabMain.TabPages.Remove(tp)
            tabMain.TabPages.Insert(index, newSearchTab)
        Else
            tabMain.TabPages.Add(newSearchTab) 'add new tab
        End If
        tabMain.SelectedTab = newSearchTab  'select tab

        custSearchTab.cboSearchType.SelectedIndex = cboSearchType.SelectedIndex 'select the correct searched value in cbo

        AddHandler custSearchTab.btnCloseSearchTab.Click, AddressOf CloseSelectedTab 'handler to remove tab

        'hide all rows
        For i = 0 To custSearchTab.dgvSearchResult.Columns.Count - 1
            custSearchTab.dgvSearchResult.Columns(i).Visible = False
        Next
        'show only the rows that are needed

        With custSearchTab.dgvSearchResult
            If .Columns.Count <> 0 Then
                .Columns("NameLast").Visible = True
                .Columns("NameLast").HeaderText = "Last Name"
                .Columns("NameLast").DisplayIndex = 0
                .Columns("NameFirst").Visible = True
                .Columns("NameFirst").HeaderText = "First Name"
                .Columns("NameFirst").DisplayIndex = 1
                .Columns("SSN").Visible = True
                .Columns("SSN").HeaderText = "Social Security"
                .Columns("SSN").DisplayIndex = 2
                .Columns("PhoneCell").Visible = True
                .Columns("PhoneCell").HeaderText = "Cell Phone"
                .Columns("PhoneCell").DisplayIndex = 3
                .Columns("PhoneHome").Visible = True
                .Columns("PhoneHome").HeaderText = "Home Phone"
                .Columns("PhoneHome").DisplayIndex = 4
                .Columns("PhoneWork").Visible = True
                .Columns("PhoneWork").HeaderText = "Work Phone"
                .Columns("PhoneWork").DisplayIndex = 5

            End If
            .Size = New Size(757, 423)
        End With

        'setting the location of close tab btn that is anchored to right and top
        Dim x As Integer
        x = tabMain.TabPages(0).Size.Width - 25
        custSearchTab.btnCloseSearchTab.Location = New Point(x, 3)

        '********************
        'Not all properties carry over from class :(
        '********************
    End Sub

    'this method is added to each close tab button at runtime so that each is completely separate from the other
    Private Sub CloseSelectedTab(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer = tabMain.SelectedIndex
        Dim tc As Integer = tabMain.TabCount
        'look at the currently selected tab that is being deleted then move the next appropriate tab upon selected tab's deletion
        If i = tc - 1 Then
            tabMain.TabPages.Remove(tabMain.SelectedTab)
            tabMain.SelectedIndex = tabMain.TabCount - 1
        Else
            tabMain.TabPages.Remove(tabMain.SelectedTab)
            tabMain.SelectedIndex = i
        End If
    End Sub

    Private Sub MailerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles msMailer.Click
        frmEmail_SMS.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles msSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub EmployeeManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeManagementToolStripMenuItem.Click
        Dim empRepo As EmployeeRepo

        If Not tabMain.TabPages.Contains(employeeMgmtTabPage) Then

            tabMain.TabPages.Insert(1, employeeMgmtTabPage)
            tabMain.SelectedTab = employeeMgmtTabPage

            EmployeeManagementToolStripMenuItem.Enabled = False

            empRepo = New EmployeeRepo
            lstEmployees = New List(Of Employee)
            lstEmployees = empRepo.GetAll()
            lstFilteredEmployees = New List(Of Employee)
            LoadEmployeeDGV()
        End If
    End Sub

    Private Sub LoadEmployeeDGV()
        dgvEmployee.Rows.Clear()
        lstFilteredEmployees = lstEmployees.Where(Function(x) x.FullName().ToLower.Contains(txtEmployeeFilter.Text.ToLower()) Or x.Username.ToLower.Contains(txtEmployeeFilter.Text.ToLower())).OrderBy(Function(x) x.NameLast).ToList()

        For Each e As Employee In lstFilteredEmployees
            dgvEmployee.Rows.Add(e.EID, e.FullNameLastNameFirst(), e.Username)
        Next
    End Sub

    Private Sub txtEmployeeFilter_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeFilter.TextChanged
        LoadEmployeeDGV()
    End Sub

    Private Sub btnCloseEmployeeManagement_Click(sender As Object, e As EventArgs) Handles btnCloseEmployeeManagement.Click
        employeeMgmtTabPage = tpEmployeeManagement
        EmployeeManagementToolStripMenuItem.Enabled = True
        ResetEmployeeManagementTab()
        CloseSelectedTab(Nothing, Nothing)
    End Sub

    Private Sub ResetEmployeeManagementTab()
        txtEmployeeFilter.Text = ""
        dgvEmployee.Rows.Clear()
    End Sub


    Dim selectedEmp As New Employee
    Private Sub dgvEmployee_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmployee.SelectionChanged
        If dgvEmployee.Rows.Count <> 0 Then
            If dgvEmployee.SelectedRows.Count = 1 Then
                selectedEmp = lstEmployees.FirstOrDefault(Function(x) x.EID = CInt(dgvEmployee.SelectedRows(0).Cells("EID").Value))
            End If


            lblEmpFullName.Text = selectedEmp.FullName()
        End If

    End Sub
End Class