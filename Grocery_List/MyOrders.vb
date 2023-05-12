Imports Grocery_List.DataClass
Imports Grocery_List.frmConfirmInfor
Public Class frmMyOrders

    Dim r As Double = 2.0
    Dim NameControlNo As Integer = 1

    Public Sub ProcessMyOrders(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As New System.Windows.Forms.Panel()  ' It is used to create label at run time 
        FlowLayoutPanelOrders.Controls.Add(panel) ' Add() method is used to Add Label  
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Size = New Size(1077, 189)
        panel.Name = "panel" & NameControlNo

        Dim NameLabel, AddressLabel, ContactInfoLabelTitle, ContactInfoLabelNumber, ContactInfoLabelEmail, DeliveryLabelTitle, DeliveryLabelPayments, DeliveryLabelDeliveryExpress, ReceiptTitle, ReceiptNo, ReceiptDate, TotalLabelTitle, TotalLabelCost As New System.Windows.Forms.Label()
        Dim CancelButton As New System.Windows.Forms.Button()
        Dim ControlsOrders As List(Of Control) = New List(Of Control)({NameLabel, AddressLabel, ContactInfoLabelTitle, ContactInfoLabelNumber, ContactInfoLabelEmail, DeliveryLabelTitle, DeliveryLabelPayments, DeliveryLabelDeliveryExpress, ReceiptTitle, ReceiptNo, ReceiptDate, TotalLabelTitle, TotalLabelCost, CancelButton})
        For Each adding In ControlsOrders
            panel.Controls.Add(adding)
        Next

        'Full Name
        NameLabel.Text = FirstName & " " & LastName
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(34, 31)
        NameLabel.Font = New Font("Verdana", emSize:=10.25, FontStyle.Bold) 'Set the font style of the label   label.Font = New Font("Times New Roman", 12) 'Set the font style of the label   

        'Address
        AddressLabel.Text = Address
        AddressLabel.Size = New Size(260, 68)
        AddressLabel.Location = New Point(35, 58)
        AddressLabel.Font = New Font("Verdana", emSize:=9.75)

        'ContactInfoLabel

        ContactInfoLabelTitle.Text = "Contact Info.:"
        ContactInfoLabelTitle.Size = New Size(109, 21)
        ContactInfoLabelTitle.Location = New Point(400, 37)
        ContactInfoLabelTitle.Font = New Font("Verdana", emSize:=9.75, FontStyle.Bold)

        'ContactInfoNumber

        ContactInfoLabelNumber.Text = PhoneNumber
        ContactInfoLabelNumber.Size = New Size(112, 21)
        ContactInfoLabelNumber.Location = New Point(510, 37)
        ContactInfoLabelNumber.Font = New Font("Verdana", emSize:=9.75)

        'ContactInfoEmail

        ContactInfoLabelEmail.Text = Email
        ContactInfoLabelEmail.Size = New Size(259, 21)
        ContactInfoLabelEmail.Location = New Point(510, 58)
        ContactInfoLabelEmail.Font = New Font("Verdana", emSize:=9.75)

        'DeliveryLabel

        DeliveryLabelTitle.Text = "Delivery:"
        DeliveryLabelTitle.Size = New Size(76, 21)
        DeliveryLabelTitle.Location = New Point(428, 95)
        DeliveryLabelTitle.Font = New Font("Verdana", emSize:=9.75, FontStyle.Bold)

        'DeliveryLabelPayments 

        DeliveryLabelPayments.Text = TypePayments
        DeliveryLabelPayments.Size = New Size(139, 21)
        DeliveryLabelPayments.Location = New Point(510, 95)
        DeliveryLabelPayments.Font = New Font("Verdana", emSize:=9.75)


        'DeliveryLabelExpress

        DeliveryLabelDeliveryExpress.Text = TypeDelivery
        DeliveryLabelDeliveryExpress.Size = New Size(139, 21)
        DeliveryLabelDeliveryExpress.Location = New Point(510, 116)
        DeliveryLabelDeliveryExpress.Font = New Font("Verdana", emSize:=9.75)

        'ReceiptTitle

        ReceiptTitle.Text = "Receipt: "
        ReceiptTitle.Size = New Size(63, 21)
        ReceiptTitle.Location = New Point(871, 16)
        ReceiptTitle.Font = New Font("Verdana", emSize:=9.75, FontStyle.Bold)

        'ReceiptNo.

        ReceiptNo.Text = RecieptNoCI
        ReceiptNo.Size = New Size(131, 21)
        ReceiptNo.Location = New Point(940, 16)
        ReceiptNo.Font = New Font("Verdana", emSize:=9.75)

        'ReceiptDate


        If thisDate.Day <= 9 Then ' For adding 0 on day
            ReceiptDate.Text = thisDate.Month & "/" & "0" & thisDate.Day & "/" & thisDate.Year
        Else
            ReceiptDate.Text = thisDate.Month & "/" & thisDate.Day & "/" & thisDate.Year
        End If

        ReceiptDate.Size = New Size(131, 21)
        ReceiptDate.Location = New Point(940, 37)
        ReceiptDate.Font = New Font("Verdana", emSize:=9.75)

        'TotalLabel

        TotalLabelTitle.Text = "Total:"
        TotalLabelTitle.Size = New Size(59, 18)
        TotalLabelTitle.Location = New Point(892, 124)
        TotalLabelTitle.Font = New Font("Verdana", emSize:=9.75, FontStyle.Bold)

        'TotalLabelCost

        TotalLabelCost.Text = TotalCost
        TotalLabelCost.Size = New Size(96, 18)
        TotalLabelCost.Location = New Point(957, 124)
        TotalLabelCost.Font = New Font("Verdana", emSize:=9.75)


        'CancelButton

        CancelButton.Text = "Remove"
        CancelButton.Size = New Size(93, 33)
        CancelButton.Location = New Point(943, 150)
        CancelButton.Font = New Font("Verdana", emSize:=9.75)
        CancelButton.Name = "btnMyOrderCancel" & NameControlNo

        AddHandler CancelButton.Click, AddressOf OnButton_Delete_Click


        '''''''''''''''''''''''''''''''''''''''
        NameControlNo = NameControlNo + 1
        Dim mbSubmiting As String
        mbSubmiting = MsgBox("Are you sure?", vbYesNo + vbQuestion, "Confirmation Receipt")

        Select Case mbSubmiting
            Case vbYes
                MsgBox("Your Order is processing, please standby in your email/phone number to contact if have a issue problem ", vbOKOnly + vbInformation, "Order Successful")
                RecieptNoCI = ""
                ReceiptPrice.Clear()
                ReceiptGroceryName.Clear()
                ReceiptQuantity.Clear()
                ReceiptAmount.Clear()
                frmConfirmInfor.Close()
                frmBuyNow.Close()
                frmCart.Close()
                frmDrinks.Close()
                frmCB.Close()
                frmSaucesSeasoning.Close()
                frmSnacks.Close()
                frmNoodles.Close()
                frmRG.Close()
                frmMain.Show()
                Dim YourCart As New frmCart
                YourCart.lvYourCart.Clear()
            Case vbNo
                FlowLayoutPanelOrders.Controls.Remove(panel)
        End Select
    End Sub
    Private Sub OnButton_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim parentPanelName As String
        parentPanelName = Nothing

        'Remover Handle
        For Each controlObj As Control In FlowLayoutPanelOrders.Controls
            For Each childControlObj As Control In controlObj.Controls
                If childControlObj.Name = sender.name Then
                    RemoveHandler childControlObj.Click, AddressOf OnButton_Delete_Click
                    parentPanelName = childControlObj.Parent.Name

                End If
            Next
        Next

        'Remove Order panel
        For Each controlObj As Control In FlowLayoutPanelOrders.Controls
            If controlObj.Name = parentPanelName Then
                FlowLayoutPanelOrders.Controls.Remove(controlObj)
                controlObj.Dispose()
            End If
        Next
    End Sub

    Private Sub tsMyOrdersBack_Click(sender As Object, e As EventArgs) Handles tsMyOrdersBack.Click
        Me.Hide()
    End Sub
End Class