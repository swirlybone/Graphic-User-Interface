'Imports System.IO
Option Strict On
Public Class frmSorted
    Private Sub frmSorted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lstSort.Items.Clear()
        'For i As Integer = 0 To frmSort.lstGame.Items.Count - 1
        'lstSort.Items.Add(frmSort.lstGame.Items(i))
        ' Next
        'lstSort.Sorted = True
        'lstSort.Items.Remove("")

        'The frmDisplayInventory load event Is a second forms that 
        'displays the sorted inventory items
        Dim strItem As String

        'Sorts the _strInventory array
        Array.Sort(frmSort._strGameList)

        'Displays the _strInventoryItem array
        For Each strItem In frmSort._strGameList
            lstSort.Items.Add(strItem)
        Next
    End Sub

    Private Sub lstSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSort.SelectedIndexChanged

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'This Sub procedure opens the first form
        Dim frmFirst As New frmSort

        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class