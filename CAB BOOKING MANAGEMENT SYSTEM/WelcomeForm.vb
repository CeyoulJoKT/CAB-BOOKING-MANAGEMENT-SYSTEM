Public Class Welcome_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aboutus As New Aboutus
        Me.Hide()
        aboutus.Show()
    End Sub

    Private Sub txtexit_Click(sender As Object, e As EventArgs) Handles txtexit.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(" Ceyoul Joseph Kariaty 19CS4A1003 
                           Christin P Mathew 19CS4A1004", MessageBoxIcon.Information)

    End Sub

    Private Sub txtnext_Click(sender As Object, e As EventArgs) Handles txtnext.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim homepage As New HomePage()
        Me.Hide()
        homepage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim userlogin As New UserLogin
        Me.Hide()
        userlogin.Show()
    End Sub
End Class