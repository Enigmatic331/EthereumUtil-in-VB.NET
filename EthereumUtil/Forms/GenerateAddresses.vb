Imports System.IO
Imports System.Text.RegularExpressions
Imports Nethereum.Web3
Imports Nethereum.Hex

Public Class GenerateAddresses
    Private Async Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim ecKey As Object
        Dim privateKey As String, publicKey As String
        Dim cnt As Integer = 0
        Dim tmp As String = "PrivateKey,Address"
        Dim numKeys As Integer = IIf(txtNum.Text.Length = 0, 1, txtNum.Text)
        Dim blnCont = True
        Dim r As HexTypes.HexBigInteger
        Dim totalKeyGen As Int64

        ''' hackish
        Dim startsWith = txtStarts.Text
        Dim endsWith = txtEnds.Text

        If showBalance.Checked = True Then
            tmp = tmp & ",Balance" & vbCrLf
        Else
            tmp = tmp & vbCrLf
        End If

        If startsWith.Length <> 0 Then
            If IsHex(startsWith) Then
                blnCont = True
            Else
                blnCont = False
                MessageBox.Show("Please ensure 'start with' inputs are hex characters!")
            End If
        End If

        If endsWith.Length <> 0 Then
            If IsHex(endsWith) Then
                blnCont = True
            Else
                blnCont = False
                MessageBox.Show("Please ensure 'end with' inputs are hex characters!")
            End If
        End If

        If numKeys > 2000 Then
            If MessageBox.Show("Seems that you are attempting to generate a large number of keys - " &
                            "This might take some time." & vbCrLf & vbCrLf &
                            "Are you sure you'd like to continue?", "Attempting...", MessageBoxButtons.YesNo) = DialogResult.No Then
                blnCont = False
            End If
        End If

        If blnCont = True Then
            btnStart.Enabled = False
            txtNum.Enabled = False
            showBalance.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Label3.Text = "Working..."
            Application.DoEvents()

            While cnt < numKeys
                ecKey = Nethereum.Signer.EthECKey.GenerateKey()
                privateKey = ecKey.GetPrivateKey.ToString.Substring(2)
                publicKey = ecKey.GetPublicAddress

                totalKeyGen += 1

                Label4.Text = "Searched " & totalKeyGen & " number of keys..."
                Application.DoEvents()

                If startsWith.Length <> 0 Then
                    'trim
                    Dim tmpPubK As String = ""
                    If publicKey.StartsWith("0x") Then
                        tmpPubK = Mid(publicKey, 3, publicKey.Length - 2)
                    Else
                        tmpPubK = publicKey
                    End If

                    If tmpPubK.ToLower.StartsWith(startsWith) Then
                        blnCont = True
                    Else
                        blnCont = False
                    End If
                End If
                If endsWith.Length <> 0 And blnCont Then
                    If publicKey.ToLower.EndsWith(endsWith) Then
                        blnCont = True
                    Else
                        blnCont = False
                    End If
                End If

                If blnCont Then
                    If showBalance.Checked = True Then
                        r = Await CheckBalance(publicKey)
                        ' just being cheeky
                        'If r.Value.ToString <> "0" Then 
                        tmp = tmp + privateKey & "," & publicKey & "," & r.Value.ToString & vbCrLf
                        cnt = cnt + 1

                        If (cnt Mod 2) = 0 Then
                            Label3.Text = "Found " & cnt & " out of " & numKeys & StrDup((cnt Mod 3) + 3, ".")
                            Application.DoEvents()
                        End If
                        'End If
                    Else
                        tmp = tmp + privateKey & "," & publicKey & vbCrLf
                        cnt = cnt + 1

                        'hack in a backup first
                        Dim file As System.IO.StreamWriter
                        file = My.Computer.FileSystem.OpenTextFileWriter("backup.txt", True)
                        file.WriteLine(privateKey & "," & publicKey)
                        file.Close()

                        If (cnt Mod 100) = 0 Then
                            Label3.Text = "Found " & cnt & " out of " & numKeys & StrDup((cnt Mod 3) + 3, ".")
                            Application.DoEvents()
                        End If

                        'End If
                    End If
                End If
            End While

            'print out to .csv
            Dim sfd As New SaveFileDialog
            sfd.Filter = "CSV Files | *.csv"
            sfd.RestoreDirectory = True

            Try
                If sfd.ShowDialog = DialogResult.OK Then
                    Dim sw As StreamWriter = New StreamWriter(sfd.OpenFile())
                    If (sw IsNot Nothing) Then
                        sw.WriteLine(tmp)
                        sw.Close()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Critical Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            Me.Cursor = Cursors.Default

            Label3.Text = "Completed."
            btnStart.Text = "Start"
            btnStart.Enabled = True
            txtNum.Enabled = True
            showBalance.Enabled = True
        End If
    End Sub

    Private Async Function CheckBalance(ByVal publicKey As String) As Task(Of HexTypes.HexBigInteger)
        'initialise web3 - this could probably be better optimised as a module variable
        Dim web3 As Web3
        web3 = New Web3("https://mainnet.infura.io/")
        'web3 = New Web3("http://127.0.0.1:8545")
        Dim accountTotal As HexTypes.HexBigInteger

        accountTotal = New HexTypes.HexBigInteger(0)

        Try
            accountTotal = Await web3.Eth.GetBalance.SendRequestAsync(publicKey)
        Catch ex As Exception
            MessageBox.Show("Error - GenerateAddress.CheckBalance - " & ex.Message)
            Return accountTotal
        End Try

        Return accountTotal
    End Function

    Private Sub GenerateAddresses_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub txtNum_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtNum.Text = digitsOnly.Replace(txtNum.Text, "")
    End Sub

    Public Function IsHex(ByVal str As String) As Boolean
        If String.IsNullOrWhiteSpace(str) Then _
            Return False

        Dim i As Int32, c As Char

        If str.StartsWith("0x") Then
            str = Mid(str, 3, str.Length - 2)
        End If

        If str.IndexOf("0x") = 0 Then _
            str = str.Substring(2)

        While (i < str.Length)
            c = str.Chars(i)

            If Not (((c >= "0"c) AndAlso (c <= "9"c)) OrElse
                    ((c >= "a"c) AndAlso (c <= "f"c)) OrElse
                    ((c >= "A"c) AndAlso (c <= "F"c))) _
            Then
                Return False
            Else
                i += 1
            End If
        End While
        Return True
    End Function
End Class