Public Class frmGymMembership
    'Declare a variable to store the value of base fee
    Dim baseFee As Integer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Not (txtMonths.Text = "") Then
            If radAdult.Checked Then
                baseFee = 40
            ElseIf radChild.Checked Then
                baseFee = 20
            ElseIf radStudent.Checked Then
                baseFee = 25
            ElseIf radSenior.Checked Then
                baseFee = 30
            End If

            If chkYoga.Checked Then
                baseFee += 10
            End If
            If chkKarate.Checked Then
                baseFee += 30
            End If
            If chkTrainer.Checked Then
                baseFee += 50
            End If

            lblMonthlyFee.Text = baseFee
            lblTotal.Text = baseFee * txtMonths.Text
        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you wish to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            splash.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radAdult.Checked = False
        radChild.Checked = False
        radStudent.Checked = False
        radSenior.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False
        chkYoga.Checked = False
        txtMonths.Text = String.Empty
        lblMonthlyFee.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmLoanCalculator.Show()
    End Sub

End Class
