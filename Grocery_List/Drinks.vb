Imports Grocery_List.DataClass
Public Class frmDrinks
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub tsYourCartDrinks_Click(sender As Object, e As EventArgs) Handles tsYourCartDrinks.Click
        frmCart.Show()
    End Sub

    Private Sub btnDrinksAddCart1_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart1.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks1.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks1.Value
        GroceryName.Add(lblGroceryDrinks1.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub btnDrinksAddCart2_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart2.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks2.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks2.Value
        GroceryName.Add(lblGroceryDrinks2.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub btnDrinksAddCart3_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart3.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks3.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks3.Value
        GroceryName.Add(lblGroceryDrinks3.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub btnDrinksAddCart4_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart4.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks4.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks4.Value
        GroceryName.Add(lblGroceryDrinks4.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub btnDrinksAddCart5_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart5.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks5.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks5.Value
        GroceryName.Add(lblGroceryDrinks5.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub btnDrinksAddCart6_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart6.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks6.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks6.Value
        GroceryName.Add(lblGroceryDrinks6.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub btnDrinksAddCart7_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart7.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks7.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks7.Value
        GroceryName.Add(lblGroceryDrinks7.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub btnDrinksAddCart8_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart8.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks8.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks8.Value
        GroceryName.Add(lblGroceryDrinks8.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub btnDrinksAddCart9_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart9.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks9.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks9.Value
        GroceryName.Add(lblGroceryDrinks9.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub btnDrinksAddCart10_Click(sender As Object, e As EventArgs) Handles btnDrinksAddCart10.Click
        Dim DrinksPriceCost As Double = lblPriceDrinks10.Text
        Dim DrinksQuantity As Integer = nudQuatityDrinks10.Value
        GroceryName.Add(lblGroceryDrinks10.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerDrinks.Enabled = True
    End Sub

    Private Sub TimerDrinks_Tick(sender As Object, e As EventArgs) Handles TimerDrinks.Tick
        TimerDrinks.Interval = 1
        If picItemsAdded.Left > tsYourCartDrinks.Width - 10 Then
            picItemsAdded.Left -= 30
        Else
            picItemsAdded.Location = New Point(1105, 11)
            picItemsAdded.Visible = False
            TimerDrinks.Enabled = False
        End If
    End Sub

    Private Sub tsHelp_Click(sender As Object, e As EventArgs) Handles tsHelp.Click
        frmHelp.ShowDialog()
    End Sub
End Class