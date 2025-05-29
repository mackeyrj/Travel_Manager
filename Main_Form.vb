

Public Class Main_Form


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnTrackExpenses.Click
        frmExpense.Show()
    End Sub

    Private Sub NewTripToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewTripToolStripMenuItem1.Click
        frmNewTrip.Show()
    End Sub

    Private Sub btnCreateTrip_Click(sender As Object, e As EventArgs) Handles btnCreateTrip.Click
        frmNewTrip.Show()
    End Sub

    Private Sub LoadTripToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoadTripToolStripMenuItem1.Click
        frmExpense.Show()
    End Sub
End Class
