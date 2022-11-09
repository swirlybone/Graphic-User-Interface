<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblMonsterHP = New System.Windows.Forms.Label()
        Me.lblWeapon = New System.Windows.Forms.Label()
        Me.lblPotion = New System.Windows.Forms.Label()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.btnDefend = New System.Windows.Forms.Button()
        Me.btnHeal = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.txtHP = New System.Windows.Forms.Label()
        Me.txtWeapon = New System.Windows.Forms.Label()
        Me.txtPotion = New System.Windows.Forms.Label()
        Me.txtMonsterHP = New System.Windows.Forms.Label()
        Me.lblDialogue = New System.Windows.Forms.Label()
        Me.btnMagic = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHP.Location = New System.Drawing.Point(20, 74)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(134, 16)
        Me.lblHP.TabIndex = 7
        Me.lblHP.Text = "Player Health:"
        '
        'lblMonsterHP
        '
        Me.lblMonsterHP.AutoSize = True
        Me.lblMonsterHP.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonsterHP.Location = New System.Drawing.Point(234, 18)
        Me.lblMonsterHP.Name = "lblMonsterHP"
        Me.lblMonsterHP.Size = New System.Drawing.Size(162, 27)
        Me.lblMonsterHP.TabIndex = 8
        Me.lblMonsterHP.Text = "Dragon HP:"
        '
        'lblWeapon
        '
        Me.lblWeapon.AutoSize = True
        Me.lblWeapon.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeapon.Location = New System.Drawing.Point(20, 135)
        Me.lblWeapon.Name = "lblWeapon"
        Me.lblWeapon.Size = New System.Drawing.Size(134, 16)
        Me.lblWeapon.TabIndex = 9
        Me.lblWeapon.Text = "Player Weapon:"
        '
        'lblPotion
        '
        Me.lblPotion.AutoSize = True
        Me.lblPotion.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPotion.Location = New System.Drawing.Point(20, 185)
        Me.lblPotion.Name = "lblPotion"
        Me.lblPotion.Size = New System.Drawing.Size(125, 16)
        Me.lblPotion.TabIndex = 10
        Me.lblPotion.Text = "Potion Count:"
        '
        'btnAttack
        '
        Me.btnAttack.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttack.ForeColor = System.Drawing.Color.Black
        Me.btnAttack.Location = New System.Drawing.Point(324, 264)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(91, 32)
        Me.btnAttack.TabIndex = 15
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'btnDefend
        '
        Me.btnDefend.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefend.ForeColor = System.Drawing.Color.Black
        Me.btnDefend.Location = New System.Drawing.Point(324, 340)
        Me.btnDefend.Name = "btnDefend"
        Me.btnDefend.Size = New System.Drawing.Size(91, 32)
        Me.btnDefend.TabIndex = 16
        Me.btnDefend.Text = "Defend"
        Me.btnDefend.UseVisualStyleBackColor = True
        '
        'btnHeal
        '
        Me.btnHeal.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeal.ForeColor = System.Drawing.Color.Black
        Me.btnHeal.Location = New System.Drawing.Point(324, 378)
        Me.btnHeal.Name = "btnHeal"
        Me.btnHeal.Size = New System.Drawing.Size(91, 32)
        Me.btnHeal.TabIndex = 17
        Me.btnHeal.Text = "Heal"
        Me.btnHeal.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.ForeColor = System.Drawing.Color.Black
        Me.btnEnd.Location = New System.Drawing.Point(324, 264)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(91, 32)
        Me.btnEnd.TabIndex = 18
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        Me.btnEnd.Visible = False
        '
        'txtHP
        '
        Me.txtHP.AutoSize = True
        Me.txtHP.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHP.Location = New System.Drawing.Point(145, 74)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(62, 16)
        Me.txtHP.TabIndex = 20
        Me.txtHP.Text = "XXXXXX"
        '
        'txtWeapon
        '
        Me.txtWeapon.AutoSize = True
        Me.txtWeapon.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeapon.Location = New System.Drawing.Point(145, 135)
        Me.txtWeapon.Name = "txtWeapon"
        Me.txtWeapon.Size = New System.Drawing.Size(62, 16)
        Me.txtWeapon.TabIndex = 21
        Me.txtWeapon.Text = "XXXXXX"
        '
        'txtPotion
        '
        Me.txtPotion.AutoSize = True
        Me.txtPotion.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPotion.Location = New System.Drawing.Point(145, 185)
        Me.txtPotion.Name = "txtPotion"
        Me.txtPotion.Size = New System.Drawing.Size(62, 16)
        Me.txtPotion.TabIndex = 22
        Me.txtPotion.Text = "XXXXXX"
        '
        'txtMonsterHP
        '
        Me.txtMonsterHP.AutoSize = True
        Me.txtMonsterHP.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonsterHP.Location = New System.Drawing.Point(405, 18)
        Me.txtMonsterHP.Name = "txtMonsterHP"
        Me.txtMonsterHP.Size = New System.Drawing.Size(102, 27)
        Me.txtMonsterHP.TabIndex = 23
        Me.txtMonsterHP.Text = "XXXXXX"
        '
        'lblDialogue
        '
        Me.lblDialogue.AutoSize = True
        Me.lblDialogue.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDialogue.Location = New System.Drawing.Point(213, 84)
        Me.lblDialogue.Name = "lblDialogue"
        Me.lblDialogue.Size = New System.Drawing.Size(215, 99)
        Me.lblDialogue.TabIndex = 24
        Me.lblDialogue.Text = resources.GetString("lblDialogue.Text")
        Me.lblDialogue.Visible = False
        '
        'btnMagic
        '
        Me.btnMagic.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMagic.ForeColor = System.Drawing.Color.Black
        Me.btnMagic.Location = New System.Drawing.Point(324, 302)
        Me.btnMagic.Name = "btnMagic"
        Me.btnMagic.Size = New System.Drawing.Size(91, 32)
        Me.btnMagic.TabIndex = 25
        Me.btnMagic.Text = "Magic"
        Me.btnMagic.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMagic)
        Me.Controls.Add(Me.lblDialogue)
        Me.Controls.Add(Me.txtMonsterHP)
        Me.Controls.Add(Me.txtPotion)
        Me.Controls.Add(Me.txtWeapon)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnHeal)
        Me.Controls.Add(Me.btnDefend)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.lblPotion)
        Me.Controls.Add(Me.lblWeapon)
        Me.Controls.Add(Me.lblMonsterHP)
        Me.Controls.Add(Me.lblHP)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmGame"
        Me.Text = " Morio Ventures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHP As Label
    Friend WithEvents lblMonsterHP As Label
    Friend WithEvents lblWeapon As Label
    Friend WithEvents lblPotion As Label
    Friend WithEvents btnAttack As Button
    Friend WithEvents btnDefend As Button
    Friend WithEvents btnHeal As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents txtHP As Label
    Friend WithEvents txtWeapon As Label
    Friend WithEvents txtPotion As Label
    Friend WithEvents txtMonsterHP As Label
    Friend WithEvents lblDialogue As Label
    Friend WithEvents btnMagic As Button
End Class
