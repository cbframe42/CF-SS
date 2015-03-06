Imports System.Data.Entity.Migrations

Public Class LogRepo
    Public Function GetAll() As List(Of AppLog)
        Dim lstLogs As New List(Of AppLog)
        Try
            Using conn As New SSDBEntities
                lstLogs = conn.AppLogs.ToList()
            End Using
            Return lstLogs
        Catch ex As Exception
            Return lstLogs
        End Try
    End Function

    Public Function Insert(nLog As AppLog) As Boolean
        Try
            Using conn As New SSDBEntities
                ' conn.AppLogs.Attach(nLog)
                conn.AppLogs.AddOrUpdate(nLog)
                conn.SaveChanges()
            End Using
            Return True

        Catch ex As Exception
            MsgBox(ex.Message & "logs")
            Return False
        End Try
    End Function

    Public Overloads Function Delete(nLogID As Integer) As Boolean
        Try
            Using conn As New SSDBEntities
                conn.AppLogs.Remove(conn.AppLogs.Find(nLogID))
                conn.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Overloads Function Delete(nLog As AppLog) As Boolean
        Try
            Using conn As New SSDBEntities
                conn.AppLogs.Remove(nLog)
                conn.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function FindOneByDate(nDate As Date) As AppLog
        Dim l As New AppLog
        Try
            Using conn As New SSDBEntities
                l = conn.AppLogs.SingleOrDefault(Function(x) x.DateTime.Date = nDate)
            End Using
            Return l
        Catch ex As Exception
            Return l
        End Try
    End Function

    Public Function FindCountByDateAndType(nDate As Date, nType As String) As Integer
        Try
            Dim c As New List(Of AppLog)
            Using conn As New SSDBEntities
                c = conn.AppLogs.Where(Function(x) x.DateAdded = nDate And x.LogType = nType).ToList()
            End Using
            Return c.Count
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function UpdateLog(nLog As AppLog) As Boolean
        Try
            Using conn As New SSDBEntities
                conn.AppLogs.AddOrUpdate(nLog)
                conn.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
