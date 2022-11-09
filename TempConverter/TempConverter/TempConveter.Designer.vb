<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempConverter
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
        Me.lblConvertfrm = New System.Windows.Forms.Label()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.radCelsius = New System.Windows.Forms.RadioButton()
        Me.radFahrenheit = New System.Windows.Forms.RadioButton()
        Me.grpConvert = New System.Windows.Forms.GroupBox()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.grpConvert.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblConvertfrm
        '
        Me.lblConvertfrm.AutoSize = True
        Me.lblConvertfrm.Location = New System.Drawing.Point(90, 64)
        Me.lblConvertfrm.Name = "lblConvertfrm"
        Me.lblConvertfrm.Size = New System.Drawing.Size(70, 13)
        Me.lblConvertfrm.TabIndex = 0
        Me.lblConvertfrm.Text = "Convert From"
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(90, 220)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(98, 13)
        Me.lblEnter.TabIndex = 1
        Me.lblEnter.Text = "Enter Temperature:"
        '
        'radCelsius
        '
        Me.radCelsius.AutoSize = True
        Me.radCelsius.Location = New System.Drawing.Point(6, 24)
        Me.radCelsius.Name = "radCelsius"
        Me.radCelsius.Size = New System.Drawing.Size(58, 17)
        Me.radCelsius.TabIndex = 2
        Me.radCelsius.TabStop = True
        Me.radCelsius.Text = "Celsius"
        Me.radCelsius.UseVisualStyleBackColor = True
        '
        'radFahrenheit
        '
        Me.radFahrenheit.AutoSize = True
        Me.radFahrenheit.Location = New System.Drawing.Point(6, 68)
        Me.radFahrenheit.Name = "radFahrenheit"
        Me.radFahrenheit.Size = New System.Drawing.Size(75, 17)
        Me.radFahrenheit.TabIndex = 3
        Me.radFahrenheit.TabStop = True
        Me.radFahrenheit.Text = "Fahrenheit"
        Me.radFahrenheit.UseVisualStyleBackColor = True
        '
        'grpConvert
        '
        Me.grpConvert.Controls.Add(Me.radCelsius)
        Me.grpConvert.Controls.Add(Me.radFahrenheit)
        Me.grpConvert.Location = New System.Drawing.Point(202, 64)
        Me.grpConvert.Name = "grpConvert"
        Me.grpConvert.Size = New System.Drawing.Size(200, 100)
        Me.grpConvert.TabIndex = 4
        Me.grpConvert.TabStop = False
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(208, 220)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(208, 306)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(90, 368)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(143, 13)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "The Output Temperature is   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(240, 368)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(35, 13)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "XXXX"
        '
        'TempConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.grpConvert)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lblConvertfrm)
        Me.Name = "TempConverter"
        Me.Text = "Temperature Converter"
        Me.grpConvert.ResumeLayout(False)
        Me.grpConvert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConvertfrm As Label
    Friend WithEvents lblEnter As Label
    Friend WithEvents radCelsius As RadioButton
    Friend WithEvents radFahrenheit As RadioButton
    Friend WithEvents grpConvert As GroupBox
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblResult As Label
End Class
