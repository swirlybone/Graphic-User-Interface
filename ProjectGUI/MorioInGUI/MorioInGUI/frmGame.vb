Public Class frmGame
    Public Shared size As Integer = 1
    Dim intCount As Integer = 0
    Public Shared monsterHealth(size) As Integer
    Dim monsterHp As Integer
    Dim playerHealth As Integer = 100
    'Dim monsterHealth As Integer
    Dim playerAttack As Integer = 50
    Dim playerWeapon As String = "Sword and Shield"
    Dim monsterAttack As Integer = 10
    Dim potionCount As Integer = 10
    Dim playerStats As String
    Dim playerBlock As Integer
    'Dim playerMana As Integer = 10
    Dim strFile As String = "C:\ProjectGUI\MorioInGUI\MorioInGUI\stats.txt"
    Dim strFileError As String = "The file is not found."
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFile As String = "C:\ProjectGUI\MorioInGUI\MorioInGUI\stats.txt"
        'Dim monsterHealth As Integer
        If IO.File.Exists(strFile) = True Then
            objReader = IO.File.OpenText(strFile)
            Do While objReader.Peek() <> -1
                monsterHealth(intCount) = objReader.ReadLine()
                monsterHp = monsterHealth(intCount)
                intCount += 1

            Loop

        End If
        txtWeapon.Text = playerWeapon
        txtHP.Text = playerHealth
        txtMonsterHP.Text = monsterHp
        txtPotion.Text = potionCount
        'txtMana.Text = playerMana


    End Sub

    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click

        If monsterHp > 1 Then
            lblDialogue.Visible = True
            monsterHp = monsterHp - 50
            playerHealth = playerHealth - monsterAttack
            playerStats = "Player dealt " + playerAttack.ToString() + ", Monster dealt " + monsterAttack.ToString() + "!"
            lblDialogue.Text = playerStats
            txtHP.Text = playerHealth
            txtMonsterHP.Text = monsterHp
        ElseIf 1 > monsterHp Then
            lblDialogue.Text = "Winner!"
            btnAttack.Visible = False
            btnDefend.Visible = False
            btnHeal.Visible = False
            btnMagic.Visible = False
            btnEnd.Visible = True
        End If
        If playerHealth < 1 Then
            Dim frmGame As New frmGameOver
            Hide()
            frmGameOver.ShowDialog()
        End If

    End Sub

    Private Sub btnDefend_Click(sender As Object, e As EventArgs) Handles btnDefend.Click
        If monsterHp > 1 Then
            lblDialogue.Visible = True
            playerBlock = monsterAttack / 2
            playerHealth = playerHealth - playerBlock
            playerStats = "Player blocked damage " + playerBlock.ToString + " damage!"
            lblDialogue.Text = playerStats
            txtHP.Text = playerHealth
            txtMonsterHP.Text = monsterHp
        ElseIf 1 > monsterHp Then
            lblDialogue.Text = "Winner!"
            btnAttack.Visible = False
            btnDefend.Visible = False
            btnHeal.Visible = False
            btnEnd.Visible = True
            btnMagic.Visible = False
            If playerHealth < 1 Then
                Dim frmGame As New frmGameOver
                Hide()
                frmGameOver.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnHeal_Click(sender As Object, e As EventArgs) Handles btnHeal.Click
        If potionCount > 0 Then
            lblDialogue.Visible = True
            playerHealth = playerHealth + 20
            playerHealth = playerHealth - monsterAttack
            potionCount = potionCount - 1
            playerStats = "Player heals for 20, however while healing the monster hit for  " + monsterAttack.ToString + " damage!"
            txtPotion.Text = potionCount
            lblDialogue.Text = playerStats
            txtHP.Text = playerHealth
            txtMonsterHP.Text = monsterHp
        ElseIf 1 > monsterHp Then
            lblDialogue.Text = "Winner!"
            btnAttack.Visible = False
            btnDefend.Visible = False
            btnHeal.Visible = False
            btnEnd.Visible = True
            btnMagic.Visible = False
        ElseIf potionCount = 0 Then
            lblDialogue.Text = "Out of potions!"
            'btnAttack.Visible = False
            'btnDefend.Visible = False
            btnHeal.Visible = False
            'btnEnd.Visible = True
            If playerHealth > 1 Then
                Dim frmGame As New frmGameOver
                Hide()
                frmGameOver.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Dim frmGame As New frmVictory
        Hide()
        frmVictory.ShowDialog()
    End Sub

    Private Sub btnMagic_Click(sender As Object, e As EventArgs) Handles btnMagic.Click
        Dim magicAttack As Integer = 55
        If monsterHp > 1 Then
            lblDialogue.Visible = True
            monsterHp = monsterHp - 55
            playerHealth = playerHealth - monsterAttack * 2
            playerStats = "Player used a fire ball and dealt " + magicAttack.ToString() + ", Monster dealt double damage!"
            lblDialogue.Text = playerStats
            txtHP.Text = playerHealth
            txtMonsterHP.Text = monsterHp
            'playerMana = playerMana - 1
            'txtMana.Text = playerMana
        ElseIf 1 > monsterHp Then
            lblDialogue.Text = "Winner!"
            btnAttack.Visible = False
            btnDefend.Visible = False
            btnHeal.Visible = False
            btnMagic.Visible = False
            btnEnd.Visible = True
        End If
        If playerHealth < 1 Then
            Dim frmGame As New frmGameOver
            Hide()
            frmGameOver.ShowDialog()
        End If
    End Sub


End Class