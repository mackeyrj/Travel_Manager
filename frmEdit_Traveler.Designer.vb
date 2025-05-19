<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit_Traveler
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
        btnUpdateTraveler = New Button()
        txtAirline = New TextBox()
        Label17 = New Label()
        Label16 = New Label()
        txtDOB = New MaskedTextBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtKnownTravelerNumber = New TextBox()
        btnClose = New Button()
        txtGeneralNotes = New TextBox()
        txtMedicalNotes = New TextBox()
        txtSOSNumber = New TextBox()
        txtSOSContact = New TextBox()
        txtPhone = New TextBox()
        txtZip = New TextBox()
        txtState = New TextBox()
        txtCity = New TextBox()
        txtAddress = New TextBox()
        txtFrequentFlyer = New TextBox()
        txtPassport = New TextBox()
        txtNickName = New TextBox()
        cbEditTraveler = New ComboBox()
        SuspendLayout()
        ' 
        ' btnUpdateTraveler
        ' 
        btnUpdateTraveler.Location = New Point(561, 1394)
        btnUpdateTraveler.Margin = New Padding(5, 5, 5, 5)
        btnUpdateTraveler.Name = "btnUpdateTraveler"
        btnUpdateTraveler.Size = New Size(190, 56)
        btnUpdateTraveler.TabIndex = 76
        btnUpdateTraveler.Text = "Update"
        btnUpdateTraveler.UseVisualStyleBackColor = True
        ' 
        ' txtAirline
        ' 
        txtAirline.Location = New Point(680, 421)
        txtAirline.Name = "txtAirline"
        txtAirline.Size = New Size(438, 47)
        txtAirline.TabIndex = 74
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(530, 421)
        Label17.Name = "Label17"
        Label17.Size = New Size(101, 41)
        Label17.TabIndex = 73
        Label17.Text = "Airline"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label16.Location = New Point(415, 93)
        Label16.Name = "Label16"
        Label16.Size = New Size(540, 89)
        Label16.TabIndex = 72
        Label16.Text = "EDIT  TRAVELER"
        ' 
        ' txtDOB
        ' 
        txtDOB.Location = New Point(683, 1028)
        txtDOB.Mask = "00/00/0000"
        txtDOB.Name = "txtDOB"
        txtDOB.Size = New Size(142, 47)
        txtDOB.TabIndex = 71
        txtDOB.ValidatingType = GetType(Date)
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(423, 1328)
        Label15.Name = "Label15"
        Label15.Size = New Size(207, 41)
        Label15.TabIndex = 70
        Label15.Text = "General Notes"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(376, 1251)
        Label14.Name = "Label14"
        Label14.Size = New Size(254, 41)
        Label14.TabIndex = 69
        Label14.Text = "Medication Notes"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(238, 1174)
        Label13.Name = "Label13"
        Label13.Size = New Size(393, 41)
        Label13.TabIndex = 68
        Label13.Text = "Emergency Contact Number"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(354, 1097)
        Label12.Name = "Label12"
        Label12.Size = New Size(276, 41)
        Label12.TabIndex = 67
        Label12.Text = "Emergency Contact"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(551, 1020)
        Label11.Name = "Label11"
        Label11.Size = New Size(79, 41)
        Label11.TabIndex = 66
        Label11.Text = "DOB"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(491, 943)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 41)
        Label10.TabIndex = 65
        Label10.Text = "Phone"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(491, 866)
        Label9.Name = "Label9"
        Label9.Size = New Size(139, 41)
        Label9.TabIndex = 64
        Label9.Text = "Zip Code"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(546, 789)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 41)
        Label8.TabIndex = 63
        Label8.Text = "State"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(561, 712)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 41)
        Label7.TabIndex = 62
        Label7.Text = "City"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(505, 635)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 41)
        Label6.TabIndex = 61
        Label6.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(296, 558)
        Label5.Name = "Label5"
        Label5.Size = New Size(335, 41)
        Label5.TabIndex = 60
        Label5.Text = "Known Traveler Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(292, 481)
        Label4.Name = "Label4"
        Label4.Size = New Size(338, 41)
        Label4.TabIndex = 59
        Label4.Text = "Frequent Flyer Numbers"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(496, 339)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 41)
        Label3.TabIndex = 58
        Label3.Text = "Passport"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(525, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 41)
        Label2.TabIndex = 57
        Label2.Text = "Initials"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(530, 202)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 41)
        Label1.TabIndex = 56
        Label1.Text = "Name"
        ' 
        ' txtKnownTravelerNumber
        ' 
        txtKnownTravelerNumber.Location = New Point(680, 584)
        txtKnownTravelerNumber.Name = "txtKnownTravelerNumber"
        txtKnownTravelerNumber.Size = New Size(438, 47)
        txtKnownTravelerNumber.TabIndex = 55
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(806, 1484)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(189, 57)
        btnClose.TabIndex = 54
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' txtGeneralNotes
        ' 
        txtGeneralNotes.Location = New Point(683, 1323)
        txtGeneralNotes.Name = "txtGeneralNotes"
        txtGeneralNotes.Size = New Size(438, 47)
        txtGeneralNotes.TabIndex = 52
        ' 
        ' txtMedicalNotes
        ' 
        txtMedicalNotes.Location = New Point(683, 1253)
        txtMedicalNotes.Name = "txtMedicalNotes"
        txtMedicalNotes.Size = New Size(438, 47)
        txtMedicalNotes.TabIndex = 51
        ' 
        ' txtSOSNumber
        ' 
        txtSOSNumber.Location = New Point(683, 1184)
        txtSOSNumber.Name = "txtSOSNumber"
        txtSOSNumber.Size = New Size(438, 47)
        txtSOSNumber.TabIndex = 50
        ' 
        ' txtSOSContact
        ' 
        txtSOSContact.Location = New Point(683, 1105)
        txtSOSContact.Name = "txtSOSContact"
        txtSOSContact.Size = New Size(438, 47)
        txtSOSContact.TabIndex = 49
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(683, 954)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(438, 47)
        txtPhone.TabIndex = 48
        ' 
        ' txtZip
        ' 
        txtZip.Location = New Point(683, 869)
        txtZip.Name = "txtZip"
        txtZip.Size = New Size(438, 47)
        txtZip.TabIndex = 47
        ' 
        ' txtState
        ' 
        txtState.Location = New Point(683, 799)
        txtState.Name = "txtState"
        txtState.Size = New Size(438, 47)
        txtState.TabIndex = 46
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(683, 730)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(438, 47)
        txtCity.TabIndex = 45
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(683, 671)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(438, 47)
        txtAddress.TabIndex = 44
        ' 
        ' txtFrequentFlyer
        ' 
        txtFrequentFlyer.Location = New Point(680, 500)
        txtFrequentFlyer.Multiline = True
        txtFrequentFlyer.Name = "txtFrequentFlyer"
        txtFrequentFlyer.Size = New Size(438, 47)
        txtFrequentFlyer.TabIndex = 43
        ' 
        ' txtPassport
        ' 
        txtPassport.Location = New Point(680, 353)
        txtPassport.Name = "txtPassport"
        txtPassport.Size = New Size(438, 47)
        txtPassport.TabIndex = 42
        ' 
        ' txtNickName
        ' 
        txtNickName.Location = New Point(680, 272)
        txtNickName.Name = "txtNickName"
        txtNickName.Size = New Size(438, 47)
        txtNickName.TabIndex = 41
        ' 
        ' cbEditTraveler
        ' 
        cbEditTraveler.FormattingEnabled = True
        cbEditTraveler.Location = New Point(680, 202)
        cbEditTraveler.Margin = New Padding(5, 5, 5, 5)
        cbEditTraveler.Name = "cbEditTraveler"
        cbEditTraveler.Size = New Size(438, 49)
        cbEditTraveler.TabIndex = 79
        ' 
        ' frmEdit_Traveler
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1360, 1827)
        Controls.Add(cbEditTraveler)
        Controls.Add(btnUpdateTraveler)
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
        Margin = New Padding(5, 5, 5, 5)
        Name = "frmEdit_Traveler"
        Text = "frmEdit_Traveler"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnUpdateTraveler As Button
    Friend WithEvents txtAirline As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDOB As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKnownTravelerNumber As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents txtGeneralNotes As TextBox
    Friend WithEvents txtMedicalNotes As TextBox
    Friend WithEvents txtSOSNumber As TextBox
    Friend WithEvents txtSOSContact As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFrequentFlyer As TextBox
    Friend WithEvents txtPassport As TextBox
    Friend WithEvents txtNickName As TextBox
    Friend WithEvents cbEditTraveler As ComboBox
End Class
