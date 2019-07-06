Public Class A_Loading

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            koneksi()
            f_login.Show()
            Me.Hide()
        End If
        Label1.Text = ProgressBar1.Value & "%"
    End Sub

    Private Sub A_Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class