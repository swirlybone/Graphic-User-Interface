Public Class frmSort
    Public Shared _intSizeOfArray As Integer = 9
    Public Shared _strGameList(_intSizeOfArray) As String
    'Public Shared top_game(_intSizeOfArray) As String
    'Dim top_game(10, 3) As String
    'Private top_game(20, 1)
    'Private top_game(_intSizeOfArray) As String
    'Dim total_amount As Double = 0
    'Private total_amount(_intSizeOfArray) As Integer
    Private _intDownloads(_intSizeOfArray) As Integer
    Private _intLifeOfItems As Integer = 5
    Private Sub frmSort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFile As String = "C:\mobile.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Restart when the file is available."
        Dim TextLine As String = ""
        If IO.File.Exists(strFile) = True Then
            objReader = IO.File.OpenText(strFile)
            Do While objReader.Peek() <> -1
                'TextLine = TextLine & objReader.ReadLine()
                '_strInventoryItem(intCount) = objReader.ReadLine()
                '_strItemId(intCount) = objReader.ReadLine()
                '_decInitialPrice(intCount) = Convert.ToDecimal(objReader.ReadLine())
                '_intQuantity(intCount) = Convert.ToInt32(objReader.ReadLine())
                'top_game(intCount) = objReader.ReadLine()
                _strGameList(intCount) = objReader.ReadLine()
                _intDownloads(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()

            'The list object is filled with the game downloads
            For intFill = 0 To (_strGameList.Length - 1)
                lstGame.Items.Add(_strGameList(intFill))
            Next
            'Dim top() As String = TextLine.Split(",")
            'Dim j As Integer = 0
            'For i As Integer = 0 To top.Length - 1
            'If (i Mod 3 = 0) Then
            'top_game(j, 0) = top(i)
            'ElseIf (i Mod 3 = 1) Then
            'top_game(j, 1) = top(i)
            'ElseIf (i Mod 3 = 2) Then
            'top_game(j, 2) = top(i)
            'j = j + 1
            'End If
            'Next
            'For i As Integer = 0 To 9
            'lstGame.Items.Add(top_game(i, 0))
            'total_amount += Convert.ToDouble(top_game(i, 2))
            'Next
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub lstGame_Click(sender As Object, e As EventArgs) Handles lstGame.Click
        'MsgBox("Total Download is ::" + top_game(lstGame.SelectedIndex, 1) + vbNewLine + "Total Amount is:: " +
        'CStr(total_amount))




    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        frmSorted.Show()
        Me.Hide()
    End Sub

    Private Sub lstGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGame.SelectedIndexChanged

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs)
        Dim intSelectedGame As Integer
        Dim strSelectedGame As String
        Dim strGame As String

        'lblInfo.Text = "The Game selected is " & _strGameList()

    End Sub

    Private Sub btnDownloads_Click(sender As Object, e As EventArgs) Handles btnDownloads.Click
        'The btnCalculateDepreciation click event calsl the depreciation Sub procedures
        'Declare variables
        Dim intSelectedItemId As Integer
        Dim strMissingSelection As String = "Missing Selection"
        Dim strSelectInventoryItemIDError As String = "Select Game Title"

        'If the ListBox and the Depreciation RadioButton object are selected, 
        'call the depreciation procedures
        If lstGame.SelectedIndex >= 0 Then
            intSelectedItemId = lstGame.SelectedIndex
            If radDownloads.Checked Then
                Downloads(intSelectedItemId)
            ElseIf radTotal.Checked Then
                Total(intSelectedItemId)
            Else
                MsgBox(strMissingSelection)
            End If
        Else
            MsgBox(strSelectInventoryItemIDError, , strMissingSelection)
        End If
    End Sub

    Private Sub Downloads(ByVal intItemId As Integer)
        'Dim intDownloads As Integer
        Dim strDownloads = "The number of downloads are "

        MakeObjectsVisible()
        lblInfo.Text = strDownloads & _intDownloads(intItemId)


    End Sub

    Private Sub Total(ByVal intItemId As Integer)
        Dim intDownloads As Integer
        Dim strDownloads = "The total number of downloads are "
        Dim counter As Integer = 1

        'Dim sum As Long = (From item In fileContents Select CLng(item)).Sum
        'MsgBox(sum)


        'Do While counter < 10
        'intDownloads = _intDownloads(intItemId) + _intDownloads(intItemId)
        'counter = counter + 1
        'Loop

        '_intDownloads(intItemId) += _intDownloads(intItemId)

        'intDownloads = _intDownloads(intItemId)
        'intDownloads = total
        'Number should be 109770

        Dim intItem As Integer
        Dim intItem2 As Integer
        Dim intItem3 As Integer
        Dim intItem4 As Integer
        Dim intItem5 As Integer
        Dim intItem6 As Integer
        Dim intItem7 As Integer
        Dim intItem8 As Integer
        Dim intItem9 As Integer
        Dim intItem10 As Integer


        'Sorts the _strInventory array
        'Array.Sort(frmSort._strGameList)

        'Displays the _strInventoryItem array
        For Each strItem In _intDownloads
            intItem = _intDownloads(0) + _intDownloads(2) + _intDownloads(3) + _intDownloads(4) +
             _intDownloads(5) + _intDownloads(6) + _intDownloads(7) + _intDownloads(8) + _intDownloads(9) +
            _intDownloads(1)
        Next

        intDownloads = intItem
        MakeObjectsVisible()


        lblInfo.Text = strDownloads & intDownloads


    End Sub

    Private Sub MakeObjectsVisible()
        lblInfo.Visible = True
    End Sub



    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        lblInfo.Visible = False
    End Sub

    Private Sub ExitB_Click(sender As Object, e As EventArgs) Handles ExitB.Click
        Application.Exit()
    End Sub
End Class
