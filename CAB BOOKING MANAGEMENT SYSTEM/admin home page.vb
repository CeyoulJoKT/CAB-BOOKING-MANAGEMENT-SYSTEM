Imports System.Data.SqlClient
Public Class admin_home_page
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connectionnstring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        Dim sql As String = "SELECT * FROM userreg"
        Dim connection As New SqlConnection(connectionnstring)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim DS As New DataSet
        connection.Open()
        dataadapter.Fill(DS, "userreg")
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "userreg"


    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim connectionnstring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        Dim sql As String = "SELECT * FROM userreg"
        Dim connection As New SqlConnection(connectionnstring)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim DS1 As New DataSet
        connection.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionnstring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        Dim sql As String = "SELECT * FROM bookingdata"
        Dim connection As New SqlConnection(connectionnstring)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim DS As New DataSet
        connection.Open()
        dataadapter.Fill(DS, "bookingdata")
        DataGridView2.DataSource = DS
        DataGridView2.DataMember = "bookingdata"
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionnstring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        Dim sql As String = "SELECT * FROM driverdat"
        Dim connection As New SqlConnection(connectionnstring)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim DS As New DataSet
        connection.Open()
        dataadapter.Fill(DS, "driverdat")
        DataGridView3.DataSource = DS
        DataGridView3.DataMember = "driverdat"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connectionnstring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        Dim sql As String = "SELECT cardnumber,cardname,upi FROM payment"
        Dim connection As New SqlConnection(connectionnstring)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim DS As New DataSet
        connection.Open()
        dataadapter.Fill(DS, "payment")
        DataGridView4.DataSource = DS
        DataGridView4.DataMember = "payment"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form1 As New Form1
        Me.Hide()
        form1.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim adminhome1 As New adminhome1
        adminhome1.Show()
        Me.Hide()


    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim connectionnstring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        Dim sql As String = "SELECT * FROM feedback"
        Dim connection As New SqlConnection(connectionnstring)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim DS As New DataSet
        connection.Open()
        dataadapter.Fill(DS, "feedback")
        DataGridView5.DataSource = DS
        DataGridView5.DataMember = "feedback"
    End Sub

    Private Sub admin_home_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select username from userreg"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        Do While dr1.Read
            ComboBox1.Items.Add(dr1("username"))
        Loop
        dr1.Close()
        hh()
        uu()

    End Sub
    Private Sub uu()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select bookingid from bookingdata"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        Do While dr1.Read
            ComboBox2.Items.Add(dr1("bookingid"))
        Loop
        dr1.Close()
    End Sub
    Private Sub hh()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select drivername from driverdat"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        Do While dr1.Read
            ComboBox3.Items.Add(dr1("drivername"))
        Loop
        dr1.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim Con = New SqlConnection("Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
        Con.Open()
        Dim query = " Select * From userreg where username='" & ComboBox1.Text & "'"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        Dim adapther As SqlDataAdapter
        adapther = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapther)
        Dim ds As DataSet
        ds = New DataSet
        adapther.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
        ComboBox3.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim Con = New SqlConnection("Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
        Con.Open()
        Dim query = " Select * From bookingdata where bookingid='" & ComboBox2.Text & "'"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        Dim adapther As SqlDataAdapter
        adapther = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapther)
        Dim ds As DataSet
        ds = New DataSet
        adapther.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
        ComboBox1.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim Con = New SqlConnection("Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
        Con.Open()
        Dim query = " Select * From driverdat where drivername='" & ComboBox3.Text & "'"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        Dim adapther As SqlDataAdapter
        adapther = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapther)
        Dim ds As DataSet
        ds = New DataSet
        adapther.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
End Class