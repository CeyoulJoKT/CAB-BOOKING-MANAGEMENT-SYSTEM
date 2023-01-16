Public Class HomePage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim booking As New Booking()

        booking.Show()
        Me.Hide()


    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim adminlogin As New Adminlogin
        adminlogin.Show()
        Me.Hide()
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Need to login with admin privelages", MessageBoxIcon.Warning, MessageBoxButtons.OK)
        Me.Show()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim feedback As New Feedback
        feedback.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim welcome_form As New Welcome_Form
        welcome_form.Show()
        Me.Hide()
    End Sub
End Class