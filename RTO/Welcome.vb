Public Class Welcome
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start.Close()
        Timer1.Interval = 500
        Timer1.Start()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RTO_Officer.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Label4.Text.Substring(1) & Label4.Text.Substring(0, 1)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Applicant.Show()
        Me.Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dealer.Show()
        Me.Hide()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TRACK_APPLICATION.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class