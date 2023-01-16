Imports System.Data.SqlClient
Imports System.Data
Public Class Feedback

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim homepage As New HomePage
        Me.Hide()
        homepage.Show()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Dim constring As String = "Data Source=LAPTOP-2E828ACM\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"
        con = New SqlConnection(constring)
        If (ComboBox1.Text = "" Or ComboBox2.Text = "") Then
            Label8.Visible = True
            MsgBox("Please enter all fields", MessageBoxIcon.Warning)

        Else
            Label8.Visible = False
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO [dbo].[feedback]
           ([experience]
           ,[rate]
           ,[feedback])
VALUES(@experience,@rate,@feedback)"
            Dim paramexperience As New SqlParameter("@experience", SqlDbType.VarChar, 50)
            paramexperience.Value = ComboBox1.Text
            Dim paramrate As New SqlParameter("@rate", SqlDbType.Int)
            paramrate.Value = ComboBox2.Text
            Dim paramfeedback As New SqlParameter("@feedback", SqlDbType.VarChar, 60)
            paramfeedback.Value = RichTextBox1.Text


            cmd.Parameters.Add(paramexperience)
            cmd.Parameters.Add(paramrate)
            cmd.Parameters.Add(paramfeedback)


            Dim da As New SqlDataAdapter
            da.InsertCommand = cmd
            da.InsertCommand.ExecuteNonQuery()
            Label1.Visible = False
            MsgBox("submitted successfully", MessageBoxIcon.Information)

            Dim userlogin As New UserLogin()
            Me.Hide()
            userlogin.Show()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged



    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Visible = False
    End Sub
End Class