Imports Grocery_List.DataClass
Imports System.Windows.Forms.DialogResult
Public Class frmBuyNow

    Const GO_Express As Double = 60.0
    Const JT_Express As Double = 45.0
    Const Ninja_Van As Double = 55.0
    Const JRS_Express As Double = 65.0
    Const LBC_Express As Double = 90.0
    Const DHL_Express As Double = 86.0

    Private Sub frmBuyNow_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lbltotal.Text = TotalCost


        If thisDate.Day <= 9 Then ' For adding 0 on day
            mtxtDate.Text = thisDate.Month & "0" & thisDate.Day & thisDate.Year
        Else
            mtxtDate.Text = thisDate.Month & thisDate.Day & thisDate.Year
        End If

        Select Case frmCard.DialogResult
            Case DialogResult.Cancel
                cbPayments.SelectedItem = "Select"
            Case DialogResult.OK
                cbPayments.SelectedItem = "Card"
        End Select
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            FirstName = txtFirstName.Text
            LastName = txtLastName.Text
            Address = txtAddress.Text
            PhoneNumber = mtxtPhoneNo.Text
            Email = txtEmail.Text
            TypePayments = cbPayments.SelectedItem
            If rb2GO.Checked Then
                TypeDelivery = rb2GO.Name
                DeliveryShipFess = GO_Express

            ElseIf rbDHL.Checked Then
                TypeDelivery = rbDHL.Text
                DeliveryShipFess = DHL_Express

            ElseIf rbJRS.Checked Then
                TypeDelivery = rbJRS.Text
                DeliveryShipFess = JRS_Express

            ElseIf rbJTExpress.Checked Then
                TypeDelivery = rbJTExpress.Text
                DeliveryShipFess = JT_Express

            ElseIf rbNinjaVan.Checked Then
                TypeDelivery = rbNinjaVan.Text
                DeliveryShipFess = Ninja_Van

            ElseIf rbLBC.Checked Then
                TypeDelivery = rbLBC.Text
                DeliveryShipFess = LBC_Express
            End If

            'Check if user input correctly information
            If Email.Contains("@") = False And Email.Contains(".com") = False Then
                MsgBox("This value is not a valid email address", vbOKOnly, "Email Validation Error")
            ElseIf Not TypePayments <> "Select" Then
                MsgBox("Please choose value what type of payment", vbOKOnly, "Type of Payment Error")
            ElseIf PhoneNumber.Length() < 11 Or PhoneNumber Is Nothing Then
                MsgBox("Please input properly value of Phone Number", vbOKOnly, "Phone Number Error")
            ElseIf String.IsNullOrEmpty(TypeDelivery) Then
                MsgBox("Please choose value what type of delivery", vbOKOnly, "Type of Delivery Error")
            Else
                frmConfirmInfor.Show()
            End If

        Catch ex As NullReferenceException
            MsgBox("Please fill up complete correctly before confirm", vbOKOnly + vbExclamation, "Error")
        End Try


    End Sub

    Private Sub cbPayments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPayments.SelectedIndexChanged
        If cbPayments.SelectedItem = "Card" Then
            frmCard.ShowDialog()
        End If
    End Sub

    Private Sub btmCancel_Click(sender As Object, e As EventArgs) Handles btmCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmBuyNow_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbPayments.SelectedItem = "Select"
    End Sub
End Class