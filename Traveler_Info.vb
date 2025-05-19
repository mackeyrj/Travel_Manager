
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
        If txtName.Text IsNot "" Then
            Dim traveler As New Traveler With {
                .Name = txtName.Text.Trim(),
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
                .DateOfBirth = txtDOB.Text.Trim
            }

            Dim dbHelper As New DatabaseHelper()
            dbHelper.AddTraveler(traveler)
        Else
            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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


End Class