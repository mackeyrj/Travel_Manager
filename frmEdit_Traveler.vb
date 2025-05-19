Public Class frmEdit_Traveler
    Private Sub frmEdit_Traveler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dbHelper As New DatabaseHelper()
            Dim travelerNames = dbHelper.GetAllTravelerNames()

            If travelerNames.Count > 0 Then
                cbEditTraveler.DataSource = travelerNames
            Else
                MessageBox.Show("No travelers found in the database.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading travelers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbEditTravelers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEditTraveler.SelectedIndexChanged
        Try
            If cbEditTraveler.SelectedItem IsNot Nothing Then
                Dim selectedTravelerName As String = cbEditTraveler.SelectedItem.ToString()

                Dim dbHelper As New DatabaseHelper()
                Dim traveler = dbHelper.GetTravelerByName(selectedTravelerName)


                If traveler IsNot Nothing Then
                    txtNickName.Text = traveler.Initials
                    txtPassport.Text = traveler.PassportNumber
                    txtKnownTravelerNumber.Text = traveler.KnownTravelerNumber
                    txtFrequentFlyer.Text = traveler.FrequentFlyerNumbers
                    txtAddress.Text = traveler.Address
                    txtCity.Text = traveler.City
                    txtState.Text = traveler.State
                    txtZip.Text = traveler.ZipCode
                    txtPhone.Text = traveler.PhoneNumber
                    txtDOB.Text = traveler.DateOfBirth

                    txtSOSContact.Text = traveler.EmergencyContactName
                    txtSOSNumber.Text = traveler.EmergencyContactPhone
                    txtMedicalNotes.Text = traveler.MedicalNotes
                    txtGeneralNotes.Text = traveler.Notes
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading traveler details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateTraveler_Click(sender As Object, e As EventArgs) Handles btnUpdateTraveler.Click
        Try
            If cbEditTraveler.SelectedItem IsNot Nothing Then
                Dim selectedTravelerName As String = cbEditTraveler.SelectedItem.ToString()

                Dim dbHelper As New DatabaseHelper()
                dbHelper.UpdateTraveler(
                    selectedTravelerName,
                    txtNickName.Text.Trim(),
                    txtPassport.Text.Trim(),
                    txtKnownTravelerNumber.Text.Trim(),
                    txtFrequentFlyer.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtCity.Text.Trim(),
                    txtState.Text.Trim(),
                    txtZip.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtDOB.Text.Trim(),
                    txtSOSContact.Text.Trim(),
                    txtSOSNumber.Text.Trim(),
                    txtMedicalNotes.Text.Trim(),
                    txtGeneralNotes.Text.Trim()
                )

                ' Refresh the traveler list in the combo box
                cbEditTraveler.DataSource = dbHelper.GetAllTravelerNames()
                cbEditTraveler.SelectedIndex = -1

                ' Clear the form fields
                txtNickName.Clear()
                txtPassport.Clear()
                txtKnownTravelerNumber.Clear()
                txtFrequentFlyer.Clear()
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
            Else
                MessageBox.Show("Please select a traveler to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error updating traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class