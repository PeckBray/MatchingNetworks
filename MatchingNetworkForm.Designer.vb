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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LoadImpedanceComboBox = New System.Windows.Forms.ComboBox()
        Me.SourceImpedanceComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'NetworksComboBox
        '
        Me.NetworksComboBox.FormattingEnabled = True
        Me.NetworksComboBox.Location = New System.Drawing.Point(12, 64)
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
        Me.LoadImpedanceTextBox.Text = "0"
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
        Me.SourceImpedanceTextBox.Text = "0"
        '
        'SourceResistanceTextBox
        '
        Me.SourceResistanceTextBox.Location = New System.Drawing.Point(243, 63)
        Me.SourceResistanceTextBox.Name = "SourceResistanceTextBox"
        Me.SourceResistanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SourceResistanceTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Matching Network Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Source Resistance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(516, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Load Resistance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Source Impedance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(516, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Load Impedance"
        '
        'LoadImpedanceComboBox
        '
        Me.LoadImpedanceComboBox.FormattingEnabled = True
        Me.LoadImpedanceComboBox.Location = New System.Drawing.Point(465, 104)
        Me.LoadImpedanceComboBox.Name = "LoadImpedanceComboBox"
        Me.LoadImpedanceComboBox.Size = New System.Drawing.Size(48, 21)
        Me.LoadImpedanceComboBox.TabIndex = 12
        '
        'SourceImpedanceComboBox
        '
        Me.SourceImpedanceComboBox.FormattingEnabled = True
        Me.SourceImpedanceComboBox.Location = New System.Drawing.Point(187, 104)
        Me.SourceImpedanceComboBox.Name = "SourceImpedanceComboBox"
        Me.SourceImpedanceComboBox.Size = New System.Drawing.Size(50, 21)
        Me.SourceImpedanceComboBox.TabIndex = 13
        '
        'MatchingNetworkForm
        '
        Me.AcceptButton = Me.Start
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SourceImpedanceComboBox)
        Me.Controls.Add(Me.LoadImpedanceComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LoadImpedanceComboBox As ComboBox
    Friend WithEvents SourceImpedanceComboBox As ComboBox
End Class
