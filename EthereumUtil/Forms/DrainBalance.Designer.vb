<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrainBalance
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
        Me.btnDrain = New System.Windows.Forms.Button()
        Me.txtPrivKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReceiving = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDrain
        '
        Me.btnDrain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDrain.Location = New System.Drawing.Point(448, 532)
        Me.btnDrain.Name = "btnDrain"
        Me.btnDrain.Size = New System.Drawing.Size(207, 47)
        Me.btnDrain.TabIndex = 0
        Me.btnDrain.Text = "Start"
        Me.btnDrain.UseVisualStyleBackColor = True
        '
        'txtPrivKey
        '
        Me.txtPrivKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrivKey.Location = New System.Drawing.Point(27, 65)
        Me.txtPrivKey.MaxLength = 0
        Me.txtPrivKey.Multiline = True
        Me.txtPrivKey.Name = "txtPrivKey"
        Me.txtPrivKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPrivKey.Size = New System.Drawing.Size(628, 167)
        Me.txtPrivKey.TabIndex = 1
        Me.txtPrivKey.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Private Keys:"
        '
        'txtReceiving
        '
        Me.txtReceiving.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReceiving.Location = New System.Drawing.Point(27, 306)
        Me.txtReceiving.Multiline = True
        Me.txtReceiving.Name = "txtReceiving"
        Me.txtReceiving.Size = New System.Drawing.Size(628, 44)
        Me.txtReceiving.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Receiving Address:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(22, 438)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(633, 68)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ready."
        '
        'DrainBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 591)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReceiving)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrivKey)
        Me.Controls.Add(Me.btnDrain)
        Me.MinimumSize = New System.Drawing.Size(715, 662)
        Me.Name = "DrainBalance"
        Me.Text = "Transfer From"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDrain As Button
    Friend WithEvents txtPrivKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReceiving As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
