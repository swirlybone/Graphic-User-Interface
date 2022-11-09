Public Class frmTracker
    'Const _cdecHoursPerWeek As Decimal = 2.5D

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decHours As Integer = 2.5D
        Dim strFirstName As String
        strFirstName = txtFirst.Text
        Dim strLastName As String
        strLastName = txtLast.Text
        Dim strbirthMon As String
        strbirthMon = txtBirth.Text
        Dim strbirthDay As String
        strbirthDay = txtBirth2.Text
        Dim strbirthYear As String
        strbirthYear = txtBirth3.Text
        Dim strcurrentMon As String
        strcurrentMon = txtDate.Text
        Dim strcurrentDay As String
        strcurrentDay = txtDate2.Text
        Dim strcurrentYear As String
        strcurrentYear = txtDate3.Text
        Dim intbirthMon As Integer
        intbirthMon = Convert.ToInt32(strbirthMon)
        Dim intbirthDay As Integer
        intbirthDay = Convert.ToInt32(strbirthDay)
        Dim intbirthYear As Decimal
        intbirthYear = Convert.ToDecimal(strbirthYear)
        Dim intcurrentDay As Integer
        intcurrentDay = Convert.ToInt32(strcurrentDay)
        Dim intcurrentMonth As Integer
        intcurrentMonth = Convert.ToInt32(strcurrentMon)
        Dim intcurrentYear As Decimal
        intcurrentYear = Convert.ToDecimal(strcurrentYear)
        Dim decTotalHours As Integer
        Dim strTotal As String
        Dim strNonNumericError As String = "Error"
        Dim strNegativeError As String = "Error"


        decTotalHours = intcurrentYear + intbirthYear * decHours
        strTotal = Convert.ToString(decTotalHours)



        'lblOutput.Text = decTotalHours.ToString("C")
        lblOutput.Text = strFirstName + " " + strLastName + " 's total number of hours exercised is " + strTotal

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirst.Clear()
        txtLast.Clear()
        txtBirth.Clear()
        txtBirth2.Clear()
        txtBirth3.Clear()
        txtDate.Clear()
        txtDate2.Clear()
        txtDate3.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
