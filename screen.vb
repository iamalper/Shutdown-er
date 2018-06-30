Public Class screen

    Public force As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckBox1.Checked = True Then force = True

        timer.Interval = secondsnum.Value * 6000

        timer.Start()

        Me.Visible = False


    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick

        If force = True Then
            Shell("shutdown /p /f")
        Else
            Shell("shutdown /p")
        End If
        timer.Stop()

    End Sub
End Class
