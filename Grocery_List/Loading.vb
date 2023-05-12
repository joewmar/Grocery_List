Public Class frmLoading
    Private Sub TimerLoading_Tick(sender As Object, e As EventArgs) Handles TimerLoading.Tick
        Me.pbLoading.Value = pbLoading.Value + 1
        If pbLoading.Value >= 100 Then
            TimerLoading.Stop()
            frmMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerLoading.Start()
    End Sub
End Class