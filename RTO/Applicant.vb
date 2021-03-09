Imports MySql.Data.MySqlClient
Public Class Applicant
    Dim conn As New MySqlConnection
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Applicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Rto_managementDataSet2.vehicle' table. You can move, or remove it, as needed.

        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If DateTimePicker1.Value <= "12-12-1997" Then
            MsgBox("You are eligible to apply DL and LL", MsgBoxStyle.Information, "Ready To Apply")
            Label4.Show()
            Label4.Text = "Next"
            Label2.Hide()
        ElseIf DateTimePicker1.Value >= "12-12-1997" Then
            MsgBox("Sorry you are not 18 yrs old and not eligible", MsgBoxStyle.Information, "")
            If vbOK Then
                DateTimePicker1.Hide()
                Label2.Hide()
                Label3.Hide()
                RadioButton2.Show()
                RadioButton2.Checked = True
                Label4.Show()
                Label4.Text = "Back"
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            DateTimePicker1.Show()
            Label2.Show()
            Label3.Show()
            Label4.Hide()
            RadioButton2.Hide()

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If RadioButton2.Checked Then
            Welcome.Show()
            Me.Close()
        ElseIf Label4.Text = "Next" Then
            LLRegistration.Show()
            Me.Close()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label4.Show()
            Label4.Text = "Back"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        RadioButton1.Show()
        RadioButton2.Show()

        Button2.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        starttest.Show()
        Button1.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Button1.Show()
        Button2.Show()
        Button4.Show()

    End Sub

    Private Sub Applicant_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Button1.Visible = False
        Button2.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RadioButton1.Show()
        RadioButton2.Show()
        Button2.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        starttest.Show()
        Button1.Hide()
    End Sub
End Class