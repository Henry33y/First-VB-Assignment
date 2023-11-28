Public Class frmLogin
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you wish to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim userName As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        If userName = "Henry" AndAlso password = "1234567" Then
            frmLink.Show()
            Me.Close()
        Else
            MsgBox("Incorrect Credentials!")
        End If
    End Sub

End Class