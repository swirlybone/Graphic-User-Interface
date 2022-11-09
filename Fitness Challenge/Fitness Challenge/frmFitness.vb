'Program Name: Fitness Challenge
'Author:   Trevon Harris
'Date:      Feb 24, 2020
'Purpose:   The Fitness Challenge program enters the weight loss 
'           loss from team members for a fitness challenge.

Option Strict On
Public Class frmFitness
    Private Sub btnWeightLoss_Click(sender As Object, e As EventArgs) Handles btnWeightLoss.Click
        Dim strWeightLoss As String
        Dim decWeightLoss As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalWeightLoss As Decimal = 0D
        Dim strInputMessage As String = "Enter the weight loss for team member #"
        Dim strInputHeading As String = "Weight Loss"
        Dim strInputNormalMessage As String = "Enter the weight for loss team member #"
        Dim strNormalMessage As String = "Enter the weight loss for team member #"

        Dim strNonNumericError As String = "Error - Enter the weight loss for team member  #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight loss of team member #"

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        'This loop allows the user to enter the weight loss of up to 8 members
        'The loop terminates when the user has entered 8 weight loss values or the user
        'clicks the cancel button or the close button in the inputbox
        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strWeightLoss = strCancelClicked
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)
                If decWeightLoss > 0 Then
                    lstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss += decWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strInputNormalMessage
                Else
                    strInputMessage = strNormalMessage
                End If
            Else
                strInputMessage = strNegativeError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        'Calculates and displays average team weight loss
        If intNumberOfEntries > 1 Then
            lblAverageLoss.Visible = True
            decAverageLoss = decTotalWeightLoss / (intNumberOfEntries - 1)
            lblAverageLoss.Text = "Average weight loss is " &
                decAverageLoss.ToString("F1") & " lbs"
        Else
            MsgBox("No weight loss value entered")
        End If

        'Disables the weight loss button
        btnWeightLoss.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'The mnuClear click event  clears the listbox object and hides 
        'the average weight loss label. It also enables the weight loss button

        lstWeightLoss.Items.Clear()
        lblAverageLoss.Visible = False
        btnWeightLoss.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'the menuexit click event closes the window

        Close()
    End Sub

    Private Sub frmFitness_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
