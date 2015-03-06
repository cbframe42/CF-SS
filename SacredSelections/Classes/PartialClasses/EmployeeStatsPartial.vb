Partial Public Class EmployeeStat
    Inherits SSDBEntities

    Public Function TimeLoggedIn() As String
        Dim t As TimeSpan?
        If LogOutTime Is Nothing Then
            t = (DateTime.Now - LogInTime)
            Return t.ToString()
        Else
            t = LogOutTime - LogInTime
            Return t.ToString()
        End If

    End Function

End Class