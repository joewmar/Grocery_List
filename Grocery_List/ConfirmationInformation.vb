Imports Grocery_List.DataClass
Imports System.Text
Imports Grocery_List.frmCart
Imports System.Windows.Forms

Public Class frmConfirmInfor

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub ConfirmationInformation_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If RecieptNoCI = "" Then
            Dim s As String = "0123456789"
            Dim r As New Random
            Dim sb As New StringBuilder

            ' Random number for receipt number
            For i As Integer = 1 To 8
                Dim idx As Integer = r.Next(0, 10)
                sb.Append(s.Substring(idx, 1))
            Next
            RecieptNoCI = sb.ToString
        End If

        'Receipt Information e.g name address.....
        lblReceiptName.Text = FirstName & " " & LastName

        If thisDate.Day <= 9 Then ' For adding 0 on day
            lblReceiptDate.Text = thisDate.Month & "/" & "0" & thisDate.Day & "/" & thisDate.Year
        Else
            lblReceiptDate.Text = thisDate.Month & "/" & thisDate.Day & "/" & thisDate.Year
        End If

        lblReceiptAddress.Text = Address
        lblReceiptPhoneNo.Text = PhoneNumber
        lblReceiptEmail.Text = Email
        lblReceiptTypePay.Text = TypePayments
        lblReceiptTypeDelivery.Text = TypeDelivery
        lblReceiptNo.Text = RecieptNoCI




        lblReceiptTotalCost.Text = TotalCost
        lblReceiptShipFees.Text = DeliveryShipFess
        Dim addAll As Double = CDbl(lblReceiptTotalCost.Text) + CDbl(lblReceiptShipFees.Text)
        lblTotaALL.Text = CStr(addAll)

    End Sub

    Private Sub frmConfirmInfor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim ReceiptListing As New ListViewItem

        For ReceiptCount As Integer = 0 To ReceiptGroceryName.Count - 1 'Count of list
            If Not lvReceipt.FindItemWithText(ReceiptGroceryName.Item(ReceiptCount)) Is Nothing Then 'Find item if already have

                For j As Integer = 0 To lvReceipt.Items.Count - 1
                    If lvReceipt.Items(j).SubItems(0).Text = ReceiptGroceryName.Item(ReceiptCount) Then
                        Continue For
                    End If
                Next
            Else

                ReceiptListing = lvReceipt.Items.Add(ReceiptGroceryName.Item(ReceiptCount))
                ReceiptListing.SubItems.Add(ReceiptPrice.Item(ReceiptCount))
                ReceiptListing.SubItems.Add(ReceiptQuantity.Item(ReceiptCount))
                ReceiptListing.SubItems.Add(ReceiptAmount.Item(ReceiptCount))


            End If

        Next ReceiptCount


        ReceiptGroceryName.Clear()
        ReceiptPrice.Clear()
        ReceiptQuantity.Clear()
        ReceiptAmount.Clear()

    End Sub

    Private Sub frmConfirmInfor_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler btnSubmit.Click, AddressOf frmMyOrders.ProcessMyOrders
    End Sub

End Class
