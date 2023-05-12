Imports Grocery_List.DataClass
Public Class frmCB

    Dim GroceryNameCB As List(Of String) = New List(Of String)()
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub tsYourCartCB_Click(sender As Object, e As EventArgs) Handles tsYourCartCB.Click
        frmCart.Show()
    End Sub

    Private Sub btnCBsAddCart1_Click(sender As Object, e As EventArgs) Handles btnCBsAddCart1.Click
        Dim DrinksPriceCost As Double = lblPriceCB1.Text
        Dim DrinksQuantity As Integer = nudQuatityCB1.Value
        GroceryNameCB.Add(lblGroceryCB8.Text)
        GroceryName.Add(lblGroceryCB1.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerCB.Enabled = True
    End Sub

    Private Sub btnCBsAddCart2_Click(sender As Object, e As EventArgs) Handles btnCBsAddCart2.Click
        Dim DrinksPriceCost As Double = lblPriceCB2.Text
        Dim DrinksQuantity As Integer = nudQuatityCB2.Value
        GroceryNameCB.Add(lblGroceryCB8.Text)
        GroceryName.Add(lblGroceryCB2.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerCB.Enabled = True
    End Sub

    Private Sub btnCBsAddCart3_Click(sender As Object, e As EventArgs) Handles btnCBsAddCart3.Click
        Dim DrinksPriceCost As Double = lblPriceCB3.Text
        Dim DrinksQuantity As Integer = nudQuatityCB3.Value
        GroceryNameCB.Add(lblGroceryCB8.Text)
        GroceryName.Add(lblGroceryCB3.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerCB.Enabled = True
    End Sub

    Private Sub btnCBsAddCart4_Click(sender As Object, e As EventArgs) Handles btnCBsAddCart4.Click
        Dim DrinksPriceCost As Double = lblPriceCB4.Text
        Dim DrinksQuantity As Integer = nudQuatityCB4.Value
        GroceryNameCB.Add(lblGroceryCB8.Text)
        GroceryName.Add(lblGroceryCB4.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerCB.Enabled = True
    End Sub

    Private Sub btnCBsAddCart5_Click(sender As Object, e As EventArgs) Handles btnCBsAddCart5.Click
        Dim DrinksPriceCost As Double = lblPriceCB5.Text
        Dim DrinksQuantity As Integer = nudQuatityCB5.Value
        GroceryNameCB.Add(lblGroceryCB8.Text)
        GroceryName.Add(lblGroceryCB5.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerCB.Enabled = True
    End Sub

    Private Sub btnCBsAddCart6_Click(sender As Object, e As EventArgs) Handles btnCBsAddCart6.Click
        Dim DrinksPriceCost As Double = lblPriceCB6.Text
        Dim DrinksQuantity As Integer = nudQuatityCB6.Value
        GroceryNameCB.Add(lblGroceryCB8.Text)
        GroceryName.Add(lblGroceryCB6.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerCB.Enabled = True
    End Sub

    Private Sub btnCBsAddCart7_Click(sender As Object, e As EventArgs) Handles btnCBsAddCart7.Click
        Dim DrinksPriceCost As Double = lblPriceCB7.Text
        Dim DrinksQuantity As Integer = nudQuatityCB7.Value
        GroceryNameCB.Add(lblGroceryCB8.Text)
        GroceryName.Add(lblGroceryCB7.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerCB.Enabled = True
    End Sub

    Private Sub btnCBsAddCart8_Click(sender As Object, e As EventArgs) Handles btnCBsAddCart8.Click
        Dim DrinksPriceCost As Double = lblPriceCB8.Text
        Dim DrinksQuantity As Integer = nudQuatityCB8.Value
        GroceryNameCB.Add(lblGroceryCB8.Text)
        GroceryName.Add(lblGroceryCB8.Text)
        Price.Add(DrinksPriceCost)
        Quantity.Add(DrinksQuantity)
        Amount.Add(Calculation(DrinksPriceCost, DrinksQuantity))
        picItemsAdded.Visible = True
        TimerCB.Enabled = True
    End Sub


    Private Sub TimerCB_Tick(sender As Object, e As EventArgs) Handles TimerCB.Tick
        TimerCB.Interval = 1
        If picItemsAdded.Left > tsYourCartCB.Width - 10 Then
            picItemsAdded.Left -= 30
        Else
            picItemsAdded.Location = New Point(1105, 11)
            TimerCB.Enabled = False
            picItemsAdded.Visible = False
        End If

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        frmHelp.ShowDialog()
    End Sub
End Class