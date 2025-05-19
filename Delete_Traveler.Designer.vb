<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete_Traveler
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
        lblDeleteTraveler = New Label()
        cbTravelers = New ComboBox()
        btnDeleteTraveler = New Button()
        SuspendLayout()
        ' 
        ' lblDeleteTraveler
        ' 
        lblDeleteTraveler.AutoSize = True
        lblDeleteTraveler.Location = New Point(64, 30)
        lblDeleteTraveler.Name = "lblDeleteTraveler"
        lblDeleteTraveler.Size = New Size(126, 25)
        lblDeleteTraveler.TabIndex = 0
        lblDeleteTraveler.Text = "Delete Traveler"
        ' 
        ' cbTravelers
        ' 
        cbTravelers.FormattingEnabled = True
        cbTravelers.Location = New Point(159, 85)
        cbTravelers.Name = "cbTravelers"
        cbTravelers.Size = New Size(182, 33)
        cbTravelers.TabIndex = 1
        ' 
        ' btnDeleteTraveler
        ' 
        btnDeleteTraveler.Location = New Point(175, 171)
        btnDeleteTraveler.Name = "btnDeleteTraveler"
        btnDeleteTraveler.Size = New Size(112, 34)
        btnDeleteTraveler.TabIndex = 2
        btnDeleteTraveler.Text = "Delete Traveler"
        btnDeleteTraveler.UseVisualStyleBackColor = True
        ' 
        ' Delete_Traveler
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(469, 330)
        Controls.Add(btnDeleteTraveler)
        Controls.Add(cbTravelers)
        Controls.Add(lblDeleteTraveler)
        Name = "Delete_Traveler"
        Text = "Delete_Traveler"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDeleteTraveler As Label
    Friend WithEvents cbTravelers As ComboBox
    Friend WithEvents btnDeleteTraveler As Button
End Class
