Public Class frmStart
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim frmStart As New frmBegin
        Hide()
        frmBegin.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
