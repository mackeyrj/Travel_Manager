<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditTrip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cbTripName = New ComboBox()
        btnEdit = New Button()
        txtTripDate = New TextBox()
        txtTripDestination = New TextBox()
        txtTripDetails = New TextBox()
        jlblTripName = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnCancel = New Button()
        btnDeleteTrip = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' cbTripName
        ' 
        cbTripName.FormattingEnabled = True
        cbTripName.Location = New Point(162, 64)
        cbTripName.Margin = New Padding(2)
        cbTripName.Name = "cbTripName"
        cbTripName.Size = New Size(358, 33)
        cbTripName.TabIndex = 0
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(56, 404)
        btnEdit.Margin = New Padding(2)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(111, 35)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' txtTripDate
        ' 
        txtTripDate.Location = New Point(162, 140)
        txtTripDate.Margin = New Padding(2)
        txtTripDate.Name = "txtTripDate"
        txtTripDate.Size = New Size(358, 31)
        txtTripDate.TabIndex = 3
        ' 
        ' txtTripDestination
        ' 
        txtTripDestination.Location = New Point(162, 212)
        txtTripDestination.Margin = New Padding(2)
        txtTripDestination.Name = "txtTripDestination"
        txtTripDestination.Size = New Size(358, 31)
        txtTripDestination.TabIndex = 4
        ' 
        ' txtTripDetails
        ' 
        txtTripDetails.Location = New Point(162, 283)
        txtTripDetails.Margin = New Padding(2)
        txtTripDetails.Multiline = True
        txtTripDetails.Name = "txtTripDetails"
        txtTripDetails.Size = New Size(358, 96)
        txtTripDetails.TabIndex = 5
        ' 
        ' jlblTripName
        ' 
        jlblTripName.AutoSize = True
        jlblTripName.Location = New Point(62, 69)
        jlblTripName.Margin = New Padding(2, 0, 2, 0)
        jlblTripName.Name = "jlblTripName"
        jlblTripName.Size = New Size(59, 25)
        jlblTripName.TabIndex = 6
        jlblTripName.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 143)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 25)
        Label2.TabIndex = 7
        Label2.Text = "Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 215)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 25)
        Label3.TabIndex = 8
        Label3.Text = "Destination"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(56, 283)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 25)
        Label4.TabIndex = 9
        Label4.Text = "Details"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(225, 404)
        btnCancel.Margin = New Padding(2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(111, 35)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Close"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteTrip
        ' 
        btnDeleteTrip.Location = New Point(430, 413)
        btnDeleteTrip.Margin = New Padding(2)
        btnDeleteTrip.Name = "btnDeleteTrip"
        btnDeleteTrip.Size = New Size(111, 35)
        btnDeleteTrip.TabIndex = 11
        btnDeleteTrip.Text = "Delete"
        btnDeleteTrip.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(808, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 12
        ' 
        ' frmEditTrip
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1452, 480)
        Controls.Add(TextBox1)
        Controls.Add(btnDeleteTrip)
        Controls.Add(btnCancel)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(jlblTripName)
        Controls.Add(txtTripDetails)
        Controls.Add(txtTripDestination)
        Controls.Add(txtTripDate)
        Controls.Add(btnEdit)
        Controls.Add(cbTripName)
        Margin = New Padding(2)
        Name = "frmEditTrip"
        Text = "Edit Trip"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbTripName As ComboBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtTripDate As TextBox
    Friend WithEvents txtTripDestination As TextBox
    Friend WithEvents txtTripDetails As TextBox
    Friend WithEvents jlblTripName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDeleteTrip As Button
    Friend WithEvents TextBox1 As TextBox
End Class
