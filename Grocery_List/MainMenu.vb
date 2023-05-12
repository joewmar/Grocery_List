
Public Class frmMain
    Private Sub btnMenusSnacks_Click(sender As Object, e As EventArgs) Handles btnMenusSnacks.Click
        frmSnacks.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenusRG_Click(sender As Object, e As EventArgs) Handles btnMenusRG.Click
        frmRG.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenusDrinks_Click(sender As Object, e As EventArgs) Handles btnMenusDrinks.Click
        frmDrinks.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenusSS_Click(sender As Object, e As EventArgs) Handles btnMenusSS.Click
        frmSaucesSeasoning.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenusNoddles_Click(sender As Object, e As EventArgs) Handles btnMenusNoddles.Click
        frmNoodles.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenusCB_Click(sender As Object, e As EventArgs) Handles btnMenusCB.Click
        frmCB.Show()
        Me.Hide()
    End Sub

    Private Sub tsYourCartMainMenu_Click(sender As Object, e As EventArgs) Handles tsYourCartMainMenu.Click
        frmCart.Show()
    End Sub

    Private Sub tsExit2_Click(sender As Object, e As EventArgs) Handles tsExit.Click
        Application.Exit()
    End Sub

    Private Sub tsAboutUs_Click(sender As Object, e As EventArgs) Handles tsAboutUs.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub tsHelp_Click(sender As Object, e As EventArgs) Handles tsHelp.Click
        frmHelp.ShowDialog()
    End Sub

    Private Sub tsMyOrders_Click(sender As Object, e As EventArgs) Handles tsMyOrders.Click
        frmMyOrders.Show()
    End Sub
End Class
