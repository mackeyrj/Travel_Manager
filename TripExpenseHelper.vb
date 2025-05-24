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
        lblCurrentUSTraveler1 As Label,
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

            ' Step 5 & 6: Setup label structures and reset them
            Dim traveler1Labels As New TravelerCashLabels With {
                .BeginUS = lblBeginUSTraveler1,
                .BeginFrn = lblBeginFrnTraveler1,
                .CurrentUS = lblCurrentUSTraveler1,
                .CurrentFrn = lblCurrentFRNTraveler1,
                .BCUSCash = lblBCUSCashTraveler1,
                .BCForeignCash = lblBCForeignCashTraveler1,
                .CCUSCash = lblCCUSCashTraveler1,
                .CCForeignCash = lblCCForeignCashTraveler1
            }

            Dim traveler2Labels As New TravelerCashLabels With {
                .BeginUS = lblBeginUSTraveler2,
                .BeginFrn = lblBeginFrnTraveler2,
                .CurrentUS = lblCurrentUSTraveler2,
                .CurrentFrn = lblCurrentFrnTraveler2,
                .BCUSCash = lblBCUSCashTraveler2,
                .BCForeignCash = lblBCForeignCashTraveler2,
                .CCUSCash = lblCCUSCashTraveler2,
                .CCForeignCash = lblCCForeignCashTraveler2
            }

            ' Set initials to header labels
            traveler1Labels.BCUSCash.Text = traveler1.Initials
            traveler1Labels.BCForeignCash.Text = traveler1.Initials
            traveler1Labels.CCUSCash.Text = traveler1.Initials
            traveler1Labels.CCForeignCash.Text = traveler1.Initials

            traveler2Labels.BCUSCash.Text = traveler2.Initials
            traveler2Labels.BCForeignCash.Text = traveler2.Initials
            traveler2Labels.CCUSCash.Text = traveler2.Initials
            traveler2Labels.CCForeignCash.Text = traveler2.Initials

            ' Reset all numeric labels to "0"
            ResetTravelerCashLabels(traveler1Labels)
            ResetTravelerCashLabels(traveler2Labels)
        End Using
    End Sub

End Class
