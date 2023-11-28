Public Class splash
    Dim progress As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progress += 1
        progBar.Value = progress
        lblProgPercent.Text = $"{progress}%"
        If progress = 50 Then
            lblLoadingMsg.Text = "Getting ready"
        ElseIf progress = 80 Then
            lblLoadingMsg.Text = "Almost Done"
        ElseIf progress = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            frmLogin.Show()
        End If

    End Sub
End Class