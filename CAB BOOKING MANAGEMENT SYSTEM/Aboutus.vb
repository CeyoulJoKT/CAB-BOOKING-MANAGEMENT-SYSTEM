Public Class Aboutus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim welcome_form As New Welcome_Form
        welcome_form.Show()
        Me.Hide()
    End Sub
End Class