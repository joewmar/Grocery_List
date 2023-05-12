<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHelp
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
        Me.picItemsAdded = New System.Windows.Forms.PictureBox()
        Me.TimerHelp = New System.Windows.Forms.Timer(Me.components)
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picItemsAdded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picItemsAdded
        '
        Me.picItemsAdded.BackColor = System.Drawing.Color.Transparent
        Me.picItemsAdded.Image = Global.Grocery_List.My.Resources.Resources.icons8_add_shopping_cart_90
        Me.picItemsAdded.Location = New System.Drawing.Point(54, 36)
        Me.picItemsAdded.Name = "picItemsAdded"
        Me.picItemsAdded.Size = New System.Drawing.Size(56, 43)
        Me.picItemsAdded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picItemsAdded.TabIndex = 11
        Me.picItemsAdded.TabStop = False
        '
        'TimerHelp
        '
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.BackColor = System.Drawing.Color.Transparent
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.Location = New System.Drawing.Point(680, 393)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(85, 32)
        Me.OKButton.TabIndex = 12
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(714, 32)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "A MOVE CART IS SYMBOL OF YOUR ITEMS IS ADDED IN YOUR CART"
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.picItemsAdded)
        Me.Name = "frmHelp"
        Me.Text = "Help"
        CType(Me.picItemsAdded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picItemsAdded As PictureBox
    Friend WithEvents TimerHelp As Timer
    Friend WithEvents OKButton As Button
    Friend WithEvents Label2 As Label
End Class
