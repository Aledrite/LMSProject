Imports System.Collections.ObjectModel
Imports Microsoft.VisualBasic

Public Class GlobalVariables

    Public Shared Books As New Dictionary(Of Integer, Dictionary(Of String, String))()

    Public Shared Users As New Dictionary(Of Integer, Dictionary(Of String, String))()

    Public Shared UserRentedBooks As New Dictionary(Of Integer, Dictionary(Of Integer, Dictionary(Of String, String)))()

End Class
