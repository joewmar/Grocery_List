Imports Grocery_List.DataClass

Public Class frmNoodles
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles tsYourCartNoodles.Click
        frmCart.Show()
    End Sub

    Private Sub btnNoodlesAddCart1_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart1.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles1.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles1.Value
        GroceryName.Add(lblGroceryNoodles1.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub btnNoodlesAddCart2_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart2.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles2.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles2.Value
        GroceryName.Add(lblGroceryNoodles2.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub btnNoodlesAddCart3_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart3.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles3.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles3.Value
        GroceryName.Add(lblGroceryNoodles3.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub btnNoodlesAddCart4_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart4.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles4.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles4.Value
        GroceryName.Add(lblGroceryNoodles4.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub btnNoodlesAddCart5_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart5.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles5.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles5.Value
        GroceryName.Add(lblGroceryNoodles5.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub btnNoodlesAddCart6_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart6.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles6.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles6.Value
        GroceryName.Add(lblGroceryNoodles6.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub btnNoodlesAddCart7_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart7.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles7.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles7.Value
        GroceryName.Add(lblGroceryNoodles7.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub btnNoodlesAddCart8_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart8.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles8.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles8.Value
        GroceryName.Add(lblGroceryNoodles8.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub btnNoodlesAddCart9_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart9.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles9.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles9.Value
        GroceryName.Add(lblGroceryNoodles9.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub btnNoodlesAddCart10_Click(sender As Object, e As EventArgs) Handles btnNoodlesAddCart10.Click
        Dim DrinksPriceCost As Double = lblPriceNoodles10.Text
        Dim DrinksQuantity As Integer = nudQuatityNoodles10.Value
        GroceryName.Add(nudQuatityNoodles10.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerNoodles.Enabled = True
    End Sub

    Private Sub TimerNoodles_Tick(sender As Object, e As EventArgs) Handles TimerNoodles.Tick
        TimerNoodles.Interval = 1
        If picItemsAdded.Left > tsYourCartNoodles.Width - 10 Then
            picItemsAdded.Left -= 30
        Else
            picItemsAdded.Location = New Point(1105, 11)
            picItemsAdded.Visible = False
            TimerNoodles.Enabled = False
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        frmHelp.ShowDialog()
    End Sub
End Class