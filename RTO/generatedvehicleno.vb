Imports MySql.Data.MySqlClient
Public Class generatedvehicleno
    Dim conn As New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = "select rto,vehicle_no from vehicle where vehicle_slno='" & serialno.Text & "'"
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            Label3.Visible = True
            Label4.Visible = True
            VNO.Visible = True
            While reader.Read
                Label3.Text = reader.GetString("RTO")
                Label4.Text = reader.GetString("Vehicle_no")
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub generatedvehicleno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Rto_managementDataSet1.vehicle' table. You can move, or remove it, as needed.

        conn.ConnectionString = "server=localhost;username=root;password=root;database=RTO_management"
        Dim comm As MySqlCommand
        Dim Query As String
        Dim reader
        Try
            conn.Open()
            Query = "select sname from dealer where did='" & Dealerlogin.DID.Text & "'"
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            While reader.Read
                Me.sname.Text = reader.GetString("sname")
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        Try

            conn.Open()
            adapter = New MySqlDataAdapter("SELECT rto,vehicle_slno,nameofvehicle,nameofbuyer,tov,nos,aob,pob,status FROM vehicle  where nos = '" & sname.Text & "'", conn)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        Me.VehicleTableAdapter.Fill(Me.Rto_managementDataSet1.vehicle)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Welcomedealer.Show()
    End Sub

    Private Sub serialno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles serialno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class