Public Class billgenerated
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, rno.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click, Label9.Click, type.Click, status.Click, cardno.Click, appno.Click, amt.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Your bill is being Printed", MsgBoxStyle.Information, "information")
        If vbOK Then
            Welcome.Show()
            Me.Close()
            Application_View.Close()

        End If
    End Sub

    Private Sub billgenerated_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class