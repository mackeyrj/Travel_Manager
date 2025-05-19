Imports System.ComponentModel.DataAnnotations

Public Class Trip
    <Key>
    Public Property TripID As Integer
    Public Property TripName As String
    Public Property TripDate As String
    Public Property TripDestination As String
    Public Property TripDetails As String

    ' Navigation properties
    Public Overridable Property TravelMethods As ICollection(Of TravelMethod)
    Public Overridable Property TripDetailsList As ICollection(Of TripDetail)

    Public Sub New()
        TravelMethods = New List(Of TravelMethod)()
        TripDetailsList = New List(Of TripDetail)()
    End Sub
End Class
