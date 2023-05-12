Imports Grocery_List.DataClass
Public Class frmSaucesSeasoning
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles tsYourCartSS.Click
        frmCart.Show()
    End Sub

    Private Sub btnSSAddCart1_Click(sender As Object, e As EventArgs) Handles btnSSAddCart1.Click
        Dim DrinksPriceCost As Double = lblPriceSS1.Text
        Dim DrinksQuantity As Integer = nudQuatitySS1.Value
        GroceryName.Add(lblGrocerySS1.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub btnSSAddCart2_Click(sender As Object, e As EventArgs) Handles btnSSAddCart2.Click
        Dim DrinksPriceCost As Double = lblPriceSS2.Text
        Dim DrinksQuantity As Integer = nudQuatitySS2.Value
        GroceryName.Add(lblGrocerySS2.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub btnSSAddCart3_Click(sender As Object, e As EventArgs) Handles btnSSAddCart3.Click
        Dim DrinksPriceCost As Double = lblPriceSS3.Text
        Dim DrinksQuantity As Integer = nudQuatitySS3.Value
        GroceryName.Add(lblGrocerySS3.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub btnSSAddCart4_Click(sender As Object, e As EventArgs) Handles btnSSAddCart4.Click
        Dim DrinksPriceCost As Double = lblPriceSS4.Text
        Dim DrinksQuantity As Integer = nudQuatitySS4.Value
        GroceryName.Add(lblGrocerySS4.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub btnSSAddCart5_Click(sender As Object, e As EventArgs) Handles btnSSAddCart5.Click
        Dim DrinksPriceCost As Double = lblPriceSS5.Text
        Dim DrinksQuantity As Integer = nudQuatitySS4.Value
        GroceryName.Add(lblGrocerySS5.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub btnSSAddCart6_Click(sender As Object, e As EventArgs) Handles btnSSAddCart6.Click
        Dim DrinksPriceCost As Double = lblPriceSS6.Text
        Dim DrinksQuantity As Integer = nudQuatitySS6.Value
        GroceryName.Add(lblGrocerySS6.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub btnSSAddCart7_Click(sender As Object, e As EventArgs) Handles btnSSAddCart7.Click
        Dim DrinksPriceCost As Double = lblPriceSS7.Text
        Dim DrinksQuantity As Integer = nudQuatitySS7.Value
        GroceryName.Add(lblGrocerySS7.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub btnSSAddCart8_Click(sender As Object, e As EventArgs) Handles btnSSAddCart8.Click
        Dim DrinksPriceCost As Double = lblPriceSS8.Text
        Dim DrinksQuantity As Integer = nudQuatitySS8.Value
        GroceryName.Add(lblGrocerySS8.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub btnSSAddCart9_Click(sender As Object, e As EventArgs) Handles btnSSAddCart9.Click
        Dim DrinksPriceCost As Double = lblPriceSS9.Text
        Dim DrinksQuantity As Integer = nudQuatitySS9.Value
        GroceryName.Add(lblGrocerySS9.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub btnSSAddCart_Click(sender As Object, e As EventArgs) Handles btnSSAddCart.Click
        Dim DrinksPriceCost As Double = lblPriceSS10.Text
        Dim DrinksQuantity As Integer = nudQuatitySS10.Value
        GroceryName.Add(lblGrocerySS10.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerSS.Enabled = True
    End Sub

    Private Sub TimerSS_Tick(sender As Object, e As EventArgs) Handles TimerSS.Tick
        TimerSS.Interval = 1
        If picItemsAdded.Left > tsYourCartSS.Width - 10 Then
            picItemsAdded.Left -= 30
        Else
            picItemsAdded.Location = New Point(1105, 11)
            picItemsAdded.Visible = False
            TimerSS.Enabled = False
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        frmHelp.ShowDialog()
    End Sub
End Class