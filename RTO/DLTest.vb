Imports MySql.Data.MySqlClient
Public Class DLTest
    Dim Conn As New MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String

        Dim stat As String
        If o2.Checked And o21.Checked And o31.Checked And o42.Checked And o52.Checked And o61.Checked Then
            Try
                stat = "Test Completed And LL Confirmed"
                Conn.Open()
                Query = " update Registered set status='" & stat & "' where application_no='" & Appno.Text & "'"
                comm = New MySqlCommand(Query, Conn)
                comm.ExecuteNonQuery()
                Conn.Dispose()
                MsgBox("You have successfully Cleared the Test", MsgBoxStyle.Information, "Successfull")
                If vbOK Then
                    LLconfirmation.Show()
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                Conn.Dispose()
            End Try
        Else
            MsgBox("You are Not Eligible For DL", MsgBoxStyle.Information, "Failed")
            If vbOK Then
                Welcome.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub DLTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
    End Sub
End Class