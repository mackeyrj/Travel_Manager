Imports System.ComponentModel.DataAnnotations

Public Class TripDetail
    <Key>
    Public Property TripDetailID As Integer
    Public Property TripID As Integer
    Public Property TravelerID As Integer
    Public Property Role As String

    ' Navigation properties
    Public Overridable Property Trip As Trip
    Public Overridable Property Traveler As Traveler
End Class
