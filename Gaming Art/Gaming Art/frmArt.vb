'Title:     Gaming Art Windows Application
'Author:    Trevon Harris
'Date:      April 13, 2020

Public Class frmArt
    Private Sub ArtistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArtDataSet)

    End Sub

    Private Sub frmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ArtDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.ArtDataSet.Artist)

    End Sub

    Private Sub Art_IDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Artist_NameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Artist_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Artist_NameTextBox.TextChanged

    End Sub

    Private Sub Art_TitleLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Art_TitleTextBox_TextChanged(sender As Object, e As EventArgs) Handles Art_TitleTextBox.TextChanged

    End Sub

    Private Sub Retail_PriceLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        'strSql is a SQL statement that selects all the fields from the 
        'Artist table

        Dim strSql As String = "SELECT * FROM Artist"

        'strPath provides the database type and path of the Art database 
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source =C:\Art.accdb"
        Dim odaArtist As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim decTotalValue As Decimal = 0D

        ' The dataTable name datValue is filled with the table data
        odaArtist.Fill(datValue)
        'The connection to the database is disconnected
        odaArtist.Dispose()
        For intCount = 0 To datValue.Rows.Count - 1
            decTotalValue += Convert.ToDecimal(datValue.Rows(intCount)("Retail Price"))
        Next
        lblTotalRetailValue.Visible = True
        lblTotalRetailValue.Text = "The Total Retail Value is " & decTotalValue.ToString("C")
    End Sub
End Class
