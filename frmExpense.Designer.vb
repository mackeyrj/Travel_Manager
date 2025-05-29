<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpense
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
        btnCreditTransaction = New Button()
        lblTripName = New Label()
        scCurrentCash = New SplitContainer()
        lblCCUSCashTraveler1 = New Label()
        lblCCUSCashTraveler2 = New Label()
        lblCurrentUSTraveler2 = New Label()
        lblCurrentUSTraveler1 = New Label()
        lblCurrentFrnTraveler2 = New Label()
        lblCCForeignCashTraveler2 = New Label()
        lblCurrentFRNTraveler1 = New Label()
        lblCCForeignCashTraveler1 = New Label()
        scBeginingCash = New SplitContainer()
        lblBCUSCashTraveler2 = New Label()
        lblBCUSCashTraveler1 = New Label()
        lblBeginUSTraveler2 = New Label()
        lblBeginUSTraveler1 = New Label()
        lblBeginFrnTraveler2 = New Label()
        lblBCForeignCashTraveler2 = New Label()
        lblBeginFrnrTaveler1 = New Label()
        lblBCForeignCashTraveler1 = New Label()
        lblDescription = New Label()
        GroupBox2 = New GroupBox()
        Label14 = New Label()
        rbtForeignCurrency = New RadioButton()
        rbtUSCurrency = New RadioButton()
        GroupBox1 = New GroupBox()
        Label13 = New Label()
        rbtTraveler2 = New RadioButton()
        rbtTraveler1 = New RadioButton()
        txtDescription = New TextBox()
        btnReset = New Button()
        btnSubmit = New Button()
        Label4 = New Label()
        Label3 = New Label()
        txtAmount = New TextBox()
        lblAmount = New Label()
        lblMerchantType = New Label()
        cbMerchantDetail = New ComboBox()
        cbRecipient = New ComboBox()
        lblType = New Label()
        txtLocation = New TextBox()
        lblLocation = New Label()
        DTPDatePicker = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        lblTitle = New Label()
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
        CType(scCurrentCash, ComponentModel.ISupportInitialize).BeginInit()
        scCurrentCash.Panel1.SuspendLayout()
        scCurrentCash.Panel2.SuspendLayout()
        scCurrentCash.SuspendLayout()
        CType(scBeginingCash, ComponentModel.ISupportInitialize).BeginInit()
        scBeginingCash.Panel1.SuspendLayout()
        scBeginingCash.Panel2.SuspendLayout()
        scBeginingCash.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        mnuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCreditTransaction
        ' 
        btnCreditTransaction.Location = New Point(1079, 80)
        btnCreditTransaction.Name = "btnCreditTransaction"
        btnCreditTransaction.Size = New Size(311, 34)
        btnCreditTransaction.TabIndex = 71
        btnCreditTransaction.Text = "Credit/Debit Transaction"
        btnCreditTransaction.UseVisualStyleBackColor = True
        ' 
        ' lblTripName
        ' 
        lblTripName.AutoSize = True
        lblTripName.Font = New Font("Segoe UI", 26.0F, FontStyle.Bold)
        lblTripName.Location = New Point(254, 85)
        lblTripName.Name = "lblTripName"
        lblTripName.Size = New Size(340, 70)
        lblTripName.TabIndex = 70
        lblTripName.Text = "Place Holder"
        ' 
        ' scCurrentCash
        ' 
        scCurrentCash.BackColor = SystemColors.ButtonHighlight
        scCurrentCash.BorderStyle = BorderStyle.Fixed3D
        scCurrentCash.Location = New Point(753, 554)
        scCurrentCash.Name = "scCurrentCash"
        ' 
        ' scCurrentCash.Panel1
        ' 
        scCurrentCash.Panel1.Controls.Add(lblCCUSCashTraveler1)
        scCurrentCash.Panel1.Controls.Add(lblCCUSCashTraveler2)
        scCurrentCash.Panel1.Controls.Add(lblCurrentUSTraveler2)
        scCurrentCash.Panel1.Controls.Add(lblCurrentUSTraveler1)
        ' 
        ' scCurrentCash.Panel2
        ' 
        scCurrentCash.Panel2.Controls.Add(lblCurrentFrnTraveler2)
        scCurrentCash.Panel2.Controls.Add(lblCCForeignCashTraveler2)
        scCurrentCash.Panel2.Controls.Add(lblCurrentFRNTraveler1)
        scCurrentCash.Panel2.Controls.Add(lblCCForeignCashTraveler1)
        scCurrentCash.Size = New Size(768, 150)
        scCurrentCash.SplitterDistance = 384
        scCurrentCash.TabIndex = 69
        ' 
        ' lblCCUSCashTraveler1
        ' 
        lblCCUSCashTraveler1.AutoSize = True
        lblCCUSCashTraveler1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCCUSCashTraveler1.ForeColor = Color.Green
        lblCCUSCashTraveler1.Location = New Point(72, 29)
        lblCCUSCashTraveler1.Margin = New Padding(2, 0, 2, 0)
        lblCCUSCashTraveler1.Name = "lblCCUSCashTraveler1"
        lblCCUSCashTraveler1.Size = New Size(36, 28)
        lblCCUSCashTraveler1.TabIndex = 22
        lblCCUSCashTraveler1.Text = "T1"
        lblCCUSCashTraveler1.UseWaitCursor = True
        ' 
        ' lblCCUSCashTraveler2
        ' 
        lblCCUSCashTraveler2.AutoSize = True
        lblCCUSCashTraveler2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCCUSCashTraveler2.ForeColor = Color.Green
        lblCCUSCashTraveler2.Location = New Point(235, 29)
        lblCCUSCashTraveler2.Margin = New Padding(2, 0, 2, 0)
        lblCCUSCashTraveler2.Name = "lblCCUSCashTraveler2"
        lblCCUSCashTraveler2.Size = New Size(36, 28)
        lblCCUSCashTraveler2.TabIndex = 23
        lblCCUSCashTraveler2.Text = "T2"
        lblCCUSCashTraveler2.UseWaitCursor = True
        ' 
        ' lblCurrentUSTraveler2
        ' 
        lblCurrentUSTraveler2.AutoSize = True
        lblCurrentUSTraveler2.Location = New Point(245, 96)
        lblCurrentUSTraveler2.Margin = New Padding(2, 0, 2, 0)
        lblCurrentUSTraveler2.Name = "lblCurrentUSTraveler2"
        lblCurrentUSTraveler2.RightToLeft = RightToLeft.Yes
        lblCurrentUSTraveler2.Size = New Size(22, 25)
        lblCurrentUSTraveler2.TabIndex = 27
        lblCurrentUSTraveler2.Text = "0"
        lblCurrentUSTraveler2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCurrentUSTraveler1
        ' 
        lblCurrentUSTraveler1.AutoSize = True
        lblCurrentUSTraveler1.Location = New Point(88, 96)
        lblCurrentUSTraveler1.Margin = New Padding(2, 0, 2, 0)
        lblCurrentUSTraveler1.Name = "lblCurrentUSTraveler1"
        lblCurrentUSTraveler1.RightToLeft = RightToLeft.Yes
        lblCurrentUSTraveler1.Size = New Size(22, 25)
        lblCurrentUSTraveler1.TabIndex = 26
        lblCurrentUSTraveler1.Text = "0"
        lblCurrentUSTraveler1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCurrentFrnTraveler2
        ' 
        lblCurrentFrnTraveler2.AutoSize = True
        lblCurrentFrnTraveler2.Location = New Point(243, 96)
        lblCurrentFrnTraveler2.Margin = New Padding(2, 0, 2, 0)
        lblCurrentFrnTraveler2.Name = "lblCurrentFrnTraveler2"
        lblCurrentFrnTraveler2.RightToLeft = RightToLeft.Yes
        lblCurrentFrnTraveler2.Size = New Size(22, 25)
        lblCurrentFrnTraveler2.TabIndex = 29
        lblCurrentFrnTraveler2.Text = "0"
        lblCurrentFrnTraveler2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCCForeignCashTraveler2
        ' 
        lblCCForeignCashTraveler2.AutoSize = True
        lblCCForeignCashTraveler2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCCForeignCashTraveler2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblCCForeignCashTraveler2.Location = New Point(228, 29)
        lblCCForeignCashTraveler2.Margin = New Padding(2, 0, 2, 0)
        lblCCForeignCashTraveler2.Name = "lblCCForeignCashTraveler2"
        lblCCForeignCashTraveler2.Size = New Size(36, 28)
        lblCCForeignCashTraveler2.TabIndex = 25
        lblCCForeignCashTraveler2.Text = "T2"
        lblCCForeignCashTraveler2.UseWaitCursor = True
        ' 
        ' lblCurrentFRNTraveler1
        ' 
        lblCurrentFRNTraveler1.AutoSize = True
        lblCurrentFRNTraveler1.Location = New Point(73, 96)
        lblCurrentFRNTraveler1.Margin = New Padding(2, 0, 2, 0)
        lblCurrentFRNTraveler1.Name = "lblCurrentFRNTraveler1"
        lblCurrentFRNTraveler1.RightToLeft = RightToLeft.Yes
        lblCurrentFRNTraveler1.Size = New Size(22, 25)
        lblCurrentFRNTraveler1.TabIndex = 28
        lblCurrentFRNTraveler1.Text = "0"
        lblCurrentFRNTraveler1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblCCForeignCashTraveler1
        ' 
        lblCCForeignCashTraveler1.AutoSize = True
        lblCCForeignCashTraveler1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCCForeignCashTraveler1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblCCForeignCashTraveler1.Location = New Point(60, 29)
        lblCCForeignCashTraveler1.Margin = New Padding(2, 0, 2, 0)
        lblCCForeignCashTraveler1.Name = "lblCCForeignCashTraveler1"
        lblCCForeignCashTraveler1.Size = New Size(36, 28)
        lblCCForeignCashTraveler1.TabIndex = 24
        lblCCForeignCashTraveler1.Text = "T1"
        lblCCForeignCashTraveler1.UseWaitCursor = True
        ' 
        ' scBeginingCash
        ' 
        scBeginingCash.BackColor = SystemColors.ButtonHighlight
        scBeginingCash.BorderStyle = BorderStyle.Fixed3D
        scBeginingCash.Location = New Point(753, 307)
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
        scBeginingCash.Size = New Size(768, 150)
        scBeginingCash.SplitterDistance = 373
        scBeginingCash.TabIndex = 68
        ' 
        ' lblBCUSCashTraveler2
        ' 
        lblBCUSCashTraveler2.AutoSize = True
        lblBCUSCashTraveler2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBCUSCashTraveler2.ForeColor = Color.Green
        lblBCUSCashTraveler2.Location = New Point(235, 42)
        lblBCUSCashTraveler2.Margin = New Padding(2, 0, 2, 0)
        lblBCUSCashTraveler2.Name = "lblBCUSCashTraveler2"
        lblBCUSCashTraveler2.Size = New Size(36, 28)
        lblBCUSCashTraveler2.TabIndex = 19
        lblBCUSCashTraveler2.Text = "T2"
        lblBCUSCashTraveler2.UseWaitCursor = True
        ' 
        ' lblBCUSCashTraveler1
        ' 
        lblBCUSCashTraveler1.AutoSize = True
        lblBCUSCashTraveler1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBCUSCashTraveler1.ForeColor = Color.Green
        lblBCUSCashTraveler1.Location = New Point(72, 36)
        lblBCUSCashTraveler1.Margin = New Padding(2, 0, 2, 0)
        lblBCUSCashTraveler1.Name = "lblBCUSCashTraveler1"
        lblBCUSCashTraveler1.Size = New Size(36, 28)
        lblBCUSCashTraveler1.TabIndex = 18
        lblBCUSCashTraveler1.Text = "T1"
        lblBCUSCashTraveler1.UseWaitCursor = True
        ' 
        ' lblBeginUSTraveler2
        ' 
        lblBeginUSTraveler2.AutoSize = True
        lblBeginUSTraveler2.Location = New Point(245, 89)
        lblBeginUSTraveler2.Margin = New Padding(2, 0, 2, 0)
        lblBeginUSTraveler2.Name = "lblBeginUSTraveler2"
        lblBeginUSTraveler2.RightToLeft = RightToLeft.Yes
        lblBeginUSTraveler2.Size = New Size(22, 25)
        lblBeginUSTraveler2.TabIndex = 23
        lblBeginUSTraveler2.Text = "0"
        lblBeginUSTraveler2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblBeginUSTraveler1
        ' 
        lblBeginUSTraveler1.AutoSize = True
        lblBeginUSTraveler1.Location = New Point(88, 89)
        lblBeginUSTraveler1.Margin = New Padding(2, 0, 2, 0)
        lblBeginUSTraveler1.Name = "lblBeginUSTraveler1"
        lblBeginUSTraveler1.RightToLeft = RightToLeft.Yes
        lblBeginUSTraveler1.Size = New Size(22, 25)
        lblBeginUSTraveler1.TabIndex = 22
        lblBeginUSTraveler1.Text = "0"
        lblBeginUSTraveler1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblBeginFrnTraveler2
        ' 
        lblBeginFrnTraveler2.AutoSize = True
        lblBeginFrnTraveler2.Location = New Point(252, 88)
        lblBeginFrnTraveler2.Margin = New Padding(2, 0, 2, 0)
        lblBeginFrnTraveler2.Name = "lblBeginFrnTraveler2"
        lblBeginFrnTraveler2.RightToLeft = RightToLeft.Yes
        lblBeginFrnTraveler2.Size = New Size(22, 25)
        lblBeginFrnTraveler2.TabIndex = 25
        lblBeginFrnTraveler2.Text = "0"
        lblBeginFrnTraveler2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblBCForeignCashTraveler2
        ' 
        lblBCForeignCashTraveler2.AutoSize = True
        lblBCForeignCashTraveler2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBCForeignCashTraveler2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblBCForeignCashTraveler2.Location = New Point(237, 48)
        lblBCForeignCashTraveler2.Margin = New Padding(2, 0, 2, 0)
        lblBCForeignCashTraveler2.Name = "lblBCForeignCashTraveler2"
        lblBCForeignCashTraveler2.Size = New Size(36, 28)
        lblBCForeignCashTraveler2.TabIndex = 21
        lblBCForeignCashTraveler2.Text = "T2"
        lblBCForeignCashTraveler2.UseWaitCursor = True
        ' 
        ' lblBeginFrnrTaveler1
        ' 
        lblBeginFrnrTaveler1.AutoSize = True
        lblBeginFrnrTaveler1.Location = New Point(82, 88)
        lblBeginFrnrTaveler1.Margin = New Padding(2, 0, 2, 0)
        lblBeginFrnrTaveler1.Name = "lblBeginFrnrTaveler1"
        lblBeginFrnrTaveler1.RightToLeft = RightToLeft.Yes
        lblBeginFrnrTaveler1.Size = New Size(22, 25)
        lblBeginFrnrTaveler1.TabIndex = 24
        lblBeginFrnrTaveler1.Text = "0"
        lblBeginFrnrTaveler1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblBCForeignCashTraveler1
        ' 
        lblBCForeignCashTraveler1.AutoSize = True
        lblBCForeignCashTraveler1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBCForeignCashTraveler1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblBCForeignCashTraveler1.Location = New Point(69, 48)
        lblBCForeignCashTraveler1.Margin = New Padding(2, 0, 2, 0)
        lblBCForeignCashTraveler1.Name = "lblBCForeignCashTraveler1"
        lblBCForeignCashTraveler1.Size = New Size(36, 28)
        lblBCForeignCashTraveler1.TabIndex = 20
        lblBCForeignCashTraveler1.Text = "T1"
        lblBCForeignCashTraveler1.UseWaitCursor = True
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Segoe UI", 10.0F)
        lblDescription.Location = New Point(138, 663)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(112, 28)
        lblDescription.TabIndex = 67
        lblDescription.Text = "Description"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(rbtForeignCurrency)
        GroupBox2.Controls.Add(rbtUSCurrency)
        GroupBox2.Location = New Point(138, 378)
        GroupBox2.Margin = New Padding(2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2)
        GroupBox2.Size = New Size(481, 55)
        GroupBox2.TabIndex = 66
        GroupBox2.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10.0F)
        Label14.Location = New Point(-5, 26)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(102, 28)
        Label14.TabIndex = 42
        Label14.Text = "Select one"
        ' 
        ' rbtForeignCurrency
        ' 
        rbtForeignCurrency.AutoSize = True
        rbtForeignCurrency.Location = New Point(361, 17)
        rbtForeignCurrency.Margin = New Padding(2)
        rbtForeignCurrency.Name = "rbtForeignCurrency"
        rbtForeignCurrency.Size = New Size(97, 29)
        rbtForeignCurrency.TabIndex = 41
        rbtForeignCurrency.TabStop = True
        rbtForeignCurrency.Text = "Foreign"
        rbtForeignCurrency.UseVisualStyleBackColor = True
        ' 
        ' rbtUSCurrency
        ' 
        rbtUSCurrency.AutoSize = True
        rbtUSCurrency.Location = New Point(256, 17)
        rbtUSCurrency.Margin = New Padding(2)
        rbtUSCurrency.Name = "rbtUSCurrency"
        rbtUSCurrency.Size = New Size(59, 29)
        rbtUSCurrency.TabIndex = 40
        rbtUSCurrency.TabStop = True
        rbtUSCurrency.Text = "US"
        rbtUSCurrency.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(rbtTraveler2)
        GroupBox1.Controls.Add(rbtTraveler1)
        GroupBox1.Location = New Point(138, 307)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(481, 55)
        GroupBox1.TabIndex = 65
        GroupBox1.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.0F)
        Label13.Location = New Point(-5, 25)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(102, 28)
        Label13.TabIndex = 27
        Label13.Text = "Select one"
        ' 
        ' rbtTraveler2
        ' 
        rbtTraveler2.AutoSize = True
        rbtTraveler2.Location = New Point(361, 16)
        rbtTraveler2.Margin = New Padding(2)
        rbtTraveler2.Name = "rbtTraveler2"
        rbtTraveler2.Size = New Size(56, 29)
        rbtTraveler2.TabIndex = 26
        rbtTraveler2.TabStop = True
        rbtTraveler2.Text = "T2"
        rbtTraveler2.UseVisualStyleBackColor = True
        ' 
        ' rbtTraveler1
        ' 
        rbtTraveler1.AutoSize = True
        rbtTraveler1.Location = New Point(254, 16)
        rbtTraveler1.Margin = New Padding(2)
        rbtTraveler1.Name = "rbtTraveler1"
        rbtTraveler1.Size = New Size(56, 29)
        rbtTraveler1.TabIndex = 25
        rbtTraveler1.TabStop = True
        rbtTraveler1.Text = "T1"
        rbtTraveler1.UseVisualStyleBackColor = True
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(264, 663)
        txtDescription.Margin = New Padding(2)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(422, 31)
        txtDescription.TabIndex = 64
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(1040, 758)
        btnReset.Margin = New Padding(2)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(186, 35)
        btnReset.TabIndex = 63
        btnReset.Text = "Reset Amounts to 0"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(343, 764)
        btnSubmit.Margin = New Padding(2)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(111, 35)
        btnSubmit.TabIndex = 62
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label4.Location = New Point(1040, 490)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(205, 28)
        Label4.TabIndex = 52
        Label4.Text = "C u r r e n t    C a s h"
        Label4.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label3.Location = New Point(1040, 247)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(224, 28)
        Label3.TabIndex = 51
        Label3.Text = "B e g i n i n g    C a s h"
        Label3.UseWaitCursor = True
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(264, 721)
        txtAmount.Margin = New Padding(2)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(422, 31)
        txtAmount.TabIndex = 61
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Segoe UI", 10.0F)
        lblAmount.Location = New Point(138, 722)
        lblAmount.Margin = New Padding(2, 0, 2, 0)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(83, 28)
        lblAmount.TabIndex = 60
        lblAmount.Text = "Amount"
        ' 
        ' lblMerchantType
        ' 
        lblMerchantType.Font = New Font("Segoe UI", 10.0F)
        lblMerchantType.Location = New Point(138, 592)
        lblMerchantType.Margin = New Padding(2, 0, 2, 0)
        lblMerchantType.Name = "lblMerchantType"
        lblMerchantType.Size = New Size(98, 57)
        lblMerchantType.TabIndex = 59
        lblMerchantType.Text = "Merchant Type"
        lblMerchantType.Visible = False
        ' 
        ' cbMerchantDetail
        ' 
        cbMerchantDetail.FormattingEnabled = True
        cbMerchantDetail.Items.AddRange(New Object() {"NA", "Food", "Souvenier", "Clothes", "Other"})
        cbMerchantDetail.Location = New Point(264, 606)
        cbMerchantDetail.Margin = New Padding(2)
        cbMerchantDetail.Name = "cbMerchantDetail"
        cbMerchantDetail.Size = New Size(422, 33)
        cbMerchantDetail.TabIndex = 58
        cbMerchantDetail.Visible = False
        ' 
        ' cbRecipient
        ' 
        cbRecipient.FormattingEnabled = True
        cbRecipient.Items.AddRange(New Object() {"Guide", "Taxi", "Bus", "Hotel", "Excursion", "Merchant", "Currency", "Other"})
        cbRecipient.Location = New Point(264, 556)
        cbRecipient.Margin = New Padding(2)
        cbRecipient.Name = "cbRecipient"
        cbRecipient.Size = New Size(422, 33)
        cbRecipient.TabIndex = 57
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Font = New Font("Segoe UI", 10.0F)
        lblType.Location = New Point(138, 550)
        lblType.Margin = New Padding(2, 0, 2, 0)
        lblType.Name = "lblType"
        lblType.Size = New Size(53, 28)
        lblType.TabIndex = 56
        lblType.Text = "Type"
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(264, 452)
        txtLocation.Margin = New Padding(2)
        txtLocation.MaxLength = 50
        txtLocation.Multiline = True
        txtLocation.Name = "txtLocation"
        txtLocation.ScrollBars = ScrollBars.Vertical
        txtLocation.Size = New Size(422, 89)
        txtLocation.TabIndex = 55
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Font = New Font("Segoe UI", 10.0F)
        lblLocation.Location = New Point(138, 478)
        lblLocation.Margin = New Padding(2, 0, 2, 0)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(87, 28)
        lblLocation.TabIndex = 54
        lblLocation.Text = "Location"
        ' 
        ' DTPDatePicker
        ' 
        DTPDatePicker.Location = New Point(319, 272)
        DTPDatePicker.Margin = New Padding(2)
        DTPDatePicker.Name = "DTPDatePicker"
        DTPDatePicker.Size = New Size(333, 31)
        DTPDatePicker.TabIndex = 53
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(1229, 205)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 32)
        Label2.TabIndex = 50
        Label2.Text = "Foreign Cash"
        Label2.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(927, 205)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 32)
        Label1.TabIndex = 49
        Label1.Text = "US Cash"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitle.Location = New Point(319, 189)
        lblTitle.Margin = New Padding(2, 0, 2, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(268, 48)
        lblTitle.TabIndex = 48
        lblTitle.Text = "RA Travel Cash"
        ' 
        ' mnuStrip
        ' 
        mnuStrip.ImageScalingSize = New Size(24, 24)
        mnuStrip.Items.AddRange(New ToolStripItem() {MS_File, EditToolStripMenuItem, NewTripToolStripMenuItem, TransportationToolStripMenuItem, TravelerInfoToolStripMenuItem, AboutToolStripMenuItem})
        mnuStrip.Location = New Point(0, 0)
        mnuStrip.Name = "mnuStrip"
        mnuStrip.Size = New Size(1659, 33)
        mnuStrip.TabIndex = 72
        mnuStrip.Text = "MenuStrip1"
        ' 
        ' MS_File
        ' 
        MS_File.DropDownItems.AddRange(New ToolStripItem() {MS_File_Open, MS_File_Print, MS_File_Close})
        MS_File.Name = "MS_File"
        MS_File.Size = New Size(54, 29)
        MS_File.Text = "File"
        ' 
        ' MS_File_Open
        ' 
        MS_File_Open.DropDownItems.AddRange(New ToolStripItem() {MS_File_Open_Traveler1, MS_File_Open_Traveler2, BalanceToolStripMenuItem})
        MS_File_Open.Name = "MS_File_Open"
        MS_File_Open.Size = New Size(270, 34)
        MS_File_Open.Text = "Open "
        ' 
        ' MS_File_Open_Traveler1
        ' 
        MS_File_Open_Traveler1.Name = "MS_File_Open_Traveler1"
        MS_File_Open_Traveler1.Size = New Size(270, 34)
        MS_File_Open_Traveler1.Text = "RJM "
        ' 
        ' MS_File_Open_Traveler2
        ' 
        MS_File_Open_Traveler2.Name = "MS_File_Open_Traveler2"
        MS_File_Open_Traveler2.Size = New Size(270, 34)
        MS_File_Open_Traveler2.Text = "AED"
        ' 
        ' BalanceToolStripMenuItem
        ' 
        BalanceToolStripMenuItem.Name = "BalanceToolStripMenuItem"
        BalanceToolStripMenuItem.Size = New Size(270, 34)
        BalanceToolStripMenuItem.Text = "Balance"
        ' 
        ' MS_File_Print
        ' 
        MS_File_Print.DropDownItems.AddRange(New ToolStripItem() {MS_File_Print_Traveler1, MS_File_Print_Traveler2, BalanceToolStripMenuItem1})
        MS_File_Print.Name = "MS_File_Print"
        MS_File_Print.Size = New Size(270, 34)
        MS_File_Print.Text = "Print"
        ' 
        ' MS_File_Print_Traveler1
        ' 
        MS_File_Print_Traveler1.Name = "MS_File_Print_Traveler1"
        MS_File_Print_Traveler1.Size = New Size(173, 34)
        MS_File_Print_Traveler1.Text = "RJM"
        ' 
        ' MS_File_Print_Traveler2
        ' 
        MS_File_Print_Traveler2.Name = "MS_File_Print_Traveler2"
        MS_File_Print_Traveler2.Size = New Size(173, 34)
        MS_File_Print_Traveler2.Text = "AED"
        ' 
        ' BalanceToolStripMenuItem1
        ' 
        BalanceToolStripMenuItem1.Name = "BalanceToolStripMenuItem1"
        BalanceToolStripMenuItem1.Size = New Size(173, 34)
        BalanceToolStripMenuItem1.Text = "Balance"
        ' 
        ' MS_File_Close
        ' 
        MS_File_Close.Name = "MS_File_Close"
        MS_File_Close.ShortcutKeys = Keys.Alt Or Keys.C
        MS_File_Close.Size = New Size(270, 34)
        MS_File_Close.Text = "Close"
        MS_File_Close.ToolTipText = "Close the App"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddRJMUSCashToolStripMenuItem, AddAEDUSCashToolStripMenuItem, AddRJMForeignCashToolStripMenuItem, AddAEDForeignCashToolStripMenuItem, SettingsToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(58, 29)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' AddRJMUSCashToolStripMenuItem
        ' 
        AddRJMUSCashToolStripMenuItem.Name = "AddRJMUSCashToolStripMenuItem"
        AddRJMUSCashToolStripMenuItem.Size = New Size(295, 34)
        AddRJMUSCashToolStripMenuItem.Text = "Add RJM US Cash"
        ' 
        ' AddAEDUSCashToolStripMenuItem
        ' 
        AddAEDUSCashToolStripMenuItem.Name = "AddAEDUSCashToolStripMenuItem"
        AddAEDUSCashToolStripMenuItem.Size = New Size(295, 34)
        AddAEDUSCashToolStripMenuItem.Text = "Add AED US Cash"
        ' 
        ' AddRJMForeignCashToolStripMenuItem
        ' 
        AddRJMForeignCashToolStripMenuItem.Name = "AddRJMForeignCashToolStripMenuItem"
        AddRJMForeignCashToolStripMenuItem.Size = New Size(295, 34)
        AddRJMForeignCashToolStripMenuItem.Text = "Add RJM Foreign Cash"
        ' 
        ' AddAEDForeignCashToolStripMenuItem
        ' 
        AddAEDForeignCashToolStripMenuItem.Name = "AddAEDForeignCashToolStripMenuItem"
        AddAEDForeignCashToolStripMenuItem.Size = New Size(295, 34)
        AddAEDForeignCashToolStripMenuItem.Text = "Add AED Foreign Cash"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(295, 34)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' NewTripToolStripMenuItem
        ' 
        NewTripToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewTripToolStripMenuItem1, LoadTripToolStripMenuItem1, EditTripToolStripMenuItem})
        NewTripToolStripMenuItem.Name = "NewTripToolStripMenuItem"
        NewTripToolStripMenuItem.Size = New Size(56, 29)
        NewTripToolStripMenuItem.Text = "Trip"
        ' 
        ' NewTripToolStripMenuItem1
        ' 
        NewTripToolStripMenuItem1.Name = "NewTripToolStripMenuItem1"
        NewTripToolStripMenuItem1.Size = New Size(186, 34)
        NewTripToolStripMenuItem1.Text = "New Trip"
        ' 
        ' LoadTripToolStripMenuItem1
        ' 
        LoadTripToolStripMenuItem1.Name = "LoadTripToolStripMenuItem1"
        LoadTripToolStripMenuItem1.Size = New Size(186, 34)
        LoadTripToolStripMenuItem1.Text = "Load Trip"
        ' 
        ' EditTripToolStripMenuItem
        ' 
        EditTripToolStripMenuItem.Name = "EditTripToolStripMenuItem"
        EditTripToolStripMenuItem.Size = New Size(186, 34)
        EditTripToolStripMenuItem.Text = "Edit Trip"
        ' 
        ' TransportationToolStripMenuItem
        ' 
        TransportationToolStripMenuItem.Name = "TransportationToolStripMenuItem"
        TransportationToolStripMenuItem.Size = New Size(142, 29)
        TransportationToolStripMenuItem.Text = "Transportation"
        ' 
        ' TravelerInfoToolStripMenuItem
        ' 
        TravelerInfoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddTravelerToolStripMenuItem, EditTravelerToolStripMenuItem, DeleteTraverToolStripMenuItem})
        TravelerInfoToolStripMenuItem.Name = "TravelerInfoToolStripMenuItem"
        TravelerInfoToolStripMenuItem.Size = New Size(87, 29)
        TravelerInfoToolStripMenuItem.Text = "Traveler"
        ' 
        ' AddTravelerToolStripMenuItem
        ' 
        AddTravelerToolStripMenuItem.Name = "AddTravelerToolStripMenuItem"
        AddTravelerToolStripMenuItem.Size = New Size(270, 34)
        AddTravelerToolStripMenuItem.Text = "Add Traveler"
        ' 
        ' EditTravelerToolStripMenuItem
        ' 
        EditTravelerToolStripMenuItem.Name = "EditTravelerToolStripMenuItem"
        EditTravelerToolStripMenuItem.Size = New Size(270, 34)
        EditTravelerToolStripMenuItem.Text = "Edit Traveler"
        ' 
        ' DeleteTraverToolStripMenuItem
        ' 
        DeleteTraverToolStripMenuItem.Name = "DeleteTraverToolStripMenuItem"
        DeleteTraverToolStripMenuItem.Size = New Size(270, 34)
        DeleteTraverToolStripMenuItem.Text = "Delete Traver"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(78, 29)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' frmExpense
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1659, 878)
        Controls.Add(mnuStrip)
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
        Name = "frmExpense"
        Text = "frmExpense"
        scCurrentCash.Panel1.ResumeLayout(False)
        scCurrentCash.Panel1.PerformLayout()
        scCurrentCash.Panel2.ResumeLayout(False)
        scCurrentCash.Panel2.PerformLayout()
        CType(scCurrentCash, ComponentModel.ISupportInitialize).EndInit()
        scCurrentCash.ResumeLayout(False)
        scBeginingCash.Panel1.ResumeLayout(False)
        scBeginingCash.Panel1.PerformLayout()
        scBeginingCash.Panel2.ResumeLayout(False)
        scBeginingCash.Panel2.PerformLayout()
        CType(scBeginingCash, ComponentModel.ISupportInitialize).EndInit()
        scBeginingCash.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        mnuStrip.ResumeLayout(False)
        mnuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCreditTransaction As Button
    Friend WithEvents lblTripName As Label
    Friend WithEvents scCurrentCash As SplitContainer
    Friend WithEvents lblCCUSCashTraveler1 As Label
    Friend WithEvents lblCCUSCashTraveler2 As Label
    Friend WithEvents lblCurrentUSTraveler2 As Label
    Friend WithEvents lblCurrentUSTraveler1 As Label
    Friend WithEvents lblCurrentFrnTraveler2 As Label
    Friend WithEvents lblCCForeignCashTraveler2 As Label
    Friend WithEvents lblCurrentFRNTraveler1 As Label
    Friend WithEvents lblCCForeignCashTraveler1 As Label
    Friend WithEvents scBeginingCash As SplitContainer
    Friend WithEvents lblBCUSCashTraveler2 As Label
    Friend WithEvents lblBCUSCashTraveler1 As Label
    Friend WithEvents lblBeginUSTraveler2 As Label
    Friend WithEvents lblBeginUSTraveler1 As Label
    Friend WithEvents lblBeginFrnTraveler2 As Label
    Friend WithEvents lblBCForeignCashTraveler2 As Label
    Friend WithEvents lblBeginFrnrTaveler1 As Label
    Friend WithEvents lblBCForeignCashTraveler1 As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents rbtForeignCurrency As RadioButton
    Friend WithEvents rbtUSCurrency As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents rbtTraveler2 As RadioButton
    Friend WithEvents rbtTraveler1 As RadioButton
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblMerchantType As Label
    Friend WithEvents cbMerchantDetail As ComboBox
    Friend WithEvents cbRecipient As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents DTPDatePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents MS_File As ToolStripMenuItem
    Friend WithEvents MS_File_Open As ToolStripMenuItem
    Friend WithEvents MS_File_Open_Traveler1 As ToolStripMenuItem
    Friend WithEvents MS_File_Open_Traveler2 As ToolStripMenuItem
    Friend WithEvents BalanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MS_File_Print As ToolStripMenuItem
    Friend WithEvents MS_File_Print_Traveler1 As ToolStripMenuItem
    Friend WithEvents MS_File_Print_Traveler2 As ToolStripMenuItem
    Friend WithEvents BalanceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MS_File_Close As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRJMUSCashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAEDUSCashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRJMForeignCashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAEDForeignCashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTripToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTripToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoadTripToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditTripToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransportationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TravelerInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTravelerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditTravelerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteTraverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
