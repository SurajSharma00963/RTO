Imports MySql.Data.MySqlClient
Public Class DealarRegistration
    Dim conn As New MySqlConnection
    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged
        If Len(pass.Text) < 6 Then
            pass.BackColor = Color.Red
        ElseIf Len(pass.Text) >= 6 Then
            pass.BackColor = Color.White

        End If
    End Sub

    Private Sub DelearRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
        Dim comm As New MySqlCommand
        comm.Connection = conn
        conn.Open()
        Dim i As Integer
        comm.CommandText = "select Max(did) from dealer"
        If IsDBNull(comm.ExecuteScalar) Then
            i = 16001
            did.Text = i
        Else
            i = comm.ExecuteScalar + 1
            did.Text = i
        End If
        comm.Dispose()
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim pass1 As String



        Try
            If oname.Text = "" Or sname.Text = "" Or Tino.Text = "" Or bname.Text = "" Or address.Text = "" Or pass.Text = "" Or rpass.Text = "" Then
                MsgBox("Fill All The Fields", MsgBoxStyle.Critical, "Empty Fields")
                Exit Sub
            End If

            If pass.Text = rpass.Text Then
                pass1 = rpass.Text
            Else
                MsgBox("Check The Password", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If

            conn.Open()
            Query = " insert into Dealer(did,oname,sname,tin,date,bname,address,Rtono,RTO_NAME,password) values('" & did.Text & "','" & oname.Text & "','" & sname.Text & "','" & Tino.Text & "','" & DateTimePicker1.Text & "','" & bname.Text & "','" & address.Text & "','" & rtono.Text & "','" & rtoname.Text & "','" & rpass.Text & "')"
            comm = New MySqlCommand(Query, conn)
            comm.ExecuteNonQuery()
            conn.Dispose()
            MsgBox("Successfully Registered", MsgBoxStyle.Information, "Successfull")
            If vbOK Then
                Dealer.Show()
                Me.Close()
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dealer.Show()
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rtono.SelectedIndexChanged
        If rtono.SelectedItem = "KA01" Then
            rtoname.Text = "RTO KORAMANGALA"
        ElseIf rtono.SelectedItem = "KA02" Then
            rtoname.Text = "RTO BANGALORE( WEST )"
        ElseIf rtono.SelectedItem = "KA03" Then
            rtoname.Text = "RTO BANGALORE( EAST )"
        ElseIf rtono.SelectedItem = "KA04" Then
            rtoname.Text = "RTO BANGALORE( NORTH )"
        ElseIf rtono.SelectedItem = "KA05" Then
            rtoname.Text = "RTO BANGALORE( SOUTH )"

        End If
    End Sub

    Private Sub oname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles oname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            oname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Tino_TextChanged(sender As Object, e As EventArgs) Handles Tino.TextChanged
        Tino.MaxLength = 10
    End Sub

    Private Sub Tino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tino.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Tino.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub sname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            sname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub bname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            bname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles address.KeyPress
        If Char.IsLower(e.KeyChar) Then
            address.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub rpass_TextChanged(sender As Object, e As EventArgs) Handles rpass.TextChanged
        If Len(rpass.Text) < 6 Then
            rpass.BackColor = Color.Red
        ElseIf Len(pass.Text) >= 6 Then
            rpass.BackColor = Color.White
        End If
    End Sub

    Private Sub address_TextChanged(sender As Object, e As EventArgs) Handles address.TextChanged

    End Sub
End Class