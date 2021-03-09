Imports MySql.Data.MySqlClient
Public Class payment
    Dim conn As New MySqlConnection

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PictureBox1.Show()
    End Sub

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Click
        PictureBox1.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim exp, y, m, amount, a, r As String
        Dim status, status1 As String
        Dim reader As MySqlDataReader
        Try
            y = YYYY.Text
            m = mm.Text
            exp = m + s.Text + y
            a = amt.Text
            r = "₹"
            amount = r + a
            status = "Application Submitted And Receieved "
            status1 = "Payment Successfull"
            conn.Open()
            Query = "INSERT INTO `rto_management`.`payment` (`Reciept`, `name`, `city`, `cardtype`, `cardno`, `expiry`, `cvv`, `Application`, `amount`, `status`) VALUES ('" & Recieptno.Text & "','" & Aname.Text & "','" & City.Text & "','" & cardtype.Text & "','" & CD.Text & "','" & exp & "','" & cvv.Text & "','" & appno.Text & "','" & amount & "','" & status1 & "' ) "
            comm = New MySqlCommand(Query, conn)
            comm.ExecuteNonQuery()
            conn.Dispose()
            MsgBox("Payment Successfull", MsgBoxStyle.Information, "Successfull")
            If vbOK Then
                conn.Open()
                Query = "update registered set status='" & status & "' where application_no='" & appno.Text & "'"
                comm = New MySqlCommand(Query, conn)
                comm.ExecuteNonQuery()
                conn.Dispose()
                billgenerated.Show()
                conn.Open()
                Query = "select reciept, application,CardType,Cardno,amount,status from payment where '" & appno.Text & "'"
                comm = New MySqlCommand(Query, conn)
                reader = comm.ExecuteReader()
                While reader.Read
                    billgenerated.appno.Text = reader.GetString("application")
                    billgenerated.rno.Text = reader.GetString("reciept")
                    billgenerated.type.Text = reader.GetString("cardtype")
                    billgenerated.cardno.Text = reader.GetString("cardno")
                    billgenerated.amt.Text = reader.GetString("amount")
                    billgenerated.status.Text = reader.GetString("status")
                End While
                Me.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub payment_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"

        Dim comm As New MySqlCommand
        comm.Connection = conn
        conn.Open()
        Dim i As Integer
        comm.CommandText = "select Max(Reciept) from Payment"
        If IsDBNull(comm.ExecuteScalar) Then
            i = 30140101
            Recieptno.Text = i
        Else
            i = comm.ExecuteScalar + 1
            Recieptno.Text = i
        End If
        comm.Dispose()
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub CD_TextChanged(sender As Object, e As EventArgs) Handles CD.TextChanged
        CD.MaxLength = 16
        If Len(CD.Text) < 16 Then
            CD.BackColor = Color.Red
        ElseIf Len(CD.Text) = 16 Then
            CD.BackColor = Color.White
        End If
    End Sub

    Private Sub Pin_TextChanged(sender As Object, e As EventArgs) Handles Pin.TextChanged
        Pin.MaxLength = 6
    End Sub

    Private Sub CD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CD.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Pin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pin.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cvv_TextChanged(sender As Object, e As EventArgs) Handles cvv.TextChanged
        cvv.MaxLength = 3
    End Sub

    Private Sub cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cvv.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Aname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Aname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Aname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub City_KeyPress(sender As Object, e As KeyPressEventArgs) Handles City.KeyPress
        If Char.IsLower(e.KeyChar) Then
            City.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub payment_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        PictureBox1.Visible = False
    End Sub
End Class