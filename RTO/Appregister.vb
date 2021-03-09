Imports MySql.Data.MySqlClient
Public Class Appregister
    Dim conn As New MySqlConnection
    Private Sub Appregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=suraj957;database=rto_management"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim comm As New MySqlCommand
        Dim Query As String
        Dim date1 As String
        Dim gender1 As String
        Dim lname1, fname1, flname, emailid, mid1 As String
        Dim a As String
        Dim b As String

        Try
            conn.Open()
            fname1 = fname.Text
            lname1 = lname.Text
            mid1 = mID.Text
            flname = fname1 + mid1 + lname1
            emailid = email.Text + at.Text + ComboBox1.SelectedItem

            a = password.Text
            b = Retypepass.Text
            If b < a Then
                MsgBox("Check the Password", MsgBoxStyle.Critical, "Error")
            End If

            If RadioButton1.Checked Then
                gender1 = RadioButton1.Text
            ElseIf RadioButton2.Checked Then
                gender1 = RadioButton2.Text
            End If
            If Len(mobile.Text) < 10 Then
                MsgBox("Check Contact number", MsgBoxStyle.Critical, "WARNING")
                Exit Sub
            End If
            date1 = dob.Text
            Query = "Insert into rto_management.Applicant values('" & username.Text & "','" & Retypepass.Text & "','" & flname & "','" & emailid & "','" & date1 & "','" & gender1 & "','" & mobile.Text & "','" & loc.Text & "' )"
            comm = New MySqlCommand(Query, conn)
            comm.ExecuteNonQuery()
            conn.Dispose()
            MsgBox("Successfully Registered")
            If vbYes Then
                '  App_Login.Show()
                fname.Text = ""
                lname.Text = ""
                dob.Text = Date.Today
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                email.Text = ""
                ComboBox1.SelectedItem = ""
                username.Text = ""
                password.Text = ""
                Retypepass.Text = ""
                mobile.Text = ""
                loc.Text = ""
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub at_Click(sender As Object, e As EventArgs) Handles at.Click

    End Sub

    Private Sub location_TextChanged(sender As Object, e As EventArgs) Handles loc.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Retypepass_TextChanged(sender As Object, e As EventArgs) Handles Retypepass.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub dob_ValueChanged(sender As Object, e As EventArgs) Handles dob.ValueChanged

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged

    End Sub

    Private Sub lname_TextChanged(sender As Object, e As EventArgs) Handles lname.TextChanged

    End Sub

    Private Sub fname_TextChanged(sender As Object, e As EventArgs) Handles fname.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub mobile_TextChanged(sender As Object, e As EventArgs) Handles mobile.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class