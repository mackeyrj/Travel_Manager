Public Class frmEditTrip

    Private selectedTripID As Integer = -1

    Private Sub frmEditTrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New TravelManagerContext()
            Dim trips = db.Trip.OrderBy(Function(t) t.TripName).ToList()
            cbTripName.DataSource = trips
            cbTripName.DisplayMember = "TripName"
            cbTripName.ValueMember = "TripID"
            cbTripName.SelectedIndex = -1
        End Using

        ' Clear all input fields
        txtTripDate.Clear()
        txtTripDestination.Clear()
        txtTripDetails.Clear()
        txtTraveler1.Clear()
        txtTraveler1Init.Clear()
        txtTraveler2.Clear()
        txtTraveler2Init.Clear()
    End Sub
    Private Sub cbTripName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTripName.SelectedIndexChanged
        If cbTripName.SelectedIndex = -1 Then Exit Sub

        Dim selectedTrip = TryCast(cbTripName.SelectedItem, Trip)
        If selectedTrip Is Nothing Then Exit Sub

        txtTripDate.Text = selectedTrip.TripDate
        txtTripDestination.Text = selectedTrip.TripDestination
        txtTripDetails.Text = selectedTrip.TripDetails

        Using db As New TravelManagerContext()
            Dim details = db.TripDetail.Where(Function(td) td.TripID = selectedTrip.TripID).ToList()
            If details.Count >= 2 Then
                Dim traveler1 = db.Traveler.FirstOrDefault(Function(t) t.TravelerID = details(0).TravelerID)
                Dim traveler2 = db.Traveler.FirstOrDefault(Function(t) t.TravelerID = details(1).TravelerID)

                If traveler1 IsNot Nothing Then
                    txtTraveler1.Text = traveler1.Name
                    txtTraveler1Init.Text = traveler1.Initials
                End If

                If traveler2 IsNot Nothing Then
                    txtTraveler2.Text = traveler2.Name
                    txtTraveler2Init.Text = traveler2.Initials
                End If
            End If
        End Using
    End Sub




    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If cbTripName.SelectedIndex = -1 Then
            MessageBox.Show("Please select a trip to edit.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim selectedTrip = TryCast(cbTripName.SelectedItem, Trip)
            If selectedTrip Is Nothing Then Return

            Using db As New TravelManagerContext()
                Dim trip = db.Trip.FirstOrDefault(Function(t) t.TripID = selectedTrip.TripID)
                If trip IsNot Nothing Then
                    trip.TripName = cbTripName.Text.Trim()
                    trip.TripDate = txtTripDate.Text.Trim()
                    trip.TripDestination = txtTripDestination.Text.Trim()
                    trip.TripDetails = txtTripDetails.Text.Trim()

                    Dim details = db.TripDetail.Where(Function(td) td.TripID = trip.TripID).ToList()
                    If details.Count >= 2 Then
                        Dim traveler1Name = txtTraveler1.Text.Trim()
                        Dim traveler2Name = txtTraveler2.Text.Trim()

                        Dim traveler1 = db.Traveler.FirstOrDefault(Function(t) t.Name = traveler1Name)
                        Dim traveler2 = db.Traveler.FirstOrDefault(Function(t) t.Name = traveler2Name)

                        If traveler1 IsNot Nothing Then
                            details(0).TravelerID = traveler1.TravelerID
                        End If

                        If traveler2 IsNot Nothing Then
                            details(1).TravelerID = traveler2.TravelerID
                        End If
                    End If

                    db.SaveChanges()
                    MessageBox.Show("Trip updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End Using

        Catch ex As Exception
            Dim msg = $"An error occurred while updating the trip: {ex.Message}"
            If ex.InnerException IsNot Nothing Then msg &= vbCrLf & ex.InnerException.Message
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim confirm = MessageBox.Show(
            "Are you sure you want to cancel? Any unsaved changes will be lost.",
            "Confirm Cancel",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirm = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnDeleteTrip_Click(sender As Object, e As EventArgs) Handles btnDeleteTrip.Click
        If selectedTripID = -1 Then
            MessageBox.Show("Please select a trip to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm = MessageBox.Show(
            "Are you sure you want to delete this trip? This action cannot be undone.",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirm = DialogResult.No Then Return

        Try
            Using db As New TravelManagerContext()
                Dim trip = db.Trip.FirstOrDefault(Function(t) t.TripID = selectedTripID)
                If trip IsNot Nothing Then
                    db.Trip.Remove(trip)
                    db.SaveChanges()
                    MessageBox.Show("Trip deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Trip not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error deleting trip: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class