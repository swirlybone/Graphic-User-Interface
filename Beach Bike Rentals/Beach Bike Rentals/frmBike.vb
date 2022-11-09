'Program: Beach Bike Rentals
'Author: Trevon Harris
'Date: Feb 9, 2020
'Purpose: This application calculates and displays the total
'cost of renting a bike for a specified number of days.

Option Strict On
Public Class frmBike
    ' Cost per bike rental used in multiple procedures
    Const _cdecPricePerDay As Decimal = 9.95D
    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        'This event handler is executed when the user clicks the 
        'Find Cost button. It calculates and displays the cost
        'of the bike rented (number of days times the cost per bike).

        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecPricePerDay
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the form is loaded.
        'It displays the cost heading, clears the Text property of the 
        'Total Cost label, and sets the focus onm
        'The txtNumberOfDays textbox object

        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the window and terminate the application
        Close()
    End Sub

    Private Sub picBikes_Click(sender As Object, e As EventArgs) Handles picBikes.Click

    End Sub

    Private Sub frmBike_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the form is loaded.
        'It displays the cost heading, clears the text property of the 
        'Total cost label, and sets the focus on
        'the txtNumberOfDays textbox object.

        lblCostHeading.Text = _cdecPricePerDay.ToString("C") & " per Day"
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub
End Class
