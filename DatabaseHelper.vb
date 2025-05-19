Imports System.IO

Public Class DatabaseHelper
    Private ReadOnly logFilePath As String = "C:\Users\macke\Desktop\Travel_Manager\ErrorLog.txt"

    Public Sub AddTraveler(traveler As Traveler)
        Try
            Using db As New TravelManagerContext()
                db.Traveler.Add(traveler)
                db.SaveChanges()
                MessageBox.Show($"Traveler '{traveler.Name}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            LogError(ex)
            MessageBox.Show($"Error adding traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub AddExpense(expense As Expense)
        Try
            Using db As New TravelManagerContext()
                db.Expense.Add(expense)
                db.SaveChanges()
                MessageBox.Show($"Traveler '{expense.Merchant}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            LogError(ex)
            MessageBox.Show($"Error adding traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Private Sub LogError(ex As Exception)
        Try
            Using writer As New StreamWriter(logFilePath, True)
                writer.WriteLine($"[{DateTime.Now}] Error Message: {ex.Message}")
                writer.WriteLine($"[{DateTime.Now}] Stack Trace: {ex.StackTrace}")

                ' Include inner exception if present
                If ex.InnerException IsNot Nothing Then
                    writer.WriteLine($"[{DateTime.Now}] Inner Exception: {ex.InnerException.Message}")
                    writer.WriteLine($"[{DateTime.Now}] Inner Stack Trace: {ex.InnerException.StackTrace}")
                End If

                writer.WriteLine(New String("-"c, 80))
            End Using
        Catch logEx As Exception
            MessageBox.Show($"Failed to write to log file: {logEx.Message}", "Logging Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub EditTravelerByName(name As String, updatedTraveler As Traveler)
        Try
            Using db As New TravelManagerContext()
                ' Find the traveler by name
                Dim existingTraveler = db.Traveler.FirstOrDefault(Function(t) t.Name = name)

                If existingTraveler IsNot Nothing Then
                    ' Update the properties
                    existingTraveler.Name = updatedTraveler.Name
                    existingTraveler.Initials = updatedTraveler.Initials
                    existingTraveler.PassportNumber = updatedTraveler.PassportNumber
                    existingTraveler.City = updatedTraveler.City
                    existingTraveler.KnownTravelerNumber = updatedTraveler.KnownTravelerNumber
                    existingTraveler.FrequentFlyerNumbers = updatedTraveler.FrequentFlyerNumbers
                    existingTraveler.Address = updatedTraveler.Address
                    existingTraveler.State = updatedTraveler.State
                    existingTraveler.ZipCode = updatedTraveler.ZipCode
                    existingTraveler.PhoneNumber = updatedTraveler.PhoneNumber
                    existingTraveler.EmergencyContactName = updatedTraveler.EmergencyContactName
                    existingTraveler.EmergencyContactPhone = updatedTraveler.EmergencyContactPhone
                    existingTraveler.MedicalNotes = updatedTraveler.MedicalNotes
                    existingTraveler.Notes = updatedTraveler.Notes
                    existingTraveler.DateOfBirth = updatedTraveler.DateOfBirth

                    ' Save the changes
                    db.SaveChanges()
                    MessageBox.Show($"Traveler '{existingTraveler.Name}' updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"Traveler with the name '{name}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            LogError(ex)
            MessageBox.Show($"Error updating traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function FindTravelerByName(name As String) As Traveler
        Try
            Using db As New TravelManagerContext()
                ' Find the traveler by name
                Dim traveler = db.Traveler.FirstOrDefault(Function(t) t.Name = name)

                If traveler IsNot Nothing Then
                    Return traveler
                Else
                    MessageBox.Show($"Traveler with the name '{name}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            LogError(ex)
            MessageBox.Show($"Error finding traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Sub DeleteTravelerByName(name As String)
        Try
            Using db As New TravelManagerContext()
                ' Find the traveler by name
                Dim travelerToDelete = db.Traveler.FirstOrDefault(Function(t) t.Name = name)

                If travelerToDelete IsNot Nothing Then
                    db.Traveler.Remove(travelerToDelete)
                    db.SaveChanges()
                    MessageBox.Show($"Traveler '{name}' deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"No traveler found with the name '{name}'.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            ' Log the full exception
            LogError(ex)

            ' Show a basic message to the user
            MessageBox.Show($"Error deleting traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetAllTravelerNames() As List(Of String)
        Try
            Using db As New TravelManagerContext()
                ' Return a list of all traveler names
                Return db.Traveler.Select(Function(t) t.Name).ToList()
            End Using
        Catch ex As Exception
            ' Log the full exception
            LogError(ex)

            ' Return an empty list on error
            Return New List(Of String)()
        End Try
    End Function

    Public Function GetTravelerByName(name As String) As Traveler
        Try
            Using db As New TravelManagerContext()
                ' Find the traveler by name
                Dim traveler = db.Traveler.FirstOrDefault(Function(t) t.Name = name)

                If traveler IsNot Nothing Then
                    Return traveler
                Else
                    MessageBox.Show($"No traveler found with the name '{name}'.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            ' Log the full exception
            LogError(ex)
            MessageBox.Show($"Error loading traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Sub UpdateTraveler(name As String,
                          nickname As String,
                          passportNumber As String,
                          knownTravelerNumber As String,
                          frequentFlyerNumbers As String,
                          address As String,
                          city As String,
                          state As String,
                          zipCode As String,
                          phoneNumber As String,
                          dateOfBirth As String,
                          emergencyContactName As String,
                          emergencyContactPhone As String,
                          medicalNotes As String,
                          notes As String)

        Try
            Using db As New TravelManagerContext()
                ' Find the traveler by name
                Dim traveler = db.Traveler.FirstOrDefault(Function(t) t.Name = name)

                If traveler IsNot Nothing Then

                    traveler.PassportNumber = passportNumber
                    traveler.KnownTravelerNumber = knownTravelerNumber
                    traveler.FrequentFlyerNumbers = frequentFlyerNumbers
                    traveler.Address = address
                    traveler.City = city
                    traveler.State = state
                    traveler.ZipCode = zipCode
                    traveler.PhoneNumber = phoneNumber
                    traveler.DateOfBirth = dateOfBirth

                    traveler.EmergencyContactName = emergencyContactName
                    traveler.EmergencyContactPhone = emergencyContactPhone
                    traveler.MedicalNotes = medicalNotes
                    traveler.Notes = notes

                    ' Save the changes
                    db.SaveChanges()
                    MessageBox.Show($"Traveler '{name}' updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"No traveler found with the name '{name}'.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            ' Log the full exception
            LogError(ex)

            ' Show a basic message to the user
            MessageBox.Show($"Error updating traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub AddTrip(trip As Trip)
        Try
            Using db As New TravelManagerContext()
                db.Trip.Add(trip)
                db.SaveChanges()
            End Using
        Catch ex As Exception
            LogError(ex)
            Throw
        End Try
    End Sub

    Public Sub AddTravelerToTrip(tripID As Integer, travelerName As String, role As String)
        Try
            Using db As New TravelManagerContext()
                Dim traveler = db.Traveler.FirstOrDefault(Function(t) t.Name = travelerName)

                If traveler IsNot Nothing Then
                    Dim tripDetail As New TripDetail() With {
                    .TripID = tripID,
                    .TravelerID = traveler.TravelerID,
                    .Role = role
                }
                    db.TripDetail.Add(tripDetail)
                    db.SaveChanges()
                Else
                    MessageBox.Show($"No traveler found with the name '{travelerName}'.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            LogError(ex)
            Throw
        End Try
    End Sub

    Public Sub AddTravelMethod(method As TravelMethod)
        Try
            Using db As New TravelManagerContext()
                db.TravelMethod.Add(method)
                db.SaveChanges()
                MessageBox.Show($"Travel method '{method.MethodType}' saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            LogError(ex)
            MessageBox.Show($"Error saving travel method: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class