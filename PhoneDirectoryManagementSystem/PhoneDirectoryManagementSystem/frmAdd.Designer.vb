<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdd
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
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.Location = New System.Drawing.Point(151, 139)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(15, 20)
        Me.lblNumber2.TabIndex = 31
        Me.lblNumber2.Text = "-"
        '
        'txtNumber2
        '
        Me.txtNumber2.BackColor = System.Drawing.Color.Lavender
        Me.txtNumber2.Location = New System.Drawing.Point(167, 139)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(45, 20)
        Me.txtNumber2.TabIndex = 30
        '
        'txtNumber
        '
        Me.txtNumber.BackColor = System.Drawing.Color.Lavender
        Me.txtNumber.Location = New System.Drawing.Point(120, 139)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(25, 20)
        Me.txtNumber.TabIndex = 29
        '
        'txtLocation
        '
        Me.txtLocation.BackColor = System.Drawing.Color.Lavender
        Me.txtLocation.Location = New System.Drawing.Point(90, 109)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(139, 20)
        Me.txtLocation.TabIndex = 28
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.Color.Lavender
        Me.txtPosition.Location = New System.Drawing.Point(86, 73)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(139, 20)
        Me.txtPosition.TabIndex = 27
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Lavender
        Me.txtName.Location = New System.Drawing.Point(77, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 20)
        Me.txtName.TabIndex = 26
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lavender
        Me.btnSave.Location = New System.Drawing.Point(118, 182)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 40)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(20, 144)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(94, 13)
        Me.lblNumber.TabIndex = 24
        Me.lblNumber.Text = "Phone Number:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(33, 112)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(60, 13)
        Me.lblLocation.TabIndex = 23
        Me.lblLocation.Text = "Location:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(33, 76)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(56, 13)
        Me.lblPosition.TabIndex = 22
        Me.lblPosition.Text = "Position:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(33, 42)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(43, 13)
        Me.lblName.TabIndex = 21
        Me.lblName.Text = "Name:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Lavender
        Me.btnBack.Location = New System.Drawing.Point(118, 277)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(149, 39)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Return to Home"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Lavender
        Me.btnClear.Location = New System.Drawing.Point(118, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(149, 43)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmAdd"
        Me.Text = "Add Employee Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber2 As Label
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
End Class
