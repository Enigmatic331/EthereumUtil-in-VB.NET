Imports Nethereum
Imports Nethereum.Hex.HexConvertors.Extensions
Imports System.IO


Public Class UtilWallet
    Private _error As String

    Public ReadOnly Property returnError As String
        Get
            Return _error
        End Get
    End Property

    Public Function initAccount(ByVal privKey As String) As Web3.Accounts.Account
        Dim account As Web3.Accounts.Account

        Try
            'attempt to initialise account with privatekey
            account = New Web3.Accounts.Account(privKey)
        Catch ex As Exception
            _error = "[Function initAccount][Error]: Error initialising account with private key: " & ex.Message
            account = Nothing
        End Try

        Return account
    End Function

    ''' <summary>
    ''' Convert private key to UTC JSON Keystore File (v3)
    ''' </summary>
    ''' <param name="account">Web3 account object</param>
    ''' <param name="password">Password to set</param>
    ''' <param name="path">Optional: Path</param>
    ''' <returns>Path - Returns path to the saved JSON file</returns>
    Public Function privateKeyToJSON(ByRef account As Web3.Accounts.Account, ByVal password As String, Optional ByVal path As String = "") As String
        Dim KeyStoreService As New KeyStore.KeyStoreService
        Dim JSONstring As String = KeyStoreService.EncryptAndGenerateDefaultKeyStoreAsJson(password,
                                                                                           account.PrivateKey.Substring(account.PrivateKey.Length - 64).HexToByteArray,
                                                                                           account.Address)
        Dim filename As String = KeyStoreService.GenerateUTCFileName(account.Address)
        Dim fullPath As String = "" ' just for clarity - upon cancellation or if anything goes wrong, fullpath returns empty string

        Try
            If path <> "" Then
                fullPath = IIf(path.Substring(path.Length - 1) = "\", path & filename, path & "\" & filename)

                Try
                    'if there's a path, save it automatically to that directory
                    Dim sw As StreamWriter = New StreamWriter(fullPath)
                    If (sw IsNot Nothing) Then
                        sw.WriteLine(JSONstring)
                        sw.Close()
                    End If
                Catch ex As Exception
                    _error = "[Function privateKeyToJSON][Error]: " & ex.Message
                End Try
            Else
                'save the file based off a selected directory
                Dim sfd As New SaveFileDialog
                sfd.Filter = ""
                sfd.RestoreDirectory = True
                sfd.FileName = filename

                If sfd.ShowDialog = DialogResult.OK Then
                    Dim sw As StreamWriter = New StreamWriter(sfd.OpenFile())
                    If (sw IsNot Nothing) Then
                        sw.WriteLine(JSONstring)
                        sw.Close()
                        fullPath = sfd.FileName
                    End If
                End If
            End If
        Catch ex As Exception
            _error = "[Function privateKeyToJSON][Error]: " & ex.Message
            fullPath = ""
        End Try

        Return fullPath
    End Function

End Class
