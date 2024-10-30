<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentTextBox = New System.Windows.Forms.TextBox()
        Me.PreviousTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.ChargeLabel = New System.Windows.Forms.Label()
        Me.GalUsedLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CurrentTextBox)
        Me.GroupBox1.Controls.Add(Me.PreviousTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(363, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cu&rrent reading:"
        '
        'CurrentTextBox
        '
        Me.CurrentTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CurrentTextBox.Location = New System.Drawing.Point(208, 28)
        Me.CurrentTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CurrentTextBox.Name = "CurrentTextBox"
        Me.CurrentTextBox.Size = New System.Drawing.Size(104, 22)
        Me.CurrentTextBox.TabIndex = 1
        '
        'PreviousTextBox
        '
        Me.PreviousTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PreviousTextBox.Location = New System.Drawing.Point(208, 74)
        Me.PreviousTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PreviousTextBox.Name = "PreviousTextBox"
        Me.PreviousTextBox.Size = New System.Drawing.Size(104, 22)
        Me.PreviousTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Previous reading:"
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(222, 294)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(115, 38)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        '
        'CalcButton
        '
        Me.CalcButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcButton.Location = New System.Drawing.Point(296, 198)
        Me.CalcButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(115, 38)
        Me.CalcButton.TabIndex = 1
        Me.CalcButton.Text = "&Calculate"
        '
        'ChargeLabel
        '
        Me.ChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChargeLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargeLabel.Location = New System.Drawing.Point(179, 251)
        Me.ChargeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChargeLabel.Name = "ChargeLabel"
        Me.ChargeLabel.Size = New System.Drawing.Size(103, 33)
        Me.ChargeLabel.TabIndex = 7
        Me.ChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GalUsedLabel
        '
        Me.GalUsedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GalUsedLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GalUsedLabel.Location = New System.Drawing.Point(179, 203)
        Me.GalUsedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GalUsedLabel.Name = "GalUsedLabel"
        Me.GalUsedLabel.Size = New System.Drawing.Size(103, 33)
        Me.GalUsedLabel.TabIndex = 5
        Me.GalUsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 251)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total charge:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 203)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gallons used:"
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(296, 248)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(115, 38)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "C&lear"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 343)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.ChargeLabel)
        Me.Controls.Add(Me.GalUsedLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Rhodes State Water Bill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CurrentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreviousTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents ChargeLabel As System.Windows.Forms.Label
    Friend WithEvents GalUsedLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button

End Class
