Imports System.Data.SqlClient
Public Class Booking
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label15.Visible = False

        If (txtbooking.Text() = "" Or txtname.Text() = "" Or Txtphone.Text() = "" Or txtaddress.Text() = "" Or cmdploc.Text() = "" Or cmddloc.Text() = "" Or DateTimePicker1.Text() = Nothing Or cmdcarmodel.Text() = "" Or cmdcolor.Text() = "" Or Txtkm.Text() = "" Or Txtamt.Text() = "" Or txtpassenger.Text() = "" Or txtprice.Text() = "" Or txthour.Text = "" Or txtmin.Text = "" Or txtmm.Text = "" Or txtmm.Text = "") Then
            MsgBox("Fill all the blank space ", MessageBoxIcon.Warning, MessageBoxButtons.OK)

        ElseIf Txtphone.Text.Length < 10 Or Txtphone.Text.Length > 10 Then
            Label15.Visible = True
            MsgBox("Enter a valid phone no", MessageBoxIcon.Information)

        Else


            Dim conString As String = ("Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
            con = New SqlConnection(conString)
                Try
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [dbo].[bookingdata]
           (name,phoneno,address,pickuplocation,droplocation,pickupdate,carmodel,carcolor,noofpassengers,price,noofkm,totalamt,bookingid,hour,minute,merdian)
     VALUES(@name,@phoneno,@address,@pickuplocation,@droplocation,@pickUpdate,@carmodel,@carcolor,@noofpassengers,@price,@noofkm,@totalamt,@bookingid,@hour,@minute,@merdian)"


                Dim paramname As New SqlParameter("@name", SqlDbType.NVarChar, 20)
                paramname.Value = txtname.Text
                Dim paramphoneno As New SqlParameter("@phoneno", SqlDbType.NVarChar, 20)
                paramphoneno.Value = Txtphone.Text
                Dim paramaddress As New SqlParameter("@address", SqlDbType.NVarChar, 50)
                paramaddress.Value = txtaddress.Text
                Dim parampickuplocation As New SqlParameter("@pickuplocation", SqlDbType.NVarChar, 10)
                parampickuplocation.Value = cmdploc.Text
                Dim paramdroplocation As New SqlParameter("@droplocation", SqlDbType.NVarChar, 10)
                paramdroplocation.Value = cmddloc.Text
                Dim parampickupdate As New SqlParameter("@pickupdate", SqlDbType.Date)
                parampickupdate.Value = DateTimePicker1.Text
                Dim paramcarmodel As New SqlParameter("@carmodel", SqlDbType.NVarChar, 10)
                paramcarmodel.Value = cmdcarmodel.Text
                Dim paramcarcolor As New SqlParameter("@carcolor", SqlDbType.NVarChar, 10)
                paramcarcolor.Value = cmdcolor.Text
                Dim paramnoofpassengers As New SqlParameter("@noofpassengers", SqlDbType.NVarChar, 5)
                paramnoofpassengers.Value = txtpassenger.Text
                Dim paramprice As New SqlParameter("@price", SqlDbType.NVarChar, 10)
                paramprice.Value = txtprice.Text
                Dim paramnoofkm As New SqlParameter("@noofkm", SqlDbType.NVarChar, 10)
                paramnoofkm.Value = Txtkm.Text
                Dim paramtotalamt As New SqlParameter("@totalamt", SqlDbType.NVarChar, 10)
                paramtotalamt.Value = Txtamt.Text
                Dim parambookingid As New SqlParameter("@bookingid", SqlDbType.NVarChar, 10)
                parambookingid.Value = txtbooking.Text
                Dim paramhour As New SqlParameter("@hour", SqlDbType.NVarChar, 20)
                paramhour.Value = txthour.Text
                Dim paramminute As New SqlParameter("@minute", SqlDbType.VarChar, 10)
                paramminute.Value = txtmin.Text
                Dim parammerdian As New SqlParameter("@merdian", SqlDbType.VarChar, 10)
                parammerdian.Value = txtmm.Text

                cmd.Parameters.Add(paramname)
                cmd.Parameters.Add(paramphoneno)
                cmd.Parameters.Add(paramaddress)
                cmd.Parameters.Add(parampickuplocation)
                cmd.Parameters.Add(paramdroplocation)
                cmd.Parameters.Add(parampickupdate)
                cmd.Parameters.Add(paramcarmodel)
                cmd.Parameters.Add(paramcarcolor)
                cmd.Parameters.Add(paramnoofpassengers)
                cmd.Parameters.Add(paramprice)
                cmd.Parameters.Add(paramnoofkm)
                cmd.Parameters.Add(paramtotalamt)
                cmd.Parameters.Add(parambookingid)
                cmd.Parameters.Add(paramhour)
                cmd.Parameters.Add(paramminute)
                cmd.Parameters.Add(parammerdian)


                Dim da As New SqlDataAdapter
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()

                    Dim payment As New Payment()
                    payment.Txttoam.Text = Txtamt.Text
                    payment.Show()
                    payment.TextBox1.Text = txtbooking.Text
                    payment.Show()


                    Me.Hide()

                Catch ex As Exception
                MsgBox("Booking ID aldready exist", MessageBoxIcon.Information)
            End Try
            End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim homepage As New HomePage
        homepage.Show()
        Me.Hide()
    End Sub


    Private Sub Cmdcolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdcolor.SelectedIndexChanged
    End Sub
    Private Sub Cmdcarmodel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdcarmodel.SelectedIndexChanged
        If cmdcarmodel.SelectedItem.ToString = "Mercedes Benz" Then
            MsgBox("Per km/40Rps", MessageBoxIcon.Information)
            cmdcolor.Items.Clear()
            cmdcolor.Items.Add("white")
            cmdcolor.Items.Add("Grey")
            cmdcolor.Items.Add("Black")
            cmdcolor.Items.Add("Maroon")
            txtprice.Text = "40"

        ElseIf cmdcarmodel.SelectedItem.ToString = "Fortuner" Then
            MsgBox("Per km/30Rps", MessageBoxIcon.Information)
            cmdcolor.Items.Clear()
            cmdcolor.Items.Add("white")
            cmdcolor.Items.Add("Grey")
            cmdcolor.Items.Add("Black")
            cmdcolor.Items.Add("Maroon")
            txtprice.Text = "30"

        ElseIf cmdcarmodel.SelectedItem.ToString = "Hyundai I20" Then
            MsgBox("Per km/20Rps", MessageBoxIcon.Information)
            cmdcolor.Items.Clear()
            cmdcolor.Items.Add("white")
            cmdcolor.Items.Add("Grey")
            cmdcolor.Items.Add("Black")
            cmdcolor.Items.Add("Maroon")
            txtprice.Text = "20"

        ElseIf cmdcarmodel.SelectedItem.ToString = "Mahindira Bolero" Then
            MsgBox("Per km/25Rps", MessageBoxIcon.Information)
            cmdcolor.Items.Clear()
            cmdcolor.Items.Add("white")
            cmdcolor.Items.Add("Grey")
            cmdcolor.Items.Add("Black")
            cmdcolor.Items.Add("Maroon")
            txtprice.Text = "25"
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Txtkm.TextChanged
    End Sub
    Private Sub Cmdploc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdploc.SelectedIndexChanged
    End Sub
    Private Sub Cmddloc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmddloc.SelectedIndexChanged

        If cmdploc.SelectedItem = "Bangalore" And cmddloc.SelectedItem = "Pune" Then
            Txtkm.Text = "500"
        ElseIf cmdploc.SelectedItem = "Bangalore" And cmddloc.SelectedItem = "Mumbai" Then
            Txtkm.Text = "550"
        ElseIf cmdploc.SelectedItem = "Bangalore" And cmddloc.SelectedItem = "Chennai" Then
            Txtkm.Text = "600"
        ElseIf cmdploc.SelectedItem = "Bangalore" And cmddloc.SelectedItem = "Delhi" Then
            Txtkm.Text = "450"
        ElseIf cmdploc.SelectedItem = "Bangalore" And cmddloc.SelectedItem = "Bangalore" Then
            Txtkm.Text = "10"
        ElseIf cmdploc.SelectedItem = "Bangalore" And cmddloc.SelectedItem = "Hyderabad" Then
            Txtkm.Text = "340"
        ElseIf cmdploc.SelectedItem = "Bangalore" And cmddloc.SelectedItem = "Kolkata" Then
            Txtkm.Text = "520"
        ElseIf cmdploc.SelectedItem = "Bangalore" And cmddloc.SelectedItem = "Kerala" Then
            Txtkm.Text = "500"
        ElseIf cmdploc.SelectedItem = "Bangalore" And cmddloc.SelectedItem = "Jharkhand" Then
            Txtkm.Text = "650"

        ElseIf cmdploc.SelectedItem = "Pune" And cmddloc.SelectedItem = "Bangalore" Then
            Txtkm.Text = "500"
        ElseIf cmdploc.SelectedItem = "Pune" And cmddloc.SelectedItem = "Pune" Then
            Txtkm.Text = "40"
        ElseIf cmdploc.SelectedItem = "Pune" And cmddloc.SelectedItem = "Mumbai" Then
            Txtkm.Text = "250"
        ElseIf cmdploc.SelectedItem = "Pune" And cmddloc.SelectedItem = "Delhi" Then
            Txtkm.Text = "500"
        ElseIf cmdploc.SelectedItem = "Pune" And cmddloc.SelectedItem = "Hyderabad" Then
            Txtkm.Text = "360"
        ElseIf cmdploc.SelectedItem = "Pune" And cmddloc.SelectedItem = "Chennai" Then
            Txtkm.Text = "450"
        ElseIf cmdploc.SelectedItem = "Pune" And cmddloc.SelectedItem = "Kolkata" Then
            Txtkm.Text = "430"
        ElseIf cmdploc.SelectedItem = "Pune" And cmddloc.SelectedItem = "Kerala" Then
            Txtkm.Text = "200"
        ElseIf cmdploc.SelectedItem = "Pune" And cmddloc.SelectedItem = "Jharkhand" Then
            Txtkm.Text = "260"

        ElseIf cmdploc.SelectedItem = "Mumbai" And cmddloc.SelectedItem = "Pune" Then
            Txtkm.Text = "480"
        ElseIf cmdploc.SelectedItem = "Mumbai" And cmddloc.SelectedItem = "Mumbai" Then
            Txtkm.Text = "40"
        ElseIf cmdploc.SelectedItem = "Mumbai" And cmddloc.SelectedItem = "Chennai" Then
            Txtkm.Text = "590"
        ElseIf cmdploc.SelectedItem = "Mumbai" And cmddloc.SelectedItem = "Delhi" Then
            Txtkm.Text = "470"
        ElseIf cmdploc.SelectedItem = "Mumbai" And cmddloc.SelectedItem = "Bangalore" Then
            Txtkm.Text = "465"
        ElseIf cmdploc.SelectedItem = "Mumbai" And cmddloc.SelectedItem = "Hyderabad" Then
            Txtkm.Text = "350"
        ElseIf cmdploc.SelectedItem = "Mumbai" And cmddloc.SelectedItem = "Kolkata" Then
            Txtkm.Text = "462"
        ElseIf cmdploc.SelectedItem = "Mumbai" And cmddloc.SelectedItem = "Kerala" Then
            Txtkm.Text = "560"
        ElseIf cmdploc.SelectedItem = "Mumbai" And cmddloc.SelectedItem = "Jharkhand" Then
            Txtkm.Text = "250"

        ElseIf cmdploc.SelectedItem = "Chennai" And cmddloc.SelectedItem = "Pune" Then
            Txtkm.Text = "560"
        ElseIf cmdploc.SelectedItem = "Chennai" And cmddloc.SelectedItem = "Mumbai" Then
            Txtkm.Text = "220"
        ElseIf cmdploc.SelectedItem = "Chennai" And cmddloc.SelectedItem = "Chennai" Then
            Txtkm.Text = "40"
        ElseIf cmdploc.SelectedItem = "Chennai" And cmddloc.SelectedItem = "Delhi" Then
            Txtkm.Text = "350"
        ElseIf cmdploc.SelectedItem = "Chennai" And cmddloc.SelectedItem = "Bangalore" Then
            Txtkm.Text = "550"
        ElseIf cmdploc.SelectedItem = "Chennai" And cmddloc.SelectedItem = "Hyderabad" Then
            Txtkm.Text = "650"
        ElseIf cmdploc.SelectedItem = "Chennai" And cmddloc.SelectedItem = "Kolkata" Then
            Txtkm.Text = "650"
        ElseIf cmdploc.SelectedItem = "Chennai" And cmddloc.SelectedItem = "Kerala" Then
            Txtkm.Text = "220"
        ElseIf cmdploc.SelectedItem = "Chennai" And cmddloc.SelectedItem = "Jharkhand" Then
            Txtkm.Text = "650"
        End If


    End Sub
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Visible = False


    End Sub
    Private Sub Txtamt_Textmouseenter(sender As Object, e As EventArgs) Handles Txtamt.MouseEnter
        Txtamt.Text = Txtkm.Text * txtprice.Text

    End Sub
    Private Sub Txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        End Sub


    Private Sub txtreset_Click(sender As Object, e As EventArgs) Handles txtreset.Click
        txtbooking.Text() = ""
        txtname.Text() = ""
        Txtphone.Text() = ""
        txtaddress.Text() = ""
        cmdploc.Text() = ""
        cmddloc.Text() = ""
        DateTimePicker1.Text() = Nothing
        cmdcarmodel.Text() = ""
        cmdcolor.Text() = ""
        Txtkm.Text() = ""
        Label5.Visible = False
        Txtamt.Text() = ""
        txtpassenger.Text() = ""
        txtprice.Text() = ""
        txthour.Text() = ""
        txtmin.Text() = ""
        txtmm.Text() = ""
    End Sub

    Private Sub txtpassenger_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Dim obj As New Object
    Private Sub txtbooking_TextChanged(sender As Object, e As EventArgs) Handles txtbooking.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rn As New Random
        txtbooking.Text = (rn.Next(100, 1000))

    End Sub

    Private Sub Txtamt_TextChanged(sender As Object, e As EventArgs) Handles Txtamt.TextChanged

    End Sub

    Private Sub Txtphone_keypress(sender As Object, e As KeyPressEventArgs) Handles Txtphone.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Only numbers Allowed", MessageBoxIcon.Information)
            Txtphone.Text = ""
        End If
    End Sub

    Private Sub txthour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txthour.SelectedIndexChanged

    End Sub
End Class