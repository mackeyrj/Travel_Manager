Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("Traveling")>
Public Class Traveling
    <Key>
    Public Property TravelingID As Integer
    Public Property Name As String
    Public Property Nickname As String
    Public Property PassportNumber As String
    Public Property KnownTravelerNumber As String
    Public Property FrequentFlyerNumbers As String ' Store as comma-separated values
    Public Property Address As String
    Public Property City As String
    Public Property State As String
    Public Property ZipCode As String
    Public Property PhoneNumber As String
    Public Property DateOfBirth As String
    Public Property Nationality As String
    Public Property EmergencyContactName As String
    Public Property EmergencyContactPhone As String
    Public Property MedicalNotes As String
    Public Property Notes As String
End Class
