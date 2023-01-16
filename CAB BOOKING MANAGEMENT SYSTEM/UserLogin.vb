
Imports System.Data
Imports System.Data.SqlClient

Public Class UserLogin

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Txtpass.UseSystemPasswordChar = False
        Else
            Txtpass.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        Label1.Visible = False


        Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from userreg where username= '" + txtuser.Text + "'and password = '" + Txtpass.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("login was successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim welcome_form As New Welcome_Form()
            welcome_form.Show()
            Me.Hide()

        Else
            Label1.Visible = True
            MessageBox.Show("login was Unsuccessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        txtuser.Text = ""
        Txtpass.Text = ""
        Label1.Visible = False
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtpass.UseSystemPasswordChar = True
        Label1.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class