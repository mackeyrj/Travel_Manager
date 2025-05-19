Imports System.Drawing.Printing
Imports System.IO


Public Class FileHandler
    Private ReadOnly baseDirectory As String = "C:\Users\macke\Desktop\Travel_Manager"

    Public Sub CreateDirectoryIfNotExists()
        Try
            If Not Directory.Exists(baseDirectory) Then
                Directory.CreateDirectory(baseDirectory)
                NotificationHelper.ShowSuccess($"Created main directory at {baseDirectory}.")
            End If
        Catch ex As Exception
            NotificationHelper.ShowError($"An error occurred while creating the directory: {ex.Message}")
        End Try
    End Sub

    Public Sub OpenTravelerFile(travelerName As String)
        Try
            ' Ensure the main directory exists
            CreateDirectoryIfNotExists()

            ' Create a directory for the traveler
            Dim travelerDirectory As String = Path.Combine(baseDirectory, travelerName)
            If Not Directory.Exists(travelerDirectory) Then
                Directory.CreateDirectory(travelerDirectory)
                NotificationHelper.ShowSuccess($"Created directory for {travelerName}.")
            End If

            ' Create the traveler file if it doesn't exist
            Dim travelerFilePath As String = Path.Combine(travelerDirectory, "transactions.txt")
            If Not File.Exists(travelerFilePath) Then
                File.WriteAllText(travelerFilePath, $"{travelerName} Transactions Log{Environment.NewLine}")
                NotificationHelper.ShowSuccess($"Created new file for {travelerName}.")
            End If

            ' Open the file in Notepad
            Process.Start("notepad.exe", travelerFilePath)
        Catch ex As Exception
            NotificationHelper.ShowError($"An error occurred while opening the traveler file: {ex.Message}")
        End Try
    End Sub


    Public Sub PrintTravelerFile(travelerName As String)
        Try
            ' Ensure the main directory exists
            CreateDirectoryIfNotExists()

            ' Define the traveler directory and file path
            Dim travelerDirectory As String = Path.Combine(baseDirectory, travelerName)
            Dim travelerFilePath As String = Path.Combine(travelerDirectory, "transactions.txt")

            If Not File.Exists(travelerFilePath) Then
                NotificationHelper.ShowWarning($"File for {travelerName} does not exist.")
                Return
            End If

            ' Read the file content
            Dim fileContent As String = File.ReadAllText(travelerFilePath)

            ' Set up the print document
            Dim printDoc As New PrintDocument()
            AddHandler printDoc.PrintPage, Sub(sender As Object, e As PrintPageEventArgs)
                                               e.Graphics.DrawString(fileContent, New Font("Consolas", 10), Brushes.Black, New RectangleF(0, 0, e.PageBounds.Width, e.PageBounds.Height))
                                           End Sub

            ' Print the document
            printDoc.Print()
            NotificationHelper.ShowSuccess($"Printing file for {travelerName}...")
        Catch ex As Exception
            NotificationHelper.ShowError($"An error occurred while printing: {ex.Message}")
        End Try
    End Sub


    Public Sub WriteTransaction(travelerName As String, transactionDate As DateTime, currency As String, location As String, recipient As String, merchantDetail As String, description As String, amount As Decimal, tripName As String)
        Try
            ' Ensure the main directory exists
            CreateDirectoryIfNotExists()

            ' Create a directory for the traveler
            Dim travelerDirectory As String = Path.Combine(baseDirectory, travelerName)
            If Not Directory.Exists(travelerDirectory) Then
                Directory.CreateDirectory(travelerDirectory)
                NotificationHelper.ShowSuccess($"Created directory for {travelerName}.")
            End If

            ' Prepare the transaction file path
            Dim travelerFilePath As String = Path.Combine(travelerDirectory, "transactions.txt")

            ' Create the file header if it doesn't exist
            If Not File.Exists(travelerFilePath) Then
                Dim header As String = $"{tripName}{Environment.NewLine}Traveler: {travelerName}{Environment.NewLine}Transactions{Environment.NewLine}{New String("-"c, 20)}{Environment.NewLine}"
                File.WriteAllText(travelerFilePath, header)
                NotificationHelper.ShowSuccess($"Created new file for {travelerName}.")
            End If

            ' Prepare the formatted transaction entry
            Dim transactionEntry As String = $"Date: {transactionDate:yyyy-MM-dd}{Environment.NewLine}Currency: {currency}{Environment.NewLine}Location: {location}{Environment.NewLine}Recipient: {recipient}{Environment.NewLine}Merchant Detail: {merchantDetail}{Environment.NewLine}Description: {description}{Environment.NewLine}Amount: {amount:C}{Environment.NewLine}{New String("-"c, 20)}{Environment.NewLine}"

            ' Append the transaction to the file
            File.AppendAllText(travelerFilePath, transactionEntry)
            NotificationHelper.ShowSuccess("Transaction saved successfully!")
        Catch ex As Exception
            NotificationHelper.ShowError($"An error occurred while saving the transaction: {ex.Message}")
        End Try
    End Sub

    Public Sub WriteTraveler(traveler As Traveler)
        Try
            ' Ensure the main directory exists
            CreateDirectoryIfNotExists()

            ' Create a directory for the traveler
            Dim travelerDirectory As String = Path.Combine(baseDirectory, traveler.Name)
            If Not Directory.Exists(travelerDirectory) Then
                Directory.CreateDirectory(travelerDirectory)
                NotificationHelper.ShowSuccess($"Created directory for {traveler.Name}.")
            End If

            ' Prepare the traveler file path
            Dim travelerFilePath As String = Path.Combine(travelerDirectory, $"{traveler.Name}.txt")

            ' Prepare the traveler info for saving
            Dim travelerInfo As New System.Text.StringBuilder()
            travelerInfo.AppendLine($"Name: {traveler.Name}")
            travelerInfo.AppendLine($"Nickname: {traveler.Initials}")
            travelerInfo.AppendLine($"Passport Number: {traveler.PassportNumber}")
            travelerInfo.AppendLine($"Known Traveler Number: {traveler.KnownTravelerNumber}")
            travelerInfo.AppendLine($"Frequent Flyer Numbers: {traveler.FrequentFlyerNumbers}")
            ' travelerInfo.AppendLine($"Airline: {String.Join(", ", traveler.Airline)}")
            travelerInfo.AppendLine($"Address: {traveler.Address}")
            travelerInfo.AppendLine($"City: {traveler.City}")
            travelerInfo.AppendLine($"State: {traveler.State}")
            travelerInfo.AppendLine($"Zip Code: {traveler.ZipCode}")
            travelerInfo.AppendLine($"Phone Number: {traveler.PhoneNumber}")
            travelerInfo.AppendLine($"Date of Birth: {traveler.DateOfBirth}")
            'travelerInfo.AppendLine($"Nationality: {traveler.Nationality}")
            travelerInfo.AppendLine($"Emergency Contact: {traveler.EmergencyContactName}")
            travelerInfo.AppendLine($"Emergency Contact Phone: {traveler.EmergencyContactPhone}")
            travelerInfo.AppendLine($"Medical Notes: {traveler.MedicalNotes}")
            travelerInfo.AppendLine($"Notes: {traveler.Notes}")
            travelerInfo.AppendLine(New String("-"c, 20))

            ' Write the traveler info to the file
            File.WriteAllText(travelerFilePath, travelerInfo.ToString())

            NotificationHelper.ShowSuccess($"Traveler '{traveler.Name}' saved successfully!")
        Catch ex As Exception
            NotificationHelper.ShowError($"An error occurred while saving the traveler: {ex.Message}")
        End Try
    End Sub




    Public Sub CloseApplication()
        Application.Exit()
    End Sub

End Class
