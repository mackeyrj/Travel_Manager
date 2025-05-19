
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Traveler
    <Key>
    Public Property TravelerID As Integer
    Public Property Name As String
    Public Property Initials As String
    Public Property PassportNumber As String
    Public Property KnownTravelerNumber As String
    Public Property FrequentFlyerNumbers As String
    'Public Property Airline As String
    Public Property Address As String
    Public Property City As String
    Public Property State As String
    Public Property ZipCode As String
    Public Property PhoneNumber As String
    Public Property DateOfBirth As String
    'Public Property Nationality As String
    Public Property EmergencyContactName As String
    Public Property EmergencyContactPhone As String
    Public Property MedicalNotes As String
    Public Property Notes As String
    Public Sub New(name As String, Optional nickname As String = "", Optional airline As String = "", Optional passportNumber As String = "", Optional knownTravelerNumber As String = "", Optional address As String = "", Optional city As String = "", Optional state As String = "", Optional zipCode As String = "", Optional phoneNumber As String = "", Optional dateOfBirth As String = "", Optional nationality As String = "", Optional emergencyContactName As String = "", Optional emergencyContactPhone As String = "", Optional medicalNotes As String = "", Optional notes As String = "")
        Me.Name = name
        Me.Initials = Initials
        Me.PassportNumber = passportNumber
        'Me.Airline = airline
        Me.KnownTravelerNumber = knownTravelerNumber
        Me.FrequentFlyerNumbers = FrequentFlyerNumbers
        Me.Address = address
        Me.City = city
        Me.State = state
        Me.ZipCode = zipCode
        Me.PhoneNumber = phoneNumber
        Me.DateOfBirth = dateOfBirth
        'Me.Nationality = nationality
        Me.EmergencyContactName = emergencyContactName
        Me.EmergencyContactPhone = emergencyContactPhone
        Me.MedicalNotes = medicalNotes
        Me.Notes = notes
    End Sub



    Public Sub New(name As String, Optional nickname As String = "", Optional passportNumber As String = "", Optional knownTravelerNumber As String = "", Optional address As String = "", Optional city As String = "", Optional state As String = "", Optional zipCode As String = "", Optional phoneNumber As String = "")
        Me.Name = name
        Me.Initials = nickname
        Me.PassportNumber = passportNumber
        Me.KnownTravelerNumber = knownTravelerNumber
        Me.FrequentFlyerNumbers = FrequentFlyerNumbers
        Me.Address = address
        Me.City = city
        Me.State = state
        Me.ZipCode = zipCode
        Me.PhoneNumber = phoneNumber
    End Sub


    Public Sub AddTrip(trip As Trip)

    End Sub

    Public Sub New()
    End Sub

    Public Function GetTravelerInfo() As String
        Dim info As New System.Text.StringBuilder()
        info.AppendLine($"Name: {Name}")
        info.AppendLine($"Initials: {Initials}")
        info.AppendLine($"Passport Number: {PassportNumber}")
        info.AppendLine($"Known Traveler Number: {KnownTravelerNumber}")
        info.AppendLine($"Frequent Flyer Numbers: {FrequentFlyerNumbers}")
        info.AppendLine($"Address: {Address}")
        info.AppendLine($"City: {City}")
        info.AppendLine($"State: {State}")
        info.AppendLine($"Zip Code: {ZipCode}")
        info.AppendLine($"Phone Number: {PhoneNumber}")
        info.AppendLine($"Date of Birth: {DateOfBirth}")
        'info.AppendLine($"Nationality: {Nationality}")
        info.AppendLine($"Emergency Contact: {EmergencyContactName}")
        info.AppendLine($"Emergency Contact Phone: {EmergencyContactPhone}")
        info.AppendLine($"Medical Notes: {MedicalNotes}")
        info.AppendLine($"Notes: {Notes}")

    End Function

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
