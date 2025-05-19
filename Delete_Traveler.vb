Public Class Delete_Traveler
    Private Sub Delete_Traveler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dbHelper As New DatabaseHelper()
            Dim travelerNames = dbHelper.GetAllTravelerNames()

            If travelerNames.Count > 0 Then
                cbTravelers.DataSource = travelerNames
            Else
                MessageBox.Show("No travelers found in the database.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading travelers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteTraveler_Click(sender As Object, e As EventArgs) Handles btnDeleteTraveler.Click
        Try
            If cbTravelers.SelectedItem IsNot Nothing Then
                Dim selectedTraveler As String = cbTravelers.SelectedItem.ToString()

                ' Confirm before deleting
                Dim confirmResult = MessageBox.Show($"Are you sure you want to delete '{selectedTraveler}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If confirmResult = DialogResult.Yes Then
                    Dim dbHelper As New DatabaseHelper()
                    dbHelper.DeleteTravelerByName(selectedTraveler)

                    ' Refresh the traveler list
                    Dim travelerNames = dbHelper.GetAllTravelerNames()
                    cbTravelers.DataSource = travelerNames

                    ' Clear the selection
                    cbTravelers.SelectedIndex = -1
                End If
            Else
                MessageBox.Show("Please select a traveler to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error deleting traveler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class