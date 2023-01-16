Public Class Adminlogin

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "123" And TextBox2.Text = "123" Then
            MsgBox("Login is successfull", MessageBoxIcon.Information, MessageBoxButtons.OKCancel)
            Dim adminhome1 As New adminhome1
            Me.Hide()
            adminhome1.Show()
            Label4.Visible = False
        Else
            Label4.Visible = True
            MsgBox("Invalid username or password", MessageBoxIcon.Information, MessageBoxButtons.RetryCancel)

        End If

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form1 As New Form1
        form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label4.Visible = False
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
    End Sub
End Class