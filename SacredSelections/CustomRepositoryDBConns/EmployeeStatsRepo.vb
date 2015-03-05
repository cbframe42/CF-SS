Imports System.Data.Entity.Migrations

Public Class EmployeeStatsRepo

    Public Function Insert(nStat As EmployeeStat) As Boolean
        Try
            Using context As New SSDBEntities()
                context.EmployeeStats.Add(nStat)
                context.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function UpdateEmployeeStat(nStat As EmployeeStat) As Boolean
        Try
            Using context As New SSDBEntities()
                context.EmployeeStats.AddOrUpdate(nStat)
                context.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    'can be used to find out if employee is already logged in.
    Public Overloads Function GetTopStat(nEmployee As Employee) As EmployeeStat
        Dim empStat As New EmployeeStat
        Try
            Dim lstStat As New List(Of EmployeeStat)
            Using context As New SSDBEntities()
                lstStat = context.EmployeeStats.SqlQuery(String.Format("select Top 1 * from NSDB.dbo.EmployeeStat where EmployeeID = '{0}' order by LogInTime desc", nEmployee.EID)).ToList()
                empStat = lstStat(0)
            End Using
            Return empStat
        Catch ex As Exception
            Return empStat
        End Try
    End Function

    Public Overloads Function GetTopStat(nEmployeeID As Integer) As EmployeeStat
        Dim empStat As New EmployeeStat
        Try
            Dim lstStat As New List(Of EmployeeStat)
            Using context As New SSDBEntities()
                lstStat = context.EmployeeStats.SqlQuery(String.Format("select Top 1 * from NSDB.dbo.EmployeeStat where EmployeeID = '{0}' order by LogInTime desc", nEmployeeID)).ToList()
            End Using
            empStat = lstStat(0)
            Return empStat
        Catch ex As Exception
            Return empStat
        End Try
    End Function
End Class
