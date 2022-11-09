﻿'Program Name: Chef Shack Food Truck Depreciation Windows Application
'Name:          Trevon Harris
'Date:          April 6, 2020

Option Strict On
Public Class frmDepreciation
    'Class Level Private variables
    Private _intLifeOfItems As Integer = 5
    Public Shared _intSizeOfArray As Integer = 7
    Public Shared _strInventoryItem(_intSizeOfArray) As String
    Private _strItemId(_intSizeOfArray) As String
    Private _decInitialPrice(_intSizeOfArray) As Decimal
    Private _intQuantity(_intSizeOfArray) As Integer

    Private Sub frmDepreciation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Initialize an instance of the streamreader object and declare variables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "C:\Users\MemeTrey\Desktop\2019-20\GUI\Depreciation\Inventory.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Restart when the file is available."

        'Verify the file exists
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            'Read the file line by line until file is completed
            Do While objReader.Peek <> -1
                _strInventoryItem(intCount) = objReader.ReadLine()
                _strItemId(intCount) = objReader.ReadLine()
                _decInitialPrice(intCount) = Convert.ToDecimal(objReader.ReadLine())
                _intQuantity(intCount) = Convert.ToInt32(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()

            'The list object is filled with the invetory IDs
            For intFill = 0 To (_strItemId.Length - 1)
                lstInventoryId.Items.Add(_strItemId(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub btnCalculateDepreciation_Click(sender As Object, e As EventArgs) Handles btnCalculateDepreciation.Click
        'The btnCalculateDepreciation click event calsl the depreciation Sub procedures
        'Declare variables
        Dim intSelectedItemId As Integer
        Dim strMissingSelection As String = "Missing Selection"
        Dim strSelectDepreciationError As String = "Select a Depreciation Method"
        Dim strSelectInventoryItemIDError As String = "Select an Inventory Item ID"

        'If the ListBox and the Depreciation RadioButton object are selected, 
        'call the depreciation procedures
        If lstInventoryId.SelectedIndex >= 0 Then
            intSelectedItemId = lstInventoryId.SelectedIndex
            If radStraightLine.Checked Then
                StraightLineDepreciation(intSelectedItemId)
            ElseIf radDoubleDeclining.Checked Then
                DoubleDecliningDepreciation(intSelectedItemId)
            Else
                MsgBox(strSelectDepreciationError, , strMissingSelection)
            End If
        Else
            MsgBox(strSelectInventoryItemIDError, , strMissingSelection)
        End If
    End Sub

    Private Sub StraightLineDepreciation(ByVal intItemId As Integer)
        'This sub procedure computes  and displays the straight line depreciation for the item selected
        'Declare variables
        Dim intStraightPresentYear As Integer
        Dim decStraightPresentYearValue As Decimal = 0
        Dim decStraightDepreciation As Decimal
        Dim decStraightTotal As Decimal
        Dim strDepreciationItem As String = "The depreciation of the item: "
        Dim strQuantityMessage As String = "Quantity: "

        'The procedure MakeObjectsVisible is called to display the Form objects
        MakeObjectsVisible()
        'Display the item and quantity of the selected item
        lblItem.Text = strDepreciationItem & _strInventoryItem(intItemId)
        lblQuantity.Text = strQuantityMessage & _intQuantity(intItemId).ToString()
        'The formula for straight-line depreciation
        decStraightDepreciation = _decInitialPrice(intItemId) / _intLifeOfItems
        decStraightPresentYearValue = _decInitialPrice(intItemId)

        'The loop repeats for the life of the items
        For intStraightPresentYear = 1 To _intLifeOfItems
            'Accumulates the total of depreciation
            decStraightTotal += decStraightDepreciation
            'Displays the edepreciation amounts
            lstYear.Items.Add(intStraightPresentYear.ToString())
            lstPresentValue.Items.Add(decStraightPresentYearValue.ToString("C"))
            lstYearDepreciation.Items.Add(decStraightDepreciation.ToString("C"))
            lstTotalDepreciation.Items.Add(decStraightTotal.ToString("C"))
            decStraightPresentYearValue -= decStraightDepreciation
        Next
    End Sub

    Private Sub DoubleDecliningDepreciation(ByVal intItemId As Integer)
        'This sub procedure computes  and displays the double declining line depreciation for the item selected
        'Declare variables
        Dim intDoublePresentYear As Integer
        Dim decDoublePresentYearValue As Decimal = 0
        Dim decDoubleDepreciation As Decimal
        Dim decDoubleTotal As Decimal

        'The procedure MakeObjectsVisible is called to display the Form objects
        MakeObjectsVisible()
        'Display the item and quantity of the selected item
        lblItem.Text = "The depreciation of the item: " & _strInventoryItem(intItemId)
        lblQuantity.Text = "Quantity: " & _intQuantity(intItemId).ToString()
        decDoublePresentYearValue = _decInitialPrice(intItemId)

        'The loop repeats for the life of the items
        For intDoublePresentYear = 1 To _intLifeOfItems
            'The formula for double-declining depreciation inside the loop to repeat the process
            decDoubleDepreciation = (decDoublePresentYearValue * 20) / _intLifeOfItems
            'Accumulates total of depreciation
            decDoubleTotal += decDoubleDepreciation
            'Displays the edepreciation amounts
            lstYear.Items.Add(intDoublePresentYear.ToString())
            lstPresentValue.Items.Add(decDoublePresentYearValue.ToString("C"))
            lstYearDepreciation.Items.Add(decDoubleDepreciation.ToString("C"))
            lstTotalDepreciation.Items.Add(decDoubleTotal.ToString("C"))
            decDoublePresentYearValue -= decDoubleDepreciation
        Next
    End Sub

    Private Sub MakeObjectsVisible()
        lblItem.Visible = True
        lblQuantity.Visible = True
        lblYear.Visible = True
        lstYear.Visible = True
        lblPresentValue.Visible = True
        lstPresentValue.Visible = True
        lblYearDepreciation.Visible = True
        lstYearDepreciation.Visible = True
        lblTotalDepreciation.Visible = True
        lstTotalDepreciation.Visible = True
        'Previous data is removed
        lstYear.Items.Clear()
        lstPresentValue.Items.Clear()
        lstYearDepreciation.Items.Clear()
        lstTotalDepreciation.Items.Clear()
    End Sub

    Private Sub mnuDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDisplay.Click
        'The mnuDisplay click event creates an instance of the frmDisplayInventory
        Dim frmSecond As New frmDisplayInventory

        'Hide this form and show the display inventory form
        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        'The mnuClear click event clears and resets the form
        lstInventoryId.SelectedIndex = -1
        radStraightLine.Checked = False
        radDoubleDeclining.Checked = False
        lblItem.Visible = False
        lblQuantity.Visible = False
        lblYear.Visible = False
        lstYear.Visible = False
        lstYear.Items.Clear()
        lblPresentValue.Visible = False
        lstPresentValue.Visible = False
        lstPresentValue.Items.Clear()
        lblYearDepreciation.Visible = False
        lstYearDepreciation.Visible = False
        lstYearDepreciation.Items.Clear()
        lblTotalDepreciation.Visible = False
        lstTotalDepreciation.Visible = False
        lstTotalDepreciation.Items.Clear()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        'The mnuExit click event closes the application
        Application.Exit()
    End Sub
End Class
