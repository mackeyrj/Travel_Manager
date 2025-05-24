

Public Class Main_Form
    Private Sub TransportationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransportationToolStripMenuItem.Click
        Transportation.Show()
    End Sub



    Private Sub MS_File_Click(sender As Object, e As EventArgs) Handles MS_File.Click

    End Sub

    Private Sub MS_File_Open_Click(sender As Object, e As EventArgs) Handles MS_File_Open.Click

    End Sub

    Private fileHandler As New FileHandler()

    Private Sub MS_File_Open_Traveler1_Click(sender As Object, e As EventArgs) Handles MS_File_Open_Traveler1.Click
        fileHandler.OpenTravelerFile("Traveler1")
    End Sub

    Private Sub MS_File_Open_Traveler2_Click(sender As Object, e As EventArgs) Handles MS_File_Open_Traveler2.Click
        fileHandler.OpenTravelerFile("Traveler2")
    End Sub

    Private Sub MS_File_Print_Traveler1_Click(sender As Object, e As EventArgs) Handles MS_File_Print_Traveler1.Click
        fileHandler.PrintTravelerFile("Traveler1")
    End Sub

    Private Sub MS_File_Print_Traveler2_Click(sender As Object, e As EventArgs) Handles MS_File_Print_Traveler2.Click
        fileHandler.PrintTravelerFile("Traveler2")
    End Sub

    Private Sub MS_File_Close_Click(sender As Object, e As EventArgs) Handles MS_File_Close.Click
        fileHandler.CloseApplication()
    End Sub

    Private Sub cbRecipient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRecipient.SelectedIndexChanged
        ' Show or hide cbMerchantDetail based on the selected recipient
        If cbRecipient.SelectedItem IsNot Nothing AndAlso cbRecipient.SelectedItem.ToString() = "Merchant" Then
            cbMerchantDetail.Visible = True
        Else
            cbMerchantDetail.Visible = False
            cbMerchantDetail.SelectedIndex = -1 ' Clear selection if hiding
        End If
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            ' Determine the selected traveler
            ' Determine the selected traveler
            Dim travelerName As String
            If rbtTraveler1.Checked Then
                travelerName = rbtTraveler1.Text.Trim()
            ElseIf rbtTraveler2.Checked Then
                travelerName = rbtTraveler2.Text.Trim()
            Else
                NotificationHelper.ShowWarning("Please select a traveler.")
                Return
            End If


            ' Determine the selected currency
            Dim currency As String
            If rbtUSCurrency.Checked Then
                currency = "USD"
            ElseIf rbtForeignCurrency.Checked Then
                currency = "Foreign"
            Else
                NotificationHelper.ShowWarning("Please select a currency.")
                Return
            End If

            ' Collect other form inputs
            Dim transactionDate As DateTime = DTPDatePicker.Value
            Dim location As String = txtLocation.Text.Trim()

            ' Collect recipient
            If cbRecipient.SelectedItem Is Nothing Then
                NotificationHelper.ShowWarning("Please select a recipient.")
                Return
            End If

            Dim recipient As String = cbRecipient.SelectedItem.ToString()

            ' Only include merchant detail if "Merchant" is selected
            Dim merchantDetail As String = ""
            If recipient = "Merchant" Then
                If cbMerchantDetail.SelectedItem IsNot Nothing Then
                    merchantDetail = cbMerchantDetail.SelectedItem.ToString()
                Else
                    NotificationHelper.ShowWarning("Please select a merchant detail.")
                    Return
                End If
            End If

            ' Validate the amount input
            Dim amount As Decimal
            If Not Decimal.TryParse(txtAmount.Text.Trim(), amount) Then
                NotificationHelper.ShowWarning("Please enter a valid amount.")
                Return
            End If

            ' Prepare the description
            Dim description As String = txtDescription.Text.Trim()

            ' Get the trip name
            Dim tripName As String = lblTripName.Text.Trim()
            If String.IsNullOrEmpty(tripName) Then
                NotificationHelper.ShowWarning("Please enter a trip name.")
                Return
            End If

            ' Create an instance of the FileHandler class
            Dim fileHandler As New FileHandler()
            fileHandler.WriteTransaction(travelerName, transactionDate, currency, location, recipient, merchantDetail, description, amount, tripName)

            ' Reset the form using the helper method
            FormHelper.ResetTransactionFields(txtLocation, txtDescription, txtAmount, cbRecipient, cbMerchantDetail, rbtTraveler1, rbtTraveler2, rbtUSCurrency, rbtForeignCurrency, DTPDatePicker)

            NotificationHelper.ShowSuccess("Transaction saved successfully!")

        Catch ex As Exception
            NotificationHelper.ShowError($"An error occurred: {ex.Message}")
        End Try




    End Sub

    Private Sub AddTravelerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTravelerToolStripMenuItem.Click
        Traveler_Info.Show()
    End Sub

    Private Sub EditTravelerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditTravelerToolStripMenuItem.Click
        frmEdit_Traveler.Show()

    End Sub

    Private Sub DeleteTraverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteTraverToolStripMenuItem.Click
        Delete_Traveler.Show()
    End Sub

    Private Sub btnCreditTransaction_Click(sender As Object, e As EventArgs) Handles btnCreditTransaction.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim expense As New Expense With {
           .Merchant = If(cbMerchantDetail.Visible AndAlso cbMerchantDetail.SelectedItem IsNot Nothing AndAlso cbMerchantDetail.SelectedItem.ToString().Length > 0, cbMerchantDetail.SelectedItem.ToString(), "NA"),
            .Traveler = If(rbtTraveler1.Checked, rbtTraveler1.Text.Trim(), rbtTraveler2.Text.Trim()),
            .PurchaseDate = DTPDatePicker.Value.ToString("yyyy-MM-dd"),
            .Currency = If(rbtUSCurrency.Checked, "USD", "Foreign"),
            .Location = txtLocation.Text.Trim(),
            .Type = cbRecipient.SelectedItem.ToString(),
            .Description = txtDescription.Text.Trim(),
            .Amount = txtAmount.Text.Trim(),
            .TripName = lblTripName.Text.Trim()
        }
        Dim dbHelper As New DatabaseHelper()
        dbHelper.AddExpense(expense)
        MessageBox.Show(expense.Merchant, "Merchant", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub NewTripToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTripToolStripMenuItem.Click

    End Sub

    Private Sub LoadTripToolStripMenuItem1_DropDownOpening(sender As Object, e As EventArgs) Handles LoadTripToolStripMenuItem1.DropDownOpening
        LoadTripToolStripMenuItem1.DropDownItems.Clear()

        Using db As New TravelManagerContext()
            Dim trips = db.Trip.OrderBy(Function(t) t.TripDate).ToList()

            For Each trip In trips
                Dim item As New ToolStripMenuItem(trip.TripName)
                item.Tag = trip.TripID
                AddHandler item.Click, AddressOf TripMenuItem_Click
                LoadTripToolStripMenuItem1.DropDownItems.Add(item)
            Next
        End Using
    End Sub

    Private Sub TripMenuItem_Click(sender As Object, e As EventArgs)
        Using db As New TravelManagerContext()
            Dim tripNames = db.Trip.Select(Function(t) t.TripName).ToList()

            If tripNames.Count = 0 Then
                MessageBox.Show("No trips found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim list As String = String.Join(Environment.NewLine, tripNames)
            Dim input As String = InputBox("Available Trips:" & Environment.NewLine & list & vbNewLine & vbNewLine & "Enter the trip name exactly:", "Select Trip")

            If String.IsNullOrWhiteSpace(input) OrElse Not tripNames.Contains(input) Then
                MessageBox.Show("Invalid or missing trip name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Proceed with initializing the trip
            TripExpenseHelper.InitializeTripExpenseForm(
                input,
        lblTripName,
        rbtTraveler1,
        rbtTraveler2,
        rbtUSCurrency,
        rbtForeignCurrency,
        txtLocation,
        cbRecipient,
        cbMerchantDetail,
        txtDescription,
        txtAmount,
        lblBCUSCashTraveler1,
        lblBCUSCashTraveler2,
        lblBCForeignCashTraveler1,
        lblBCForeignCashTraveler2,
        lblCCUSCashTraveler1,
        lblCCUSCashTraveler2,
        lblCCForeignCashTraveler1,
        lblCCForeignCashTraveler2,
        lblBeginUSTraveler1,
        lblBeginUSTraveler2,
        lblBeginFrnrTaveler1,
        lblBeginFrnTraveler2,
        lblCurrentUSTraveler1,
        lblCurrentUSTraveler2,
        lblCurrentFRNTraveler1,
        lblCurrentFrnTraveler2
           )
        End Using
    End Sub

    Private Sub EditTripToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditTripToolStripMenuItem.Click
        frmEditTrip.Show()
    End Sub

    Private Sub NewTripToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewTripToolStripMenuItem1.Click
        frmNewTrip.Show()
    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadTripToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoadTripToolStripMenuItem1.Click

    End Sub


End Class
