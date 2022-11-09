'The frmDisplayInventory class is opened by frmDepreciation
'and displays the inventory file in sorted order


Option Strict On
Public Class frmDisplayInventory
    Private Sub frmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The frmDisplayInventory load event is a second forms that 
        'displays the sorted inventory items
        Dim strItems As String

        'Sorts the _strInventory array
        Array.Sort(frmDepreciation._strInventoryItem)

        'Displays the _strInventoryItem array
        For Each strItems In frmDepreciation._strInventoryItem
            lstDisplay.Items.Add(strItems)
        Next
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'This Sub procedure opens the first form
        Dim frmFirst As New frmDepreciation

        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class