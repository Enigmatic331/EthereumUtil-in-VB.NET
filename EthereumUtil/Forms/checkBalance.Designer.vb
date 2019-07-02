<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkBalance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnCheckBal = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select File (.CSV)"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(59, 102)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(559, 31)
        Me.txtDir.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(624, 102)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(42, 31)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnCheckBal
        '
        Me.btnCheckBal.Location = New System.Drawing.Point(596, 202)
        Me.btnCheckBal.Name = "btnCheckBal"
        Me.btnCheckBal.Size = New System.Drawing.Size(116, 45)
        Me.btnCheckBal.TabIndex = 3
        Me.btnCheckBal.Text = "Start"
        Me.btnCheckBal.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ready."
        '
        'checkBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 259)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCheckBal)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "checkBalance"
        Me.Text = "Check Balances"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDir As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCheckBal As Button
    Friend WithEvents Label2 As Label
End Class
