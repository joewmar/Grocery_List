<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCart))
        Me.lvYourCart = New System.Windows.Forms.ListView()
        Me.colNames = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripButton()
        Me.nudCartUpdate = New System.Windows.Forms.NumericUpDown()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuyNow = New System.Windows.Forms.Button()
        Me.lbCartUpdates = New System.Windows.Forms.Label()
        Me.lblqt = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.nudCartUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvYourCart
        '
        Me.lvYourCart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNames, Me.colPrice, Me.colQuantity, Me.colAmount})
        Me.lvYourCart.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvYourCart.FullRowSelect = True
        Me.lvYourCart.GridLines = True
        Me.lvYourCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvYourCart.HideSelection = False
        Me.lvYourCart.LabelWrap = False
        Me.lvYourCart.Location = New System.Drawing.Point(32, 56)
        Me.lvYourCart.MultiSelect = False
        Me.lvYourCart.Name = "lvYourCart"
        Me.lvYourCart.Size = New System.Drawing.Size(1082, 473)
        Me.lvYourCart.TabIndex = 0
        Me.lvYourCart.UseCompatibleStateImageBehavior = False
        Me.lvYourCart.View = System.Windows.Forms.View.Details
        '
        'colNames
        '
        Me.colNames.Text = "Item Name"
        Me.colNames.Width = 517
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 187
        '
        'colQuantity
        '
        Me.colQuantity.Text = "Quantity"
        Me.colQuantity.Width = 187
        '
        'colAmount
        '
        Me.colAmount.Text = "Amount"
        Me.colAmount.Width = 187
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1165, 44)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Grocery_List.My.Resources.Resources._93634
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(59, 41)
        Me.ToolStripButton1.Text = "Back"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(57, 41)
        Me.ToolStripLabel1.Text = "Help"
        '
        'nudCartUpdate
        '
        Me.nudCartUpdate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCartUpdate.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.nudCartUpdate.Location = New System.Drawing.Point(106, 585)
        Me.nudCartUpdate.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCartUpdate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCartUpdate.Name = "nudCartUpdate"
        Me.nudCartUpdate.Size = New System.Drawing.Size(86, 27)
        Me.nudCartUpdate.TabIndex = 7
        Me.nudCartUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudCartUpdate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCartUpdate.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(243, 585)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(129, 42)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCost.Location = New System.Drawing.Point(979, 532)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(61, 25)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(838, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "TOTAL:     ₱"
        '
        'btnBuyNow
        '
        Me.btnBuyNow.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuyNow.Location = New System.Drawing.Point(913, 583)
        Me.btnBuyNow.Name = "btnBuyNow"
        Me.btnBuyNow.Size = New System.Drawing.Size(201, 67)
        Me.btnBuyNow.TabIndex = 11
        Me.btnBuyNow.Text = "Buy Now"
        Me.btnBuyNow.UseVisualStyleBackColor = True
        '
        'lbCartUpdates
        '
        Me.lbCartUpdates.AutoSize = True
        Me.lbCartUpdates.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCartUpdates.Location = New System.Drawing.Point(27, 551)
        Me.lbCartUpdates.Name = "lbCartUpdates"
        Me.lbCartUpdates.Size = New System.Drawing.Size(106, 18)
        Me.lbCartUpdates.TabIndex = 12
        Me.lbCartUpdates.Text = "Item Name"
        Me.lbCartUpdates.Visible = False
        '
        'lblqt
        '
        Me.lblqt.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqt.Location = New System.Drawing.Point(29, 583)
        Me.lblqt.Name = "lblqt"
        Me.lblqt.Size = New System.Drawing.Size(82, 29)
        Me.lblqt.TabIndex = 13
        Me.lblqt.Text = "Quatity: "
        Me.lblqt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblqt.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(410, 583)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(136, 44)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'frmCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1165, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblqt)
        Me.Controls.Add(Me.lbCartUpdates)
        Me.Controls.Add(Me.btnBuyNow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.nudCartUpdate)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lvYourCart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YOUR CART"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.nudCartUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvYourCart As ListView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripButton
    Friend WithEvents nudCartUpdate As NumericUpDown
    Friend WithEvents btnUpdate As Button
    Friend WithEvents colNames As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents colQuantity As ColumnHeader
    Friend WithEvents colAmount As ColumnHeader
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuyNow As Button
    Friend WithEvents lbCartUpdates As Label
    Friend WithEvents lblqt As Label
    Friend WithEvents btnDelete As Button
End Class
