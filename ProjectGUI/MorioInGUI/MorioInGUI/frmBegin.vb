Public Class frmBegin
    Private Sub frmBegin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDialogue.Text = "You awake outside of the Morio town gate."
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        txtDialogue.Text = "Guard: Hello there stranger. You must be new here. Well, welcome to Morio."
        btnContinue.Visible = False
        btnContinue2.Visible = True
    End Sub

    Private Sub btnContinue2_Click(sender As Object, e As EventArgs) Handles btnContinue2.Click
        txtDialogue.Text = "Guard: Unfortunately however, we cannot accept new people in currently."
        btnContinue2.Visible = False
        btnContinue3.Visible = True
    End Sub

    Private Sub btnContinue3_Click(sender As Object, e As EventArgs) Handles btnContinue3.Click
        txtDialogue.Text = "Guard: You see we have a dragon invasion."
        btnContinue3.Visible = False
        btnContinue4.Visible = True
    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click

        Dim frmBegin As New frmJourney
        Hide()
        frmJourney.ShowDialog()
    End Sub

    Private Sub btnContinue4_Click(sender As Object, e As EventArgs) Handles btnContinue4.Click
        txtDialogue.Text = "Tell you what. You help us out we'll let you in."
        btnContinue4.Visible = False
        btnLeave.Visible = True
    End Sub
End Class