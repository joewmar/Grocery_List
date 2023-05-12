<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmInfor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblReceiptName = New System.Windows.Forms.Label()
        Me.lblReceiptAddress = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblReceiptPhoneNo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblReceiptEmail = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblReceiptTypePay = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblReceiptDate = New System.Windows.Forms.Label()
        Me.lblReceiptNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblReceiptTypeDelivery = New System.Windows.Forms.Label()
        Me.gbCards = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotaALL = New System.Windows.Forms.Label()
        Me.lblReceiptShipFees = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblReceiptTotalCost = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lvReceipt = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbCards.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSubmit, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(348, 658)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(207, 39)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(3, 3)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 33)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(106, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 33)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'lblReceiptName
        '
        Me.lblReceiptName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptName.Location = New System.Drawing.Point(202, 131)
        Me.lblReceiptName.Name = "lblReceiptName"
        Me.lblReceiptName.Size = New System.Drawing.Size(260, 21)
        Me.lblReceiptName.TabIndex = 29
        Me.lblReceiptName.Text = "John Doe"
        '
        'lblReceiptAddress
        '
        Me.lblReceiptAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptAddress.Location = New System.Drawing.Point(202, 167)
        Me.lblReceiptAddress.Name = "lblReceiptAddress"
        Me.lblReceiptAddress.Size = New System.Drawing.Size(260, 68)
        Me.lblReceiptAddress.TabIndex = 31
        Me.lblReceiptAddress.Text = "20 Sunny Street, City, Country or Sunny Street, 20, City, Country"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 26)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Address:"
        '
        'lblReceiptPhoneNo
        '
        Me.lblReceiptPhoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptPhoneNo.Location = New System.Drawing.Point(203, 235)
        Me.lblReceiptPhoneNo.Name = "lblReceiptPhoneNo"
        Me.lblReceiptPhoneNo.Size = New System.Drawing.Size(259, 21)
        Me.lblReceiptPhoneNo.TabIndex = 33
        Me.lblReceiptPhoneNo.Text = "09123456789"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 21)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Phone No.: "
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 21)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Email:"
        '
        'lblReceiptEmail
        '
        Me.lblReceiptEmail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptEmail.Location = New System.Drawing.Point(203, 274)
        Me.lblReceiptEmail.Name = "lblReceiptEmail"
        Me.lblReceiptEmail.Size = New System.Drawing.Size(259, 21)
        Me.lblReceiptEmail.TabIndex = 35
        Me.lblReceiptEmail.Text = "example@gmail.com"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 21)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Type of Payments: "
        '
        'lblReceiptTypePay
        '
        Me.lblReceiptTypePay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptTypePay.Location = New System.Drawing.Point(203, 323)
        Me.lblReceiptTypePay.Name = "lblReceiptTypePay"
        Me.lblReceiptTypePay.Size = New System.Drawing.Size(259, 21)
        Me.lblReceiptTypePay.TabIndex = 37
        Me.lblReceiptTypePay.Text = "Cash on Delivery"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(333, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 21)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Receipt Date:"
        '
        'lblReceiptDate
        '
        Me.lblReceiptDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptDate.Location = New System.Drawing.Point(447, 49)
        Me.lblReceiptDate.Name = "lblReceiptDate"
        Me.lblReceiptDate.Size = New System.Drawing.Size(135, 21)
        Me.lblReceiptDate.TabIndex = 39
        Me.lblReceiptDate.Text = "MM/DD/YYYY"
        '
        'lblReceiptNo
        '
        Me.lblReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptNo.Location = New System.Drawing.Point(451, 23)
        Me.lblReceiptNo.Name = "lblReceiptNo"
        Me.lblReceiptNo.Size = New System.Drawing.Size(131, 21)
        Me.lblReceiptNo.TabIndex = 41
        Me.lblReceiptNo.Text = "891879"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 26)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Name:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(333, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 21)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Receipt No.:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(33, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(276, 20)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "ONRAIN PINOY HAPONESHU"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(12, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(560, 2)
        Me.Label16.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(42, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(204, 21)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "4981 R-9, Capas, Tarlac"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(43, 371)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 21)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Type of Delivery: "
        '
        'lblReceiptTypeDelivery
        '
        Me.lblReceiptTypeDelivery.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptTypeDelivery.Location = New System.Drawing.Point(203, 371)
        Me.lblReceiptTypeDelivery.Name = "lblReceiptTypeDelivery"
        Me.lblReceiptTypeDelivery.Size = New System.Drawing.Size(259, 21)
        Me.lblReceiptTypeDelivery.TabIndex = 47
        Me.lblReceiptTypeDelivery.Text = "Express"
        '
        'gbCards
        '
        Me.gbCards.Controls.Add(Me.Label1)
        Me.gbCards.Controls.Add(Me.lblTotaALL)
        Me.gbCards.Controls.Add(Me.lblReceiptShipFees)
        Me.gbCards.Controls.Add(Me.Label20)
        Me.gbCards.Controls.Add(Me.lblReceiptTotalCost)
        Me.gbCards.Controls.Add(Me.Label21)
        Me.gbCards.Location = New System.Drawing.Point(315, 561)
        Me.gbCards.Name = "gbCards"
        Me.gbCards.Size = New System.Drawing.Size(240, 91)
        Me.gbCards.TabIndex = 59
        Me.gbCards.TabStop = False
        Me.gbCards.Text = " "
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(135, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 2)
        Me.Label1.TabIndex = 64
        '
        'lblTotaALL
        '
        Me.lblTotaALL.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotaALL.Location = New System.Drawing.Point(144, 67)
        Me.lblTotaALL.Name = "lblTotaALL"
        Me.lblTotaALL.Size = New System.Drawing.Size(96, 22)
        Me.lblTotaALL.TabIndex = 30
        Me.lblTotaALL.Text = "000.00"
        '
        'lblReceiptShipFees
        '
        Me.lblReceiptShipFees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptShipFees.Location = New System.Drawing.Point(144, 41)
        Me.lblReceiptShipFees.Name = "lblReceiptShipFees"
        Me.lblReceiptShipFees.Size = New System.Drawing.Size(96, 22)
        Me.lblReceiptShipFees.TabIndex = 29
        Me.lblReceiptShipFees.Text = "000.00"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(113, 22)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Shipping fees:"
        '
        'lblReceiptTotalCost
        '
        Me.lblReceiptTotalCost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptTotalCost.Location = New System.Drawing.Point(144, 16)
        Me.lblReceiptTotalCost.Name = "lblReceiptTotalCost"
        Me.lblReceiptTotalCost.Size = New System.Drawing.Size(96, 21)
        Me.lblReceiptTotalCost.TabIndex = 27
        Me.lblReceiptTotalCost.Text = "000.00"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 28)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Total: "
        '
        'lvReceipt
        '
        Me.lvReceipt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvReceipt.GridLines = True
        Me.lvReceipt.HideSelection = False
        Me.lvReceipt.Location = New System.Drawing.Point(36, 410)
        Me.lvReceipt.Name = "lvReceipt"
        Me.lvReceipt.Size = New System.Drawing.Size(519, 145)
        Me.lvReceipt.TabIndex = 60
        Me.lvReceipt.UseCompatibleStateImageBehavior = False
        Me.lvReceipt.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Items Name"
        Me.ColumnHeader1.Width = 279
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantity"
        Me.ColumnHeader3.Width = 55
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.Width = 91
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(41, 577)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(168, 21)
        Me.Label22.TabIndex = 61
        Me.Label22.Text = "Term and Conditions"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(59, 598)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(221, 21)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Payment is due within 15 days"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(59, 619)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(250, 67)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Note: Please make check information correctly especailly email phone to send reci" &
    "ept in case of issue of technical delivery"
        '
        'frmConfirmInfor
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(585, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lvReceipt)
        Me.Controls.Add(Me.gbCards)
        Me.Controls.Add(Me.lblReceiptTypeDelivery)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblReceiptNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblReceiptDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblReceiptTypePay)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblReceiptEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblReceiptPhoneNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblReceiptAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblReceiptName)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfirmInfor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confimation"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbCards.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblReceiptName As Label
    Friend WithEvents lblReceiptAddress As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblReceiptPhoneNo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblReceiptEmail As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblReceiptTypePay As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblReceiptDate As Label
    Friend WithEvents lblReceiptNo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblReceiptTypeDelivery As Label
    Friend WithEvents gbCards As GroupBox
    Friend WithEvents lblReceiptShipFees As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblReceiptTotalCost As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lvReceipt As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotaALL As Label
End Class
