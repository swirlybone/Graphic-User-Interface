Public Class frmAdd
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim frmHome As New frmHome
        Hide()
        frmHome.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim decNumber As Decimal
        My.Computer.FileSystem.WriteAllText("C:\PhoneDirectoryManagementSystem\PhoneDirectoryManagementSystem\phone_turner_college.txt", Environment.NewLine & txtName.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\PhoneDirectoryManagementSystem\PhoneDirectoryManagementSystem\phone_turner_college.txt", ";" & txtPosition.Text, True)
        My.Computer.FileSystem.WriteAllText("C:\PhoneDirectoryManagementSystem\PhoneDirectoryManagementSystem\phone_turner_college.txt", ";" & txtLocation.Text, True)
        If IsNumeric(txtNumber.Text) Then
            decNumber = Convert.ToDecimal(txtNumber.Text)
            My.Computer.FileSystem.WriteAllText("C:\PhoneDirectoryManagementSystem\PhoneDirectoryManagementSystem\phone_turner_college.txt", ";" & txtNumber.Text, True)
        Else
            MsgBox("Enter numbers only.")
        End If
        If IsNumeric(txtNumber2.Text) Then
            decNumber = Convert.ToDecimal(txtNumber2.Text)
            My.Computer.FileSystem.WriteAllText("C:\PhoneDirectoryManagementSystem\PhoneDirectoryManagementSystem\phone_turner_college.txt", "-" & txtNumber2.Text, True)
        Else
            MsgBox("Enter numbers only.")
        End If

        MsgBox("Employee Has Been Added!")
        txtName.Clear()
        txtLocation.Clear()
        txtPosition.Clear()
        txtNumber.Clear()
        txtNumber2.Clear()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

End Class