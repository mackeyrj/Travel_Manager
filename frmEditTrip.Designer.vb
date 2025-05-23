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
        SuspendLayout()
        ' 
        ' cbTripName
        ' 
        cbTripName.FormattingEnabled = True
        cbTripName.Location = New Point(276, 105)
        cbTripName.Name = "cbTripName"
        cbTripName.Size = New Size(605, 49)
        cbTripName.TabIndex = 0
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(95, 662)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(188, 58)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' txtTripDate
        ' 
        txtTripDate.Location = New Point(276, 229)
        txtTripDate.Name = "txtTripDate"
        txtTripDate.Size = New Size(605, 47)
        txtTripDate.TabIndex = 3
        ' 
        ' txtTripDestination
        ' 
        txtTripDestination.Location = New Point(276, 347)
        txtTripDestination.Name = "txtTripDestination"
        txtTripDestination.Size = New Size(605, 47)
        txtTripDestination.TabIndex = 4
        ' 
        ' txtTripDetails
        ' 
        txtTripDetails.Location = New Point(276, 464)
        txtTripDetails.Multiline = True
        txtTripDetails.Name = "txtTripDetails"
        txtTripDetails.Size = New Size(605, 155)
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
        Label3.Location = New Point(33, 353)
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
        btnCancel.Location = New Point(382, 662)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(188, 58)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Close"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteTrip
        ' 
        btnDeleteTrip.Location = New Point(731, 678)
        btnDeleteTrip.Name = "btnDeleteTrip"
        btnDeleteTrip.Size = New Size(188, 58)
        btnDeleteTrip.TabIndex = 11
        btnDeleteTrip.Text = "Delete"
        btnDeleteTrip.UseVisualStyleBackColor = True
        ' 
        ' frmEditTrip
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1081, 788)
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
End Class
