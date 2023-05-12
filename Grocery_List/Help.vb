Public Class frmHelp
    Private Sub TimerHelp_Tick(sender As Object, e As EventArgs) Handles TimerHelp.Tick
        TimerHelp.Interval = 10
        If picItemsAdded.Left < Me.Width + 10 Then
            picItemsAdded.Left += 10
        Else
            picItemsAdded.Location = New Point(54, 36)
        End If

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        picItemsAdded.Location = New Point(1105, 11)
        TimerHelp.Stop()
        Me.Close()
    End Sub

    Private Sub frmHelp_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TimerHelp.Start()
    End Sub
End Class