Public Class TempConverter
    Private Sub radCelsius_CheckedChanged(sender As Object, e As EventArgs) Handles radCelsius.CheckedChanged

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Dim decTemp As Decimal
        Dim decCelsius As Decimal
        Dim decFahrenheit As Decimal
        Dim decConverter As Decimal
        Dim strAnswer As String

        'If IsNumeric(txtTemp.Text) Then

        'If 

        'End If
        'End If

        If IsNumeric(txtTemp.Text) Then
            decCelsius = Convert.ToDecimal(txtTemp.Text)
            If decCelsius > -273 Then
                If radFahrenheit.Checked Then
                    'decFahrenheit = (9 / 5 * decCelsius) + 32
                    decConverter = decCelsius
                End If
                decFahrenheit = (9 / 5 * decConverter) + 32
                lblResult.Text = decFahrenheit.ToString("C")
                'strAnswer = Convert.ToString(decFahrenheit)
                'lblResult.Text = strAnswer + " degrees"
            End If
            If IsNumeric(txtTemp.Text) Then
                decFahrenheit = Convert.ToDecimal(txtTemp.Text)
                If decCelsius > -459.4 Then
                    If radCelsius.Checked Then
                        'decFahrenheit = (9 / 5 * decCelsius) + 32
                        decConverter = decCelsius
                    End If
                    decCelsius = (decConverter - 32) * (5 / 9)
                    lblResult.Text = decCelsius.ToString("D")
                End If
            End If
        End If
    End Sub
End Class
