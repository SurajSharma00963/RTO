Imports MySql.Data.MySqlClient
Public Class Welcomedealer
    Dim conn As New MySqlConnection
    Private Sub Welcomedealer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VehicleRegistration.Show()
        Dim comm As MySqlCommand
        Dim Query As String
        Dim reader
        Try
            conn.Open()
            Query = "select Rtono,sname from dealer where did='" & Dealerlogin.DID.Text & "'"
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            While reader.Read
                VehicleRegistration.RTO.Text = reader.GetString("Rtono")
                VehicleRegistration.nos.Text = reader.getstring("sname")

            End While


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        generatedvehicleno.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dealerlogin.Close()
        Welcome.Show()
        Me.Close()
    End Sub
End Class