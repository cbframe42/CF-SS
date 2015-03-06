Partial Public Class Employee
    Inherits SSDBEntities

    Private _hashSalt As HashSaltFactory
    Private Const Space As String = " "
    Private Const NL As String = ControlChars.NewLine

    'Public Function GetEID() As String
    '    Dim strEid As String
    '    strEid = NameFirst.ToLower().Substring(0, 1) & NameLast.ToLower().Substring(0, 2) & SSN.Substring(5, 4)
    '    Return strEid
    'End Function


    'Public Function Level() As String

    'End Function

    Public Function IsPasswordMatch(value As String) As Boolean
        Try
            _hashSalt = New HashSaltFactory()
            Dim match As Boolean
            match = (_hashSalt.CreateHash(value, Salt) = Password)
            Return match
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub SetNewPassword(nPassword As String, Optional nforcePasswordChange As Boolean = False)
        Try
            _hashSalt = New HashSaltFactory()
            'set new salt
            Dim newSalt As String = _hashSalt.CreateSalt()
            'set new encrypted password with the salt
            Dim newPwd As String = _hashSalt.CreateHash(nPassword, newSalt)

            'save new salt, encrypted password, and whether the password needs to be changed
            Salt = newSalt
            Password = newPwd
            ForcePasswordChange = nforcePasswordChange
        Catch ex As Exception
            MsgBox("Password change failed.")
        End Try

    End Sub

    Public Function CheckLogInStatus() As Boolean
        Dim stat As New EmployeeStat
        Dim statsRepo As New EmployeeStatsRepo
        stat = statsRepo.GetTopStat(EID)
        If stat Is Nothing Then
            Return False
        Else
            Return stat.LoggedIn
        End If
    End Function

    Public Function LogLoginTime() As Boolean
        Try
            Dim stat As New EmployeeStat
            Dim empStatRepo As New EmployeeStatsRepo
            Dim dt As DateTime = DateTime.Now
            stat.EmployeeID = EID
            stat.Date = Date.Today
            stat.LogInTime = dt
            stat.LoggedIn = True
            stat.LogOutTime = Nothing
            empStatRepo.Insert(stat)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function LogLogoutTime() As Boolean
        Try
            Dim stat As New EmployeeStat
            Dim empStatRepo As New EmployeeStatsRepo
            Dim dt As New DateTime
            dt = DateTime.Now
            stat = empStatRepo.GetTopStat(EID)
            stat.LogOutTime = dt
            stat.LoggedIn = False
            empStatRepo.UpdateEmployeeStat(stat)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function TimeLoggedIn() As String
        Try
            Dim stat As New EmployeeStat
            Dim empStatRepo As New EmployeeStatsRepo
            stat = empStatRepo.GetTopStat(EID)
            Return stat.TimeLoggedIn()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function FullName() As String
        If NameMiddle <> Nothing Then
            Return NameFirst & Space & NameMiddle & Space & NameLast
        Else
            Return NameFirst & Space & NameLast
        End If
    End Function

    Public Function FullNameLastNameFirst() As String
        If NameMiddle <> Nothing Then
            Return NameLast & "," & Space & NameFirst & Space & NameMiddle.Substring(0, 1).ToUpper()
        Else
            Return NameLast & "," & Space & NameFirst
        End If
    End Function
End Class
