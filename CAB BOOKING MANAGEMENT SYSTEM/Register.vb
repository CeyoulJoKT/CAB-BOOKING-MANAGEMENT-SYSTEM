Imports System.Data
Imports System.Data.SqlClient

Public Class Register
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub _Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim constring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"

        con = New SqlConnection(constring)
        Label1.Visible = False
        If (txtname.Text = "" Or txtaddress.Text = "" Or txtphone.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Or Txtadhr.Text = "") Then
            Label1.Visible = True
            MsgBox("Please enter all fields", MessageBoxIcon.Warning)
        End If
        If txtphone.Text.Length > 10 Or txtphone.Text.Length < 10 Then
            MsgBox("Enter a valid phone no", MessageBoxIcon.Warning)
            Label3.Visible = True

        ElseIf Txtadhr.Text.Length > 12 Or Txtadhr.Text.Length < 12 Then
            MsgBox("Please enter valid adhaar number")

        Else
            Try
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [dbo].[userreg]
           ([name]
           ,[address]
           ,[phone]
           ,[username]
           ,[password],[addhar])
VALUES(@name,@address,@phone,@username,@password,@addhar)"
                Dim paramname As New SqlParameter("@name", SqlDbType.VarChar, 50)
                paramname.Value = txtname.Text
                Dim paramaddress As New SqlParameter("@address", SqlDbType.VarChar, 50)
                paramaddress.Value = txtaddress.Text
                Dim paramphone As New SqlParameter("@phone", SqlDbType.VarChar, 50)
                paramphone.Value = txtphone.Text
                Dim paramusername As New SqlParameter("@username", SqlDbType.VarChar, 50)
                paramusername.Value = txtuser.Text
                Dim parampassword As New SqlParameter("@password", SqlDbType.VarChar, 50)
                parampassword.Value = txtpass.Text
                Dim paramaddhar As New SqlParameter("@addhar", SqlDbType.VarChar, 50)
                paramaddhar.Value = Txtadhr.Text

                cmd.Parameters.Add(paramname)
                cmd.Parameters.Add(paramaddress)
                cmd.Parameters.Add(paramphone)
                cmd.Parameters.Add(paramusername)
                cmd.Parameters.Add(parampassword)
                cmd.Parameters.Add(paramaddhar)


                Dim da As New SqlDataAdapter
                da.InsertCommand = cmd
                da.InsertCommand.ExecuteNonQuery()
                Label1.Visible = False
                MessageBox.Show("Registered succesfully")
                MsgBox("Now Login with new username credentials", MessageBoxIcon.Information)
                Dim userlogin As New UserLogin()
                Me.Hide()
                userlogin.Show()
            Catch ex As Exception
                MsgBox("Username Aldreay Exist", MessageBoxIcon.Information)
            End Try
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtname.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        txtaddress.Text = ""
        txtphone.Text = ""
        Label1.Visible = False
        Txtadhr.Text=""

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
        
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Only numbers Allowed", MessageBoxIcon.Information)
            txtphone.Text = ""
        End If
    End Sub

    Private Sub Txtadhr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtadhr.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Only numbers Allowed", MessageBoxIcon.Information)
            Txtadhr.Text = ""
        End If
    End Sub
End Class