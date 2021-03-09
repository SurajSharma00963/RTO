Public Class RTO_Officer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If RadioButton1.Checked Then

            RTO_Login.Show()
            Me.Close()
        ElseIf RadioButton2.Checked Then
            Welcome.Show()
            Me.Close()
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label2.Visible = True
            Label2.Text = "Next"
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label2.Visible = True
            Label2.Text = "Back"
        End If
    End Sub
    Private Sub Rto_officer_Load(sender As Object, e As EventArgs) Handles MyBase.Click
        Label2.Visible = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Welcome.Show()
        Me.Close()

    End Sub
End Class