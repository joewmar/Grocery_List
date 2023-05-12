<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMyOrders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerCB = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsMyOrdersBack = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FlowLayoutPanelOrders = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 48)
        Me.Panel1.TabIndex = 13
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMyOrdersBack, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1164, 44)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsMyOrdersBack
        '
        Me.tsMyOrdersBack.Image = Global.Grocery_List.My.Resources.Resources._93634
        Me.tsMyOrdersBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsMyOrdersBack.Name = "tsMyOrdersBack"
        Me.tsMyOrdersBack.Size = New System.Drawing.Size(59, 41)
        Me.tsMyOrdersBack.Text = "Back"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'FlowLayoutPanelOrders
        '
        Me.FlowLayoutPanelOrders.AutoScroll = True
        Me.FlowLayoutPanelOrders.Location = New System.Drawing.Point(0, 49)
        Me.FlowLayoutPanelOrders.Name = "FlowLayoutPanelOrders"
        Me.FlowLayoutPanelOrders.Padding = New System.Windows.Forms.Padding(40)
        Me.FlowLayoutPanelOrders.Size = New System.Drawing.Size(1164, 662)
        Me.FlowLayoutPanelOrders.TabIndex = 15
        '
        'frmMyOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanelOrders)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMyOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyOrders"
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerCB As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsMyOrdersBack As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FlowLayoutPanelOrders As FlowLayoutPanel
End Class
