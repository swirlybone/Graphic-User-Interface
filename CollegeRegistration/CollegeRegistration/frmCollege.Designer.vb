<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollege
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
        Me.picCollege = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblNumberOfUnits = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfUnits = New System.Windows.Forms.TextBox()
        Me.cboMajor = New System.Windows.Forms.ComboBox()
        Me.grpResidence = New System.Windows.Forms.GroupBox()
        Me.radOnCampus = New System.Windows.Forms.RadioButton()
        Me.radOffCampus = New System.Windows.Forms.RadioButton()
        Me.btnCalculateCosts = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.lblCosts = New System.Windows.Forms.Label()
        Me.grpHousingBoard = New System.Windows.Forms.GroupBox()
        Me.radJulianSuites = New System.Windows.Forms.RadioButton()
        Me.radCraigHall = New System.Windows.Forms.RadioButton()
        Me.radCooperDorm = New System.Windows.Forms.RadioButton()
        Me.txtStudentID = New System.Windows.Forms.MaskedTextBox()
        CType(Me.picCollege, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResidence.SuspendLayout()
        Me.grpHousingBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCollege
        '
        Me.picCollege.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCollege.Image = Global.CollegeRegistration.My.Resources.Resources.college
        Me.picCollege.Location = New System.Drawing.Point(-1, -1)
        Me.picCollege.Name = "picCollege"
        Me.picCollege.Size = New System.Drawing.Size(176, 113)
        Me.picCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCollege.TabIndex = 0
        Me.picCollege.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(231, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(341, 78)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Register for Classes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Bedford College"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblStudentID.Location = New System.Drawing.Point(18, 153)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(109, 23)
        Me.lblStudentID.TabIndex = 2
        Me.lblStudentID.Text = "Student ID:"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblStudentName.Location = New System.Drawing.Point(18, 184)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(138, 23)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name:"
        '
        'lblNumberOfUnits
        '
        Me.lblNumberOfUnits.AutoSize = True
        Me.lblNumberOfUnits.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfUnits.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNumberOfUnits.Location = New System.Drawing.Point(18, 215)
        Me.lblNumberOfUnits.Name = "lblNumberOfUnits"
        Me.lblNumberOfUnits.Size = New System.Drawing.Size(157, 23)
        Me.lblNumberOfUnits.TabIndex = 4
        Me.lblNumberOfUnits.Text = "Number Of Units:"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMajor.Location = New System.Drawing.Point(335, 276)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(64, 23)
        Me.lblMajor.TabIndex = 5
        Me.lblMajor.Text = "Major:"
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtStudentName.Location = New System.Drawing.Point(210, 179)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(296, 30)
        Me.txtStudentName.TabIndex = 7
        '
        'txtNumberOfUnits
        '
        Me.txtNumberOfUnits.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfUnits.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumberOfUnits.Location = New System.Drawing.Point(210, 217)
        Me.txtNumberOfUnits.Name = "txtNumberOfUnits"
        Me.txtNumberOfUnits.Size = New System.Drawing.Size(49, 30)
        Me.txtNumberOfUnits.TabIndex = 8
        '
        'cboMajor
        '
        Me.cboMajor.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMajor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMajor.FormattingEnabled = True
        Me.cboMajor.Items.AddRange(New Object() {"Biology", "Business", "Chemistry", "Computer Science", "Fine Arts", "Mathematics", "Physics", "Sociology", "Theology"})
        Me.cboMajor.Location = New System.Drawing.Point(411, 268)
        Me.cboMajor.Name = "cboMajor"
        Me.cboMajor.Size = New System.Drawing.Size(179, 31)
        Me.cboMajor.TabIndex = 16
        '
        'grpResidence
        '
        Me.grpResidence.Controls.Add(Me.radOnCampus)
        Me.grpResidence.Controls.Add(Me.radOffCampus)
        Me.grpResidence.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResidence.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grpResidence.Location = New System.Drawing.Point(12, 276)
        Me.grpResidence.Name = "grpResidence"
        Me.grpResidence.Size = New System.Drawing.Size(142, 78)
        Me.grpResidence.TabIndex = 17
        Me.grpResidence.TabStop = False
        Me.grpResidence.Text = "Residence"
        '
        'radOnCampus
        '
        Me.radOnCampus.AutoSize = True
        Me.radOnCampus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOnCampus.Location = New System.Drawing.Point(6, 43)
        Me.radOnCampus.Name = "radOnCampus"
        Me.radOnCampus.Size = New System.Drawing.Size(126, 27)
        Me.radOnCampus.TabIndex = 1
        Me.radOnCampus.TabStop = True
        Me.radOnCampus.Text = "On-Campus"
        Me.radOnCampus.UseVisualStyleBackColor = True
        '
        'radOffCampus
        '
        Me.radOffCampus.AutoSize = True
        Me.radOffCampus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOffCampus.Location = New System.Drawing.Point(7, 20)
        Me.radOffCampus.Name = "radOffCampus"
        Me.radOffCampus.Size = New System.Drawing.Size(127, 27)
        Me.radOffCampus.TabIndex = 0
        Me.radOffCampus.TabStop = True
        Me.radOffCampus.Text = "Off-Campus"
        Me.radOffCampus.UseVisualStyleBackColor = True
        '
        'btnCalculateCosts
        '
        Me.btnCalculateCosts.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCalculateCosts.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCosts.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCalculateCosts.Location = New System.Drawing.Point(122, 430)
        Me.btnCalculateCosts.Name = "btnCalculateCosts"
        Me.btnCalculateCosts.Size = New System.Drawing.Size(154, 31)
        Me.btnCalculateCosts.TabIndex = 18
        Me.btnCalculateCosts.Text = "Calculate Costs"
        Me.btnCalculateCosts.UseVisualStyleBackColor = False
        '
        'btnClearForm
        '
        Me.btnClearForm.BackColor = System.Drawing.Color.PeachPuff
        Me.btnClearForm.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnClearForm.Location = New System.Drawing.Point(353, 430)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(127, 31)
        Me.btnClearForm.TabIndex = 19
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'lblCosts
        '
        Me.lblCosts.AutoSize = True
        Me.lblCosts.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosts.Location = New System.Drawing.Point(140, 506)
        Me.lblCosts.Name = "lblCosts"
        Me.lblCosts.Size = New System.Drawing.Size(340, 23)
        Me.lblCosts.TabIndex = 20
        Me.lblCosts.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblCosts.Visible = False
        '
        'grpHousingBoard
        '
        Me.grpHousingBoard.Controls.Add(Me.radJulianSuites)
        Me.grpHousingBoard.Controls.Add(Me.radCraigHall)
        Me.grpHousingBoard.Controls.Add(Me.radCooperDorm)
        Me.grpHousingBoard.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHousingBoard.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grpHousingBoard.Location = New System.Drawing.Point(161, 276)
        Me.grpHousingBoard.Name = "grpHousingBoard"
        Me.grpHousingBoard.Size = New System.Drawing.Size(149, 100)
        Me.grpHousingBoard.TabIndex = 21
        Me.grpHousingBoard.TabStop = False
        Me.grpHousingBoard.Text = "Housing/Board"
        Me.grpHousingBoard.Visible = False
        '
        'radJulianSuites
        '
        Me.radJulianSuites.AutoSize = True
        Me.radJulianSuites.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radJulianSuites.Location = New System.Drawing.Point(7, 67)
        Me.radJulianSuites.Name = "radJulianSuites"
        Me.radJulianSuites.Size = New System.Drawing.Size(132, 27)
        Me.radJulianSuites.TabIndex = 2
        Me.radJulianSuites.TabStop = True
        Me.radJulianSuites.Text = "Julian Suites"
        Me.radJulianSuites.UseVisualStyleBackColor = True
        '
        'radCraigHall
        '
        Me.radCraigHall.AutoSize = True
        Me.radCraigHall.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCraigHall.Location = New System.Drawing.Point(7, 43)
        Me.radCraigHall.Name = "radCraigHall"
        Me.radCraigHall.Size = New System.Drawing.Size(108, 27)
        Me.radCraigHall.TabIndex = 1
        Me.radCraigHall.TabStop = True
        Me.radCraigHall.Text = "Craig Hall"
        Me.radCraigHall.UseVisualStyleBackColor = True
        '
        'radCooperDorm
        '
        Me.radCooperDorm.AutoSize = True
        Me.radCooperDorm.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCooperDorm.Location = New System.Drawing.Point(7, 20)
        Me.radCooperDorm.Name = "radCooperDorm"
        Me.radCooperDorm.Size = New System.Drawing.Size(139, 27)
        Me.radCooperDorm.TabIndex = 0
        Me.radCooperDorm.TabStop = True
        Me.radCooperDorm.Text = "Cooper Dorm"
        Me.radCooperDorm.UseVisualStyleBackColor = True
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtStudentID.Location = New System.Drawing.Point(210, 143)
        Me.txtStudentID.Mask = "000-00-0000"
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(120, 30)
        Me.txtStudentID.TabIndex = 22
        '
        'frmCollege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(602, 562)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.grpHousingBoard)
        Me.Controls.Add(Me.lblCosts)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalculateCosts)
        Me.Controls.Add(Me.grpResidence)
        Me.Controls.Add(Me.cboMajor)
        Me.Controls.Add(Me.txtNumberOfUnits)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.lblNumberOfUnits)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picCollege)
        Me.Name = "frmCollege"
        Me.Text = "College Registration Costs"
        CType(Me.picCollege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResidence.ResumeLayout(False)
        Me.grpResidence.PerformLayout()
        Me.grpHousingBoard.ResumeLayout(False)
        Me.grpHousingBoard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCollege As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblNumberOfUnits As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtNumberOfUnits As TextBox
    Friend WithEvents cboMajor As ComboBox
    Friend WithEvents grpResidence As GroupBox
    Friend WithEvents radOnCampus As RadioButton
    Friend WithEvents radOffCampus As RadioButton
    Friend WithEvents btnCalculateCosts As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents lblCosts As Label
    Friend WithEvents grpHousingBoard As GroupBox
    Friend WithEvents radJulianSuites As RadioButton
    Friend WithEvents radCraigHall As RadioButton
    Friend WithEvents radCooperDorm As RadioButton
    Friend WithEvents txtStudentID As MaskedTextBox
End Class
