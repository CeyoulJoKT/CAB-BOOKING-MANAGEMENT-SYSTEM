Imports System.Data.SqlClient
Imports System.Data
Public Class Payment

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        If RadioButton1.Checked = True Then
            If txtcnum.Text = Nothing Or txtcnum.Text.Length < 6 Or txtcnum.Text.Length > 13 Then
                MsgBox("Enter a valid card number")
            ElseIf txtchol.Text = "" Then
                MsgBox("Enter the cardholder name")
            ElseIf Txtcvv.Text = "" Or Txtcvv.Text.Length < 3 Or Txtcvv.Text.Length > 3 Then
                MsgBox("Enter valid cvv")
            Else
                Dim constring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
                con = New SqlConnection(constring)

                Try
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [dbo].[payment]
           (cardnumber,cardname,cvv,upi)
     VALUES(@cardnumber,@cardname,@cvv,@upi)"
                    Dim paramcardnumber As New SqlParameter("@cardnumber", SqlDbType.VarChar, 20)
                    paramcardnumber.Value = txtcnum.Text
                    Dim paramacardname As New SqlParameter("@cardname", SqlDbType.VarChar, 50)
                    paramacardname.Value = txtchol.Text
                    Dim paramcvv As New SqlParameter("@cvv", SqlDbType.VarChar, 5)
                    paramcvv.Value = Txtcvv.Text
                    Dim paramupi As New SqlParameter("@upi", SqlDbType.VarChar, 10)
                    paramupi.Value = Txtupi.Text

                    cmd.Parameters.Add(paramcardnumber)
                    cmd.Parameters.Add(paramacardname)
                    cmd.Parameters.Add(paramcvv)
                    cmd.Parameters.Add(paramupi)

                    Dim da As New SqlDataAdapter
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()

                    MsgBox("Payment was successfull", MessageBoxIcon.Information)
                    MessageBox.Show("Cab Booked succesfully")
                    Dim feedback As New Feedback()
                    Me.Hide()
                    feedback.Show()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If

        If RadioButton2.Checked = True Then
            If Txtupi.Text = "" Then
                MsgBox("Enter a valid upi ID")
            ElseIf Txtupi.Text.IndexOf("@") = -1 Then
                MsgBox("Invalid UPI ID")
            ElseIf Txttoam.Text = Nothing Then
                MessageBox.Show("Enter the total amount")
            Else
                Dim constring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
                con = New SqlConnection(constring)

                Try
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [dbo].[payment]
           (cardnumber,cardname,cvv,upi)
     VALUES(@cardnumber,@cardname,@cvv,@upi)"
                    Dim paramcardnumber As New SqlParameter("@cardnumber", SqlDbType.VarChar, 20)
                    paramcardnumber.Value = txtcnum.Text
                    Dim paramacardname As New SqlParameter("@cardname", SqlDbType.VarChar, 50)
                    paramacardname.Value = txtchol.Text
                    Dim paramcvv As New SqlParameter("@cvv", SqlDbType.VarChar, 5)
                    paramcvv.Value = Txtcvv.Text
                    Dim paramupi As New SqlParameter("@upi", SqlDbType.VarChar, 10)
                    paramupi.Value = Txtupi.Text

                    cmd.Parameters.Add(paramcardnumber)
                    cmd.Parameters.Add(paramacardname)
                    cmd.Parameters.Add(paramcvv)
                    cmd.Parameters.Add(paramupi)

                    Dim da As New SqlDataAdapter
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()

                    MsgBox("Payment was successful", MessageBoxIcon.Information)
                    MessageBox.Show("Cab Booked succesfully")

                    Dim feedback As New Feedback()
                    Me.Hide()
                    feedback.Show()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If





    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtcnum.Text = ""
        Txtupi.Text = ""
        Txtcvv.Text = ""
        txtchol.Text = ""
        Label2.Visible = True

        txtcnum.Visible = True
        Txtcvv.Visible = True
        txtchol.Visible = True

        RadioButton1.Visible = True
        RadioButton2.Visible = True
        If RadioButton1.Checked = True Then
            Txtupi.Visible = False
            Label6.Visible = False
            Label2.Visible = True

            txtcnum.Visible = True
            Txtcvv.Visible = True
            txtchol.Visible = True
        Else
            RadioButton2.Checked = True
            Txtupi.Visible = True
            Label6.Visible = True
            Label2.Visible = False

            txtcnum.Visible = False
            Txtcvv.Visible = False
            txtchol.Visible = False
        End If
        Dim homepage As New HomePage
        Me.Hide()
        homepage.Show()


    End Sub




    Private Sub txtcnum_TextChanged(sender As Object, e As EventArgs) Handles txtcnum.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then

            txtcnum.Visible = True
            txtchol.Visible = True
            Txtcvv.Visible = True
            Txtupi.Visible = False
            CheckBox1.Visible = True
            Label2.Visible = True
            Label5.Visible = True
            Label1.Visible = True
            Label6.Visible = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then

            txtcnum.Visible = False
            txtchol.Visible = False
            Txtcvv.Visible = False
            Label6.Visible = True
            Txtupi.Visible = True
            CheckBox1.Visible = False
            Label2.Visible = False
            Label5.Visible = False
            Label1.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Txtcvv_TextChanged(sender As Object, e As EventArgs) Handles Txtcvv.TextChanged

    End Sub

    Private Sub Txttoam_TextChanged(sender As Object, e As EventArgs) Handles Txttoam.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Txtcvv.UseSystemPasswordChar = False
        Else
            Txtcvv.UseSystemPasswordChar = True
        End If
    End Sub
End Class

