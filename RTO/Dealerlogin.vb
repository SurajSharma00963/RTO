Imports MySql.Data.MySqlClient
Public Class Dealerlogin
    Dim Conn As New MySqlConnection
    Private Sub Dealerlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim i As Integer
        Dim reader As MySqlDataReader
        Try
            Conn.Open()
            Query = " SELECT count(*) FROM dealer where did = '" & DID.Text & "' and Password = '" & Password.Text & "'"
            comm = New MySqlCommand(Query, Conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            reader = comm.ExecuteReader
            Conn.Dispose()
            If i = 0 Then
                MsgBox("Invalid Username ID or Password!", MsgBoxStyle.Critical, "Error")
                DID.Text = ""
                Password.Text = ""

            ElseIf i = 1 Then
                Welcomedealer.Show()
                Conn.Open()
                Query = "select sname from dealer where did='" & DID.Text & "'"
                comm = New MySqlCommand(Query, Conn)
                reader = comm.ExecuteReader()
                While reader.Read
                    Welcomedealer.sname.Text = reader.GetString("sname")
                End While
                Me.Hide()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dealer.Show()
        Me.Close()

    End Sub
End Class