Imports Nethereum
Imports Nethereum.Web3
Imports System.Threading

Public Class DrainBalance
    Private Async Sub btnClick(sender As Object, e As EventArgs) Handles btnDrain.Click
        If btnDrain.Text = "Start" Then
            'initialise web3
            Dim web3 As Web3
            web3 = New Web3("https://mainnet.infura.io/")

            'get receiver address
            Dim receiverAddress As String = txtReceiving.Text

            'declare gas (21000 gas for a simple transaction is sufficient)
            Dim gas As Nethereum.Hex.HexTypes.HexBigInteger
            gas = New Hex.HexTypes.HexBigInteger(21000)

            'declare gas price (currently hardcoded to 8gwei. We could put this as an option in the future, or use ethgasstation API)
            Dim gasPrice As Nethereum.Hex.HexTypes.HexBigInteger
            gasPrice = New Hex.HexTypes.HexBigInteger(8000000000)

            'calculate total we could drain from this account
            Dim deduction As Int64
            deduction = 21000 * 8000000000

            'get private key list
            Dim tmp As String
            Dim list As String()

            tmp = txtPrivKey.Text
            If tmp.IndexOf(",") > -1 Then
                list = tmp.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            Else
                list = tmp.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            End If

            For Each privKey As String In list
                Dim senderAddress As String
                Dim accountObj As Object
                Dim encodedString As String
                Dim txCount As Object
                Dim accountTotal As Hex.HexTypes.HexBigInteger
                Dim transferTotal As Hex.HexTypes.HexBigInteger

                accountObj = New Accounts.Account(privKey.Trim)

                senderAddress = accountObj.Address
                txCount = Await web3.Eth.Transactions.GetTransactionCount.SendRequestAsync(senderAddress)
                accountTotal = Await web3.Eth.GetBalance.SendRequestAsync(senderAddress)

                If accountTotal.Value <> 0 Then
                    transferTotal = New Hex.HexTypes.HexBigInteger(accountTotal.Value - deduction)

                    'generate raw signed transaction
                    encodedString = Web3.OfflineTransactionSigner.SignTransaction(privKey.Trim, receiverAddress, transferTotal, txCount.Value, gasPrice, gas)

                    'send to remote node and retrieve transaction receipt
                    Dim txID = Await web3.Eth.Transactions.SendRawTransaction.SendRequestAsync("0x" & encodedString)
                    Dim receipt = Await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(txID)

                    'if receipt is received, transaction should be sent
                    While receipt Is Nothing
                        Thread.Sleep(5000)
                        receipt = Await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(txID)
                    End While

                    If receipt.TransactionHash = txID Then
                        Label3.Text = "Transaction sent. Address: " & senderAddress & ". TXID: " & txID
                        Application.DoEvents()
                    End If
                Else
                    'empty account
                    Label3.Text = "Address " & senderAddress & " does not have a balance."
                    Application.DoEvents()
                End If
            Next

            Label3.Text = "Completed."
            btnDrain.Text = "Close"
            Application.DoEvents()
        Else
            Me.Close()
        End If
    End Sub

End Class
