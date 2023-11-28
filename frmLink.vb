Public Class frmLink
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you wish to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnGym_Click(sender As Object, e As EventArgs) Handles btnGym.Click
        frmGymMembership.Show()
    End Sub

    Private Sub btnLoanCalc_Click(sender As Object, e As EventArgs) Handles btnLoanCalc.Click
        frmLoanCalculator.Show()
    End Sub
End Class