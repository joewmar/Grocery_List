<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCard
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
        Me.btnCardConfirm = New System.Windows.Forms.Button()
        Me.btNCardCancel = New System.Windows.Forms.Button()
        Me.gbCards = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mtxtExpire = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCCV = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mtxtCardName = New System.Windows.Forms.TextBox()
        Me.mtxtCardNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel1.Controls.Add(Me.btnCardConfirm, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btNCardCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(474, 237)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnCardConfirm
        '
        Me.btnCardConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCardConfirm.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCardConfirm.Location = New System.Drawing.Point(3, 3)
        Me.btnCardConfirm.Name = "btnCardConfirm"
        Me.btnCardConfirm.Size = New System.Drawing.Size(67, 23)
        Me.btnCardConfirm.TabIndex = 0
        Me.btnCardConfirm.Text = "Confirm"
        '
        'btNCardCancel
        '
        Me.btNCardCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btNCardCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btNCardCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNCardCancel.Location = New System.Drawing.Point(76, 3)
        Me.btNCardCancel.Name = "btNCardCancel"
        Me.btNCardCancel.Size = New System.Drawing.Size(67, 23)
        Me.btNCardCancel.TabIndex = 1
        Me.btNCardCancel.Text = "Cancel"
        '
        'gbCards
        '
        Me.gbCards.Controls.Add(Me.Label14)
        Me.gbCards.Controls.Add(Me.mtxtExpire)
        Me.gbCards.Controls.Add(Me.mtxtCCV)
        Me.gbCards.Controls.Add(Me.Label13)
        Me.gbCards.Controls.Add(Me.Label12)
        Me.gbCards.Controls.Add(Me.Label11)
        Me.gbCards.Controls.Add(Me.mtxtCardName)
        Me.gbCards.Controls.Add(Me.mtxtCardNo)
        Me.gbCards.Controls.Add(Me.Label8)
        Me.gbCards.Location = New System.Drawing.Point(12, 12)
        Me.gbCards.Name = "gbCards"
        Me.gbCards.Size = New System.Drawing.Size(604, 212)
        Me.gbCards.TabIndex = 41
        Me.gbCards.TabStop = False
        Me.gbCards.Text = " "
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(360, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 18)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "(MM/DD/YY)"
        '
        'mtxtExpire
        '
        Me.mtxtExpire.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.mtxtExpire.Location = New System.Drawing.Point(308, 129)
        Me.mtxtExpire.Mask = "00/00/0000"
        Me.mtxtExpire.Name = "mtxtExpire"
        Me.mtxtExpire.Size = New System.Drawing.Size(227, 27)
        Me.mtxtExpire.TabIndex = 29
        Me.mtxtExpire.ValidatingType = GetType(Date)
        '
        'mtxtCCV
        '
        Me.mtxtCCV.Culture = New System.Globalization.CultureInfo("fi-FI")
        Me.mtxtCCV.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.mtxtCCV.Location = New System.Drawing.Point(308, 48)
        Me.mtxtCCV.Mask = "000"
        Me.mtxtCCV.Name = "mtxtCCV"
        Me.mtxtCCV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mtxtCCV.Size = New System.Drawing.Size(227, 27)
        Me.mtxtCCV.TabIndex = 28
        Me.mtxtCCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtxtCCV.ValidatingType = GetType(Integer)
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(304, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 28)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "CCV:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(304, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 28)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Expiration"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 28)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Card Name"
        '
        'mtxtCardName
        '
        Me.mtxtCardName.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.mtxtCardName.Location = New System.Drawing.Point(13, 129)
        Me.mtxtCardName.Multiline = True
        Me.mtxtCardName.Name = "mtxtCardName"
        Me.mtxtCardName.Size = New System.Drawing.Size(227, 27)
        Me.mtxtCardName.TabIndex = 23
        '
        'mtxtCardNo
        '
        Me.mtxtCardNo.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.mtxtCardNo.Location = New System.Drawing.Point(13, 48)
        Me.mtxtCardNo.Mask = "0000-0000-0000-0000"
        Me.mtxtCardNo.Name = "mtxtCardNo"
        Me.mtxtCardNo.Size = New System.Drawing.Size(227, 27)
        Me.mtxtCardNo.TabIndex = 22
        Me.mtxtCardNo.ValidatingType = GetType(Integer)
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 28)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Card No."
        '
        'frmCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbCards)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARD"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbCards.ResumeLayout(False)
        Me.gbCards.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnCardConfirm As System.Windows.Forms.Button
    Friend WithEvents btNCardCancel As System.Windows.Forms.Button
    Friend WithEvents gbCards As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents mtxtExpire As MaskedTextBox
    Friend WithEvents mtxtCCV As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents mtxtCardName As TextBox
    Friend WithEvents mtxtCardNo As MaskedTextBox
    Friend WithEvents Label8 As Label
End Class
