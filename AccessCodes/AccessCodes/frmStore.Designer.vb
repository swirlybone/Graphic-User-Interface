<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStore
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
        Me.lstCodes = New System.Windows.Forms.ListBox()
        Me.txtCreditCard = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCreditCard = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblExpireDate = New System.Windows.Forms.Label()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.rdStudent = New System.Windows.Forms.RadioButton()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtHidden = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstCodes
        '
        Me.lstCodes.FormattingEnabled = True
        Me.lstCodes.Location = New System.Drawing.Point(357, 91)
        Me.lstCodes.Name = "lstCodes"
        Me.lstCodes.Size = New System.Drawing.Size(120, 95)
        Me.lstCodes.TabIndex = 0
        '
        'txtCreditCard
        '
        Me.txtCreditCard.Location = New System.Drawing.Point(367, 222)
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.Size = New System.Drawing.Size(165, 20)
        Me.txtCreditCard.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(391, 403)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 2
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(377, 263)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtMonth.TabIndex = 3
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(547, 263)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(321, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(170, 13)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Select The Software Access Code"
        '
        'lblCreditCard
        '
        Me.lblCreditCard.AutoSize = True
        Me.lblCreditCard.Location = New System.Drawing.Point(252, 222)
        Me.lblCreditCard.Name = "lblCreditCard"
        Me.lblCreditCard.Size = New System.Drawing.Size(102, 13)
        Me.lblCreditCard.TabIndex = 6
        Me.lblCreditCard.Text = "Credit Card Number:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(331, 270)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 7
        Me.lblMonth.Text = "Month:"
        '
        'lblExpireDate
        '
        Me.lblExpireDate.AutoSize = True
        Me.lblExpireDate.Location = New System.Drawing.Point(252, 270)
        Me.lblExpireDate.Name = "lblExpireDate"
        Me.lblExpireDate.Size = New System.Drawing.Size(65, 13)
        Me.lblExpireDate.TabIndex = 8
        Me.lblExpireDate.Text = "Expire Date:"
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Location = New System.Drawing.Point(331, 335)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(50, 13)
        Me.lblStudent.TabIndex = 9
        Me.lblStudent.Text = "Student?"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(500, 270)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 10
        Me.lblYear.Text = "Year:"
        '
        'rdStudent
        '
        Me.rdStudent.AutoSize = True
        Me.rdStudent.Location = New System.Drawing.Point(405, 331)
        Me.rdStudent.Name = "rdStudent"
        Me.rdStudent.Size = New System.Drawing.Size(62, 17)
        Me.rdStudent.TabIndex = 11
        Me.rdStudent.TabStop = True
        Me.rdStudent.Text = "Student"
        Me.rdStudent.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(306, 363)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 23)
        Me.btnTotal.TabIndex = 13
        Me.btnTotal.Text = "Find Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(402, 363)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(310, 406)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(61, 13)
        Me.lblPrice.TabIndex = 15
        Me.lblPrice.Text = "Total Price:"
        '
        'txtHidden
        '
        Me.txtHidden.Location = New System.Drawing.Point(651, 143)
        Me.txtHidden.Name = "txtHidden"
        Me.txtHidden.Size = New System.Drawing.Size(100, 20)
        Me.txtHidden.TabIndex = 16
        Me.txtHidden.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(528, 140)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save Receipt"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(579, 102)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(188, 13)
        Me.lblInfo.TabIndex = 18
        Me.lblInfo.Text = "Enter Software Name and Price Below"
        Me.lblInfo.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(503, 363)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtHidden)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.rdStudent)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.lblExpireDate)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblCreditCard)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtCreditCard)
        Me.Controls.Add(Me.lstCodes)
        Me.Name = "frmStore"
        Me.Text = "College Book Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCodes As ListBox
    Friend WithEvents txtCreditCard As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCreditCard As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblExpireDate As Label
    Friend WithEvents lblStudent As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents rdStudent As RadioButton
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtHidden As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnClose As Button
End Class
