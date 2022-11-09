<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVictory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblVictory = New System.Windows.Forms.Label()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.txtDialogue = New System.Windows.Forms.Label()
        Me.txtDialogue2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtHidden = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVictory
        '
        Me.lblVictory.AutoSize = True
        Me.lblVictory.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVictory.ForeColor = System.Drawing.Color.White
        Me.lblVictory.Location = New System.Drawing.Point(119, 9)
        Me.lblVictory.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblVictory.Name = "lblVictory"
        Me.lblVictory.Size = New System.Drawing.Size(528, 96)
        Me.lblVictory.TabIndex = 1
        Me.lblVictory.Text = "『Winner』"
        '
        'btnFin
        '
        Me.btnFin.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFin.ForeColor = System.Drawing.Color.Black
        Me.btnFin.Location = New System.Drawing.Point(325, 275)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(91, 32)
        Me.btnFin.TabIndex = 19
        Me.btnFin.Text = "Fin"
        Me.btnFin.UseVisualStyleBackColor = True
        Me.btnFin.Visible = False
        '
        'txtDialogue
        '
        Me.txtDialogue.AutoSize = True
        Me.txtDialogue.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDialogue.ForeColor = System.Drawing.Color.White
        Me.txtDialogue.Location = New System.Drawing.Point(29, 123)
        Me.txtDialogue.Name = "txtDialogue"
        Me.txtDialogue.Size = New System.Drawing.Size(62, 16)
        Me.txtDialogue.TabIndex = 20
        Me.txtDialogue.Text = "Label1"
        '
        'txtDialogue2
        '
        Me.txtDialogue2.AutoSize = True
        Me.txtDialogue2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDialogue2.ForeColor = System.Drawing.Color.White
        Me.txtDialogue2.Location = New System.Drawing.Point(29, 182)
        Me.txtDialogue2.Name = "txtDialogue2"
        Me.txtDialogue2.Size = New System.Drawing.Size(62, 16)
        Me.txtDialogue2.TabIndex = 21
        Me.txtDialogue2.Text = "Label1"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(281, 313)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(205, 32)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save Player Name"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'txtHidden
        '
        Me.txtHidden.Location = New System.Drawing.Point(305, 374)
        Me.txtHidden.Name = "txtHidden"
        Me.txtHidden.Size = New System.Drawing.Size(165, 20)
        Me.txtHidden.TabIndex = 23
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(301, 253)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(185, 19)
        Me.lblName.TabIndex = 24
        Me.lblName.Text = "Enter Name Below"
        '
        'frmVictory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtHidden)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDialogue2)
        Me.Controls.Add(Me.txtDialogue)
        Me.Controls.Add(Me.btnFin)
        Me.Controls.Add(Me.lblVictory)
        Me.Name = "frmVictory"
        Me.Text = "Game Over"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVictory As Label
    Friend WithEvents btnFin As Button
    Friend WithEvents txtDialogue As Label
    Friend WithEvents txtDialogue2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtHidden As TextBox
    Friend WithEvents lblName As Label
End Class
