Imports MySql.Data.MySqlClient
Public Class App_Login
    Dim conn As New MySqlConnection
    Private Sub App_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=suraj957;database=rto_management"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim i As Integer
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = " SELECT count(*) FROM Applicant where Username = '" & username.Text & "' and Password = '" & password.Text & "' "
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            conn.Dispose()
            If i = 0 Then
                MsgBox("Invalid Username ID or Password!", MsgBoxStyle.Critical, "Error")
                username.Text = ""
                password.Text = ""
            ElseIf i = 1 Then
                Welcome_Applicant.Show()
                conn.Open()
                Query = "select name,dob,gender,email_id,mobile_no,location from Applicant where Username='" & username.Text & "'"
                comm = New MySqlCommand(Query, conn)
                Reader = comm.ExecuteReader()
                While Reader.Read
                    Welcome_Applicant.Label2.Text = reader.GetString("name")
                    Welcome_Applicant.DOB.Text = reader.GetString("dob")
                    Welcome_Applicant.Gender.Text = reader.GetString("gender")
                    Welcome_Applicant.Email.Text = reader.GetString("email_id")
                    Welcome_Applicant.Mobile.Text = reader.GetString("mobile_no")
                    Welcome_Applicant.Location.Text = reader.GetString("Location")

                End While
                Applicant_login.Close()
                Appregister.Close()
                Me.Hide()
            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class