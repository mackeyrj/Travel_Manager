Imports System.Linq

Public Class TripExpenseHelper

    Public Shared Sub InitializeTripExpenseForm(
        tripName As String,
        lblTripName As Label,
        rbtTraveler1 As RadioButton,
        rbtTraveler2 As RadioButton,
        rbtUSCurrency As RadioButton,
        rbtForeignCurrency As RadioButton,
        txtLocation As TextBox,
        cbRecipient As ComboBox,
        cbMerchantDetail As ComboBox,
        txtDescription As TextBox,
        txtAmount As TextBox,
        lblBCUSCashTraveler1 As Label,
lblBCUSCashTraveler2 As Label,
        lblBCForeignCashTraveler1 As Label,
        lblBCForeignCashTraveler2 As Label,
        lblCCUSCashTraveler1 As Label,
        lblCCUSCashTraveler2 As Label,
        lblCCForeignCashTraveler1 As Label,
        lblCCForeignCashTraveler2 As Label,
        lblBeginUSTraveler1 As Label,
        lblBeginUSTraveler2 As Label,
        lblBeginFrnTraveler1 As Label,
        lblBeginFrnTraveler2 As Label,
        lblCurrentUSraveler1 As Label,
        lblCurrentUSTraveler2 As Label,
        lblCurrentFRNTraveler1 As Label,
        lblCurrentFrnTraveler2 As Label
    )
        Using db As New TravelManagerContext()
            ' Step 1: Load trip and display name
            Dim trip = db.Trip.FirstOrDefault(Function(t) t.TripName = tripName)
            If trip Is Nothing Then
                MessageBox.Show("Trip not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            lblTripName.Text = trip.TripName

            ' Step 2: Load travelers from TripDetail and assign to radio buttons
            Dim tripDetails = db.TripDetail.Where(Function(td) td.TripID = trip.TripID).ToList()
            If tripDetails.Count < 2 Then
                MessageBox.Show("Trip must have at least two travelers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim traveler1 = db.Traveler.FirstOrDefault(Function(t) t.TravelerID = tripDetails(0).TravelerID)
            Dim traveler2 = db.Traveler.FirstOrDefault(Function(t) t.TravelerID = tripDetails(1).TravelerID)

            rbtTraveler1.Text = traveler1.Initials
            rbtTraveler2.Text = traveler2.Initials

            ' Step 3: Reset currency selection
            rbtUSCurrency.Checked = False
            rbtForeignCurrency.Checked = False

            ' Step 4: Clear location and expense input fields
            txtLocation.Clear()
            cbRecipient.SelectedIndex = -1
            cbMerchantDetail.SelectedIndex = -1
            txtDescription.Clear()
            txtAmount.Clear()

            ' Step 5: Set traveler initials to cash labels
            lblBCUSCashTraveler1.Text = traveler1.Initials
            lblBCForeignCashTraveler1.Text = traveler1.Initials
            lblBCUSCashTraveler2.Text = traveler2.Initials
            lblBCForeignCashTraveler2.Text = traveler2.Initials


            lblCCUSCashTraveler1.Text = traveler1.Initials
            lblCCUSCashTraveler2.Text = traveler2.Initials
            lblCCForeignCashTraveler1.Text = traveler1.Initials
            lblCCForeignCashTraveler2.Text = traveler2.Initials

            ' Step 6: Set all cash-related balance labels to 0
            lblBeginUSTraveler1.Text = "0"
            lblBeginUSTraveler2.Text = "0"
            lblBeginFrnTraveler1.Text = "0"
            lblBeginFrnTraveler2.Text = "0"
            lblCurrentUSraveler1.Text = "0"
            lblCurrentUSTraveler2.Text = "0"
            lblCurrentFRNTraveler1.Text = "0"
            lblCurrentFrnTraveler2.Text = "0"
        End Using
    End Sub

End Class

