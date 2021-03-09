Public Class Start
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer,
         ByVal wMsg As Integer, ByVal wParam As Integer,
         ByVal lParam As Integer) As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = "Please wait Loading...!"
        ProgressBar1.Visible = True
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Welcome.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Text = Label3.Text.Substring(1) & Label3.Text.Substring(0, 1)
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Label3.Text
        Timer2.Interval = 500
        Timer2.Start()
        SendMessage(ProgressBar1.Handle, 1040, 3, 0)
        ProgressBar1.Increment(3)
    End Sub
End Class
