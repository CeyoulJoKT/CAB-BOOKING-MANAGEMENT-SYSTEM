Public Class Splash
    Private Sub timer1_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            Label1.Text = "Initialising system..."

        ElseIf ProgressBar1.Value <= 30 Then
            Label1.Text = "Loading all components..."

        ElseIf ProgressBar1.Value <= 50 Then
            Label1.Text = "Inte grating Database..."

        ElseIf ProgressBar1.Value <= 70 Then
            Label1.Text = "Please Wait..."

        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "Welcome to CAbmee Booking..."


            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                Dim form1 As New Form1
                form1.Show()

            End If
        End If

    End Sub
End Class