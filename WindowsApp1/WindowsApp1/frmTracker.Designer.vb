<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTracker
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtBirth = New System.Windows.Forms.TextBox()
        Me.txtBirth2 = New System.Windows.Forms.TextBox()
        Me.txtBirth3 = New System.Windows.Forms.TextBox()
        Me.txtDate2 = New System.Windows.Forms.TextBox()
        Me.txtDate3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(112, 29)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(261, 39)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Fitness Tracker"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(26, 116)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(134, 25)
        Me.lblFname.TabIndex = 1
        Me.lblFname.Text = "First Name:"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.Location = New System.Drawing.Point(26, 160)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(132, 25)
        Me.lblLname.TabIndex = 2
        Me.lblLname.Text = "Last Name:"
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirth.Location = New System.Drawing.Point(26, 204)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(127, 25)
        Me.lblBirth.TabIndex = 3
        Me.lblBirth.Text = "Birth Date:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(26, 248)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(155, 25)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Current Date:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(36, 361)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(52, 25)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "X X "
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(67, 317)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(129, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate Hours"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(232, 317)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(343, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(167, 120)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 33)
        Me.txtFirst.TabIndex = 9
        '
        'txtLast
        '
        Me.txtLast.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.Location = New System.Drawing.Point(167, 159)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 33)
        Me.txtLast.TabIndex = 10
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(189, 252)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(30, 33)
        Me.txtDate.TabIndex = 12
        '
        'txtBirth
        '
        Me.txtBirth.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirth.Location = New System.Drawing.Point(167, 204)
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.Size = New System.Drawing.Size(29, 33)
        Me.txtBirth.TabIndex = 11
        '
        'txtBirth2
        '
        Me.txtBirth2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirth2.Location = New System.Drawing.Point(202, 204)
        Me.txtBirth2.Name = "txtBirth2"
        Me.txtBirth2.Size = New System.Drawing.Size(30, 33)
        Me.txtBirth2.TabIndex = 13
        '
        'txtBirth3
        '
        Me.txtBirth3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirth3.Location = New System.Drawing.Point(238, 201)
        Me.txtBirth3.Name = "txtBirth3"
        Me.txtBirth3.Size = New System.Drawing.Size(60, 33)
        Me.txtBirth3.TabIndex = 14
        '
        'txtDate2
        '
        Me.txtDate2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate2.Location = New System.Drawing.Point(225, 252)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(30, 33)
        Me.txtDate2.TabIndex = 15
        '
        'txtDate3
        '
        Me.txtDate3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate3.Location = New System.Drawing.Point(261, 252)
        Me.txtDate3.Name = "txtDate3"
        Me.txtDate3.Size = New System.Drawing.Size(60, 33)
        Me.txtDate3.TabIndex = 16
        '
        'frmTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.sonic___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.txtDate3)
        Me.Controls.Add(Me.txtDate2)
        Me.Controls.Add(Me.txtBirth3)
        Me.Controls.Add(Me.txtBirth2)
        Me.Controls.Add(Me.txtBirth)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblBirth)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.lblHeading)
        Me.DoubleBuffered = True
        Me.Name = "frmTracker"
        Me.Text = "Fitness Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblBirth As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtBirth As TextBox
    Friend WithEvents txtBirth2 As TextBox
    Friend WithEvents txtBirth3 As TextBox
    Friend WithEvents txtDate2 As TextBox
    Friend WithEvents txtDate3 As TextBox
End Class
