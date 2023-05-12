Imports Grocery_List.DataClass
Public Class frmRG
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles tsYourCartRG.Click
        frmCart.Show()
    End Sub

    Private Sub btnRGAddCart1_Click(sender As Object, e As EventArgs) Handles btnRGAddCart1.Click
        Dim DrinksPriceCost As Double = lblPriceRG1.Text
        Dim DrinksQuantity As Integer = nudQuatityRG1.Value
        GroceryName.Add(lblGroceryRG1.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerRG.Enabled = True
    End Sub

    Private Sub btnRGAddCart2_Click(sender As Object, e As EventArgs) Handles btnRGAddCart2.Click
        Dim DrinksPriceCost As Double = lblPriceRG2.Text
        Dim DrinksQuantity As Integer = nudQuatityRG2.Value
        GroceryName.Add(lblGroceryRG2.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerRG.Enabled = True
    End Sub

    Private Sub btnRGAddCart3_Click(sender As Object, e As EventArgs) Handles btnRGAddCart3.Click
        Dim DrinksPriceCost As Double = lblPriceRG3.Text
        Dim DrinksQuantity As Integer = nudQuatityRG3.Value
        GroceryName.Add(lblGroceryRG3.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerRG.Enabled = True
    End Sub

    Private Sub btnRGAddCart4_Click(sender As Object, e As EventArgs) Handles btnRGAddCart4.Click
        Dim DrinksPriceCost As Double = lblPriceRG4.Text
        Dim DrinksQuantity As Integer = nudQuatityRG4.Value
        GroceryName.Add(lblGroceryRG4.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerRG.Enabled = True
    End Sub

    Private Sub btnRGAddCart5_Click(sender As Object, e As EventArgs) Handles btnRGAddCart5.Click
        Dim DrinksPriceCost As Double = lblPriceRG5.Text
        Dim DrinksQuantity As Integer = nudQuatityRG5.Value
        GroceryName.Add(lblGroceryRG5.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerRG.Enabled = True
    End Sub

    Private Sub btnRGAddCart6_Click(sender As Object, e As EventArgs) Handles btnRGAddCart6.Click
        Dim DrinksPriceCost As Double = lblPriceRG6.Text
        Dim DrinksQuantity As Integer = nudQuatityRG6.Value
        GroceryName.Add(lblGroceryRG6.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerRG.Enabled = True
    End Sub

    Private Sub btnRGAddCart7_Click(sender As Object, e As EventArgs) Handles btnRGAddCart7.Click
        Dim DrinksPriceCost As Double = lblPriceRG7.Text
        Dim DrinksQuantity As Integer = nudQuatityRG7.Value
        GroceryName.Add(lblGroceryRG7.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerRG.Enabled = True
    End Sub

    Private Sub TimerRG_Tick(sender As Object, e As EventArgs) Handles TimerRG.Tick
        TimerRG.Interval = 1
        If picItemsAdded.Left > tsYourCartRG.Width - 10 Then
            picItemsAdded.Left -= 30
        Else
            picItemsAdded.Location = New Point(1105, 11)
            picItemsAdded.Visible = False
            TimerRG.Enabled = False
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        frmHelp.ShowDialog()
    End Sub
End Class