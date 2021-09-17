<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatchingNetworkForm
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
        Me.NetworksComboBox = New System.Windows.Forms.ComboBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.LoadImpedanceTextBox = New System.Windows.Forms.TextBox()
        Me.LoadResistanceTextBox = New System.Windows.Forms.TextBox()
        Me.SourceImpedanceTextBox = New System.Windows.Forms.TextBox()
        Me.SourceResistanceTextBox = New System.Windows.Forms.TextBox()
        Me.ComplexLoadAndSourceCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'NetworksComboBox
        '
        Me.NetworksComboBox.FormattingEnabled = True
        Me.NetworksComboBox.Location = New System.Drawing.Point(12, 62)
        Me.NetworksComboBox.Name = "NetworksComboBox"
        Me.NetworksComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NetworksComboBox.TabIndex = 0
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(669, 373)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(119, 65)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Generate Matching Network"
        Me.Start.UseVisualStyleBackColor = True
        '
        'LoadImpedanceTextBox
        '
        Me.LoadImpedanceTextBox.Location = New System.Drawing.Point(519, 105)
        Me.LoadImpedanceTextBox.Name = "LoadImpedanceTextBox"
        Me.LoadImpedanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LoadImpedanceTextBox.TabIndex = 2
        '
        'LoadResistanceTextBox
        '
        Me.LoadResistanceTextBox.Location = New System.Drawing.Point(519, 62)
        Me.LoadResistanceTextBox.Name = "LoadResistanceTextBox"
        Me.LoadResistanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LoadResistanceTextBox.TabIndex = 3
        '
        'SourceImpedanceTextBox
        '
        Me.SourceImpedanceTextBox.Location = New System.Drawing.Point(243, 105)
        Me.SourceImpedanceTextBox.Name = "SourceImpedanceTextBox"
        Me.SourceImpedanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SourceImpedanceTextBox.TabIndex = 4
        '
        'SourceResistanceTextBox
        '
        Me.SourceResistanceTextBox.Location = New System.Drawing.Point(243, 63)
        Me.SourceResistanceTextBox.Name = "SourceResistanceTextBox"
        Me.SourceResistanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SourceResistanceTextBox.TabIndex = 5
        '
        'ComplexLoadAndSourceCheckBox
        '
        Me.ComplexLoadAndSourceCheckBox.AutoSize = True
        Me.ComplexLoadAndSourceCheckBox.Location = New System.Drawing.Point(12, 28)
        Me.ComplexLoadAndSourceCheckBox.Name = "ComplexLoadAndSourceCheckBox"
        Me.ComplexLoadAndSourceCheckBox.Size = New System.Drawing.Size(142, 17)
        Me.ComplexLoadAndSourceCheckBox.TabIndex = 6
        Me.ComplexLoadAndSourceCheckBox.Text = "Complex Load or Source"
        Me.ComplexLoadAndSourceCheckBox.UseVisualStyleBackColor = True
        '
        'MatchingNetworkForm
        '
        Me.AcceptButton = Me.Start
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComplexLoadAndSourceCheckBox)
        Me.Controls.Add(Me.SourceResistanceTextBox)
        Me.Controls.Add(Me.SourceImpedanceTextBox)
        Me.Controls.Add(Me.LoadResistanceTextBox)
        Me.Controls.Add(Me.LoadImpedanceTextBox)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.NetworksComboBox)
        Me.Name = "MatchingNetworkForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NetworksComboBox As ComboBox
    Friend WithEvents Start As Button
    Friend WithEvents LoadImpedanceTextBox As TextBox
    Friend WithEvents LoadResistanceTextBox As TextBox
    Friend WithEvents SourceImpedanceTextBox As TextBox
    Friend WithEvents SourceResistanceTextBox As TextBox
    Friend WithEvents ComplexLoadAndSourceCheckBox As CheckBox
End Class
