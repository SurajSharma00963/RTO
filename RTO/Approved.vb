Imports MySql.Data.MySqlClient
Public Class Approved
    Dim conn As New MySqlConnection
    Private Sub Approved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            conn.Open()
            adapter = New MySqlDataAdapter("SELECT application_no,type_of_Licence,Name_Of_Applicant,Status FROM Registered where status = 'Your Application Has Been Approved Wait For Your LL'", conn)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Welcome_officer.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class