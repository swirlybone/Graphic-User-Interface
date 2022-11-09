Imports System.IO
Public Class frmEmployees
    'Public Shared _intSizeOfArray As Integer = 54
    'Public Shared _name(_intSizeOfArray) As String
    'Public Shared _position(_intSizeOfArray) As String
    'Public Shared _location(_intSizeOfArray) As String
    'Public Shared _phoneNumber(_intSizeOfArray) As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim frmHome As New frmHome
        Hide()
        frmHome.ShowDialog()
    End Sub

    Private Sub frmShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim line As String
        For Each line In File.ReadAllLines("C:\PhoneDirectoryManagementSystem\PhoneDirectoryManagementSystem\phone_turner_college.txt")
            Dim i As Integer = 0
            Dim parts As String() = line.Split(New Char() {";"c})

            Dim part As String
            For Each part In parts
                lstName.Items.Add(part)
            Next
            i += 1
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim line As String
        If (txtSearch.Text = "") Then
            MsgBox("Enter Department to search.")
        Else
            For Each line In File.ReadAllLines("C:\PhoneDirectoryManagementSystem\PhoneDirectoryManagementSystem\phone_turner_college.txt")
                Dim strline As String() = line.Split(New Char() {";"c})

                Dim str As String

                If line.Contains(txtSearch.Text) = True Then
                    lstSearch.Items.Add(line)
                End If
            Next
        End If
    End Sub

    Private Function FileContainingString(path As String, match As String) As Boolean
        Dim s As String = File.ReadAllText(path)
        Return s.Contains(match)
    End Function


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSearch.Items.Clear()
    End Sub
End Class