<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnMenusSnacks = New System.Windows.Forms.Button()
        Me.btnMenusDrinks = New System.Windows.Forms.Button()
        Me.btnMenusSS = New System.Windows.Forms.Button()
        Me.btnMenusCB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMenusRG = New System.Windows.Forms.Button()
        Me.btnMenusNoddles = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsYourCartMainMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsMyOrders = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAboutUs = New System.Windows.Forms.ToolStripButton()
        Me.tsExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMenusSnacks
        '
        Me.btnMenusSnacks.Location = New System.Drawing.Point(130, 158)
        Me.btnMenusSnacks.Name = "btnMenusSnacks"
        Me.btnMenusSnacks.Size = New System.Drawing.Size(284, 200)
        Me.btnMenusSnacks.TabIndex = 0
        Me.btnMenusSnacks.Text = "SNACKS"
        Me.btnMenusSnacks.UseVisualStyleBackColor = True
        '
        'btnMenusDrinks
        '
        Me.btnMenusDrinks.Location = New System.Drawing.Point(746, 158)
        Me.btnMenusDrinks.Name = "btnMenusDrinks"
        Me.btnMenusDrinks.Size = New System.Drawing.Size(284, 200)
        Me.btnMenusDrinks.TabIndex = 1
        Me.btnMenusDrinks.Text = "DRINKS"
        Me.btnMenusDrinks.UseVisualStyleBackColor = True
        '
        'btnMenusSS
        '
        Me.btnMenusSS.Location = New System.Drawing.Point(130, 391)
        Me.btnMenusSS.Name = "btnMenusSS"
        Me.btnMenusSS.Size = New System.Drawing.Size(284, 200)
        Me.btnMenusSS.TabIndex = 2
        Me.btnMenusSS.Text = "SAUCES AND SEASONING"
        Me.btnMenusSS.UseVisualStyleBackColor = True
        '
        'btnMenusCB
        '
        Me.btnMenusCB.Location = New System.Drawing.Point(751, 391)
        Me.btnMenusCB.Name = "btnMenusCB"
        Me.btnMenusCB.Size = New System.Drawing.Size(284, 200)
        Me.btnMenusCB.TabIndex = 3
        Me.btnMenusCB.Text = "CANNED AND BOOTLE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnMenusCB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "KONNICHIWA AT MABUHAY EVERYONE"
        '
        'btnMenusRG
        '
        Me.btnMenusRG.Location = New System.Drawing.Point(437, 158)
        Me.btnMenusRG.Name = "btnMenusRG"
        Me.btnMenusRG.Size = New System.Drawing.Size(284, 200)
        Me.btnMenusRG.TabIndex = 5
        Me.btnMenusRG.Text = "RICE AND GRAIN"
        Me.btnMenusRG.UseVisualStyleBackColor = True
        '
        'btnMenusNoddles
        '
        Me.btnMenusNoddles.Location = New System.Drawing.Point(437, 391)
        Me.btnMenusNoddles.Name = "btnMenusNoddles"
        Me.btnMenusNoddles.Size = New System.Drawing.Size(284, 200)
        Me.btnMenusNoddles.TabIndex = 6
        Me.btnMenusNoddles.Text = "NOODLES"
        Me.btnMenusNoddles.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsYourCartMainMenu, Me.ToolStripSeparator3, Me.tsMyOrders, Me.ToolStripSeparator2, Me.tsHelp, Me.ToolStripSeparator1, Me.tsAboutUs, Me.tsExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1165, 44)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsYourCartMainMenu
        '
        Me.tsYourCartMainMenu.Image = CType(resources.GetObject("tsYourCartMainMenu.Image"), System.Drawing.Image)
        Me.tsYourCartMainMenu.Name = "tsYourCartMainMenu"
        Me.tsYourCartMainMenu.Size = New System.Drawing.Size(91, 41)
        Me.tsYourCartMainMenu.Text = "Your Cart"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 44)
        '
        'tsMyOrders
        '
        Me.tsMyOrders.Image = Global.Grocery_List.My.Resources.Resources.icons8_truck_90
        Me.tsMyOrders.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsMyOrders.Name = "tsMyOrders"
        Me.tsMyOrders.Size = New System.Drawing.Size(96, 41)
        Me.tsMyOrders.Text = "My Orders"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'tsHelp
        '
        Me.tsHelp.Image = Global.Grocery_List.My.Resources.Resources.icons8_help_901
        Me.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHelp.Name = "tsHelp"
        Me.tsHelp.Size = New System.Drawing.Size(57, 41)
        Me.tsHelp.Text = "Help"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'tsAboutUs
        '
        Me.tsAboutUs.Image = Global.Grocery_List.My.Resources.Resources.icons8_more_info_90
        Me.tsAboutUs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAboutUs.Name = "tsAboutUs"
        Me.tsAboutUs.Size = New System.Drawing.Size(86, 41)
        Me.tsAboutUs.Text = "About Us"
        '
        'tsExit
        '
        Me.tsExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsExit.Image = Global.Grocery_List.My.Resources.Resources.icons8_exit_90
        Me.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsExit.Name = "tsExit"
        Me.tsExit.Size = New System.Drawing.Size(52, 41)
        Me.tsExit.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1165, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnMenusNoddles)
        Me.Controls.Add(Me.btnMenusRG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMenusCB)
        Me.Controls.Add(Me.btnMenusSS)
        Me.Controls.Add(Me.btnMenusDrinks)
        Me.Controls.Add(Me.btnMenusSnacks)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ONRAIN PINOY HAPONESHU : PHILIPPINES  JAPAN STORE"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMenusSnacks As Button
    Friend WithEvents btnMenusDrinks As Button
    Friend WithEvents btnMenusSS As Button
    Friend WithEvents btnMenusCB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMenusRG As Button
    Friend WithEvents btnMenusNoddles As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsYourCartMainMenu As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsAboutUs As ToolStripButton
    Friend WithEvents tsExit As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsMyOrders As ToolStripButton
End Class
