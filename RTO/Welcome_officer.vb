Imports MySql.Data.MySqlClient
Public Class Welcome_officer
    Dim conn As New MySqlConnection
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("you have successfully signed out", vbOK)
        If vbOK Then
            Welcome.Show()
            Me.Close()
            RTO_Login.Close()
        End If
    End Sub

    Private Sub Welcome_officer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "server=localhost;username=root;password=root;database=RTO_Management   "


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DLLANDLLAPP.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader
        Dim i As String

        Try
            i = ""
            conn.Open()
            Query = "select count(*) from payment where status='Your Application Has Been Approved Wait For Your LL'"
            comm = New MySqlCommand(Query, conn)
            Reader = comm.ExecuteReader()
            conn.Dispose()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try
        conn.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GenerateVehicleNo.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Approved.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LLApproved.Show()
        Me.Hide()
    End Sub
End Class