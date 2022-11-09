<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJourney
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJourney))
        Me.txtDialogue = New System.Windows.Forms.Label()
        Me.btnNorth = New System.Windows.Forms.Button()
        Me.btnEast = New System.Windows.Forms.Button()
        Me.btnSouth = New System.Windows.Forms.Button()
        Me.btnWest = New System.Windows.Forms.Button()
        Me.btnNorth2 = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSouth2 = New System.Windows.Forms.Button()
        Me.btnCollect = New System.Windows.Forms.Button()
        Me.btnEast2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDialogue
        '
        Me.txtDialogue.AutoSize = True
        Me.txtDialogue.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDialogue.ForeColor = System.Drawing.Color.White
        Me.txtDialogue.Location = New System.Drawing.Point(26, 29)
        Me.txtDialogue.Name = "txtDialogue"
        Me.txtDialogue.Size = New System.Drawing.Size(476, 112)
        Me.txtDialogue.TabIndex = 0
        Me.txtDialogue.Text = resources.GetString("txtDialogue.Text")
        '
        'btnNorth
        '
        Me.btnNorth.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNorth.ForeColor = System.Drawing.Color.Black
        Me.btnNorth.Location = New System.Drawing.Point(341, 183)
        Me.btnNorth.Name = "btnNorth"
        Me.btnNorth.Size = New System.Drawing.Size(91, 32)
        Me.btnNorth.TabIndex = 16
        Me.btnNorth.Text = "North"
        Me.btnNorth.UseVisualStyleBackColor = True
        '
        'btnEast
        '
        Me.btnEast.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEast.ForeColor = System.Drawing.Color.Black
        Me.btnEast.Location = New System.Drawing.Point(341, 183)
        Me.btnEast.Name = "btnEast"
        Me.btnEast.Size = New System.Drawing.Size(91, 32)
        Me.btnEast.TabIndex = 17
        Me.btnEast.Text = "East"
        Me.btnEast.UseVisualStyleBackColor = True
        '
        'btnSouth
        '
        Me.btnSouth.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSouth.ForeColor = System.Drawing.Color.Black
        Me.btnSouth.Location = New System.Drawing.Point(341, 221)
        Me.btnSouth.Name = "btnSouth"
        Me.btnSouth.Size = New System.Drawing.Size(91, 32)
        Me.btnSouth.TabIndex = 18
        Me.btnSouth.Text = "South"
        Me.btnSouth.UseVisualStyleBackColor = True
        '
        'btnWest
        '
        Me.btnWest.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWest.ForeColor = System.Drawing.Color.Black
        Me.btnWest.Location = New System.Drawing.Point(341, 183)
        Me.btnWest.Name = "btnWest"
        Me.btnWest.Size = New System.Drawing.Size(91, 32)
        Me.btnWest.TabIndex = 19
        Me.btnWest.Text = "West"
        Me.btnWest.UseVisualStyleBackColor = True
        '
        'btnNorth2
        '
        Me.btnNorth2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNorth2.ForeColor = System.Drawing.Color.Black
        Me.btnNorth2.Location = New System.Drawing.Point(341, 183)
        Me.btnNorth2.Name = "btnNorth2"
        Me.btnNorth2.Size = New System.Drawing.Size(91, 32)
        Me.btnNorth2.TabIndex = 20
        Me.btnNorth2.Text = "Back"
        Me.btnNorth2.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.Color.Black
        Me.btnOpen.Location = New System.Drawing.Point(341, 183)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(91, 32)
        Me.btnOpen.TabIndex = 22
        Me.btnOpen.Text = "Open Chest"
        Me.btnOpen.UseVisualStyleBackColor = True
        Me.btnOpen.Visible = False
        '
        'btnSouth2
        '
        Me.btnSouth2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSouth2.ForeColor = System.Drawing.Color.Black
        Me.btnSouth2.Location = New System.Drawing.Point(341, 183)
        Me.btnSouth2.Name = "btnSouth2"
        Me.btnSouth2.Size = New System.Drawing.Size(91, 32)
        Me.btnSouth2.TabIndex = 23
        Me.btnSouth2.Text = "Back"
        Me.btnSouth2.UseVisualStyleBackColor = True
        Me.btnSouth2.Visible = False
        '
        'btnCollect
        '
        Me.btnCollect.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollect.ForeColor = System.Drawing.Color.Black
        Me.btnCollect.Location = New System.Drawing.Point(331, 183)
        Me.btnCollect.Name = "btnCollect"
        Me.btnCollect.Size = New System.Drawing.Size(116, 32)
        Me.btnCollect.TabIndex = 24
        Me.btnCollect.Text = "Collect"
        Me.btnCollect.UseVisualStyleBackColor = True
        Me.btnCollect.Visible = False
        '
        'btnEast2
        '
        Me.btnEast2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEast2.ForeColor = System.Drawing.Color.Black
        Me.btnEast2.Location = New System.Drawing.Point(341, 183)
        Me.btnEast2.Name = "btnEast2"
        Me.btnEast2.Size = New System.Drawing.Size(91, 32)
        Me.btnEast2.TabIndex = 25
        Me.btnEast2.Text = "Back"
        Me.btnEast2.UseVisualStyleBackColor = True
        Me.btnEast2.Visible = False
        '
        'frmJourney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEast2)
        Me.Controls.Add(Me.btnCollect)
        Me.Controls.Add(Me.btnSouth2)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnNorth2)
        Me.Controls.Add(Me.btnWest)
        Me.Controls.Add(Me.btnSouth)
        Me.Controls.Add(Me.btnEast)
        Me.Controls.Add(Me.btnNorth)
        Me.Controls.Add(Me.txtDialogue)
        Me.Name = "frmJourney"
        Me.Text = "Morio Ventures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDialogue As Label
    Friend WithEvents btnNorth As Button
    Friend WithEvents btnEast As Button
    Friend WithEvents btnSouth As Button
    Friend WithEvents btnWest As Button
    Friend WithEvents btnNorth2 As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSouth2 As Button
    Friend WithEvents btnCollect As Button
    Friend WithEvents btnEast2 As Button
End Class
