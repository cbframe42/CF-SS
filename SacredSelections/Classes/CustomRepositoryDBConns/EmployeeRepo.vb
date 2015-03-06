Imports System.Data.Entity.Migrations

Public Class EmployeeRepo
    Inherits SSDBEntities

    Private ReadOnly Property Lst As List(Of String)
        Get
            Lst = New List(Of String)
            Lst.Add("Error connecting to database.")
            Lst.Add("Error adding Client to database.")
            Lst.Add("Client successfully added to database.")
            Return Lst
        End Get
    End Property

    Public Function GetAll() As List(Of Employee)
        Try
            Using context As New SSDBEntities
                Return context.Employees.ToList()
            End Using
        Catch ex As Exception
            MsgBox(Lst(0).ToString() & ControlChars.NewLine & ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function Insert(nEmployee As Employee) As Boolean
        Try
            nEmployee = CheckEmployeeNulls(nEmployee)
            Using conn As New SSDBEntities
                conn.Employees.Add(nEmployee)
                conn.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Overloads Function Delete(nEmpID As String) As Boolean
        Try
            Using conn As New SSDBEntities
                conn.Employees.Remove(conn.Employees.Find(nEmpID))
                conn.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox("Error deleting Employee." & ControlChars.NewLine & ex.Message)
            Return False
        End Try
    End Function

    Public Overloads Function Delete(nEmployee As Employee) As Boolean
        Try
            Using conn As New SSDBEntities
                conn.Employees.Remove(nEmployee)
                conn.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox("Error deleting Employee." & ControlChars.NewLine & ex.Message)
            Return False
        End Try
    End Function

    'query for finding all within age range or dateadded range
    'employee active 

    Public Function FindAllByID(nID As String) As List(Of Employee)
        Try
            Dim c As New List(Of Employee)
            Using conn As New SSDBEntities
                'Dim client As New Employee
                'client = Enumerable.[Single](_context.Employees, Function(i) i.LoginID = id)
                c = conn.Employees.SqlQuery(String.Format("SELECT * from nsdb.dbo.employee where EID like '%{0}%' ORDER BY NameLast", nID)).ToList()
            End Using
            Return c
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function FindOneByID(nID As Integer) As Employee
        Try
            Dim emp As New Employee
            Using conn As New SSDBEntities
                'both of the following 'emp' assignments work correctly
                ' emp = Enumerable.[Single](_context.Employees, Function(i) i.EID = id)
                emp = conn.Employees.Single(Function(x) x.EID = nID)
            End Using
            Return emp
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function FindByLastName(nLastName As String) As List(Of Employee)
        Try
            Dim c As List(Of Employee)
            Using conn As New SSDBEntities
                c = conn.Employees.SqlQuery(String.Format("SELECT * from NSDB.dbo.Employee where NameLast like '%{0}%' ORDER BY NameLast", nLastName)).ToList()
            End Using
            Return c
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function FindBySSN(nSSN As String) As List(Of Employee)
        Try
            Dim c As List(Of Employee)
            Using conn As New SSDBEntities()
                c = conn.Employees.SqlQuery(String.Format("SELECT * from NSDB.dbo.Employee where SSN like '%{0}%' ORDER BY NameLast", nSSN)).ToList()
            End Using
            Return c
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function SearchByActive(trueFalse As Boolean) As List(Of Employee)
        Try
            Dim e As New List(Of Employee)
            Using conn As New SSDBEntities()
                e = conn.Employees.Where(Function(x) x.Active.Equals(trueFalse)).ToList()
            End Using
            Return e
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function SearchByAccountLocked(trueFalse As Boolean) As List(Of Employee)
        Try
            Dim e As New List(Of Employee)
            Using conn As New SSDBEntities
                e = conn.Employees.Where(Function(x) x.AccountLocked.Equals(trueFalse)).ToList()
            End Using
            Return e
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function SearchByAccessLevel(accessLevel As Integer) As List(Of Employee)
        Try
            If accessLevel > 0 And accessLevel < 4 Then
                Dim e As New List(Of Employee)
                Using conn As New SSDBEntities
                    e = conn.Employees.Where(Function(x) x.AccessLevel.Equals(accessLevel)).ToList()
                End Using
                Return e
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ForcePasswordChangeList() As List(Of Employee)
        Try
            Dim e As List(Of Employee)
            Using conn As New SSDBEntities
                e = conn.Employees.Where(Function(x) x.ForcePasswordChange.Equals(True)).ToList()
            End Using
            Return e
        Catch ex As Exception
            MsgBox("Error connecting to database.")
            Return Nothing
        End Try
    End Function

    Public Function FindOneByUsername(nUsername As String) As Employee
        Dim e As New Employee
        Try
            Using conn As New SSDBEntities
                e = conn.Employees.Single(Function(x) x.Username = nUsername)
            End Using

            Return e
        Catch ex As Exception
            Return e
        End Try
    End Function

    Public Function UpdateEmployee(nEmployee As Employee) As Boolean
        Try
            nEmployee = CheckEmployeeNulls(nEmployee)
            Using conn As New SSDBEntities
                conn.Employees.AddOrUpdate(nEmployee)
                conn.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function CheckEmployeeNulls(nEmployee As Employee) As Employee
        With nEmployee
            .AddressHome = If(String.IsNullOrWhiteSpace(.AddressHome), Nothing, .AddressHome)
            .CityHome = If(String.IsNullOrWhiteSpace(.CityHome), Nothing, .CityHome)
            .NameMiddle = If(String.IsNullOrWhiteSpace(.NameMiddle), Nothing, .NameMiddle)
            .PhoneHome = If(String.IsNullOrWhiteSpace(.PhoneHome), Nothing, .PhoneHome)
            .PhoneCell = If(String.IsNullOrWhiteSpace(.PhoneCell), Nothing, .PhoneCell)
            .Email = If(String.IsNullOrWhiteSpace(.Email), Nothing, .Email)
            .StateHome = If(String.IsNullOrWhiteSpace(.StateHome), Nothing, .StateHome)
            .MaritalStatus = If(String.IsNullOrWhiteSpace(.MaritalStatus), Nothing, .MaritalStatus)
            .EmergencyContactName = If(String.IsNullOrWhiteSpace(.EmergencyContactName), Nothing, .EmergencyContactName)
            .EmergencyContactPhone1 = If(String.IsNullOrWhiteSpace(.EmergencyContactPhone1), Nothing, .EmergencyContactPhone1)
            .EmergencyContactPhone2 = If(String.IsNullOrWhiteSpace(.EmergencyContactPhone2), Nothing, .EmergencyContactPhone2)
            .Username = If(String.IsNullOrWhiteSpace(.Username), Nothing, .Username.ToLower())
        End With

        Return nEmployee
    End Function

End Class