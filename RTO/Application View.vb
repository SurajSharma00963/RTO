Imports MySql.Data.MySqlClient

Public Class Application_View
    Dim conn As New MySqlConnection
    Private Sub Application_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles mp.Click
        payment.Show()
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader
        Try
            If TOL.Text = "LL" Then
                payment.amt.Text = "100"
            ElseIf TOL.Text = "DL" Then
                payment.amt.Text = "600"
            End If
            conn.Open()
            Query = "select Application_no from Registered where Application_no='" & AN.Text & "'"
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            While reader.Read
                payment.appno.Text = reader.GetString("application_no")
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub approve_Click(sender As Object, e As EventArgs) Handles approve.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader

        Dim s As String
        Try
            s = "Your Application Has Been Approved Wait For Your LL"
            conn.Open()
            Query = "update Registered set status='" & s & "' where Application_no='" & AN.Text & "'"
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            conn.Dispose()
            MsgBox("Application Approved", MsgBoxStyle.Information, "Approved")
            If vbOK Then
                Welcome_officer.Show()
                conn.Open()
                Query = "select officer_name from Officer_login where Username='" & RTO_Login.Username.Text & "'"
                comm = New MySqlCommand(Query, conn)
                reader = comm.ExecuteReader()
                While reader.Read
                    Welcome_officer.Label2.Text = reader.GetString("officer_name")
                End While
                Me.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader
        Dim s As String
        Try
            s = "Your Application Has Been Cancelled"
            conn.Open()
            Query = "update Registered set status='" & s & "' where Application_no='" & AN.Text & "'"
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            conn.Dispose()
            MsgBox("Application Cancelled", MsgBoxStyle.Information, "Approved")
            If vbOK Then
                Welcome_officer.Show()
                conn.Open()
                Query = "select officer_name from Officer_login where Username='" & RTO_Login.Username.Text & "'"
                comm = New MySqlCommand(Query, conn)
                reader = comm.ExecuteReader()
                While reader.Read
                    Welcome_officer.Label2.Text = reader.GetString("officer_name")
                End While
            End If
            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class