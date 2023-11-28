Public Class frmLoanCalculator
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you wish to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Text = ""
        txtMonths.Text = ""
        txtVehicleCost.Text = ""
        radNew.Checked = False
        radUsed.Checked = False
        lstInterestAndPayments.Items.Clear()
        lblAnInterestRate.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstInterestAndPayments.Items.Clear()
        If Not txtVehicleCost.Text = "" AndAlso Not txtMonths.Text = "" AndAlso Not txtMonths.Text = "" Then

            Dim vehicleCost As Double = CDbl(txtVehicleCost.Text)
            Dim downPayment As Double = CDbl(txtAmount.Text)
            Dim months As Integer = CInt(txtMonths.Text)
            Dim loan As Double = vehicleCost - downPayment
            Dim interest As Double
            Dim principal As Double
            Dim interestRate As Double
            If radNew.Checked Then
                interestRate = 0.05
            ElseIf radUsed.Checked Then
                interestRate = 0.08
            End If
            Dim monthlyPayment = Pmt(interestRate / 12, months, -loan)
            Dim count As Double
            For count = 1 To months
                interest = IPmt(interestRate / 12, count, months, -loan)
                principal = PPmt(interestRate / 12, count, months, -loan)
                lstInterestAndPayments.Items.Add($"Month {count:00}:  Payment = {monthlyPayment:F2},  interest = {interest:F2},  principal = {principal:F2}")
            Next
            lblAnInterestRate.Text = $"{interestRate * 100:F2}%"
        End If
    End Sub
End Class