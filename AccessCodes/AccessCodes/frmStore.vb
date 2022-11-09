Public Class frmStore
    Dim visio As String = "Visio $14.99"
    Dim quickbooks As String = "QuickBooks $24.99"
    Dim projects As String = "Projects $17.99"
    Dim powerbi As String = "Power Bi $9.99"
    Dim speedtype As String = "Speed Type $29.99"
    Dim Codeprice() As Decimal = {14.99, 24.99, 17.99, 9.99, 29.99}
    Dim Discounts() As Decimal = {0.06, 0.08, 0.08, 0.05, 0.02}
    Dim selectedItem As Integer
    Dim creditcardNum As String
    Dim month As Integer
    Dim year As Integer
    Dim disc As Decimal
    Dim totalPrice As Decimal

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        If (lstCodes.SelectedIndex < 0) Then
            MessageBox.Show("Please select a Software")
        ElseIf (txtCreditCard.Text = "" Or txtMonth.Text = "" Or txtYear.Text = "") Then
            MessageBox.Show("Please provide all necessary information")
        Else
            disc = 0.0
            selectedItem = lstCodes.SelectedIndex
            creditcardNum = txtCreditCard.Text
            'If (VerifyCreditCard(creditcardNum) = True) Then
            If (creditcardNum > 1000000000000) Then
                Try
                    month = Convert.ToInt16(txtMonth.Text)
                    year = Convert.ToInt16(txtYear.Text)
                    If (rdStudent.Checked) Then
                        disc = Discounts(selectedItem) * Codeprice(selectedItem)
                    End If
                    totalPrice = Codeprice(selectedItem) - disc
                    txtPrice.Text = totalPrice.ToString("C")
                Catch ex As Exception
                    MessageBox.Show("Please Enter Valid Expiration Date")
                End Try
            Else
                MessageBox.Show("Invalid, please enter a credit card number that's 13 or more characters long.")
            End If
        End If
        txtHidden.Visible = True
        btnSave.Visible = True
        lblInfo.Visible = True
    End Sub
    Function VerifyCreditCard(ByVal cardNumber As String) As Boolean
        'When given a card number, this functions checks that it is valid using Luhn algorithm to verify the number. 
        'This routine assumes that the cardNumber only contains numbers
        Dim counter As Integer
        Dim holdValue As Integer
        Dim digitTotal As Integer
        Dim checkDigit As Integer
        Dim calcDigit As Integer
        Dim useCard As String
        'Does some initial checks
        useCard = Trim(cardNumber)
        If (IsNumeric(useCard) = False) Then Return False

        If ((Len(useCard) Mod 2) <> 0) Then useCard = "0" & useCard
        checkDigit = useCard.Substring(Len(useCard) - 1, 1)
        useCard = useCard.Substring(0, Len(useCard) - 1)

        digitTotal = 0
        For counter = 1 To Len(useCard)
            If ((counter Mod 2) = 1) Then
                holdValue = CInt(Mid(useCard, counter, 1)) * 2
                If (holdValue > 9) Then
                    digitTotal += (holdValue = 10) + (holdValue - 10)
                Else
                    digitTotal += holdValue
                End If
            Else
                digitTotal += CInt(Mid(useCard, counter, 1))
            End If
        Next counter
        calcDigit = 10 - (digitTotal Mod 10)
        If (calcDigit = 10) Then calcDigit = 0
        If (checkDigit = calcDigit) Then Return True Else Return False
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'My.Computer.FileSystem.WriteAllText("C:\AccessCodes\AccessCodes\record.txt", "" & txtCreditCard.Text, lstCodes.SelectedIndex)
        txtCreditCard.Clear()
        txtPrice.Clear()
        txtMonth.Clear()
        txtYear.Clear()
        rdStudent.Checked = False
        lstCodes.Refresh()
        txtHidden.Visible = False
        btnSave.Visible = False
        lblInfo.Visible = False
    End Sub

    Private Sub frmStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCodes.Items.Add(visio)
        lstCodes.Items.Add(quickbooks)
        lstCodes.Items.Add(projects)
        lstCodes.Items.Add(powerbi)
        lstCodes.Items.Add(speedtype)


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Computer.FileSystem.WriteAllText("C:\AccessCodes\AccessCodes\record.txt", "," & txtCreditCard.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\AccessCodes\AccessCodes\record.txt", "," & txtHidden.Text, True)
        txtHidden.Visible = False
        btnSave.Visible = False
        lblInfo.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
