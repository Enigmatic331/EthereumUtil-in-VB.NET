Imports System.IO
Imports Nethereum.Hex
Imports Nethereum.Web3

Public Class checkBalance
    Dim filepath As String

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'check if directory makes sense
        'check if csv file is on the correct format
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files | *.csv"
        openFileDialog.RestoreDirectory = True

        openFileDialog.ShowDialog()

        If openFileDialog.FileName.Length <> 0 Then
            filepath = openFileDialog.FileName
            txtDir.Text = filepath
        Else
            MessageBox.Show("Please select a file!")
        End If
    End Sub

    Private Async Sub btnCheckBal_Click(sender As Object, e As EventArgs) Handles btnCheckBal.Click
        Dim r As HexTypes.HexBigInteger
        Dim tempfile As String

        If filepath.Length <> 0 Then
            tempfile = Path.GetTempFileName()
            Using sw = New StreamWriter(tempfile)
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filepath)
                    MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                    MyReader.Delimiters = New String() {","}
                    Dim currentRow As String()

                    If Not MyReader.EndOfData Then
                        currentRow = MyReader.ReadFields()
                        sw.WriteLine(String.Join(",", currentRow))
                    End If
                    While Not MyReader.EndOfData
                        Try
                            currentRow = MyReader.ReadFields()
                            Label1.Text = "Checking: " & currentRow(1)
                            r = Await CheckBalance(currentRow(1))
                            currentRow(2) = r.Value.ToString
                            'write to tempfile
                            sw.WriteLine(String.Join(",", currentRow))
                        Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                            MessageBox.Show("Error: " & ex.Message)
                        End Try
                    End While
                End Using
            End Using

            File.Delete(filepath)
            File.Move(tempfile, filepath)
            Label1.Text = "Completed."
        Else
            MessageBox.Show("Please select a file!")
        End If
    End Sub

    Private Async Function CheckBalance(ByVal publicKey As String) As Task(Of HexTypes.HexBigInteger)
        'initialise web3 - this could probably be better optimised as a module variable
        Dim web3 As Web3
        web3 = New Web3("https://mainnet.infura.io/")
        Dim accountTotal As HexTypes.HexBigInteger

        accountTotal = Await web3.Eth.GetBalance.SendRequestAsync(publicKey)
        Return accountTotal

    End Function

End Class