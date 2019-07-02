<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerateAddresses
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.showBalance = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many keys would you like to generate?"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(58, 91)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(178, 31)
        Me.txtNum.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "pairs"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(576, 323)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(147, 45)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'showBalance
        '
        Me.showBalance.AutoSize = True
        Me.showBalance.Location = New System.Drawing.Point(61, 141)
        Me.showBalance.Name = "showBalance"
        Me.showBalance.Size = New System.Drawing.Size(192, 29)
        Me.showBalance.TabIndex = 4
        Me.showBalance.Text = "Show Balances"
        Me.showBalance.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ready."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 25)
        Me.Label4.TabIndex = 6
        '
        'GenerateAddresses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 380)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.showBalance)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GenerateAddresses"
        Me.Text = "Generate Addresses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents showBalance As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
