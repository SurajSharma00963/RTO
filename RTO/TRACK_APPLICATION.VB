Imports MySql.Data.MySqlClient
Public Class TRACK_APPLICATION
    Dim conn As New MySqlConnection
    Private Sub TRACK_APPLICATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Appstatus.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim i As Integer
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = " SELECT count(*) FROM registered where application_no='" & Appno.Text & "'"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            reader = comm.ExecuteReader
            conn.Dispose()
            If i = 0 Then
                MsgBox("Invalid Application Number!", MsgBoxStyle.Critical, "Error")
                Appno.Text = ""

            ElseIf i = 1 Then
                Appstatus.Visible = True
                conn.Open()
                Query = "select Status from Registered where Application_no='" & Appno.Text & "'"
                comm = New MySqlCommand(Query, conn)
                reader = comm.ExecuteReader()
                While reader.Read
                    Me.Appstatus.Text = reader.GetString("Status")
                End While
                Button3.Show()
                Button2.Hide()
                Button1.Hide()
                Appno.Enabled = False

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Appno_TextChanged(sender As Object, e As EventArgs) Handles Appno.TextChanged

    End Sub

    Private Sub Appno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Appno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class