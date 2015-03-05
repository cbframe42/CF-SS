Imports System.Text.RegularExpressions

Public Class Validator

    Private result As List(Of String)

    ''' <summary>
    ''' Returns a string with the errors
    ''' </summary>
    ''' <param name="n"></param>
    ''' <param name="isMiddlename"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Name(n As String, Optional isMiddlename As Boolean = False) As Boolean
        If n = "" Or n.Length < 2 Then
            Return False
            'ElseIf n.Length > 50 Then
            'Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Returns true for errors
    ''' </summary>
    ''' <param name="s"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SSN(s As String) As Boolean
        If s.Length <> 9 Or IsNumeric(s) = False Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function Address(s As String) As Boolean
        If s.Length > 100 Or s.Length < 1 Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function WorkAddress(s As String) As Boolean
        If s.Length > 100 Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function City(s As String) As Boolean
        If s.Length > 100 Or s.Length < 1 Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function WorkCity(s As String) As Boolean
        If s.Length > 100 Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function State(s As String) As Boolean
        If s.Length > 20 Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function Zip(s As String) As Boolean
        If s.Length <> 5 Or IsNumeric(s) = False Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function Occupation(s As String) As Boolean
        If s.Length > 20 Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function Employer(s As String) As Boolean
        If s.Length > 20 Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function Phone(s As String) As Boolean
        If s.Length <> 10 Or IsNumeric(s) = False Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function DOB(s As Date) As Boolean
        If s.Date > Date.Today Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function DL(s As String) As Boolean
        If s.Length <> 9 Or IsNumeric(s) = False Then
            Return False
        Else : Return True
        End If
    End Function

    Public Function MaritalStatus(s As String) As Boolean
        Return s.Length > 20
    End Function


    'define regex for this function
    Public Function Email(s As String) As Boolean
        Const regExPattern As String = "[-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\.[a-zA-Z]{2,4}"
        Return Regex.IsMatch(s, regExPattern)
    End Function

    Public Function CheckDate(d As String) As Boolean
        Return IsDate(d)
    End Function

    Public Function Password(s As String) As Boolean
        Return s.Length > 7 AndAlso s.Length < 16
    End Function

    Public Function Username(s As String) As Boolean
        Return s.Length > 3 AndAlso s.Length < 16
    End Function

    Public Function PhoneExtension(s As String) As Boolean
        Return s.Length < 6 And IsNumeric(s)
    End Function

    'also create function for validating dates or double check DOB
End Class
