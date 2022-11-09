Public Class frmJourney
    Private Sub frmJourney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDialogue.Text = "You left Morio town gate, where should we go now? North is back to town."
        btnNorth.Visible = True
        btnSouth.Visible = True
        btnEast.Visible = False
        btnWest.Visible = False
        btnNorth2.Visible = False
    End Sub

    Private Sub btnNorth_Click(sender As Object, e As EventArgs) Handles btnNorth.Click
        txtDialogue.Text = "Guard: You still can't come here, sorry."
        btnNorth.Visible = False
        btnSouth.Visible = False
        btnEast.Visible = False
        btnWest.Visible = False
        btnNorth2.Visible = True
    End Sub

    Private Sub btnNorth2_Click(sender As Object, e As EventArgs) Handles btnNorth2.Click
        txtDialogue.Text = "You left Morio town gate, where should we go now? North is back to town."
        btnNorth.Visible = False
        btnSouth.Visible = True
        btnEast.Visible = False
        btnWest.Visible = False
        btnNorth2.Visible = False
    End Sub

    Private Sub btnSouth_Click(sender As Object, e As EventArgs) Handles btnSouth.Click
        Dim tracker As Integer = 0
        txtDialogue.Text = "You stumble upon a chest."
            btnNorth.Visible = False
            btnSouth.Visible = False
            btnEast.Visible = False
            btnWest.Visible = False
            btnNorth2.Visible = False
            btnOpen.Visible = True
        tracker = tracker + 1
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        txtDialogue.Text = "Upon opening you find a sword and shield and 10 potions."
        btnSouth2.Visible = True
        btnOpen.Visible = False
    End Sub

    Private Sub btnSouth2_Click(sender As Object, e As EventArgs) Handles btnSouth2.Click
        txtDialogue.Text = "You have returned, where to next?"
        btnNorth.Visible = False
        btnEast.Visible = True
        btnWest.Visible = False
        btnSouth2.Visible = False
    End Sub

    Private Sub btnEast_Click(sender As Object, e As EventArgs) Handles btnEast.Click
        txtDialogue.Text = "You head East into the woods and find a magic staff."
        btnNorth.Visible = False
        btnSouth.Visible = False
        btnEast.Visible = False
        btnWest.Visible = False
        btnCollect.Visible = True
    End Sub

    Private Sub btnCollect_Click(sender As Object, e As EventArgs) Handles btnCollect.Click
        txtDialogue.Text = "You pick up the staff, magic seems useful."
        btnEast2.Visible = True
        btnCollect.Visible = False
    End Sub

    Private Sub btnEast2_Click(sender As Object, e As EventArgs) Handles btnEast2.Click
        txtDialogue.Text = "You returned, where to next?"
        btnNorth.Visible = False
        btnSouth.Visible = False
        btnEast.Visible = False
        btnWest.Visible = True
        btnEast2.Visible = False
    End Sub

    Private Sub btnWest_Click(sender As Object, e As EventArgs) Handles btnWest.Click
        Dim frmJourney As New frmGame
        Hide()
        frmGame.ShowDialog()
    End Sub
End Class