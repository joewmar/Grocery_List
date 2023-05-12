Imports Grocery_List.DataClass
Public Class frmCart

    Function TotalCostCalculation() As Double ' This function use to call any where and use when update that changes of items
        ''''Total Cost
        'to reset a total cost because of update of items
        For num As Integer = 0 To lvYourCart.Items.Count - 1
            TotalCost = TotalCost + lvYourCart.Items(num).SubItems(3).Text
        Next num

        Return TotalCost
    End Function
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        GroceryName.Clear()             'To clear a list or array
        Price.Clear()
        Quantity.Clear()
        Amount.Clear()
        Me.Hide()
    End Sub

    Private Sub frmCart_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Dim listing As New ListViewItem

        '''''''''''''''''''''''''''''''''''Adding items in List View
        For i As Integer = 0 To GroceryName.Count - 1 'Count of list

            If Not lvYourCart.FindItemWithText(GroceryName.Item(i)) Is Nothing Then 'Find item if already have

                For j As Integer = 0 To lvYourCart.Items.Count - 1
                    If lvYourCart.Items(j).SubItems(0).Text = GroceryName.Item(i) Then
                        Continue For
                    End If
                Next

            Else
                listing = lvYourCart.Items.Add(GroceryName.Item(i))
                listing.SubItems.Add(Price.Item(i))
                listing.SubItems.Add(Quantity.Item(i))
                listing.SubItems.Add(Amount.Item(i))
                TotalCostCalculation()  ' We call this function to calculate total of items

                'For adding receipt List
                ReceiptGroceryName.Add(GroceryName.Item(i))
                ReceiptPrice.Add(Price.Item(i))
                ReceiptQuantity.Add(Quantity.Item(i))
                ReceiptAmount.Add(Amount.Item(i))
            End If

        Next i

        GroceryName.Clear()
        Price.Clear()
        Quantity.Clear()
        Amount.Clear()

        lblTotalCost.Text = CStr(TotalCost)

    End Sub

    Private Sub lvYourCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvYourCart.SelectedIndexChanged
        If lvYourCart.SelectedItems.Count > 0 Then
            lbCartUpdates.Text = lvYourCart.SelectedItems(0).SubItems(0).Text
            nudCartUpdate.Value = lvYourCart.SelectedItems(0).SubItems(2).Text
            lblqt.Visible = True
            btnUpdate.Visible = True
            nudCartUpdate.Visible = True
            lbCartUpdates.Visible = True
            btnDelete.Visible = True
        Else
            btnUpdate.Visible = False
            lblqt.Visible = False
            nudCartUpdate.Visible = False
            lbCartUpdates.Visible = False
            btnDelete.Visible = False
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lvYourCart.SelectedItems.Count > 0 Then

            Dim UpdateTotalCost As Double = Calculation(nudCartUpdate.Value, CDbl(lvYourCart.SelectedItems(0).SubItems(1).Text))
            'For Update a ReceiptList
            If ReceiptQuantity.Contains(lvYourCart.SelectedItems(0).SubItems(2).Text) And ReceiptAmount.Contains(lvYourCart.SelectedItems(0).SubItems(3).Text) Then
                ReceiptQuantity(ReceiptQuantity.IndexOf(lvYourCart.SelectedItems(0).SubItems(2).Text)) = nudCartUpdate.Value
                ReceiptAmount(ReceiptAmount.IndexOf(lvYourCart.SelectedItems(0).SubItems(3).Text)) = UpdateTotalCost   ' Error
            End If

            'For update ListCart
            lvYourCart.SelectedItems(0).SubItems(2).Text = nudCartUpdate.Value
            lvYourCart.SelectedItems(0).SubItems(3).Text = UpdateTotalCost
            TotalCost = 0.0
            TotalCostCalculation() ' We call this function to recalculate total of items
            lblTotalCost.Text = CStr(TotalCost)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvYourCart.SelectedItems.Count > 0 Then
            'For Remove Receipt List
            If ReceiptGroceryName.Contains(lvYourCart.SelectedItems(0).SubItems(0).Text) And ReceiptAmount.Contains(lvYourCart.SelectedItems(0).SubItems(3).Text) And ReceiptPrice.Contains(lvYourCart.SelectedItems(0).SubItems(1).Text) And ReceiptQuantity.Contains(lvYourCart.SelectedItems(0).SubItems(2).Text) Then
                ReceiptGroceryName.Remove(lvYourCart.SelectedItems(0).SubItems(0).Text)
                ReceiptPrice.Remove(lvYourCart.SelectedItems(0).SubItems(1).Text)
                ReceiptQuantity.Remove(lvYourCart.SelectedItems(0).SubItems(2).Text)
                ReceiptAmount.Remove(lvYourCart.SelectedItems(0).SubItems(3).Text)
            End If
            'For remove ListCart
            lvYourCart.Items.Remove(lvYourCart.SelectedItems(0))                     ' Remove of Seleted Items you select

            TotalCost = 0.0
            TotalCostCalculation()  'Recalcule a total of amounts
            lblTotalCost.Text = CStr(TotalCost)
            lbCartUpdates.Text = ""
            nudCartUpdate.Value = 1

        End If
    End Sub

    Private Sub btnBuyNow_Click(sender As Object, e As EventArgs) Handles btnBuyNow.Click


        If lblTotalCost.Text <> 0.0 Then
            frmBuyNow.Show()

        Else
            MsgBox("Choose at once item before you buy", vbOKOnly + vbInformation, "Information")
        End If
    End Sub


End Class