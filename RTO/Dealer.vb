Public Class Dealer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dealerlogin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DealarRegistration.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RulesRegulation.Show()
        Me.Close()
    End Sub
End Class