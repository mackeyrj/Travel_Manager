
Public Class Traveler_Info
    Private Sub btnCreateTraveler_Click(sender As Object, e As EventArgs) Handles btnCreateTraveler.Click
        Try
            ' Create the Traveler object
            Dim newTraveler As New Traveler(
            name:=txtName.Text.Trim(),
            nickname:=txtNickName.Text.Trim(),
            passportNumber:=txtPassport.Text.Trim(),
            airline:=txtAirline.Text.Trim(),
            knownTravelerNumber:=txtKnownTravelerNumber.Text.Trim(),
            address:=txtAddress.Text.Trim(),
            city:=txtCity.Text.Trim(),
            state:=txtState.Text.Trim(),
            zipCode:=txtZip.Text.Trim(),
            phoneNumber:=txtPhone.Text.Trim(),
            dateOfBirth:=txtDOB.Text.Trim(),
            emergencyContactName:=txtSOSContact.Text.Trim(),
            emergencyContactPhone:=txtSOSNumber.Text.Trim(),
            medicalNotes:=txtMedicalNotes.Text.Trim(),
            notes:=txtGeneralNotes.Text.Trim()
        )


            ' Save the traveler using FileHandler
            Dim fileHandler As New FileHandler()
            fileHandler.WriteTraveler(newTraveler)

            ' Reset the form fields
            txtName.Clear()
            txtNickName.Clear()
            txtPassport.Clear()
            txtFrequentFlyer.Clear()
            txtKnownTravelerNumber.Clear()
            txtAddress.Clear()
            txtCity.Clear()
            txtState.Clear()
            txtZip.Clear()
            txtPhone.Clear()
            txtDOB.Clear()
            txtSOSContact.Clear()
            txtSOSNumber.Clear()
            txtMedicalNotes.Clear()
            txtGeneralNotes.Clear()

        Catch ex As Exception
            MessageBox.Show($"Error creating traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSaveTraveler_Click(sender As Object, e As EventArgs) Handles btnSaveTraveler.Click

        If cbFrequentFlyerNumbers.Items.Count = 0 Then
            If MessageBox.Show("No frequent flyer numbers added. Do you want to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
        End If


        Try
            ' Validate required fields
            If String.IsNullOrWhiteSpace(txtName.Text) Then
                MessageBox.Show("Please enter a traveler name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using db As New TravelManagerContext()

                ' Step 1: Create and save Traveler
                Dim traveler As New Traveler With {
                .Name = txtName.Text.Trim(),
                .Initials = txtNickName.Text.Trim(),
                .PassportNumber = txtPassport.Text.Trim(),
                .KnownTravelerNumber = txtKnownTravelerNumber.Text.Trim(),
                .Address = txtAddress.Text.Trim(),
                .City = txtCity.Text.Trim(),
                .State = txtState.Text.Trim(),
                .ZipCode = txtZip.Text.Trim(),
                .PhoneNumber = txtPhone.Text.Trim(),
                .DateOfBirth = txtDOB.Text.Trim(),
                .EmergencyContactName = txtSOSContact.Text.Trim(),
                .EmergencyContactPhone = txtSOSNumber.Text.Trim(),
                .MedicalNotes = txtMedicalNotes.Text.Trim(),
                .Notes = txtGeneralNotes.Text.Trim()
            }

                db.Traveler.Add(traveler)
                db.SaveChanges() ' TravelerID is now generated

                ' Add each FrequentFlyer entry from the ComboBox
                For Each item As String In cbFrequentFlyerNumbers.Items
                    Dim parts = item.Split({" - "}, StringSplitOptions.None)
                    If parts.Length = 2 Then
                        db.FrequentFlyer.Add(New FrequentFlyer With {
                        .TravelerID = traveler.TravelerID,
                        .Airline = parts(0).Trim(),
                        .FrequentFlyerNumber = parts(1).Trim()
                    })
                    End If
                Next

                db.SaveChanges()
            End Using


            MessageBox.Show("Traveler and frequent flyer numbers saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            Dim fullMessage As String = $"Error saving traveler: {ex.Message}"
            If ex.InnerException IsNot Nothing Then
                fullMessage &= Environment.NewLine & "Inner Exception: " & ex.InnerException.Message
            End If
            MessageBox.Show(fullMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUpdateTraveler_Click(sender As Object, e As EventArgs) Handles btnUpdateTraveler.Click
        Dim name As String = txtName.Text.Trim()

        If Not String.IsNullOrWhiteSpace(name) Then
            Dim updatedTraveler As New Traveler With {
            .Name = name,
            .Initials = txtNickName.Text.Trim(),
            .PassportNumber = txtPassport.Text.Trim(),
            .City = txtCity.Text.Trim(),
            .KnownTravelerNumber = txtKnownTravelerNumber.Text.Trim(),
            .FrequentFlyerNumbers = txtFrequentFlyer.Text.Trim(),
            .Address = txtAddress.Text.Trim(),
            .State = txtState.Text.Trim(),
            .ZipCode = txtZip.Text.Trim(),
            .PhoneNumber = txtPhone.Text.Trim(),
            .EmergencyContactName = txtSOSContact.Text.Trim(),
            .EmergencyContactPhone = txtSOSNumber.Text.Trim(),
            .MedicalNotes = txtMedicalNotes.Text.Trim(),
            .Notes = txtGeneralNotes.Text.Trim(),
            .DateOfBirth = If(DateTime.TryParse(txtDOB.Text.Trim(), Nothing), DateTime.Parse(txtDOB.Text.Trim()), Nothing)
        }

            Dim dbHelper As New DatabaseHelper()
            dbHelper.EditTravelerByName(name, updatedTraveler)
        Else
            MessageBox.Show("Please enter a valid traveler name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnFindRecord_Click(sender As Object, e As EventArgs) Handles btnFindRecord.Click
        Dim name As String = txtName.Text.Trim()

        If Not String.IsNullOrWhiteSpace(name) Then
            Dim dbHelper As New DatabaseHelper()
            Dim traveler = dbHelper.FindTravelerByName(name)

            If traveler IsNot Nothing Then
                ' Populate the form with the traveler's data
                txtNickName.Text = traveler.Initials
                txtPassport.Text = traveler.PassportNumber
                txtCity.Text = traveler.City
                txtKnownTravelerNumber.Text = traveler.KnownTravelerNumber
                txtFrequentFlyer.Text = traveler.FrequentFlyerNumbers
                txtAddress.Text = traveler.Address
                txtState.Text = traveler.State
                txtZip.Text = traveler.ZipCode
                txtPhone.Text = traveler.PhoneNumber
                txtSOSContact.Text = traveler.EmergencyContactName
                txtSOSNumber.Text = traveler.EmergencyContactPhone
                txtMedicalNotes.Text = traveler.MedicalNotes
                txtGeneralNotes.Text = traveler.Notes
                txtDOB.Text = traveler.DateOfBirth



                MessageBox.Show($"Traveler '{traveler.Name}' found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please enter a traveler name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not String.IsNullOrWhiteSpace(txtName.Text) Then
            Dim dbHelper As New DatabaseHelper()
            dbHelper.DeleteTravelerByName(txtName.Text.Trim())
        Else
            MessageBox.Show("Please enter a name to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub







    Private Sub Traveler_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFrequentFlyer.MaxLength = 20 ' Or however long a FFN should be

    End Sub

    Private Sub btnFFN_Click(sender As Object, e As EventArgs) Handles btnFFN.Click
        Dim ffNumber As String = txtFrequentFlyer.Text.Trim()
        Dim airline As String = txtAirline.Text.Trim()

        If String.IsNullOrWhiteSpace(ffNumber) OrElse String.IsNullOrWhiteSpace(airline) Then
            MessageBox.Show("Please enter both the airline and frequent flyer number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim displayText As String = $"{airline} - {ffNumber}"

        If cbFrequentFlyerNumbers.Items.Contains(displayText) Then
            MessageBox.Show("This frequent flyer entry is already added.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFrequentFlyer.Clear()
            txtAirline.Clear()
            txtAirline.Focus()
            Return
        End If

        cbFrequentFlyerNumbers.Items.Add(displayText)
        txtFrequentFlyer.Clear()
        txtAirline.Clear()
        txtAirline.Focus()
    End Sub

End Class