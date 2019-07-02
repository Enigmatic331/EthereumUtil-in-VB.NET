<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrivateKeyToJSON
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
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Private Key:"
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(75, 74)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(560, 31)
        Me.txtinput.TabIndex = 1
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(75, 168)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.Size = New System.Drawing.Size(560, 31)
        Me.txtpassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Password for JSON File:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(459, 273)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(249, 47)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "Save"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'PrivateKeyToJSON
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 335)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrivateKeyToJSON"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generate JSON from Private Key"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtinput As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOK As Button
End Class
