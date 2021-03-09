Imports MySql.Data.MySqlClient
Public Class RTO_Login
    Dim conn As New MySqlConnection

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim i As Integer
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = " SELECT count(*) FROM officer_login where Username = '" & Username.Text & "' and Password = '" & Password.Text & "'"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            reader = comm.ExecuteReader
            conn.Dispose()
            If i = 0 Then
                MsgBox("Invalid Username ID or Password!", MsgBoxStyle.Critical, "Error")
                Username.Text = ""
                Password.Text = ""

            ElseIf i = 1 Then
                Welcome_officer.Show()
                conn.Open()
                Query = "select officer_name from Officer_login where Username='" & Username.Text & "'"
                comm = New MySqlCommand(Query, conn)
                reader = comm.ExecuteReader()
                While Reader.Read
                    Welcome_officer.Label2.Text = reader.GetString("officer_name")
                End While
                Me.Hide()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub RTO_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Welcome.Show()
        Me.Close()
    End Sub
End Class