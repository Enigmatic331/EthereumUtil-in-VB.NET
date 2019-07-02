Imports Nethereum.Web3

Public Class PrivateKeyToJSON
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Cursor = Cursors.WaitCursor
        If btnOK.Text = "Save" Then
            Call createJSON()
        Else
            Me.Close()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub createJSON()
        enableControls(False)
        btnOK.Text = "Saving... Please wait."


        'ensure private key is entered
        If Not String.IsNullOrEmpty(txtinput.Text) Then
            ' ensure password is entered
            If Not String.IsNullOrEmpty(txtpassword.Text) Then
                Dim wallet As New UtilWallet
                Dim password As String
                Dim account As Accounts.Account

                'initialise web3 account
                account = wallet.initAccount(txtinput.Text)
                password = txtpassword.Text

                If account IsNot Nothing Then
                    Dim file = wallet.privateKeyToJSON(account, password)
                    If Not String.IsNullOrEmpty(file) Then
                        MessageBox.Show("JSON file stored: " & file, "Completed", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show(wallet.returnError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                btnOK.Text = "Close"
            Else
                MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnOK.Text = "Save"
            End If
        Else
            MessageBox.Show("Please enter a private key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnOK.Text = "Save"
        End If

        enableControls(True)
    End Sub

    Private Sub enableControls(ByVal bool As Boolean)
        txtinput.Enabled = bool
        txtpassword.Enabled = bool
        btnOK.Enabled = bool
    End Sub
End Class