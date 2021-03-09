Imports MySql.Data.MySqlClient
Public Class VehicleRegistration
    Dim conn As New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim n As String
        Dim stat As String
        Try
            If slv.Text = "" Or nob.Text = "" Or aob.Text = "" Or nov.Text = "" Then
                MsgBox("Fields are Empty", MsgBoxStyle.Critical, "Empty Fields")
                Exit Sub
            End If
            stat = "Vehicle Number Not Generated "
                n = "1420"
            conn.Open()
            Query = " insert into vehicle(rto,vehicle_no,vehicle_slno,nameofvehicle,nameofbuyer,tov,nos,aob,pob,status) values('" & RTO.Text & "','" & n & "','" & slv.Text & "','" & nov.Text & "','" & nob.Text & "','" & tov.Text & "','" & nos.Text & "','" & aob.Text & "','" & POB.Text & "','" & stat & "')"
            comm = New MySqlCommand(Query, conn)
            comm.ExecuteNonQuery()
            conn.Dispose()
            MsgBox("Successfully Registered", MsgBoxStyle.Information, "Successfull")
            If vbOK Then
                slv.Text = ""
                nov.Text = ""
                tov.Text = ""
                nob.Text = ""
                nos.Text = ""
                aob.Text = ""
                POB.Text = ""

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub VehicleRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Welcomedealer.Show()
        Me.Close()
    End Sub

    Private Sub slv_TextChanged(sender As Object, e As EventArgs) Handles slv.TextChanged
        slv.MaxLength = 10
    End Sub

    Private Sub slv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles slv.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub nob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nob.KeyPress
        If Char.IsLower(e.KeyChar) Then
            nob.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub



    Private Sub nov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nov.KeyPress
        If Char.IsLower(e.KeyChar) Then
            nov.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub



    Private Sub aob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles aob.KeyPress
        If Char.IsLower(e.KeyChar) Then
            aob.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
End Class