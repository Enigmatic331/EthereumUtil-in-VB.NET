
Public Class MainForm
    Private Sub btnSweep_Click(sender As Object, e As EventArgs) Handles btnSweep.Click
        DrainBalance.ShowDialog()
    End Sub

    Private Sub btnGenKeys_Click(sender As Object, e As EventArgs) Handles btnGenKeys.Click
        GenerateAddresses.ShowDialog()
    End Sub

    Private Sub btnCheckBalance_Click(sender As Object, e As EventArgs) Handles btnCheckBalance.Click
        'making the assumption that it is the third column to update
        checkBalance.ShowDialog()
    End Sub

    Private Sub btnSender_Click(sender As Object, e As EventArgs) Handles btnSend.Click

    End Sub

    Private Sub btnPrivToJSON_Click(sender As Object, e As EventArgs) Handles btnPrivToJSON.Click
        Using frm = New PrivateKeyToJSON
            frm.ShowDialog()
        End Using
    End Sub
End Class