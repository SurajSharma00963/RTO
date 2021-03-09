Imports MySql.Data.MySqlClient
Public Class starttest
    Dim conn As New MySqlConnection
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label1.Show()
            Appno.Show()
            Button1.Show()
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label1.Hide()
            Appno.Hide()
            Button1.Hide()
            Button2.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Applicant.Button1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim i As Integer
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = " SELECT count(*) FROM registered where application_no = '" & Appno.Text & "' "
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            reader = comm.ExecuteReader
            conn.Dispose()
            If i = 0 Then
                MsgBox("Invalid Application no.!", MsgBoxStyle.Critical, "Error")
                Appno.Text = ""

            ElseIf i = 1 Then
                DLTest.Show()
                conn.Open()
                Query = "select application_no from Registered where Application_no='" & Appno.Text & "'"
                comm = New MySqlCommand(Query, conn)
                reader = comm.ExecuteReader()
                While reader.Read
                    DLTest.Appno.Text = reader.GetString("Application_no")
                End While
                Applicant.Close()
                Me.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub starttest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=RTO_management"
    End Sub
End Class