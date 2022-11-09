Public Class frmSales
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim moneyCount As Integer = Integer.Parse(txtInput.Text)
        If (moneyCount >= 50) Then
            Dim coinCount As Integer
            coinCount = Fix(moneyCount / 50)
            moneyCount = moneyCount Mod 50
            lstReturn.Items.Add(coinCount & " X $50 = " & (coinCount * 50))
        End If

        If (moneyCount >= 25) Then

            Dim coinCount As Integer
            coinCount = Fix(moneyCount / 25)
            moneyCount = moneyCount Mod 25
            lstReturn.Items.Add(coinCount & " X $25 = " & (coinCount * 25))
        End If

        If (moneyCount >= 10) Then
            Dim coinCount As Integer
            coinCount = Fix(moneyCount / 10)
            moneyCount = moneyCount Mod 10
            lstReturn.Items.Add(coinCount & " X $10 = " & (coinCount * 10))
        End If

        If (moneyCount >= 5) Then
            Dim coinCount As Integer
            coinCount = Fix(moneyCount / 5)
            moneyCount = moneyCount Mod 5
            lstReturn.Items.Add(coinCount & " X $5 = " & (coinCount * 5))
        End If

        If (moneyCount >= 1) Then
            lstReturn.Items.Add(moneyCount & " X $1 = " & moneyCount)
        End If

        'Dim decMoney As Decimal
        'Dim dollarCount As Integer
        'Dim fiveCount As Integer
        'Dim tenCount As Integer
        'Dim twentyCount As Integer
        'Dim fifteyCount As Integer
        'Dim hundredCount As Integer
        'Dim fivehunCount As Integer
        'Dim thousandCount As Integer
        'Dim fivethousandCount As Integer
        'Dim centCount As Integer
        'Dim fivecentCount As Integer
        'Dim tencentCount As Integer
        'Dim twentyfivecentCount As Integer
        'Dim fifteycentCount As Integer

        'If IsNumeric(txtInput.Text) Then
        '    If decMoney >= 5000 Then
        '        decMoney = decMoney - 5000
        '        fivethousandCount = fivethousandCount + 1
        '        If decMoney >= 1000 Then
        '            decMoney = decMoney - 1000
        '            thousandCount = thousandCount + 1
        '            If decMoney >= 500 Then
        '                decMoney = decMoney - 500
        '                fivehunCount = fivehunCount + 1
        '                If decMoney >= 100 Then
        '                    decMoney = decMoney - 1
        '                    hundredCount = hundredCount + 1
        '                    If decMoney >= 50 Then
        '                        decMoney = decMoney - 50
        '                        fifteyCount = fifteyCount + 1
        '                        If decMoney >= 20 Then
        '                            decMoney = decMoney - 20
        '                            twentyCount = twentyCount + 1
        '                            If decMoney >= 10 Then
        '                                decMoney = decMoney - 10
        '                                tenCount = tenCount + 1
        '                                If decMoney >= 5 Then
        '                                    decMoney = decMoney - 5
        '                                    fiveCount = fiveCount + 1
        '                                    If decMoney >= 1 Then
        '                                        decMoney = decMoney - 1
        '                                        dollarCount = dollarCount + 1
        '                                    End If
        '                                End If
        '                            End If
        '                        End If
        '                    End If
        '                End If
        '            End If
        '        End If
        '    End If
        '    fivethousandCount = fivethousandCount + 1
        '    'lstReturn.Items.Add(fivethousandCount)
        'End If
        'lstReturn.Items.Add(fivethousandCount)



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstReturn.Items.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
