Public Class NotificationHelper
    Public Shared Sub ShowSuccess(message As String)
        MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub ShowError(message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Shared Sub ShowWarning(message As String)
        MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class

