Imports MySql.Data.MySqlClient
Public Class Welcome_Applicant
    Dim conn As New MySqlConnection
    Private Sub Welcome_Applicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("You Have been Successfully Logged Out", vbOK)
        If vbOK Then
            Welcome.Show()
            Me.Close()
            'App_Login.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LLRegistration.Show()

        Me.Hide()
    End Sub
End Class