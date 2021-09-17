Public Class MatchingNetworkForm
    Private Sub MatchingNetworkForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworksComboBox.Items.Add("L Network")
        NetworksComboBox.Items.Add("Double L Network")
        NetworksComboBox.Items.Add("Pi Network")
        NetworksComboBox.Items.Add("T Network")
        SourceImpedanceTextBox.Visible = False
        LoadImpedanceTextBox.Visible = False
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Dim networkType As String = NetworksComboBox.SelectedItem
        Dim sourceResistance As Decimal = NumberValidation(SourceResistanceTextBox.Text)
        Dim sourceImpedance As Decimal = NumberValidation(SourceImpedanceTextBox.Text)
        Dim loadResistance As Decimal = NumberValidation(LoadResistanceTextBox.Text)
        Dim loadImpedance As Decimal = NumberValidation(SourceImpedanceTextBox.Text)
    End Sub

    Private Sub ComplexLoadAndSourceCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ComplexLoadAndSourceCheckBox.CheckedChanged
        LoadImpedanceTextBox.Visible = True
        SourceImpedanceTextBox.Visible = True
    End Sub

    Function NumberValidation(number As String)
        Dim trueNumber As Decimal
        Try
            trueNumber = CDec(number)
        Catch ex As Exception

        End Try
        Return (trueNumber)
    End Function
End Class
