
Public Class SelectionLists

    Public States As List(Of String) = StateList()
    Public MarriageStatus As List(Of String) = MaritalStatusList()
    Public Years As List(Of String) = GetYears()
    Public Months As List(Of String) = MonthsLst()
    Public SearchTypes As List(Of String) = GetSearchTypes()
    Public NumOfDays As List(Of String) = DayNumbers()
    Public AccessLevel As List(Of Integer) = AcccesLevel()
    Public CellCarriers As List(Of String) = GetCarriers()

    Private Function DayNumbers() As List(Of String)
        Const start As Integer = 1
        Const last As Integer = 31
        Dim lst As New List(Of String)
        lst.Add("")
        For i As Integer = start To last
            lst.Add(CStr(i))
        Next
        Return lst
    End Function

    Private Function GetYears() As List(Of String)
        Dim start As Integer = CInt(Date.Today.Year) - 120
        Dim last As Integer = CInt(Date.Today.Year)
        Dim lst As New List(Of String)
        lst.Add("")
        For i As Integer = last To start Step -1
            lst.Add(CStr(i))
        Next
        Return lst
    End Function


    'carriers list probaly will not be used at actual runtime
    Private Function GetCarriers() As List(Of String)
        Dim lst As New List(Of String)
        lst.Add("Select a cell carrier...")
        lst.Add("Verizon")
        lst.Add("US Cellular")
        lst.Add("Sprint")
        Return lst
    End Function

    Private Function GetSearchTypes() As List(Of String)
        Dim lst As New List(Of String)
        lst.Add("Last name")
        lst.Add("Social Security Number")
        lst.Add("Phone")
        Return lst
    End Function

    Private Function MonthsLst() As List(Of String)
        Dim lst As New List(Of String)
        lst.Add("")
        lst.Add("January")
        lst.Add("February")
        lst.Add("March")
        lst.Add("April")
        lst.Add("May")
        lst.Add("June")
        lst.Add("July")
        lst.Add("August")
        lst.Add("September")
        lst.Add("October")
        lst.Add("November")
        lst.Add("December")
        Return lst
    End Function


    Private Function StateList() As List(Of String)
        Dim list As New List(Of String)
        list.Add("")
        list.Add("Alabama")
        list.Add("Alaska")
        list.Add("Arizona")
        list.Add("Arkansas")
        list.Add("California")
        list.Add("Colorado")
        list.Add("Connecticut")
        list.Add("Delaware")
        list.Add("District Of Columbia")
        list.Add("Florida")
        list.Add("Georgia")
        list.Add("Hawaii")
        list.Add("Idaho")
        list.Add("Illinois")
        list.Add("Indiana")
        list.Add("Iowa")
        list.Add("Kansas")
        list.Add("Kentucky")
        list.Add("Louisiana")
        list.Add("Maine")
        list.Add("Maryland")
        list.Add("Massachusetts")
        list.Add("Michigan")
        list.Add("Minnesota")
        list.Add("Mississippi")
        list.Add("Missouri")
        list.Add("Montana")
        list.Add("Nebraska")
        list.Add("Nevada")
        list.Add("New Hampshire")
        list.Add("New Jersey")
        list.Add("New Mexico")
        list.Add("New York")
        list.Add("North Carolina")
        list.Add("North Dakota")
        list.Add("Ohio")
        list.Add("Oklahoma")
        list.Add("Oregon")
        list.Add("Palau")
        list.Add("Pennsylvania")
        list.Add("Puerto Rico")
        list.Add("Rhode Island")
        list.Add("South Carolina")
        list.Add("South Dakota")
        list.Add("Tennessee")
        list.Add("Texas")
        list.Add("Utah")
        list.Add("Vermont")
        list.Add("Virginia")
        list.Add("Washington")
        list.Add("West Virginia")
        list.Add("Wisconsin")
        list.Add("Wyoming")
        Return list
    End Function

    Private Function MaritalStatusList() As List(Of String)
        Dim list As New List(Of String)
        list.Add("")
        list.Add("Single")
        list.Add("Married")
        list.Add("Widowed")
        list.Add("Domestic partnership")
        list.Add("Civil union")
        Return list
    End Function

    Private Function AcccesLevel() As List(Of Integer)
        Dim list As New List(Of Integer)
        list.Add(Nothing)
        list.Add(1)
        list.Add(2)
        list.Add(3)
        Return list
    End Function

End Class

'Class Months
'    Function Num() As Integer

'    End Function
'End Class