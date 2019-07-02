<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnGenKeys = New System.Windows.Forms.Button()
        Me.btnSweep = New System.Windows.Forms.Button()
        Me.btnCheckBalance = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnPrivToJSON = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGenKeys
        '
        Me.btnGenKeys.Location = New System.Drawing.Point(85, 233)
        Me.btnGenKeys.Name = "btnGenKeys"
        Me.btnGenKeys.Size = New System.Drawing.Size(407, 66)
        Me.btnGenKeys.TabIndex = 3
        Me.btnGenKeys.Text = "Mass generate keypairs"
        Me.btnGenKeys.UseVisualStyleBackColor = True
        '
        'btnSweep
        '
        Me.btnSweep.Location = New System.Drawing.Point(85, 433)
        Me.btnSweep.Name = "btnSweep"
        Me.btnSweep.Size = New System.Drawing.Size(407, 66)
        Me.btnSweep.TabIndex = 5
        Me.btnSweep.Text = "Sweep ETH private keys"
        Me.btnSweep.UseVisualStyleBackColor = True
        '
        'btnCheckBalance
        '
        Me.btnCheckBalance.Location = New System.Drawing.Point(85, 332)
        Me.btnCheckBalance.Name = "btnCheckBalance"
        Me.btnCheckBalance.Size = New System.Drawing.Size(407, 66)
        Me.btnCheckBalance.TabIndex = 4
        Me.btnCheckBalance.Text = "Check balances"
        Me.btnCheckBalance.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(85, 49)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(407, 66)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send ETH"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnPrivToJSON
        '
        Me.btnPrivToJSON.Location = New System.Drawing.Point(85, 137)
        Me.btnPrivToJSON.Name = "btnPrivToJSON"
        Me.btnPrivToJSON.Size = New System.Drawing.Size(407, 66)
        Me.btnPrivToJSON.TabIndex = 2
        Me.btnPrivToJSON.Text = "Convert Private Key to JSON Wallet"
        Me.btnPrivToJSON.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 564)
        Me.Controls.Add(Me.btnPrivToJSON)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnCheckBalance)
        Me.Controls.Add(Me.btnSweep)
        Me.Controls.Add(Me.btnGenKeys)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Ethereum Util"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenKeys As Button
    Friend WithEvents btnSweep As Button
    Friend WithEvents btnCheckBalance As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents btnPrivToJSON As Button
End Class
