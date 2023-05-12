Imports Grocery_List.DataClass

Public Class frmSnacks

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles tsYourCartSnacks.Click
        frmCart.Show()
    End Sub

    Private Sub btnSnackAddCart1_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart1.Click
        GroceryName.Add(lblGrocerySnacks1.Text)
        Price.Add(lblPriceSnack1.Text)
        Quantity.Add(nudQuatitySnacks1.Value)
        Amount.Add(Calculation(CDbl(lblPriceSnack1.Text), CDbl(nudQuatitySnacks1.Value)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True

    End Sub

    Private Sub btnSnackAddCart2_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart2.Click
        GroceryName.Add(lblGrocerySnacks2.Text)
        Price.Add(lblPriceSnack2.Text)
        Quantity.Add(nudQuatitySnacks2.Value)
        Amount.Add(Calculation(CDbl(lblPriceSnack2.Text), CDbl(nudQuatitySnacks2.Value)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart3_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart3.Click
        GroceryName.Add(lblGrocerySnacks3.Text)
        Price.Add(lblPriceSnack3.Text)
        Quantity.Add(nudQuatitySnacks3.Value)
        Amount.Add(Calculation(CDbl(lblPriceSnack3.Text), CDbl(nudQuatitySnacks3.Value)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart4_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart4.Click
        GroceryName.Add(lblGrocerySnacks4.Text)
        Price.Add(lblPriceSnack4.Text)
        Quantity.Add(nudQuatitySnacks4.Value)
        Amount.Add(Calculation(CDbl(lblPriceSnack4.Text), CDbl(nudQuatitySnacks4.Value)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart5_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart5.Click
        GroceryName.Add(lblGrocerySnacks5.Text)
        Price.Add(lblPriceSnack5.Text)
        Quantity.Add(nudQuatitySnacks5.Value)
        Amount.Add(Calculation(CDbl(lblPriceSnack5.Text), CDbl(nudQuatitySnacks5.Value)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart6_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart6.Click
        GroceryName.Add(lblGrocerySnacks6.Text)
        Price.Add(lblPriceSnack6.Text)
        Quantity.Add(nudQuatitySnacks6.Value)
        Amount.Add(Calculation(CDbl(lblPriceSnack6.Text), CDbl(nudQuatitySnacks6.Value)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart7_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart7.Click
        GroceryName.Add(lblGrocerySnacks7.Text)
        Price.Add(lblPriceSnack7.Text)
        Quantity.Add(nudQuatitySnacks7.Value)
        Amount.Add(Calculation(CDbl(lblPriceSnack7.Text), CDbl(nudQuatitySnacks7.Value)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart8_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart8.Click
        GroceryName.Add(lblGrocerySnacks8.Text)
        Price.Add(lblPriceSnack8.Text)
        Quantity.Add(nudQuatitySnacks8.Value)
        Amount.Add(Calculation(CDbl(lblPriceSnack8.Text), CDbl(nudQuatitySnacks8.Value)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart9_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart9.Click
        GroceryName.Add(lblGrocerySnacks9.Text)
        Price.Add(lblPriceSnack9.Text)
        Quantity.Add(nudQuatitySnacks9.Value)
        Amount.Add(Calculation(CDbl(lblPriceSnack9.Text), CDbl(nudQuatitySnacks9.Value)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart10_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart10.Click
        Dim qt As Integer = nudQuatitySnacks10.Value
        Dim pricecost As Double = lblPriceSnack10.Text
        GroceryName.Add(lblGrocerySnacks10.Text)
        Price.Add(pricecost)
        Quantity.Add(qt)
        Amount.Add(Calculation(pricecost, CDbl(qt)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart11_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart11.Click
        Dim qt As Integer = nudQuatitySnacks11.Value
        Dim pricecost As Double = lblPriceSnack11.Text
        GroceryName.Add(lblGrocerySnacks11.Text)
        Price.Add(pricecost)
        Quantity.Add(qt)
        Amount.Add(Calculation(pricecost, CDbl(qt)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart12_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart12.Click
        Dim qt As Integer = nudQuatitySnacks12.Value
        Dim pricecost As Double = lblPriceSnack12.Text
        GroceryName.Add(lblGrocerySnacks12.Text)
        Price.Add(pricecost)
        Quantity.Add(qt)
        Amount.Add(Calculation(pricecost, CDbl(qt)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub btnSnackAddCart13_Click(sender As Object, e As EventArgs) Handles btnSnackAddCart13.Click
        Dim qt As Integer = nudQuatitySnacks13.Value
        Dim pricecost As Double = lblPriceSnack13.Text
        GroceryName.Add(lblGrocerySnacks13.Text)
        Price.Add(pricecost)
        Quantity.Add(qt)
        Amount.Add(Calculation(pricecost, CDbl(qt)))
        picItemsAdded.Visible = True
        TimerSnacks.Enabled = True
    End Sub

    Private Sub TimerSnacks_Tick(sender As Object, e As EventArgs) Handles TimerSnacks.Tick
        TimerSnacks.Interval = 1
        If picItemsAdded.Left > tsYourCartSnacks.Width - 10 Then
            picItemsAdded.Left -= 30
        Else
            picItemsAdded.Location = New Point(1105, 11)
            picItemsAdded.Visible = False
            TimerSnacks.Enabled = False
        End If
    End Sub

    Private Sub tsHelp_Click(sender As Object, e As EventArgs) Handles tsHelp.Click
        frmHelp.ShowDialog()
    End Sub
End Class