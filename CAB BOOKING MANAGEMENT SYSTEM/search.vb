Imports System.Data.SqlClient
Public Class search
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub search_Load(sender As Object, e As EventArgs) Handles Me.Load


        con.ConnectionString = "Data Source=LAPTOP-AD585F6A\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select username from userreg"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        Do While dr1.Read
            ComboBox1.Items.Add(dr1("username"))
        Loop
        dr1.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Dim connectionnstring As String = "Data Source=LAPTOP-AD585F6A\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        'Dim sql As String = "SELECT * FROM userreg where username=" & ComboBox1.SelectedItem.ToString() & ""
        'Dim connection As New SqlConnection(connectionnstring)
        'Dim dataadapter As New SqlDataAdapter(sql, connection)
        'Dim DS As New DataSet
        'connection.Open()
        'dataadapter.Fill(DS, "username")
        'DataGridView1.DataSource = DS
        'DataGridView1.DataMember = "username"
        Dim Con = New SqlConnection("Data Source=LAPTOP-AD585F6A\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Con = New SqlConnection("Data Source=LAPTOP-AD585F6A\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True")
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
    End Sub
    'Private Sub DisplayTr()
    '    con.Open()
    '    Dim query = " Select * From TransactionTB where acc_number='" & acc_no.Text & "'"
    '    Dim cmd As SqlCommand
    '    cmd = New SqlCommand(query, con)
    '    Dim adapther As SqlDataAdapter
    '    adapther = New SqlDataAdapter(cmd)
    '    Dim builder As New SqlCommandBuilder(adapther)
    '    Dim ds As DataSet
    '    ds = New DataSet
    '    adapther.Fill(ds)
    '    report.DataSource = ds.Tables(0)
    '    con.Close()
    'End Sub
End Class