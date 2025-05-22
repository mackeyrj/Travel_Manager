Imports System.ComponentModel.DataAnnotations

Public Class FrequentFlyer
    <Key>
    Public Property FrequentFlyerID As Integer
    Public Property TravelerID As Integer
    Public Property Airline As String
    Public Property FrequentFlyerNumber As String

    ' Navigation property
    Public Overridable Property Traveler As Traveler
End Class

