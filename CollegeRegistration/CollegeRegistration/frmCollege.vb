﻿'Program:   College Regreistration Costs
'Developer: Trevon Harris
'Date:      April 20, 2020

Option Strict On

Public Class frmCollege
    Private Sub btnCalculateCosts_Click(sender As Object, e As EventArgs) Handles btnCalculateCosts.Click
        'This calculate costs button click event handler edits the regristration(costs) form to ensure it contains valid data
        'Then, after passing control to the business class, it displays the cost.

        Dim objStudent As Student
        Dim objOnCampusStudent As OnCampusStudent
        Dim InputError As Boolean = False

        'Is student ID entered properly
        If txtStudentID.MaskFull = False Then
            MsgBox("Enter your Student ID in the Student ID box", , "Error")
            txtStudentID.Clear()
            txtStudentID.Focus()
            InputError = True
            'Is student name entered properly
        ElseIf txtStudentName.TextLength < 1 Or txtStudentName.Text < "A" Then
            MsgBox("Enter your name in the Student Name box", , "Error")
            txtStudentName.Clear()
            txtStudentName.Focus()
            InputError = True
            'Is number of units entered properly
        ElseIf Not IsNumeric(txtNumberOfUnits.Text) Then
            MsgBox("Enter the units in the Number of Units box", , "Error")
            txtNumberOfUnits.Clear()
            txtNumberOfUnits.Focus()
            InputError = True
            'Has 1-24 units been entered
        ElseIf Convert.ToInt32(txtNumberOfUnits.Text) < 1 Or Convert.ToInt32(txtNumberOfUnits.Text) > 24 Then
            MsgBox("Units must be 1-24", , "Error")
            txtNumberOfUnits.Clear()
            txtNumberOfUnits.Focus()
            InputError = True
            'Has a major been selected
        ElseIf cboMajor.SelectedIndex < 0 Then
            MsgBox("Please select a major", , "Error")
            cboMajor.Focus()
            InputError = True
        End If
        'If no input error, process the registration costs
        If Not InputError Then
            If radOffCampus.Checked Then
                objStudent = New Student(txtStudentID.Text, txtStudentName.Text, Convert.ToString(cboMajor.SelectedItem),
                txtNumberOfUnits.Text)
                lblCosts.Visible = True
                lblCosts.Text = "Total semester costs are: " & (objStudent.ComputeCosts()).ToString("C2")
            Else
                objOnCampusStudent = New OnCampusStudent(txtStudentID.Text, txtStudentName.Text, Convert.ToString(cboMajor.SelectedItem),
                txtNumberOfUnits.Text, radCooperDorm.Checked, radCraigHall.Checked, radJulianSuites.Checked)
                lblCosts.Visible = True
                lblCosts.Text = "Total semester costs are: " & (objOnCampusStudent.ComputeCosts()).ToString("C2")
            End If
        End If
    End Sub

    Private Sub radOffCampus_CheckedChanged(sender As Object, e As EventArgs) Handles radOffCampus.CheckedChanged
        'This event handler is executed when the off campus radio is selected. It hides the housing/board radio buttons
        grpHousingBoard.Visible = False

    End Sub

    Private Sub radOnCampus_CheckedChanged(sender As Object, e As EventArgs) Handles radOnCampus.CheckedChanged
        'This event handler is executed when on campus radio button is selected

        grpHousingBoard.Visible = True

    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        txtStudentID.Clear()
        txtStudentName.Clear()
        txtNumberOfUnits.Clear()
        cboMajor.SelectedIndex = -1
        cboMajor.Text = "Select a Major"
        radOffCampus.Checked = True
        radCooperDorm.Checked = True
        grpHousingBoard.Visible = False
        lblCosts.Visible = False
        txtStudentID.Focus()
    End Sub


End Class
