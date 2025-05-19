Public Class FormHelper
    Public Shared Sub ResetTransactionFields(txtLocation As TextBox, txtDescription As TextBox, txtAmount As TextBox, cbRecipient As ComboBox, cbMerchantDetail As ComboBox, rbtTraveler1 As RadioButton, rbtTraveler2 As RadioButton, rbtUSCurrency As RadioButton, rbtForeignCurrency As RadioButton, dtpDatePicker As DateTimePicker)
        ' Clear text fields
        txtLocation.Clear()
        txtDescription.Clear()
        txtAmount.Clear()

        ' Reset combo boxes
        cbRecipient.SelectedIndex = -1
        cbMerchantDetail.SelectedIndex = -1
        cbMerchantDetail.Visible = False

        ' Reset radio buttons
        rbtTraveler1.Checked = False
        rbtTraveler2.Checked = False
        rbtUSCurrency.Checked = False
        rbtForeignCurrency.Checked = False

        ' Reset date picker to today
        dtpDatePicker.Value = DateTime.Now
    End Sub
End Class

