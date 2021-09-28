Option Explicit On
Option Strict On
Imports System.Math
Public Class MatchingNetworkForm
    Private Sub MatchingNetworkForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworksComboBox.Items.Add("L Network")
        NetworksComboBox.Items.Add("Double L Network")
        NetworksComboBox.Items.Add("Pi Network")
        NetworksComboBox.Items.Add("T Network")
        SourceImpedanceComboBox.Items.Add("+J")
        SourceImpedanceComboBox.Items.Add("-J")
        LoadImpedanceComboBox.Items.Add("+J")
        LoadImpedanceComboBox.Items.Add("-J")
        NetworksComboBox.SelectedIndex = 0
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Dim networkType As String = CStr(NetworksComboBox.SelectedItem)
        Select Case networkType
            Case "L Network"
                LNetwork()
            Case "Double L Network"

            Case "Pi Network"

            Case "T Network"

            Case Else

        End Select
        Dim sourceResistance As Decimal = NumberValidation(SourceResistanceTextBox.Text)
        Dim sourceImpedance As Decimal = NumberValidation(SourceImpedanceTextBox.Text)
        Dim loadResistance As Decimal = NumberValidation(LoadResistanceTextBox.Text)
        Dim loadImpedance As Decimal = NumberValidation(SourceImpedanceTextBox.Text)
    End Sub

    Function NumberValidation(number As String) As Decimal
        Dim trueNumber As Decimal
        Try
            trueNumber = CDec(number)
        Catch ex As Exception

        End Try
        Return (trueNumber)
    End Function
    Sub LNetwork()
        Dim sourceResistance As Decimal = NumberValidation(SourceResistanceTextBox.Text)
        Dim sourceImpedance As Decimal = NumberValidation(SourceImpedanceTextBox.Text)
        Dim loadResistance As Decimal = NumberValidation(LoadResistanceTextBox.Text)
        Dim loadImpedance As Decimal = NumberValidation(LoadImpedanceTextBox.Text)
        Dim rHigh As Decimal
        Dim rLow As Decimal
        Dim q As Decimal
        Dim xs As Decimal
        Dim xp As Decimal
        Dim seriesComponent As String
        Dim parallelComponent As String
        If sourceResistance > loadResistance Then
            rHigh = sourceResistance
            rLow = loadResistance
        Else
            rHigh = loadResistance
            rLow = sourceResistance
        End If
        q = CDec(Sqrt((rHigh / rLow) - 1))
        xs = q * rLow
        xp = rHigh / q

    End Sub

End Class
