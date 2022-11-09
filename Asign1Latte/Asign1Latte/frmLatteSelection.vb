'Project Name:  Latte Selection
'Developer:         Trevon Harris
'Date:          1/31/2020
'Purpose:       Latte Selection Interface
Public Class frmLatteSelection
    Private Sub frmLatteSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblHeading_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        ' This code is executed when user clicks the Pumpkin spice button. It displays the
        ' the pumpkin picture, hides the ocha picture, and enables the Select Latte button.
        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub picMocha_Click(sender As Object, e As EventArgs) Handles picMocha.Click

    End Sub

    Private Sub picPumpkin_Click(sender As Object, e As EventArgs) Handles picPumpkin.Click

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        '   This code is executed when the user clicks the Select button. It disables the 
        '   Pumpkin Spice button, the Select button, and the Mocha button. It hides the
        '   Instructions label, displays the confirmation label, and enables the Exit Window button.
        btnPumpkin.Enabled = False
        btnSelect.Enabled = False
        btnMocha.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        ' This code is executed when user clicks the Pumpkin spice button. It displays the
        ' the pumpkin picture, hides the ocha picture, and enables the Select Latte button.
        picMocha.Visible = True
        picPumpkin.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
