Public Class frmNewTrip
    Private Sub frmNewTrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Populate the travel method type combo box
        cbTravelMethodType.Items.AddRange(New String() {"Flight", "Car", "Train", "Bus", "Boat", "Other"})
        cbTravelMethodType.SelectedIndex = 0



        ' Hide the MethodType column (optional)
        dgvTravelMethods.Columns("MethodType").Visible = False




        Try
            Dim dbHelper As New DatabaseHelper()
            Dim travelerNames = dbHelper.GetAllTravelerNames()

            If travelerNames.Count > 0 Then
                cbTraveler1.DataSource = New List(Of String)(travelerNames)
                cbTraveler2.DataSource = New List(Of String)(travelerNames)
                cbTraveler1.SelectedIndex = -1
                cbTraveler2.SelectedIndex = -1
            Else
                MessageBox.Show("No travelers found in the database. Please add travelers first.", "No Travelers", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading travelers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCreateTrip_Click(sender As Object, e As EventArgs) Handles btnCreateTrip.Click

        Main_Form.lblTripName.Text = txtTripName.Text.Trim()

        Try
            ' Validate inputs
            If String.IsNullOrWhiteSpace(txtTripName.Text) OrElse
               String.IsNullOrWhiteSpace(txtTripDate.Text) OrElse
               String.IsNullOrWhiteSpace(txtTripDestination.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim dbHelper As New DatabaseHelper()
            Dim trip As New Trip() With {
                .TripName = txtTripName.Text.Trim(),
                .TripDate = txtTripDate.Text.Trim(),
                .TripDestination = txtTripDestination.Text.Trim(),
                .TripDetails = txtTripDetails.Text.Trim()
            }

            ' Save the new trip
            dbHelper.AddTrip(trip)

            ' Save all travel methods
            SaveTravelMethods(dbHelper, trip.TripID)

            ' Link the selected travelers to the trip
            If cbTraveler1.SelectedItem IsNot Nothing Then
                dbHelper.AddTravelerToTrip(trip.TripID, cbTraveler1.SelectedItem.ToString(), "Primary")
            End If

            If cbTraveler2.SelectedItem IsNot Nothing Then
                dbHelper.AddTravelerToTrip(trip.TripID, cbTraveler2.SelectedItem.ToString(), "Secondary")
            End If

            MessageBox.Show($"Trip '{trip.TripName}' created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show($"Error creating trip: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnAddTravelMethod_Click(sender As Object, e As EventArgs) Handles btnAddTravelMethod.Click
        If cbTravelMethodType.SelectedItem IsNot Nothing Then
            dgvTravelMethods.Rows.Add(
                cbTravelMethodType.SelectedItem.ToString(),
                "", "", "", "", "", ""
            )
        End If
    End Sub
    ' In frmNewTrip

    Private Sub SaveTravelMethods(dbHelper As DatabaseHelper, tripID As Integer)
        For Each row As DataGridViewRow In dgvTravelMethods.Rows
            ' Skip empty rows
            If row.IsNewRow Then Continue For

            ' Extract travel method data
            Dim methodType As String = If(row.Cells("MethodType").Value IsNot Nothing, row.Cells("MethodType").Value.ToString().Trim(), "")
            Dim carrier As String = If(row.Cells("Carrier").Value IsNot Nothing, row.Cells("Carrier").Value.ToString().Trim(), "")
            Dim departureLocation As String = If(row.Cells("DepartureLocation").Value IsNot Nothing, row.Cells("DepartureLocation").Value.ToString().Trim(), "")
            Dim arrivalLocation As String = If(row.Cells("ArrivalLocation").Value IsNot Nothing, row.Cells("ArrivalLocation").Value.ToString().Trim(), "")
            Dim departureDate As String = If(row.Cells("DepartureDate").Value IsNot Nothing, row.Cells("DepartureDate").Value.ToString().Trim(), "")
            Dim departureTime As String = If(row.Cells("DepartureTime").Value IsNot Nothing, row.Cells("DepartureTime").Value.ToString().Trim(), "")
            Dim arrivalDate As String = If(row.Cells("ArrivalDate").Value IsNot Nothing, row.Cells("ArrivalDate").Value.ToString().Trim(), "")
            Dim arrivalTime As String = If(row.Cells("ArrivalTime").Value IsNot Nothing, row.Cells("ArrivalTime").Value.ToString().Trim(), "")
            Dim notes As String = If(row.Cells("Notes").Value IsNot Nothing, row.Cells("Notes").Value.ToString().Trim(), "")

            ' Only save if at least one key field is filled
            If carrier <> "" OrElse departureLocation <> "" OrElse arrivalLocation <> "" Then
                dbHelper.AddTravelMethod(New TravelMethod() With {
                    .TripID = tripID,
                    .MethodType = methodType,
                    .Carrier = carrier,
                    .DepartureLocation = departureLocation,
                    .ArrivalLocation = arrivalLocation,
                    .DepartureDate = departureDate,
                    .DepartureTime = departureTime,
                    .ArrivalDate = arrivalDate,
                    .ArrivalTime = arrivalTime,
                    .Notes = notes
                })
            End If
        Next
    End Sub


End Class