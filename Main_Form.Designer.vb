<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        Label1 = New Label()
        Label2 = New Label()
        DTPDatePicker = New DateTimePicker()
        lblLocation = New Label()
        txtLocation = New TextBox()
        lblType = New Label()
        cbRecipient = New ComboBox()
        cbMerchantDetail = New ComboBox()
        lblMerchantType = New Label()
        lblAmount = New Label()
        txtAmount = New TextBox()
        btnSubmit = New Button()
        btnReset = New Button()
        lblBeginFrnTraveler2 = New Label()
        lblBeginFrnrTaveler1 = New Label()
        lblBeginUSTraveler2 = New Label()
        lblBeginUSTraveler1 = New Label()
        lblBCForeignCashTraveler2 = New Label()
        lblBCForeignCashTraveler1 = New Label()
        lblBCUSCashTraveler2 = New Label()
        lblBCUSCashTraveler1 = New Label()
        Label3 = New Label()
        lblCurrentFrnTraveler2 = New Label()
        lblCurrentFRNTraveler1 = New Label()
        lblCurrentUSTraveler2 = New Label()
        lblCurrentUSraveler1 = New Label()
        lblCCForeignCashTraveler2 = New Label()
        lblCCForeignCashTraveler1 = New Label()
        lblCCUSCashTraveler2 = New Label()
        lblCCUSCashTraveler1 = New Label()
        Label4 = New Label()
        txtDescription = New TextBox()
        GroupBox1 = New GroupBox()
        Label13 = New Label()
        rbtTraveler2 = New RadioButton()
        rbtTraveler1 = New RadioButton()
        GroupBox2 = New GroupBox()
        Label14 = New Label()
        rbtForeignCurrency = New RadioButton()
        rbtUSCurrency = New RadioButton()
        lblDescription = New Label()
        mnuStrip = New MenuStrip()
        MS_File = New ToolStripMenuItem()
        MS_File_Open = New ToolStripMenuItem()
        MS_File_Open_Traveler1 = New ToolStripMenuItem()
        MS_File_Open_Traveler2 = New ToolStripMenuItem()
        BalanceToolStripMenuItem = New ToolStripMenuItem()
        MS_File_Print = New ToolStripMenuItem()
        MS_File_Print_Traveler1 = New ToolStripMenuItem()
        MS_File_Print_Traveler2 = New ToolStripMenuItem()
        BalanceToolStripMenuItem1 = New ToolStripMenuItem()
        MS_File_Close = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        AddRJMUSCashToolStripMenuItem = New ToolStripMenuItem()
        AddAEDUSCashToolStripMenuItem = New ToolStripMenuItem()
        AddRJMForeignCashToolStripMenuItem = New ToolStripMenuItem()
        AddAEDForeignCashToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        NewTripToolStripMenuItem = New ToolStripMenuItem()
        NewTripToolStripMenuItem1 = New ToolStripMenuItem()
        LoadTripToolStripMenuItem1 = New ToolStripMenuItem()
        EditTripToolStripMenuItem = New ToolStripMenuItem()
        TransportationToolStripMenuItem = New ToolStripMenuItem()
        TravelerInfoToolStripMenuItem = New ToolStripMenuItem()
        AddTravelerToolStripMenuItem = New ToolStripMenuItem()
        EditTravelerToolStripMenuItem = New ToolStripMenuItem()
        DeleteTraverToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        scBeginingCash = New SplitContainer()
        scCurrentCash = New SplitContainer()
        lblTripName = New Label()
        btnCreditTransaction = New Button()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        mnuStrip.SuspendLayout()
        CType(scBeginingCash, ComponentModel.ISupportInitialize).BeginInit()
        scBeginingCash.Panel1.SuspendLayout()
        scBeginingCash.Panel2.SuspendLayout()
        scBeginingCash.SuspendLayout()
        CType(scCurrentCash, ComponentModel.ISupportInitialize).BeginInit()
        scCurrentCash.Panel1.SuspendLayout()
        scCurrentCash.Panel2.SuspendLayout()
        scCurrentCash.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitle.Location = New Point(371, 285)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(448, 81)
        lblTitle.TabIndex = 0
        lblTitle.Text = "RA Travel Cash"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(1404, 312)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 54)
        Label1.TabIndex = 1
        Label1.Text = "US Cash"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(1918, 312)
        Label2.Name = "Label2"
        Label2.Size = New Size(266, 54)
        Label2.TabIndex = 2
        Label2.Text = "Foreign Cash"
        Label2.UseWaitCursor = True
        ' 
        ' DTPDatePicker
        ' 
        DTPDatePicker.Location = New Point(371, 421)
        DTPDatePicker.Name = "DTPDatePicker"
        DTPDatePicker.Size = New Size(563, 47)
        DTPDatePicker.TabIndex = 21
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Font = New Font("Segoe UI", 10.0F)
        lblLocation.Location = New Point(63, 759)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(148, 46)
        lblLocation.TabIndex = 25
        lblLocation.Text = "Location"
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(277, 717)
        txtLocation.MaxLength = 50
        txtLocation.Multiline = True
        txtLocation.Name = "txtLocation"
        txtLocation.ScrollBars = ScrollBars.Vertical
        txtLocation.Size = New Size(715, 143)
        txtLocation.TabIndex = 26
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Font = New Font("Segoe UI", 10.0F)
        lblType.Location = New Point(63, 877)
        lblType.Name = "lblType"
        lblType.Size = New Size(90, 46)
        lblType.TabIndex = 27
        lblType.Text = "Type"
        ' 
        ' cbRecipient
        ' 
        cbRecipient.FormattingEnabled = True
        cbRecipient.Items.AddRange(New Object() {"Guide", "Taxi", "Bus", "Hotel", "Excursion", "Merchant", "Currency", "Other"})
        cbRecipient.Location = New Point(277, 887)
        cbRecipient.Name = "cbRecipient"
        cbRecipient.Size = New Size(715, 49)
        cbRecipient.TabIndex = 28
        ' 
        ' cbMerchantDetail
        ' 
        cbMerchantDetail.FormattingEnabled = True
        cbMerchantDetail.Items.AddRange(New Object() {"NA", "Food", "Souvenier", "Clothes", "Other"})
        cbMerchantDetail.Location = New Point(277, 969)
        cbMerchantDetail.Name = "cbMerchantDetail"
        cbMerchantDetail.Size = New Size(715, 49)
        cbMerchantDetail.TabIndex = 29
        cbMerchantDetail.Visible = False
        ' 
        ' lblMerchantType
        ' 
        lblMerchantType.Font = New Font("Segoe UI", 10.0F)
        lblMerchantType.Location = New Point(63, 946)
        lblMerchantType.Name = "lblMerchantType"
        lblMerchantType.Size = New Size(167, 93)
        lblMerchantType.TabIndex = 30
        lblMerchantType.Text = "Merchant Type"
        lblMerchantType.Visible = False
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Segoe UI", 10.0F)
        lblAmount.Location = New Point(63, 1159)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(141, 46)
        lblAmount.TabIndex = 31
        lblAmount.Text = "Amount"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(277, 1158)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(715, 47)
        txtAmount.TabIndex = 32
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(411, 1228)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(189, 57)
        btnSubmit.TabIndex = 33
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(1596, 1219)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(316, 57)
        btnReset.TabIndex = 34
        btnReset.Text = "Reset Amounts to 0"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblBeginFrnTraveler2
        ' 
        lblBeginFrnTraveler2.AutoSize = True
        lblBeginFrnTraveler2.Location = New Point(428, 144)
        lblBeginFrnTraveler2.Name = "lblBeginFrnTraveler2"
        lblBeginFrnTraveler2.RightToLeft = RightToLeft.Yes
        lblBeginFrnTraveler2.Size = New Size(34, 41)
        lblBeginFrnTraveler2.TabIndex = 25
        lblBeginFrnTraveler2.Text = "0"
        lblBeginFrnTraveler2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblBeginFrnrTaveler1
        ' 
        lblBeginFrnrTaveler1.AutoSize = True
        lblBeginFrnrTaveler1.Location = New Point(139, 144)
        lblBeginFrnrTaveler1.Name = "lblBeginFrnrTaveler1"
        lblBeginFrnrTaveler1.RightToLeft = RightToLeft.Yes
        lblBeginFrnrTaveler1.Size = New Size(34, 41)
        lblBeginFrnrTaveler1.TabIndex = 24
        lblBeginFrnrTaveler1.Text = "0"
        lblBeginFrnrTaveler1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblBeginUSTraveler2
        ' 
        lblBeginUSTraveler2.AutoSize = True
        lblBeginUSTraveler2.Location = New Point(416, 146)
        lblBeginUSTraveler2.Name = "lblBeginUSTraveler2"
        lblBeginUSTraveler2.RightToLeft = RightToLeft.Yes
        lblBeginUSTraveler2.Size = New Size(34, 41)
        lblBeginUSTraveler2.TabIndex = 23
        lblBeginUSTraveler2.Text = "0"
        lblBeginUSTraveler2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblBeginUSTraveler1
        ' 
        lblBeginUSTraveler1.AutoSize = True
        lblBeginUSTraveler1.Location = New Point(150, 146)
        lblBeginUSTraveler1.Name = "lblBeginUSTraveler1"
        lblBeginUSTraveler1.RightToLeft = RightToLeft.Yes
        lblBeginUSTraveler1.Size = New Size(34, 41)
        lblBeginUSTraveler1.TabIndex = 22
        lblBeginUSTraveler1.Text = "0"
        lblBeginUSTraveler1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblBCForeignCashTraveler2
        ' 
        lblBCForeignCashTraveler2.AutoSize = True
        lblBCForeignCashTraveler2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBCForeignCashTraveler2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblBCForeignCashTraveler2.Location = New Point(403, 79)
        lblBCForeignCashTraveler2.Name = "lblBCForeignCashTraveler2"
        lblBCForeignCashTraveler2.Size = New Size(60, 46)
        lblBCForeignCashTraveler2.TabIndex = 21
        lblBCForeignCashTraveler2.Text = "T2"
        lblBCForeignCashTraveler2.UseWaitCursor = True
        ' 
        ' lblBCForeignCashTraveler1
        ' 
        lblBCForeignCashTraveler1.AutoSize = True
        lblBCForeignCashTraveler1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBCForeignCashTraveler1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblBCForeignCashTraveler1.Location = New Point(117, 79)
        lblBCForeignCashTraveler1.Name = "lblBCForeignCashTraveler1"
        lblBCForeignCashTraveler1.Size = New Size(60, 46)
        lblBCForeignCashTraveler1.TabIndex = 20
        lblBCForeignCashTraveler1.Text = "T1"
        lblBCForeignCashTraveler1.UseWaitCursor = True
        ' 
        ' lblBCUSCashTraveler2
        ' 
        lblBCUSCashTraveler2.AutoSize = True
        lblBCUSCashTraveler2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBCUSCashTraveler2.ForeColor = Color.Green
        lblBCUSCashTraveler2.Location = New Point(400, 69)
        lblBCUSCashTraveler2.Name = "lblBCUSCashTraveler2"
        lblBCUSCashTraveler2.Size = New Size(60, 46)
        lblBCUSCashTraveler2.TabIndex = 19
        lblBCUSCashTraveler2.Text = "T2"
        lblBCUSCashTraveler2.UseWaitCursor = True
        ' 
        ' lblBCUSCashTraveler1
        ' 
        lblBCUSCashTraveler1.AutoSize = True
        lblBCUSCashTraveler1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBCUSCashTraveler1.ForeColor = Color.Green
        lblBCUSCashTraveler1.Location = New Point(122, 59)
        lblBCUSCashTraveler1.Name = "lblBCUSCashTraveler1"
        lblBCUSCashTraveler1.Size = New Size(60, 46)
        lblBCUSCashTraveler1.TabIndex = 18
        lblBCUSCashTraveler1.Text = "T1"
        lblBCUSCashTraveler1.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label3.Location = New Point(1596, 380)
        Label3.Name = "Label3"
        Label3.Size = New Size(364, 46)
        Label3.TabIndex = 17
        Label3.Text = "B e g i n i n g    C a s h"
        Label3.UseWaitCursor = True
        ' 
        ' lblCurrentFrnTraveler2
        ' 
        lblCurrentFrnTraveler2.AutoSize = True
        lblCurrentFrnTraveler2.Location = New Point(413, 157)
        lblCurrentFrnTraveler2.Name = "lblCurrentFrnTraveler2"
        lblCurrentFrnTraveler2.RightToLeft = RightToLeft.Yes
        lblCurrentFrnTraveler2.Size = New Size(34, 41)
        lblCurrentFrnTraveler2.TabIndex = 29
        lblCurrentFrnTraveler2.Text = "0"
        lblCurrentFrnTraveler2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCurrentFRNTraveler1
        ' 
        lblCurrentFRNTraveler1.AutoSize = True
        lblCurrentFRNTraveler1.Location = New Point(124, 157)
        lblCurrentFRNTraveler1.Name = "lblCurrentFRNTraveler1"
        lblCurrentFRNTraveler1.RightToLeft = RightToLeft.Yes
        lblCurrentFRNTraveler1.Size = New Size(34, 41)
        lblCurrentFRNTraveler1.TabIndex = 28
        lblCurrentFRNTraveler1.Text = "0"
        lblCurrentFRNTraveler1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCurrentUSTraveler2
        ' 
        lblCurrentUSTraveler2.AutoSize = True
        lblCurrentUSTraveler2.Location = New Point(416, 157)
        lblCurrentUSTraveler2.Name = "lblCurrentUSTraveler2"
        lblCurrentUSTraveler2.RightToLeft = RightToLeft.Yes
        lblCurrentUSTraveler2.Size = New Size(34, 41)
        lblCurrentUSTraveler2.TabIndex = 27
        lblCurrentUSTraveler2.Text = "0"
        lblCurrentUSTraveler2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCurrentUSraveler1
        ' 
        lblCurrentUSraveler1.AutoSize = True
        lblCurrentUSraveler1.Location = New Point(150, 157)
        lblCurrentUSraveler1.Name = "lblCurrentUSraveler1"
        lblCurrentUSraveler1.RightToLeft = RightToLeft.Yes
        lblCurrentUSraveler1.Size = New Size(34, 41)
        lblCurrentUSraveler1.TabIndex = 26
        lblCurrentUSraveler1.Text = "0"
        lblCurrentUSraveler1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCCForeignCashTraveler2
        ' 
        lblCCForeignCashTraveler2.AutoSize = True
        lblCCForeignCashTraveler2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCCForeignCashTraveler2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblCCForeignCashTraveler2.Location = New Point(388, 48)
        lblCCForeignCashTraveler2.Name = "lblCCForeignCashTraveler2"
        lblCCForeignCashTraveler2.Size = New Size(60, 46)
        lblCCForeignCashTraveler2.TabIndex = 25
        lblCCForeignCashTraveler2.Text = "T2"
        lblCCForeignCashTraveler2.UseWaitCursor = True
        ' 
        ' lblCCForeignCashTraveler1
        ' 
        lblCCForeignCashTraveler1.AutoSize = True
        lblCCForeignCashTraveler1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCCForeignCashTraveler1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblCCForeignCashTraveler1.Location = New Point(102, 48)
        lblCCForeignCashTraveler1.Name = "lblCCForeignCashTraveler1"
        lblCCForeignCashTraveler1.Size = New Size(60, 46)
        lblCCForeignCashTraveler1.TabIndex = 24
        lblCCForeignCashTraveler1.Text = "T1"
        lblCCForeignCashTraveler1.UseWaitCursor = True
        ' 
        ' lblCCUSCashTraveler2
        ' 
        lblCCUSCashTraveler2.AutoSize = True
        lblCCUSCashTraveler2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCCUSCashTraveler2.ForeColor = Color.Green
        lblCCUSCashTraveler2.Location = New Point(400, 48)
        lblCCUSCashTraveler2.Name = "lblCCUSCashTraveler2"
        lblCCUSCashTraveler2.Size = New Size(60, 46)
        lblCCUSCashTraveler2.TabIndex = 23
        lblCCUSCashTraveler2.Text = "T2"
        lblCCUSCashTraveler2.UseWaitCursor = True
        ' 
        ' lblCCUSCashTraveler1
        ' 
        lblCCUSCashTraveler1.AutoSize = True
        lblCCUSCashTraveler1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCCUSCashTraveler1.ForeColor = Color.Green
        lblCCUSCashTraveler1.Location = New Point(122, 48)
        lblCCUSCashTraveler1.Name = "lblCCUSCashTraveler1"
        lblCCUSCashTraveler1.Size = New Size(60, 46)
        lblCCUSCashTraveler1.TabIndex = 22
        lblCCUSCashTraveler1.Text = "T1"
        lblCCUSCashTraveler1.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label4.Location = New Point(1596, 779)
        Label4.Name = "Label4"
        Label4.Size = New Size(333, 46)
        Label4.TabIndex = 21
        Label4.Text = "C u r r e n t    C a s h"
        Label4.UseWaitCursor = True
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(277, 1063)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(715, 47)
        txtDescription.TabIndex = 37
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(rbtTraveler2)
        GroupBox1.Controls.Add(rbtTraveler1)
        GroupBox1.Location = New Point(63, 479)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(818, 90)
        GroupBox1.TabIndex = 40
        GroupBox1.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.0F)
        Label13.Location = New Point(-7, 43)
        Label13.Name = "Label13"
        Label13.Size = New Size(176, 46)
        Label13.TabIndex = 27
        Label13.Text = "Select one"
        ' 
        ' rbtTraveler2
        ' 
        rbtTraveler2.AutoSize = True
        rbtTraveler2.Location = New Point(615, 28)
        rbtTraveler2.Name = "rbtTraveler2"
        rbtTraveler2.Size = New Size(87, 45)
        rbtTraveler2.TabIndex = 26
        rbtTraveler2.TabStop = True
        rbtTraveler2.Text = "T2"
        rbtTraveler2.UseVisualStyleBackColor = True
        ' 
        ' rbtTraveler1
        ' 
        rbtTraveler1.AutoSize = True
        rbtTraveler1.Location = New Point(434, 28)
        rbtTraveler1.Name = "rbtTraveler1"
        rbtTraveler1.Size = New Size(87, 45)
        rbtTraveler1.TabIndex = 25
        rbtTraveler1.TabStop = True
        rbtTraveler1.Text = "T1"
        rbtTraveler1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(rbtForeignCurrency)
        GroupBox2.Controls.Add(rbtUSCurrency)
        GroupBox2.Location = New Point(63, 595)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(818, 90)
        GroupBox2.TabIndex = 41
        GroupBox2.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10.0F)
        Label14.Location = New Point(-7, 44)
        Label14.Name = "Label14"
        Label14.Size = New Size(176, 46)
        Label14.TabIndex = 42
        Label14.Text = "Select one"
        ' 
        ' rbtForeignCurrency
        ' 
        rbtForeignCurrency.AutoSize = True
        rbtForeignCurrency.Location = New Point(615, 30)
        rbtForeignCurrency.Name = "rbtForeignCurrency"
        rbtForeignCurrency.Size = New Size(156, 45)
        rbtForeignCurrency.TabIndex = 41
        rbtForeignCurrency.TabStop = True
        rbtForeignCurrency.Text = "Foreign"
        rbtForeignCurrency.UseVisualStyleBackColor = True
        ' 
        ' rbtUSCurrency
        ' 
        rbtUSCurrency.AutoSize = True
        rbtUSCurrency.Location = New Point(437, 30)
        rbtUSCurrency.Name = "rbtUSCurrency"
        rbtUSCurrency.Size = New Size(92, 45)
        rbtUSCurrency.TabIndex = 40
        rbtUSCurrency.TabStop = True
        rbtUSCurrency.Text = "US"
        rbtUSCurrency.UseVisualStyleBackColor = True
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Segoe UI", 10.0F)
        lblDescription.Location = New Point(63, 1063)
        lblDescription.Margin = New Padding(5, 0, 5, 0)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(191, 46)
        lblDescription.TabIndex = 42
        lblDescription.Text = "Description"
        ' 
        ' mnuStrip
        ' 
        mnuStrip.ImageScalingSize = New Size(24, 24)
        mnuStrip.Items.AddRange(New ToolStripItem() {MS_File, EditToolStripMenuItem, NewTripToolStripMenuItem, TransportationToolStripMenuItem, TravelerInfoToolStripMenuItem, AboutToolStripMenuItem})
        mnuStrip.Location = New Point(0, 0)
        mnuStrip.Name = "mnuStrip"
        mnuStrip.Padding = New Padding(10, 3, 0, 3)
        mnuStrip.Size = New Size(2508, 51)
        mnuStrip.TabIndex = 43
        mnuStrip.Text = "MenuStrip1"
        ' 
        ' MS_File
        ' 
        MS_File.DropDownItems.AddRange(New ToolStripItem() {MS_File_Open, MS_File_Print, MS_File_Close})
        MS_File.Name = "MS_File"
        MS_File.Size = New Size(87, 45)
        MS_File.Text = "File"
        ' 
        ' MS_File_Open
        ' 
        MS_File_Open.DropDownItems.AddRange(New ToolStripItem() {MS_File_Open_Traveler1, MS_File_Open_Traveler2, BalanceToolStripMenuItem})
        MS_File_Open.Name = "MS_File_Open"
        MS_File_Open.Size = New Size(351, 54)
        MS_File_Open.Text = "Open "
        ' 
        ' MS_File_Open_Traveler1
        ' 
        MS_File_Open_Traveler1.Name = "MS_File_Open_Traveler1"
        MS_File_Open_Traveler1.Size = New Size(285, 54)
        MS_File_Open_Traveler1.Text = "RJM "
        ' 
        ' MS_File_Open_Traveler2
        ' 
        MS_File_Open_Traveler2.Name = "MS_File_Open_Traveler2"
        MS_File_Open_Traveler2.Size = New Size(285, 54)
        MS_File_Open_Traveler2.Text = "AED"
        ' 
        ' BalanceToolStripMenuItem
        ' 
        BalanceToolStripMenuItem.Name = "BalanceToolStripMenuItem"
        BalanceToolStripMenuItem.Size = New Size(285, 54)
        BalanceToolStripMenuItem.Text = "Balance"
        ' 
        ' MS_File_Print
        ' 
        MS_File_Print.DropDownItems.AddRange(New ToolStripItem() {MS_File_Print_Traveler1, MS_File_Print_Traveler2, BalanceToolStripMenuItem1})
        MS_File_Print.Name = "MS_File_Print"
        MS_File_Print.Size = New Size(351, 54)
        MS_File_Print.Text = "Print"
        ' 
        ' MS_File_Print_Traveler1
        ' 
        MS_File_Print_Traveler1.Name = "MS_File_Print_Traveler1"
        MS_File_Print_Traveler1.Size = New Size(285, 54)
        MS_File_Print_Traveler1.Text = "RJM"
        ' 
        ' MS_File_Print_Traveler2
        ' 
        MS_File_Print_Traveler2.Name = "MS_File_Print_Traveler2"
        MS_File_Print_Traveler2.Size = New Size(285, 54)
        MS_File_Print_Traveler2.Text = "AED"
        ' 
        ' BalanceToolStripMenuItem1
        ' 
        BalanceToolStripMenuItem1.Name = "BalanceToolStripMenuItem1"
        BalanceToolStripMenuItem1.Size = New Size(285, 54)
        BalanceToolStripMenuItem1.Text = "Balance"
        ' 
        ' MS_File_Close
        ' 
        MS_File_Close.Name = "MS_File_Close"
        MS_File_Close.ShortcutKeys = Keys.Alt Or Keys.C
        MS_File_Close.Size = New Size(351, 54)
        MS_File_Close.Text = "Close"
        MS_File_Close.ToolTipText = "Close the App"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddRJMUSCashToolStripMenuItem, AddAEDUSCashToolStripMenuItem, AddRJMForeignCashToolStripMenuItem, AddAEDForeignCashToolStripMenuItem, SettingsToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(92, 45)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' AddRJMUSCashToolStripMenuItem
        ' 
        AddRJMUSCashToolStripMenuItem.Name = "AddRJMUSCashToolStripMenuItem"
        AddRJMUSCashToolStripMenuItem.Size = New Size(485, 54)
        AddRJMUSCashToolStripMenuItem.Text = "Add RJM US Cash"
        ' 
        ' AddAEDUSCashToolStripMenuItem
        ' 
        AddAEDUSCashToolStripMenuItem.Name = "AddAEDUSCashToolStripMenuItem"
        AddAEDUSCashToolStripMenuItem.Size = New Size(485, 54)
        AddAEDUSCashToolStripMenuItem.Text = "Add AED US Cash"
        ' 
        ' AddRJMForeignCashToolStripMenuItem
        ' 
        AddRJMForeignCashToolStripMenuItem.Name = "AddRJMForeignCashToolStripMenuItem"
        AddRJMForeignCashToolStripMenuItem.Size = New Size(485, 54)
        AddRJMForeignCashToolStripMenuItem.Text = "Add RJM Foreign Cash"
        ' 
        ' AddAEDForeignCashToolStripMenuItem
        ' 
        AddAEDForeignCashToolStripMenuItem.Name = "AddAEDForeignCashToolStripMenuItem"
        AddAEDForeignCashToolStripMenuItem.Size = New Size(485, 54)
        AddAEDForeignCashToolStripMenuItem.Text = "Add AED Foreign Cash"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(485, 54)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' NewTripToolStripMenuItem
        ' 
        NewTripToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewTripToolStripMenuItem1, LoadTripToolStripMenuItem1, EditTripToolStripMenuItem})
        NewTripToolStripMenuItem.Name = "NewTripToolStripMenuItem"
        NewTripToolStripMenuItem.Size = New Size(90, 45)
        NewTripToolStripMenuItem.Text = "Trip"
        ' 
        ' NewTripToolStripMenuItem1
        ' 
        NewTripToolStripMenuItem1.Name = "NewTripToolStripMenuItem1"
        NewTripToolStripMenuItem1.Size = New Size(305, 54)
        NewTripToolStripMenuItem1.Text = "New Trip"
        ' 
        ' LoadTripToolStripMenuItem1
        ' 
        LoadTripToolStripMenuItem1.Name = "LoadTripToolStripMenuItem1"
        LoadTripToolStripMenuItem1.Size = New Size(305, 54)
        LoadTripToolStripMenuItem1.Text = "Load Trip"
        ' 
        ' EditTripToolStripMenuItem
        ' 
        EditTripToolStripMenuItem.Name = "EditTripToolStripMenuItem"
        EditTripToolStripMenuItem.Size = New Size(305, 54)
        EditTripToolStripMenuItem.Text = "Edit Trip"
        ' 
        ' TransportationToolStripMenuItem
        ' 
        TransportationToolStripMenuItem.Name = "TransportationToolStripMenuItem"
        TransportationToolStripMenuItem.Size = New Size(233, 45)
        TransportationToolStripMenuItem.Text = "Transportation"
        ' 
        ' TravelerInfoToolStripMenuItem
        ' 
        TravelerInfoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddTravelerToolStripMenuItem, EditTravelerToolStripMenuItem, DeleteTraverToolStripMenuItem})
        TravelerInfoToolStripMenuItem.Name = "TravelerInfoToolStripMenuItem"
        TravelerInfoToolStripMenuItem.Size = New Size(143, 45)
        TravelerInfoToolStripMenuItem.Text = "Traveler"
        ' 
        ' AddTravelerToolStripMenuItem
        ' 
        AddTravelerToolStripMenuItem.Name = "AddTravelerToolStripMenuItem"
        AddTravelerToolStripMenuItem.Size = New Size(356, 54)
        AddTravelerToolStripMenuItem.Text = "Add Traveler"
        ' 
        ' EditTravelerToolStripMenuItem
        ' 
        EditTravelerToolStripMenuItem.Name = "EditTravelerToolStripMenuItem"
        EditTravelerToolStripMenuItem.Size = New Size(356, 54)
        EditTravelerToolStripMenuItem.Text = "Edit Traveler"
        ' 
        ' DeleteTraverToolStripMenuItem
        ' 
        DeleteTraverToolStripMenuItem.Name = "DeleteTraverToolStripMenuItem"
        DeleteTraverToolStripMenuItem.Size = New Size(356, 54)
        DeleteTraverToolStripMenuItem.Text = "Delete Traver"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(124, 45)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' scBeginingCash
        ' 
        scBeginingCash.BackColor = SystemColors.ButtonHighlight
        scBeginingCash.BorderStyle = BorderStyle.Fixed3D
        scBeginingCash.Location = New Point(1108, 479)
        scBeginingCash.Margin = New Padding(5)
        scBeginingCash.Name = "scBeginingCash"
        ' 
        ' scBeginingCash.Panel1
        ' 
        scBeginingCash.Panel1.Controls.Add(lblBCUSCashTraveler2)
        scBeginingCash.Panel1.Controls.Add(lblBCUSCashTraveler1)
        scBeginingCash.Panel1.Controls.Add(lblBeginUSTraveler2)
        scBeginingCash.Panel1.Controls.Add(lblBeginUSTraveler1)
        ' 
        ' scBeginingCash.Panel2
        ' 
        scBeginingCash.Panel2.Controls.Add(lblBeginFrnTraveler2)
        scBeginingCash.Panel2.Controls.Add(lblBCForeignCashTraveler2)
        scBeginingCash.Panel2.Controls.Add(lblBeginFrnrTaveler1)
        scBeginingCash.Panel2.Controls.Add(lblBCForeignCashTraveler1)
        scBeginingCash.Size = New Size(1306, 246)
        scBeginingCash.SplitterDistance = 637
        scBeginingCash.SplitterWidth = 7
        scBeginingCash.TabIndex = 44
        ' 
        ' scCurrentCash
        ' 
        scCurrentCash.BackColor = SystemColors.ButtonHighlight
        scCurrentCash.BorderStyle = BorderStyle.Fixed3D
        scCurrentCash.Location = New Point(1108, 884)
        scCurrentCash.Margin = New Padding(5)
        scCurrentCash.Name = "scCurrentCash"
        ' 
        ' scCurrentCash.Panel1
        ' 
        scCurrentCash.Panel1.Controls.Add(lblCCUSCashTraveler1)
        scCurrentCash.Panel1.Controls.Add(lblCCUSCashTraveler2)
        scCurrentCash.Panel1.Controls.Add(lblCurrentUSTraveler2)
        scCurrentCash.Panel1.Controls.Add(lblCurrentUSraveler1)
        ' 
        ' scCurrentCash.Panel2
        ' 
        scCurrentCash.Panel2.Controls.Add(lblCurrentFrnTraveler2)
        scCurrentCash.Panel2.Controls.Add(lblCCForeignCashTraveler2)
        scCurrentCash.Panel2.Controls.Add(lblCurrentFRNTraveler1)
        scCurrentCash.Panel2.Controls.Add(lblCCForeignCashTraveler1)
        scCurrentCash.Size = New Size(1306, 246)
        scCurrentCash.SplitterDistance = 653
        scCurrentCash.SplitterWidth = 7
        scCurrentCash.TabIndex = 45
        ' 
        ' lblTripName
        ' 
        lblTripName.AutoSize = True
        lblTripName.Font = New Font("Segoe UI", 26.0F, FontStyle.Bold)
        lblTripName.Location = New Point(260, 115)
        lblTripName.Margin = New Padding(5, 0, 5, 0)
        lblTripName.Name = "lblTripName"
        lblTripName.Size = New Size(568, 116)
        lblTripName.TabIndex = 46
        lblTripName.Text = "Place Holder"
        ' 
        ' btnCreditTransaction
        ' 
        btnCreditTransaction.Location = New Point(1663, 107)
        btnCreditTransaction.Margin = New Padding(5)
        btnCreditTransaction.Name = "btnCreditTransaction"
        btnCreditTransaction.Size = New Size(529, 56)
        btnCreditTransaction.TabIndex = 47
        btnCreditTransaction.Text = "Credit/Debit Transaction"
        btnCreditTransaction.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1163, 1241)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 57)
        Button1.TabIndex = 48
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Main_Form
        ' 
        AutoScaleDimensions = New SizeF(17.0F, 41.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2508, 1310)
        Controls.Add(Button1)
        Controls.Add(btnCreditTransaction)
        Controls.Add(lblTripName)
        Controls.Add(scCurrentCash)
        Controls.Add(scBeginingCash)
        Controls.Add(lblDescription)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtDescription)
        Controls.Add(btnReset)
        Controls.Add(btnSubmit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(lblMerchantType)
        Controls.Add(cbMerchantDetail)
        Controls.Add(cbRecipient)
        Controls.Add(lblType)
        Controls.Add(txtLocation)
        Controls.Add(lblLocation)
        Controls.Add(DTPDatePicker)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Controls.Add(mnuStrip)
        MainMenuStrip = mnuStrip
        Margin = New Padding(5)
        Name = "Main_Form"
        Text = "Travel Manager"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        mnuStrip.ResumeLayout(False)
        mnuStrip.PerformLayout()
        scBeginingCash.Panel1.ResumeLayout(False)
        scBeginingCash.Panel1.PerformLayout()
        scBeginingCash.Panel2.ResumeLayout(False)
        scBeginingCash.Panel2.PerformLayout()
        CType(scBeginingCash, ComponentModel.ISupportInitialize).EndInit()
        scBeginingCash.ResumeLayout(False)
        scCurrentCash.Panel1.ResumeLayout(False)
        scCurrentCash.Panel1.PerformLayout()
        scCurrentCash.Panel2.ResumeLayout(False)
        scCurrentCash.Panel2.PerformLayout()
        CType(scCurrentCash, ComponentModel.ISupportInitialize).EndInit()
        scCurrentCash.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPDatePicker As DateTimePicker
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents cbRecipient As ComboBox
    Friend WithEvents cbMerchantDetail As ComboBox
    Friend WithEvents lblMerchantType As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblBeginFrnTraveler2 As Label
    Friend WithEvents lblBeginFrnrTaveler1 As Label
    Friend WithEvents lblBeginUSTraveler2 As Label
    Friend WithEvents lblBeginUSTraveler1 As Label
    Friend WithEvents lblBCForeignCashTraveler2 As Label
    Friend WithEvents lblBCForeignCashTraveler1 As Label
    Friend WithEvents lblBCUSCashTraveler2 As Label
    Friend WithEvents lblBCUSCashTraveler1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCurrentFrnTraveler2 As Label
    Friend WithEvents lblCurrentFRNTraveler1 As Label
    Friend WithEvents lblCurrentUSTraveler2 As Label
    Friend WithEvents lblCurrentUSraveler1 As Label
    Friend WithEvents lblCCForeignCashTraveler2 As Label
    Friend WithEvents lblCCForeignCashTraveler1 As Label
    Friend WithEvents lblCCUSCashTraveler2 As Label
    Friend WithEvents lblCCUSCashTraveler1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtTraveler2 As RadioButton
    Friend WithEvents rbtTraveler1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtForeignCurrency As RadioButton
    Friend WithEvents rbtUSCurrency As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRJMUSCashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAEDUSCashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRJMForeignCashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAEDForeignCashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MS_File As ToolStripMenuItem
    Friend WithEvents MS_File_Close As ToolStripMenuItem
    Friend WithEvents MS_File_Open As ToolStripMenuItem
    Friend WithEvents MS_File_Open_Traveler1 As ToolStripMenuItem
    Friend WithEvents MS_File_Open_Traveler2 As ToolStripMenuItem
    Friend WithEvents BalanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MS_File_Print As ToolStripMenuItem
    Friend WithEvents MS_File_Print_Traveler1 As ToolStripMenuItem
    Friend WithEvents MS_File_Print_Traveler2 As ToolStripMenuItem
    Friend WithEvents BalanceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents scBeginingCash As SplitContainer
    Friend WithEvents scCurrentCash As SplitContainer
    Friend WithEvents lblTripName As Label
    Friend WithEvents NewTripToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCreditTransaction As Button
    Friend WithEvents TransportationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TravelerInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTravelerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditTravelerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteTraverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents NewTripToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoadTripToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditTripToolStripMenuItem As ToolStripMenuItem

End Class

