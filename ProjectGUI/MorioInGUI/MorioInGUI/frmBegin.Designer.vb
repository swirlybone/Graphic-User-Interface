<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBegin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBegin))
        Me.txtDialogue = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnContinue2 = New System.Windows.Forms.Button()
        Me.btnContinue3 = New System.Windows.Forms.Button()
        Me.btnLeave = New System.Windows.Forms.Button()
        Me.btnContinue4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDialogue
        '
        Me.txtDialogue.AutoSize = True
        Me.txtDialogue.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDialogue.ForeColor = System.Drawing.Color.White
        Me.txtDialogue.Location = New System.Drawing.Point(25, 34)
        Me.txtDialogue.Name = "txtDialogue"
        Me.txtDialogue.Size = New System.Drawing.Size(476, 112)
        Me.txtDialogue.TabIndex = 2
        Me.txtDialogue.Text = resources.GetString("txtDialogue.Text")
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.Black
        Me.btnContinue.Location = New System.Drawing.Point(342, 193)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(91, 32)
        Me.btnContinue.TabIndex = 17
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnContinue2
        '
        Me.btnContinue2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue2.ForeColor = System.Drawing.Color.Black
        Me.btnContinue2.Location = New System.Drawing.Point(342, 193)
        Me.btnContinue2.Name = "btnContinue2"
        Me.btnContinue2.Size = New System.Drawing.Size(91, 32)
        Me.btnContinue2.TabIndex = 18
        Me.btnContinue2.Text = "Continue"
        Me.btnContinue2.UseVisualStyleBackColor = True
        Me.btnContinue2.Visible = False
        '
        'btnContinue3
        '
        Me.btnContinue3.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue3.ForeColor = System.Drawing.Color.Black
        Me.btnContinue3.Location = New System.Drawing.Point(342, 193)
        Me.btnContinue3.Name = "btnContinue3"
        Me.btnContinue3.Size = New System.Drawing.Size(91, 32)
        Me.btnContinue3.TabIndex = 19
        Me.btnContinue3.Text = "Continue"
        Me.btnContinue3.UseVisualStyleBackColor = True
        Me.btnContinue3.Visible = False
        '
        'btnLeave
        '
        Me.btnLeave.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeave.ForeColor = System.Drawing.Color.Black
        Me.btnLeave.Location = New System.Drawing.Point(342, 187)
        Me.btnLeave.Name = "btnLeave"
        Me.btnLeave.Size = New System.Drawing.Size(91, 44)
        Me.btnLeave.TabIndex = 20
        Me.btnLeave.Text = "Leave " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gate"
        Me.btnLeave.UseVisualStyleBackColor = True
        Me.btnLeave.Visible = False
        '
        'btnContinue4
        '
        Me.btnContinue4.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue4.ForeColor = System.Drawing.Color.Black
        Me.btnContinue4.Location = New System.Drawing.Point(342, 193)
        Me.btnContinue4.Name = "btnContinue4"
        Me.btnContinue4.Size = New System.Drawing.Size(91, 32)
        Me.btnContinue4.TabIndex = 21
        Me.btnContinue4.Text = "Continue"
        Me.btnContinue4.UseVisualStyleBackColor = True
        Me.btnContinue4.Visible = False
        '
        'frmBegin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnContinue4)
        Me.Controls.Add(Me.btnLeave)
        Me.Controls.Add(Me.btnContinue3)
        Me.Controls.Add(Me.btnContinue2)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtDialogue)
        Me.Name = "frmBegin"
        Me.Text = "Morio Ventures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDialogue As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnContinue2 As Button
    Friend WithEvents btnContinue3 As Button
    Friend WithEvents btnLeave As Button
    Friend WithEvents btnContinue4 As Button
End Class
