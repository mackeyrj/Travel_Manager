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
        txtTraveler1 = New TextBox()
        txtTraveler1Init = New TextBox()
        lblTraveler1 = New Label()
        lblTraverl1Ininit = New Label()
        lblTraveler2Ininit = New Label()
        lblTraveler1Ininit = New Label()
        txtTraveler2Init = New TextBox()
        txtTraveler2 = New TextBox()
        SuspendLayout()
        ' 
        ' cbTripName
        ' 
        cbTripName.FormattingEnabled = True
        cbTripName.Location = New Point(275, 105)
        cbTripName.Name = "cbTripName"
        cbTripName.Size = New Size(606, 49)
        cbTripName.TabIndex = 0
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(95, 663)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(189, 57)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' txtTripDate
        ' 
        txtTripDate.Location = New Point(275, 230)
        txtTripDate.Name = "txtTripDate"
        txtTripDate.Size = New Size(606, 47)
        txtTripDate.TabIndex = 3
        ' 
        ' txtTripDestination
        ' 
        txtTripDestination.Location = New Point(275, 348)
        txtTripDestination.Name = "txtTripDestination"
        txtTripDestination.Size = New Size(606, 47)
        txtTripDestination.TabIndex = 4
        ' 
        ' txtTripDetails
        ' 
        txtTripDetails.Location = New Point(275, 464)
        txtTripDetails.Multiline = True
        txtTripDetails.Name = "txtTripDetails"
        txtTripDetails.Size = New Size(606, 155)
        txtTripDetails.TabIndex = 5
        ' 
        ' jlblTripName
        ' 
        jlblTripName.AutoSize = True
        jlblTripName.Location = New Point(105, 113)
        jlblTripName.Name = "jlblTripName"
        jlblTripName.Size = New Size(97, 41)
        jlblTripName.TabIndex = 6
        jlblTripName.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(122, 235)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 41)
        Label2.TabIndex = 7
        Label2.Text = "Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 353)
        Label3.Name = "Label3"
        Label3.Size = New Size(169, 41)
        Label3.TabIndex = 8
        Label3.Text = "Destination"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(95, 464)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 41)
        Label4.TabIndex = 9
        Label4.Text = "Details"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(382, 663)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(189, 57)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Close"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteTrip
        ' 
        btnDeleteTrip.Location = New Point(731, 677)
        btnDeleteTrip.Name = "btnDeleteTrip"
        btnDeleteTrip.Size = New Size(189, 57)
        btnDeleteTrip.TabIndex = 11
        btnDeleteTrip.Text = "Delete"
        btnDeleteTrip.UseVisualStyleBackColor = True
        ' 
        ' txtTraveler1
        ' 
        txtTraveler1.Location = New Point(1287, 207)
        txtTraveler1.Margin = New Padding(5)
        txtTraveler1.Name = "txtTraveler1"
        txtTraveler1.Size = New Size(252, 47)
        txtTraveler1.TabIndex = 12
        ' 
        ' txtTraveler1Init
        ' 
        txtTraveler1Init.Location = New Point(1287, 431)
        txtTraveler1Init.Margin = New Padding(5)
        txtTraveler1Init.Name = "txtTraveler1Init"
        txtTraveler1Init.Size = New Size(252, 47)
        txtTraveler1Init.TabIndex = 13
        ' 
        ' lblTraveler1
        ' 
        lblTraveler1.AutoSize = True
        lblTraveler1.Location = New Point(1340, 128)
        lblTraveler1.Margin = New Padding(5, 0, 5, 0)
        lblTraveler1.Name = "lblTraveler1"
        lblTraveler1.Size = New Size(143, 41)
        lblTraveler1.TabIndex = 14
        lblTraveler1.Text = "Traveler 1"
        ' 
        ' lblTraverl1Ininit
        ' 
        lblTraverl1Ininit.AutoSize = True
        lblTraverl1Ininit.Location = New Point(1304, 358)
        lblTraverl1Ininit.Margin = New Padding(5, 0, 5, 0)
        lblTraverl1Ininit.Name = "lblTraverl1Ininit"
        lblTraverl1Ininit.Size = New Size(102, 41)
        lblTraverl1Ininit.TabIndex = 15
        lblTraverl1Ininit.Text = "Initials"
        ' 
        ' lblTraveler2Ininit
        ' 
        lblTraveler2Ininit.AutoSize = True
        lblTraveler2Ininit.Location = New Point(1640, 343)
        lblTraveler2Ininit.Margin = New Padding(5, 0, 5, 0)
        lblTraveler2Ininit.Name = "lblTraveler2Ininit"
        lblTraveler2Ininit.Size = New Size(102, 41)
        lblTraveler2Ininit.TabIndex = 19
        lblTraveler2Ininit.Text = "Initials"
        ' 
        ' lblTraveler1Ininit
        ' 
        lblTraveler1Ininit.AutoSize = True
        lblTraveler1Ininit.Location = New Point(1676, 113)
        lblTraveler1Ininit.Margin = New Padding(5, 0, 5, 0)
        lblTraveler1Ininit.Name = "lblTraveler1Ininit"
        lblTraveler1Ininit.Size = New Size(143, 41)
        lblTraveler1Ininit.TabIndex = 18
        lblTraveler1Ininit.Text = "Traveler 2"
        ' 
        ' txtTraveler2Init
        ' 
        txtTraveler2Init.Location = New Point(1624, 417)
        txtTraveler2Init.Margin = New Padding(5)
        txtTraveler2Init.Name = "txtTraveler2Init"
        txtTraveler2Init.Size = New Size(252, 47)
        txtTraveler2Init.TabIndex = 17
        ' 
        ' txtTraveler2
        ' 
        txtTraveler2.Location = New Point(1624, 192)
        txtTraveler2.Margin = New Padding(5)
        txtTraveler2.Name = "txtTraveler2"
        txtTraveler2.Size = New Size(252, 47)
        txtTraveler2.TabIndex = 16
        ' 
        ' frmEditTrip
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2468, 787)
        Controls.Add(lblTraveler2Ininit)
        Controls.Add(lblTraveler1Ininit)
        Controls.Add(txtTraveler2Init)
        Controls.Add(txtTraveler2)
        Controls.Add(lblTraverl1Ininit)
        Controls.Add(lblTraveler1)
        Controls.Add(txtTraveler1Init)
        Controls.Add(txtTraveler1)
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
    Friend WithEvents txtTraveler1 As TextBox
    Friend WithEvents txtTraveler1Init As TextBox
    Friend WithEvents lblTraveler1 As Label
    Friend WithEvents lblTraverl1Ininit As Label
    Friend WithEvents lblTraveler2Ininit As Label
    Friend WithEvents lblTraveler1Ininit As Label
    Friend WithEvents txtTraveler2Init As TextBox
    Friend WithEvents txtTraveler2 As TextBox
End Class
