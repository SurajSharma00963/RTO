Imports MySql.Data.MySqlClient
Public Class GenerateVehicleNo
    Dim conn As New MySqlConnection

    Private Sub GenerateVehicleNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
        'TODO: This line of code loads data into the 'Rto_managementDataSet2.vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter1.Fill(Me.Rto_managementDataSet2.vehicle)
        'TODO: This line of code loads data into the 'Rto_managementDataSet2.vehicle' table. You can move, or remove it, as needed.
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim comm As MySqlCommand
        Dim Query As String
        Try
            conn.Open()
            Query = "select count(*) from vehicle"
            comm = New MySqlCommand(Query, conn)
            comm.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = "select nameofvehicle,nameofbuyer,tov,aob,pob from vehicle where Vehicle_Slno='" & Serialno.Text & "'"
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            NOV.Visible = True
            NOB.Visible = True
            TOV.Visible = True
            AOB.Visible = True
            POB.Visible = True
            Button2.Visible = True
            While reader.Read
                NOV.Text = reader.GetString("Nameofvehicle")
                POB.Text = reader.GetString("pob")
                TOV.Text = reader.GetString("tov")
                NOB.Text = reader.GetString("nameofbuyer")
                AOB.Text = reader.GetString("aob")
            End While
            Label2.Enabled = False
            Serialno.Enabled = False
            DataGridView1.Enabled = False
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Verified and Vehicle No Generated", MsgBoxStyle.Information, "Success")
        If vbOK Then
            Label13.Visible = True
            VHNO.Visible = True
            Button2.Hide()
            Button3.Visible = True
            Label3.Enabled = False
            Label4.Enabled = False
            Label5.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
            NOV.Enabled = False
            NOB.Enabled = False
            TOV.Enabled = False
            AOB.Enabled = False
            POB.Enabled = False
        End If
        Dim comm As New MySqlCommand
        comm.Connection = conn
        conn.Open()
        Dim i As Integer
        comm.CommandText = "select Max(Vehicle_No) from vehicle"
        If IsDBNull(comm.ExecuteScalar) Then
            i = 1420
            VHNO.Text = i
        Else
            i = comm.ExecuteScalar + 1
            VHNO.Text = i
        End If
        comm.Dispose()
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Stat As String
        Try
            Stat = "Vehicle No. Generated"
            conn.Open()
            Query = "update vehicle set vehicle_no='" & VHNO.Text & "',status='" & Stat & "'  where Vehicle_Slno='" & Serialno.Text & "'"
            comm = New MySqlCommand(Query, conn)
            comm.ExecuteNonQuery()
            conn.Dispose()
            MsgBox("Success", MsgBoxStyle.Information, "Successfull")
            If vbOK Then
                Label3.Hide()
                Label4.Hide()
                Label5.Hide()
                Label6.Hide()
                Label7.Hide()
                NOV.Hide()
                NOB.Hide()
                TOV.Hide()
                AOB.Hide()
                POB.Hide()
                Button2.Hide()
                Button3.Hide()
                Label13.Hide()
                VHNO.Hide()
                Label2.Enabled = True
                Serialno.Enabled = True
                DataGridView1.Enabled = True
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Serialno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Serialno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Welcome_officer.Show()
        Me.Close()
    End Sub
End Class