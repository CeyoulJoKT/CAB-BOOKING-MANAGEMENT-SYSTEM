Imports System.Data.SqlClient

Public Class Driverdetails
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Private Sub txtinsert_Click(sender As Object, e As EventArgs) Handles txtinsert.Click
        Label10.Visible = False
        If txtid.Text = "" Or Txtphno.Text = "" Or Txtname.Text = "" Or Txtemail.Text = "" Or Txtcarnum.Text = "" Or Cmdmodel1.Text = "" Or RichTextBox1.Text = "" Or Txtdl.Text = "" Then
            MsgBox("fill all the blank space ", MessageBoxIcon.Warning, MessageBoxButtons.OK)
        ElseIf Txtemail.Text.IndexOf("@") = -1 Then
            MsgBox("invalid email")
        ElseIf Txtemail.Text.IndexOf(".com") = -1 Then
            MsgBox("invalid email")
        ElseIf Txtphno.Text.Length > 10 Or Txtphno.Text.Length < 10 Then
            MsgBox("enter the valid phone no")
        ElseIf Txtemail.Text.Length < 10 Then
            MsgBox("invalid email")
        ElseIf Txtdl.Text.Length < 13 Or Txtdl.Text.Length > 13 Then
            Label10.Visible = True



        Else
            Try
                Dim Con = New SqlConnection("Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
                Con.Open()
                Dim query = "insert into driverdat values('" & txtid.Text & "','" & Txtname.Text & "','" & Txtphno.Text & "','" & Txtemail.Text & "','" & RichTextBox1.Text & "','" & Cmdmodel1.Text & "','" & Txtcarnum.Text & "','" & Txtdl.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Data inserted ")
                Con.Close()
                txtid.Text() = ""
                Txtname.Text() = ""
                Txtphno.Text() = ""
                Txtemail.Text() = ""
                Txtcarnum.Text() = ""
                Cmdmodel1.Text = ""
                Txtdl.Text = ""
                RichTextBox1.Text() = Nothing
            Catch ex As Exception
                MsgBox("Driver ID Aldready Exist")

            End Try


        End If

    End Sub

    '    Dim constring As String = "data source=laptop-ad585f6a\sqlexpress;initial catalog=userreg;integrated security=True"
    '    con = New SqlConnection(constring)
    '    Try
    '        con.Open()
    '        cmd.Connection = con
    '        cmd.CommandText = "insert into [dbo].[driverdata](driverid,drivername,phoneno,email,address,carmodel,carno,driverlicenseno)
    'values(@driverid,@drivername,@phoneno,@email,@address,@carmodel,@carno,@driverlicenseno)"

    '        Dim paramdriverid As New SqlParameter("@driverid", SqlDbType.Int)
    '        paramdriverid.Value = txtid.Text
    '        Dim paramdrivername As New SqlParameter("@drivername", SqlDbType.VarChar, 50)
    '        paramdrivername.Value = Txtname.Text
    '        Dim paramphoneno As New SqlParameter("@phoneno", SqlDbType.VarChar, 50)
    '        paramphoneno.Value = Txtphno.Text
    '        Dim paramemail As New SqlParameter("@email", SqlDbType.VarChar, 50)
    '        paramemail.Value = Txtemail.Text
    '        Dim paramaddress As New SqlParameter("@address", SqlDbType.VarChar, 50)
    '        paramaddress.Value = RichTextBox1.Text
    '        Dim paramcarmodel As New SqlParameter("@carmodel", SqlDbType.VarChar, 50)
    '        paramcarmodel.Value = Cmdmodel1.Text
    '        Dim paramcarno As New SqlParameter("@carno", SqlDbType.VarChar, 50)
    '        paramcarno.Value = Txtcarnum.Text
    '        Dim paramdriverlicenseno As New SqlParameter("@driverlicenseno", SqlDbType.NVarChar, 50)
    '        paramdriverlicenseno.Value = Txtdl.Text

    '        cmd.Parameters.Add(paramdriverid)
    '        cmd.Parameters.Add(paramdrivername)
    '        cmd.Parameters.Add(paramphoneno)
    '        cmd.Parameters.Add(paramemail)
    '        cmd.Parameters.Add(paramaddress)
    '        cmd.Parameters.Add(paramcarmodel)
    '        cmd.Parameters.Add(paramcarno)
    '        cmd.Parameters.Add(paramdriverlicenseno)


    '        Dim da As New SqlDataAdapter
    '        da.InsertCommand = cmd
    '        da.InsertCommand.ExecuteNonQuery()
    '        MsgBox("data is inserted")


    '        Txtcarnum.Text() = ""
    '        Txtemail.Text() = ""
    '        Txtname.Text() = ""
    '        Txtphno.Text() = ""
    '        RichTextBox1.Text() = ""
    '        Cmdmodel1.Text() = ""
    '        txtid.Text() = ""
    '        Txtdl.Text() = ""

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        ''msgbox("driverid aldready exist", messageboxicon.warning)
    '    End Try
    'End If




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim adminhome1 As New adminhome1
        adminhome1.Show()
        Me.Hide()
    End Sub
    Private Sub Cmdmodel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmdmodel1.SelectedIndexChanged
    End Sub
    Private Sub txtdelete_Click(sender As Object, e As EventArgs) Handles txtdelete.Click

        If txtid.SelectedIndex = -1 Then
            MsgBox("Driver ID not Valid", MessageBoxIcon.Warning, MessageBoxButtons.OK)
        ElseIf Txtemail.Text.IndexOf("@") = -1 Then
            MsgBox("Invalid email")
        ElseIf Txtemail.Text.IndexOf(".com") = -1 Then
            MsgBox("Invalid email")
        ElseIf Txtphno.Text.Length > 10 Or Txtphno.Text.Length < 10 Then
            MsgBox("Enter the valid phone no")
        ElseIf Txtemail.Text.Length < 10 Then
            MsgBox("Invalid email")
        ElseIf Txtdl.Text.Length < 13 Or Txtdl.Text.Length > 13 Then
            Label10.Visible = True


        Else

            Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("DELETE FROM [dbo].[driverdat]
      WHERE [driverid]='" + txtid.Text + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Deleted successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            txtid.Text() = ""
            Txtname.Text() = ""
            Txtphno.Text() = ""
            Txtemail.Text() = ""
            Txtcarnum.Text() = ""
            Cmdmodel1.Text = ""
            Txtdl.Text = ""
            RichTextBox1.Text() = Nothing


        End If

    End Sub

    Private Sub Driverdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label10.Visible = False
        con.ConnectionString = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select driverid from driverdat"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        Do While dr1.Read
            txtid.Items.Add(dr1("driverid"))
        Loop
        dr1.Close()


    End Sub
  
    Private Sub Txtemail_TextChanged(sender As Object, e As EventArgs) Handles Txtemail.TextChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rn As New Random
        txtid.Text = (rn.Next(100, 1000))
    End Sub

    Private Sub txtid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtid.SelectedIndexChanged


        Dim dr2 As SqlDataReader
        Dim cmd2 As New SqlCommand
        cmd2.Connection = con
        If con.State = ConnectionState.Closed Then con.Open()
        cmd2.CommandText = "select drivername,phoneno,email,address,carmodel,carno,Driverlicenseno from driverdat where driverid=" & "(@driverid)"

        Dim parameterstate As New SqlParameter("@driverid", SqlDbType.Int)
        parameterstate.Direction = ParameterDirection.Input
        parameterstate.Value = txtid.SelectedItem
        cmd2.Parameters.Add(parameterstate)
        dr2 = cmd2.ExecuteReader
        Do While dr2.Read
            Txtname.Text = dr2("drivername")
            Txtphno.Text = dr2("phoneno")
            Txtemail.Text = dr2("email")
            RichTextBox1.Text = dr2("address")
            Cmdmodel1.Text = dr2("carmodel")
            Txtcarnum.Text = dr2("carno")
            Txtdl.Text = dr2("driverlicenseno")

        Loop
        dr2.Close()
        con.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txtid.SelectedIndex = -1 Then
            MsgBox("Driver ID not Valid", MessageBoxIcon.Warning, MessageBoxButtons.OK)
        ElseIf Txtemail.Text.IndexOf("@") = -1 Then
            MsgBox("Invalid email")
        ElseIf Txtemail.Text.IndexOf(".com") = -1 Then
            MsgBox("Invalid email")
        ElseIf Txtphno.Text.Length > 10 Or Txtphno.Text.Length < 10 Then
            MsgBox("Enter the valid phone no")
        ElseIf Txtemail.Text.Length < 10 Then
            MsgBox("Invalid email")
        ElseIf Txtdl.Text.Length < 13 Or Txtdl.Text.Length > 13 Then
            Label10.Visible = True


        Else
            Dim con As SqlConnection = New SqlConnection
            con.ConnectionString = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"

            Try
                con.Open()
                Dim query = "update driverdat Set driverid='" & txtid.Text & "',drivername='" & Txtname.Text & "',phoneno='" & Txtphno.Text & "',email='" & Txtemail.Text & "',address='" & RichTextBox1.Text & "',carmodel='" & Cmdmodel1.Text & "',carno='" & Txtcarnum.Text & "',driverlicenseno='" & Txtdl.Text & "' where driverid=" & txtid.Text & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox(" Driver details Updated")
                con.Close()
                txtid.Text() = ""
                Txtname.Text() = ""
                Txtphno.Text() = ""
                Txtemail.Text() = ""
                Txtcarnum.Text() = ""
                Cmdmodel1.Text = ""
                Txtdl.Text = ""
                RichTextBox1.Text() = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


    End Sub

    Private Sub Txtphno_keypress(sender As Object, e As KeyPressEventArgs) Handles Txtphno.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Only numbers Allowed", MessageBoxIcon.Information)
            Txtphno.Text = ""
        End If
    End Sub

    Private Sub Txtdl_keypress(sender As Object, e As KeyPressEventArgs) Handles Txtdl.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Only numbers Allowed", MessageBoxIcon.Information)
            Txtdl.Text = ""
        End If
    End Sub
End Class
