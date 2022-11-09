<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSort
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
        Me.lstGame = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.grpDownloads = New System.Windows.Forms.GroupBox()
        Me.radTotal = New System.Windows.Forms.RadioButton()
        Me.radDownloads = New System.Windows.Forms.RadioButton()
        Me.btnDownloads = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitB = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDownloads.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstGame
        '
        Me.lstGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGame.ForeColor = System.Drawing.Color.Black
        Me.lstGame.FormattingEnabled = True
        Me.lstGame.Location = New System.Drawing.Point(12, 22)
        Me.lstGame.Name = "lstGame"
        Me.lstGame.Size = New System.Drawing.Size(207, 225)
        Me.lstGame.TabIndex = 1
        '
        'btnSort
        '
        Me.btnSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.ForeColor = System.Drawing.Color.Black
        Me.btnSort.Location = New System.Drawing.Point(395, 168)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(177, 23)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "Sort Alphabetically"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Location = New System.Drawing.Point(256, 221)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(278, 16)
        Me.lblInfo.TabIndex = 9
        Me.lblInfo.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblInfo.Visible = False
        '
        'grpDownloads
        '
        Me.grpDownloads.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpDownloads.Controls.Add(Me.radTotal)
        Me.grpDownloads.Controls.Add(Me.radDownloads)
        Me.grpDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDownloads.ForeColor = System.Drawing.Color.Black
        Me.grpDownloads.Location = New System.Drawing.Point(259, 27)
        Me.grpDownloads.Name = "grpDownloads"
        Me.grpDownloads.Size = New System.Drawing.Size(278, 100)
        Me.grpDownloads.TabIndex = 11
        Me.grpDownloads.TabStop = False
        Me.grpDownloads.Text = "Select "
        '
        'radTotal
        '
        Me.radTotal.AutoSize = True
        Me.radTotal.Location = New System.Drawing.Point(6, 48)
        Me.radTotal.Name = "radTotal"
        Me.radTotal.Size = New System.Drawing.Size(242, 28)
        Me.radTotal.TabIndex = 1
        Me.radTotal.Text = "Total of All  Downloads"
        Me.radTotal.UseVisualStyleBackColor = True
        '
        'radDownloads
        '
        Me.radDownloads.AutoSize = True
        Me.radDownloads.Checked = True
        Me.radDownloads.Location = New System.Drawing.Point(7, 22)
        Me.radDownloads.Name = "radDownloads"
        Me.radDownloads.Size = New System.Drawing.Size(192, 28)
        Me.radDownloads.TabIndex = 0
        Me.radDownloads.TabStop = True
        Me.radDownloads.Text = "Game Downloads"
        Me.radDownloads.UseVisualStyleBackColor = True
        '
        'btnDownloads
        '
        Me.btnDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownloads.ForeColor = System.Drawing.Color.Black
        Me.btnDownloads.Location = New System.Drawing.Point(244, 168)
        Me.btnDownloads.Name = "btnDownloads"
        Me.btnDownloads.Size = New System.Drawing.Size(134, 23)
        Me.btnDownloads.TabIndex = 12
        Me.btnDownloads.Text = "View Downloads"
        Me.btnDownloads.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Clear, Me.ExitB})
        Me.ClearToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClearToolStripMenuItem.Text = "&Options"
        '
        'Clear
        '
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(180, 22)
        Me.Clear.Text = "&Clear"
        '
        'ExitB
        '
        Me.ExitB.Name = "ExitB"
        Me.ExitB.Size = New System.Drawing.Size(180, 22)
        Me.ExitB.Text = "&Exit"
        '
        'frmSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.btnDownloads)
        Me.Controls.Add(Me.grpDownloads)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.lstGame)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSort"
        Me.Text = "Most Popular Games Sold"
        Me.grpDownloads.ResumeLayout(False)
        Me.grpDownloads.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGame As ListBox
    Friend WithEvents btnSort As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents grpDownloads As GroupBox
    Friend WithEvents radTotal As RadioButton
    Friend WithEvents radDownloads As RadioButton
    Friend WithEvents btnDownloads As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Clear As ToolStripMenuItem
    Friend WithEvents ExitB As ToolStripMenuItem
End Class
