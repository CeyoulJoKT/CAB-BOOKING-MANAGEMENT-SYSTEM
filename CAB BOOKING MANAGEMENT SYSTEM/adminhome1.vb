Public Class adminhome1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim driverdetails As New Driverdetails
        driverdetails.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adminhomepage As New admin_home_page
        adminhomepage.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        Dim search As New search
        search.Show()
        Me.Hide()

    End Sub
End Class
