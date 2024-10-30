<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrandTotalRentalsLabel = New System.Windows.Forms.Label()
        Me.GrandTotalMilesLabel = New System.Windows.Forms.Label()
        Me.GrandTotalReceiptsLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Summary for ALL Car Rentals"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Number of Rentals:"
        '
        'GrandTotalRentalsLabel
        '
        Me.GrandTotalRentalsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrandTotalRentalsLabel.Location = New System.Drawing.Point(227, 94)
        Me.GrandTotalRentalsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GrandTotalRentalsLabel.Name = "GrandTotalRentalsLabel"
        Me.GrandTotalRentalsLabel.Size = New System.Drawing.Size(133, 28)
        Me.GrandTotalRentalsLabel.TabIndex = 2
        '
        'GrandTotalMilesLabel
        '
        Me.GrandTotalMilesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrandTotalMilesLabel.Location = New System.Drawing.Point(227, 146)
        Me.GrandTotalMilesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GrandTotalMilesLabel.Name = "GrandTotalMilesLabel"
        Me.GrandTotalMilesLabel.Size = New System.Drawing.Size(133, 28)
        Me.GrandTotalMilesLabel.TabIndex = 3
        '
        'GrandTotalReceiptsLabel
        '
        Me.GrandTotalReceiptsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrandTotalReceiptsLabel.Location = New System.Drawing.Point(227, 201)
        Me.GrandTotalReceiptsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GrandTotalReceiptsLabel.Name = "GrandTotalReceiptsLabel"
        Me.GrandTotalReceiptsLabel.Size = New System.Drawing.Size(133, 28)
        Me.GrandTotalReceiptsLabel.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Mileage All Vehicles:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 213)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Receipts All Rentals"
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(183, 262)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 322)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GrandTotalReceiptsLabel)
        Me.Controls.Add(Me.GrandTotalMilesLabel)
        Me.Controls.Add(Me.GrandTotalRentalsLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrandTotalRentalsLabel As System.Windows.Forms.Label
    Friend WithEvents GrandTotalMilesLabel As System.Windows.Forms.Label
    Friend WithEvents GrandTotalReceiptsLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
