<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewTrip
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtTripName = New TextBox()
        txtTripDate = New TextBox()
        txtTripDestination = New TextBox()
        txtTripDetails = New TextBox()
        cbTraveler1 = New ComboBox()
        cbTraveler2 = New ComboBox()
        btnCreateTrip = New Button()
        btnCancel = New Button()
        dgvTravelMethods = New DataGridView()
        cbTravelMethodType = New ComboBox()
        btnAddTravelMethod = New Button()
        MethodType = New DataGridViewTextBoxColumn()
        Carrier = New DataGridViewTextBoxColumn()
        DepartureLocation = New DataGridViewTextBoxColumn()
        ArrivalLocation = New DataGridViewTextBoxColumn()
        DepartureTime = New DataGridViewTextBoxColumn()
        ArrivalTime = New DataGridViewTextBoxColumn()
        DepartureDate = New DataGridViewTextBoxColumn()
        ArrivalDate = New DataGridViewTextBoxColumn()
        Notes = New DataGridViewTextBoxColumn()
        CType(dgvTravelMethods, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(95, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 41)
        Label1.TabIndex = 0
        Label1.Text = "Trip Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(112, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 41)
        Label2.TabIndex = 1
        Label2.Text = "Trip Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 311)
        Label3.Name = "Label3"
        Label3.Size = New Size(225, 41)
        Label3.TabIndex = 2
        Label3.Text = "Trip Destination"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(105, 412)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 41)
        Label4.TabIndex = 3
        Label4.Text = "Traveler 1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(105, 503)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 41)
        Label5.TabIndex = 4
        Label5.Text = "Traveler 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(85, 594)
        Label6.Name = "Label6"
        Label6.Size = New Size(163, 41)
        Label6.TabIndex = 5
        Label6.Text = "Trip Details"
        ' 
        ' txtTripName
        ' 
        txtTripName.Location = New Point(290, 146)
        txtTripName.Name = "txtTripName"
        txtTripName.Size = New Size(250, 47)
        txtTripName.TabIndex = 6
        ' 
        ' txtTripDate
        ' 
        txtTripDate.Location = New Point(290, 220)
        txtTripDate.Name = "txtTripDate"
        txtTripDate.Size = New Size(250, 47)
        txtTripDate.TabIndex = 7
        ' 
        ' txtTripDestination
        ' 
        txtTripDestination.Location = New Point(290, 305)
        txtTripDestination.Name = "txtTripDestination"
        txtTripDestination.Size = New Size(250, 47)
        txtTripDestination.TabIndex = 8
        ' 
        ' txtTripDetails
        ' 
        txtTripDetails.Location = New Point(290, 588)
        txtTripDetails.Name = "txtTripDetails"
        txtTripDetails.Size = New Size(250, 47)
        txtTripDetails.TabIndex = 9
        ' 
        ' cbTraveler1
        ' 
        cbTraveler1.FormattingEnabled = True
        cbTraveler1.Location = New Point(290, 395)
        cbTraveler1.Name = "cbTraveler1"
        cbTraveler1.Size = New Size(302, 49)
        cbTraveler1.TabIndex = 10
        ' 
        ' cbTraveler2
        ' 
        cbTraveler2.FormattingEnabled = True
        cbTraveler2.Location = New Point(290, 495)
        cbTraveler2.Name = "cbTraveler2"
        cbTraveler2.Size = New Size(302, 49)
        cbTraveler2.TabIndex = 11
        ' 
        ' btnCreateTrip
        ' 
        btnCreateTrip.Location = New Point(46, 903)
        btnCreateTrip.Name = "btnCreateTrip"
        btnCreateTrip.Size = New Size(188, 58)
        btnCreateTrip.TabIndex = 12
        btnCreateTrip.Text = "Create Trip"
        btnCreateTrip.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(329, 903)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(188, 58)
        btnCancel.TabIndex = 13
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' dgvTravelMethods
        ' 
        dgvTravelMethods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTravelMethods.Columns.AddRange(New DataGridViewColumn() {MethodType, Carrier, DepartureLocation, ArrivalLocation, DepartureTime, ArrivalTime, DepartureDate, ArrivalDate, Notes})
        dgvTravelMethods.Location = New Point(611, 289)
        dgvTravelMethods.Name = "dgvTravelMethods"
        dgvTravelMethods.RowHeadersWidth = 102
        dgvTravelMethods.Size = New Size(2373, 375)
        dgvTravelMethods.TabIndex = 20
        ' 
        ' cbTravelMethodType
        ' 
        cbTravelMethodType.FormattingEnabled = True
        cbTravelMethodType.Location = New Point(1150, 147)
        cbTravelMethodType.Name = "cbTravelMethodType"
        cbTravelMethodType.Size = New Size(302, 49)
        cbTravelMethodType.TabIndex = 21
        ' 
        ' btnAddTravelMethod
        ' 
        btnAddTravelMethod.Location = New Point(1536, 153)
        btnAddTravelMethod.Name = "btnAddTravelMethod"
        btnAddTravelMethod.Size = New Size(188, 58)
        btnAddTravelMethod.TabIndex = 22
        btnAddTravelMethod.Text = "Add Travel Method"
        btnAddTravelMethod.UseVisualStyleBackColor = True
        ' 
        ' MethodType
        ' 
        MethodType.HeaderText = "Method Type"
        MethodType.MinimumWidth = 12
        MethodType.Name = "MethodType"
        MethodType.Width = 250
        ' 
        ' Carrier
        ' 
        Carrier.HeaderText = "Carrier"
        Carrier.MinimumWidth = 12
        Carrier.Name = "Carrier"
        Carrier.Width = 250
        ' 
        ' DepartureLocation
        ' 
        DepartureLocation.HeaderText = "Departure Location"
        DepartureLocation.MinimumWidth = 12
        DepartureLocation.Name = "DepartureLocation"
        DepartureLocation.Width = 250
        ' 
        ' ArrivalLocation
        ' 
        ArrivalLocation.HeaderText = "Arrival Location"
        ArrivalLocation.MinimumWidth = 12
        ArrivalLocation.Name = "ArrivalLocation"
        ArrivalLocation.Width = 250
        ' 
        ' DepartureTime
        ' 
        DepartureTime.HeaderText = "DepartureTime"
        DepartureTime.MinimumWidth = 12
        DepartureTime.Name = "DepartureTime"
        DepartureTime.Width = 250
        ' 
        ' ArrivalTime
        ' 
        ArrivalTime.HeaderText = "Arrival Time"
        ArrivalTime.MinimumWidth = 12
        ArrivalTime.Name = "ArrivalTime"
        ArrivalTime.Width = 250
        ' 
        ' DepartureDate
        ' 
        DepartureDate.HeaderText = "Departure Date"
        DepartureDate.MinimumWidth = 12
        DepartureDate.Name = "DepartureDate"
        DepartureDate.Width = 250
        ' 
        ' ArrivalDate
        ' 
        ArrivalDate.HeaderText = "Arrival Date"
        ArrivalDate.MinimumWidth = 12
        ArrivalDate.Name = "ArrivalDate"
        ArrivalDate.Width = 250
        ' 
        ' Notes
        ' 
        Notes.HeaderText = "Notes"
        Notes.MinimumWidth = 12
        Notes.Name = "Notes"
        Notes.Width = 250
        ' 
        ' frmNewTrip
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2971, 1531)
        Controls.Add(btnAddTravelMethod)
        Controls.Add(cbTravelMethodType)
        Controls.Add(dgvTravelMethods)
        Controls.Add(btnCancel)
        Controls.Add(btnCreateTrip)
        Controls.Add(cbTraveler2)
        Controls.Add(cbTraveler1)
        Controls.Add(txtTripDetails)
        Controls.Add(txtTripDestination)
        Controls.Add(txtTripDate)
        Controls.Add(txtTripName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmNewTrip"
        Text = "frmNewTrip"
        CType(dgvTravelMethods, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTripName As TextBox
    Friend WithEvents txtTripDate As TextBox
    Friend WithEvents txtTripDestination As TextBox
    Friend WithEvents txtTripDetails As TextBox
    Friend WithEvents cbTraveler1 As ComboBox
    Friend WithEvents cbTraveler2 As ComboBox
    Friend WithEvents btnCreateTrip As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkFlight As CheckBox
    Friend WithEvents chkCar As CheckBox
    Friend WithEvents chkTrain As CheckBox
    Friend WithEvents chkBus As CheckBox
    Friend WithEvents chkBoat As CheckBox
    Friend WithEvents chkOther As CheckBox
    Friend WithEvents dgvTravelMethods As DataGridView
    Friend WithEvents cbTravelMethodType As ComboBox
    Friend WithEvents dgvCar As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents dgvTrain As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents dgvBus As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents dgvOther As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents btnAddTravelMethod As Button
    Friend WithEvents MethodType As DataGridViewTextBoxColumn
    Friend WithEvents Carrier As DataGridViewTextBoxColumn
    Friend WithEvents DepartureLocation As DataGridViewTextBoxColumn
    Friend WithEvents ArrivalLocation As DataGridViewTextBoxColumn
    Friend WithEvents DepartureTime As DataGridViewTextBoxColumn
    Friend WithEvents ArrivalTime As DataGridViewTextBoxColumn
    Friend WithEvents DepartureDate As DataGridViewTextBoxColumn
    Friend WithEvents ArrivalDate As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
End Class
