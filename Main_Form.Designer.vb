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
        btnTrackExpenses = New Button()
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
        mnuStrip = New MenuStrip()
        btnCreateTrip = New Button()
        mnuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnTrackExpenses
        ' 
        btnTrackExpenses.Location = New Point(362, 78)
        btnTrackExpenses.Name = "btnTrackExpenses"
        btnTrackExpenses.Size = New Size(304, 58)
        btnTrackExpenses.TabIndex = 48
        btnTrackExpenses.Text = "Track Expenses"
        btnTrackExpenses.UseVisualStyleBackColor = True
        ' 
        ' MS_File
        ' 
        MS_File.DropDownItems.AddRange(New ToolStripItem() {MS_File_Open, MS_File_Print, MS_File_Close})
        MS_File.Name = "MS_File"
        MS_File.Size = New Size(87, 48)
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
        EditToolStripMenuItem.Size = New Size(92, 48)
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
        NewTripToolStripMenuItem.Size = New Size(90, 48)
        NewTripToolStripMenuItem.Text = "Trip"
        ' 
        ' NewTripToolStripMenuItem1
        ' 
        NewTripToolStripMenuItem1.Name = "NewTripToolStripMenuItem1"
        NewTripToolStripMenuItem1.Size = New Size(448, 54)
        NewTripToolStripMenuItem1.Text = "New Trip"
        ' 
        ' LoadTripToolStripMenuItem1
        ' 
        LoadTripToolStripMenuItem1.Name = "LoadTripToolStripMenuItem1"
        LoadTripToolStripMenuItem1.Size = New Size(448, 54)
        LoadTripToolStripMenuItem1.Text = "Load Trip"
        ' 
        ' EditTripToolStripMenuItem
        ' 
        EditTripToolStripMenuItem.Name = "EditTripToolStripMenuItem"
        EditTripToolStripMenuItem.Size = New Size(448, 54)
        EditTripToolStripMenuItem.Text = "Edit Trip"
        ' 
        ' TransportationToolStripMenuItem
        ' 
        TransportationToolStripMenuItem.Name = "TransportationToolStripMenuItem"
        TransportationToolStripMenuItem.Size = New Size(233, 48)
        TransportationToolStripMenuItem.Text = "Transportation"
        ' 
        ' TravelerInfoToolStripMenuItem
        ' 
        TravelerInfoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddTravelerToolStripMenuItem, EditTravelerToolStripMenuItem, DeleteTraverToolStripMenuItem})
        TravelerInfoToolStripMenuItem.Name = "TravelerInfoToolStripMenuItem"
        TravelerInfoToolStripMenuItem.Size = New Size(143, 48)
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
        AboutToolStripMenuItem.Size = New Size(124, 48)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' mnuStrip
        ' 
        mnuStrip.ImageScalingSize = New Size(24, 24)
        mnuStrip.Items.AddRange(New ToolStripItem() {MS_File, EditToolStripMenuItem, NewTripToolStripMenuItem, TransportationToolStripMenuItem, TravelerInfoToolStripMenuItem, AboutToolStripMenuItem})
        mnuStrip.Location = New Point(0, 0)
        mnuStrip.Name = "mnuStrip"
        mnuStrip.Padding = New Padding(10, 3, 0, 3)
        mnuStrip.Size = New Size(913, 54)
        mnuStrip.TabIndex = 43
        mnuStrip.Text = "MenuStrip1"
        ' 
        ' btnCreateTrip
        ' 
        btnCreateTrip.Location = New Point(24, 78)
        btnCreateTrip.Name = "btnCreateTrip"
        btnCreateTrip.Size = New Size(286, 58)
        btnCreateTrip.TabIndex = 49
        btnCreateTrip.Text = "New Trip"
        btnCreateTrip.UseVisualStyleBackColor = True
        ' 
        ' Main_Form
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(913, 179)
        Controls.Add(btnCreateTrip)
        Controls.Add(btnTrackExpenses)
        Controls.Add(mnuStrip)
        MainMenuStrip = mnuStrip
        Margin = New Padding(5)
        Name = "Main_Form"
        Text = "Travel Manager"
        mnuStrip.ResumeLayout(False)
        mnuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnTrackExpenses As Button
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
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents btnCreateTrip As Button

End Class

