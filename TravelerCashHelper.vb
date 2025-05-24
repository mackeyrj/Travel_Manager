' Module: TravelerCashHelper.vb

Public Module TravelerCashHelper

    ' A structure that holds all label controls for a traveler's balances
    Public Structure TravelerCashLabels
        Public BeginUS As Label
        Public BeginFrn As Label
        Public CurrentUS As Label
        Public CurrentFrn As Label
        Public BCUSCash As Label
        Public BCForeignCash As Label
        Public CCUSCash As Label
        Public CCForeignCash As Label
    End Structure

    ' Reset only numeric balance labels
    Public Sub ResetTravelerCashLabels(labels As TravelerCashLabels)
        For Each lbl In {
            labels.BeginUS,
            labels.BeginFrn,
            labels.CurrentUS,
            labels.CurrentFrn
        }
            If lbl IsNot Nothing Then
                lbl.Text = "0"
            End If
        Next
    End Sub


End Module

