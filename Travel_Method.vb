Imports System.ComponentModel.DataAnnotations

Public Class TravelMethod
    <Key>
    Public Property MethodID As Integer
    Public Property TripID As Integer
    Public Property MethodType As String
    Public Property Carrier As String
    Public Property DepartureLocation As String
    Public Property ArrivalLocation As String
    Public Property DepartureTime As String
    Public Property ArrivalTime As String
    Public Property DepartureDate As String
    Public Property ArrivalDate As String
    Public Property Notes As String

    ' Navigation property
    Public Overridable Property Trip As Trip
End Class
