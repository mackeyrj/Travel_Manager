<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Traveler_Info
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
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtNickName = New TextBox()
        txtPassport = New TextBox()
        txtFrequentFlyer = New TextBox()
        txtAddress = New TextBox()
        txtCity = New TextBox()
        txtState = New TextBox()
        txtZip = New TextBox()
        txtPhone = New TextBox()
        txtSOSContact = New TextBox()
        txtSOSNumber = New TextBox()
        txtMedicalNotes = New TextBox()
        txtGeneralNotes = New TextBox()
        btnCreateTraveler = New Button()
        btnClose = New Button()
        txtKnownTravelerNumber = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        txtDOB = New MaskedTextBox()
        Label16 = New Label()
        Label17 = New Label()
        txtAirline = New TextBox()
        lblAddFFInfo = New Label()
        ToolTip1 = New ToolTip(components)
        btnSaveTraveler = New Button()
        btnUpdateTraveler = New Button()
        btnFindRecord = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(466, 138)
        txtName.Name = "txtName"
        txtName.Size = New Size(438, 47)
        txtName.TabIndex = 0
        ToolTip1.SetToolTip(txtName, "Name")
        ' 
        ' txtNickName
        ' 
        txtNickName.Location = New Point(466, 208)
        txtNickName.Name = "txtNickName"
        txtNickName.Size = New Size(438, 47)
        txtNickName.TabIndex = 1
        ToolTip1.SetToolTip(txtNickName, "Use 3 initials")
        ' 
        ' txtPassport
        ' 
        txtPassport.Location = New Point(466, 289)
        txtPassport.Name = "txtPassport"
        txtPassport.Size = New Size(438, 47)
        txtPassport.TabIndex = 2
        ' 
        ' txtFrequentFlyer
        ' 
        txtFrequentFlyer.Location = New Point(466, 436)
        txtFrequentFlyer.Multiline = True
        txtFrequentFlyer.Name = "txtFrequentFlyer"
        txtFrequentFlyer.Size = New Size(438, 47)
        txtFrequentFlyer.TabIndex = 3
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(469, 607)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(438, 47)
        txtAddress.TabIndex = 4
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(469, 666)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(438, 47)
        txtCity.TabIndex = 5
        ' 
        ' txtState
        ' 
        txtState.Location = New Point(469, 735)
        txtState.Name = "txtState"
        txtState.Size = New Size(438, 47)
        txtState.TabIndex = 6
        ' 
        ' txtZip
        ' 
        txtZip.Location = New Point(469, 805)
        txtZip.Name = "txtZip"
        txtZip.Size = New Size(438, 47)
        txtZip.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(469, 891)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(438, 47)
        txtPhone.TabIndex = 8
        ' 
        ' txtSOSContact
        ' 
        txtSOSContact.Location = New Point(469, 1041)
        txtSOSContact.Name = "txtSOSContact"
        txtSOSContact.Size = New Size(438, 47)
        txtSOSContact.TabIndex = 10
        ' 
        ' txtSOSNumber
        ' 
        txtSOSNumber.Location = New Point(469, 1120)
        txtSOSNumber.Name = "txtSOSNumber"
        txtSOSNumber.Size = New Size(438, 47)
        txtSOSNumber.TabIndex = 11
        ' 
        ' txtMedicalNotes
        ' 
        txtMedicalNotes.Location = New Point(469, 1189)
        txtMedicalNotes.Name = "txtMedicalNotes"
        txtMedicalNotes.Size = New Size(438, 47)
        txtMedicalNotes.TabIndex = 12
        ' 
        ' txtGeneralNotes
        ' 
        txtGeneralNotes.Location = New Point(469, 1260)
        txtGeneralNotes.Name = "txtGeneralNotes"
        txtGeneralNotes.Size = New Size(438, 47)
        txtGeneralNotes.TabIndex = 13
        ' 
        ' btnCreateTraveler
        ' 
        btnCreateTraveler.Location = New Point(99, 1420)
        btnCreateTraveler.Name = "btnCreateTraveler"
        btnCreateTraveler.Size = New Size(320, 57)
        btnCreateTraveler.TabIndex = 14
        btnCreateTraveler.Text = "CreateTo Text"
        btnCreateTraveler.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(717, 1569)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(189, 57)
        btnClose.TabIndex = 15
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' txtKnownTravelerNumber
        ' 
        txtKnownTravelerNumber.Location = New Point(466, 520)
        txtKnownTravelerNumber.Name = "txtKnownTravelerNumber"
        txtKnownTravelerNumber.Size = New Size(438, 47)
        txtKnownTravelerNumber.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(316, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 41)
        Label1.TabIndex = 17
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(311, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 41)
        Label2.TabIndex = 18
        Label2.Text = "Initials"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(282, 276)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 41)
        Label3.TabIndex = 19
        Label3.Text = "Passport"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(78, 417)
        Label4.Name = "Label4"
        Label4.Size = New Size(338, 41)
        Label4.TabIndex = 20
        Label4.Text = "Frequent Flyer Numbers"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(82, 494)
        Label5.Name = "Label5"
        Label5.Size = New Size(335, 41)
        Label5.TabIndex = 21
        Label5.Text = "Known Traveler Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(291, 571)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 41)
        Label6.TabIndex = 22
        Label6.Text = "Address"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(347, 648)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 41)
        Label7.TabIndex = 23
        Label7.Text = "City"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(332, 725)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 41)
        Label8.TabIndex = 24
        Label8.Text = "State"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(277, 802)
        Label9.Name = "Label9"
        Label9.Size = New Size(139, 41)
        Label9.TabIndex = 25
        Label9.Text = "Zip Code"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(277, 879)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 41)
        Label10.TabIndex = 26
        Label10.Text = "Phone"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(337, 956)
        Label11.Name = "Label11"
        Label11.Size = New Size(79, 41)
        Label11.TabIndex = 27
        Label11.Text = "DOB"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(139, 1033)
        Label12.Name = "Label12"
        Label12.Size = New Size(276, 41)
        Label12.TabIndex = 28
        Label12.Text = "Emergency Contact"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(24, 1110)
        Label13.Name = "Label13"
        Label13.Size = New Size(393, 41)
        Label13.TabIndex = 29
        Label13.Text = "Emergency Contact Number"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(162, 1187)
        Label14.Name = "Label14"
        Label14.Size = New Size(254, 41)
        Label14.TabIndex = 30
        Label14.Text = "Medication Notes"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(209, 1264)
        Label15.Name = "Label15"
        Label15.Size = New Size(207, 41)
        Label15.TabIndex = 31
        Label15.Text = "General Notes"
        ' 
        ' txtDOB
        ' 
        txtDOB.Location = New Point(469, 964)
        txtDOB.Mask = "00/00/0000"
        txtDOB.Name = "txtDOB"
        txtDOB.Size = New Size(142, 47)
        txtDOB.TabIndex = 32
        txtDOB.ValidatingType = GetType(Date)
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label16.Location = New Point(201, 30)
        Label16.Name = "Label16"
        Label16.Size = New Size(534, 89)
        Label16.TabIndex = 33
        Label16.Text = "NEW TRAVELER"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(316, 358)
        Label17.Name = "Label17"
        Label17.Size = New Size(101, 41)
        Label17.TabIndex = 34
        Label17.Text = "Airline"
        ' 
        ' txtAirline
        ' 
        txtAirline.Location = New Point(466, 358)
        txtAirline.Name = "txtAirline"
        txtAirline.Size = New Size(438, 47)
        txtAirline.TabIndex = 35
        ' 
        ' lblAddFFInfo
        ' 
        lblAddFFInfo.Location = New Point(0, 0)
        lblAddFFInfo.Name = "lblAddFFInfo"
        lblAddFFInfo.Size = New Size(100, 23)
        lblAddFFInfo.TabIndex = 0
        ' 
        ' ToolTip1
        ' 
        ToolTip1.BackColor = SystemColors.Control
        ' 
        ' btnSaveTraveler
        ' 
        btnSaveTraveler.Location = New Point(139, 1351)
        btnSaveTraveler.Margin = New Padding(5, 5, 5, 5)
        btnSaveTraveler.Name = "btnSaveTraveler"
        btnSaveTraveler.Size = New Size(287, 56)
        btnSaveTraveler.TabIndex = 36
        btnSaveTraveler.Text = "Save To Database"
        btnSaveTraveler.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateTraveler
        ' 
        btnUpdateTraveler.Location = New Point(209, 1597)
        btnUpdateTraveler.Margin = New Padding(5, 5, 5, 5)
        btnUpdateTraveler.Name = "btnUpdateTraveler"
        btnUpdateTraveler.Size = New Size(190, 56)
        btnUpdateTraveler.TabIndex = 37
        btnUpdateTraveler.Text = "Update"
        btnUpdateTraveler.UseVisualStyleBackColor = True
        ' 
        ' btnFindRecord
        ' 
        btnFindRecord.Location = New Point(128, 1510)
        btnFindRecord.Margin = New Padding(5, 5, 5, 5)
        btnFindRecord.Name = "btnFindRecord"
        btnFindRecord.Size = New Size(289, 56)
        btnFindRecord.TabIndex = 38
        btnFindRecord.Text = "Find Record"
        btnFindRecord.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(668, 1351)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(241, 57)
        btnDelete.TabIndex = 39
        btnDelete.Text = "Delete Record"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Traveler_Info
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1470, 1712)
        Controls.Add(btnDelete)
        Controls.Add(btnFindRecord)
        Controls.Add(btnUpdateTraveler)
        Controls.Add(btnSaveTraveler)
        Controls.Add(lblAddFFInfo)
        Controls.Add(txtAirline)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(txtDOB)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtKnownTravelerNumber)
        Controls.Add(btnClose)
        Controls.Add(btnCreateTraveler)
        Controls.Add(txtGeneralNotes)
        Controls.Add(txtMedicalNotes)
        Controls.Add(txtSOSNumber)
        Controls.Add(txtSOSContact)
        Controls.Add(txtPhone)
        Controls.Add(txtZip)
        Controls.Add(txtState)
        Controls.Add(txtCity)
        Controls.Add(txtAddress)
        Controls.Add(txtFrequentFlyer)
        Controls.Add(txtPassport)
        Controls.Add(txtNickName)
        Controls.Add(txtName)
        Name = "Traveler_Info"
        Text = "Traveler_Info"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNickName As TextBox
    Friend WithEvents txtPassport As TextBox
    Friend WithEvents txtFrequentFlyer As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtSOSContact As TextBox
    Friend WithEvents txtSOSNumber As TextBox
    Friend WithEvents txtMedicalNotes As TextBox
    Friend WithEvents txtGeneralNotes As TextBox
    Friend WithEvents btnCreateTraveler As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtKnownTravelerNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDOB As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtAirline As TextBox
    Friend WithEvents lblAddFFInfo As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnSaveTraveler As Button
    Friend WithEvents btnUpdateTraveler As Button
    Friend WithEvents btnFindRecord As Button
    Friend WithEvents btnDelete As Button

End Class
