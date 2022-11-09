Public Class frmVictory
    Private Sub frmVictory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDialogue.Text = "You return to Morio having killed the Dragon King."
        txtDialogue2.Text = "You have been let into the town of Morio after bringing the head back."
        btnSave.Visible = True
        txtHidden.Visible = True
        lblName.Visible = True

    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Computer.FileSystem.WriteAllText("C:\ProjectGUI\MorioInGUI\MorioInGUI\players.txt", "," & txtHidden.Text, True)
        txtHidden.Visible = False
        lblName.Visible = False
        btnSave.Visible = False
        btnFin.Visible = True
    End Sub
End Class