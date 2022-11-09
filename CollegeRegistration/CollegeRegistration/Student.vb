'Class:     Student
'Developer: Trevon Harris
'Date:      April 20, 2020

Option Strict On
Public Class Student
    Protected _strStudentID As String
    Protected _strStudentName As String
    Protected _strMajor As String
    Protected _intUnits As Integer
    Protected _decCost As Decimal
    Protected _decCostPerUnit As Decimal = 450D

    Dim objStudentCostsFile As StudentCostsFile

    Sub New(ByVal strStudentID As String, ByVal strStudentName As String, ByVal strMajor As String, ByVal intUnits As String)
        'This subprocedure is a constructor the student class. it is called when the object is instatiated with arguments 

        'The following code assigns the arguments to class variables
        _strStudentID = strStudentID
        _strStudentName = strStudentName
        _strMajor = strMajor
        _intUnits = Convert.ToInt32(intUnits)

    End Sub

    Overridable Function ComputeCosts() As Decimal
        'This function computes the regristation costs, writes a record in the student costs file, and returns the registration cost
        'Calculate cost
        _decCost = _intUnits * _decCostPerUnit

        'Write the student record
        objStudentCostsFile = New StudentCostsFile(_strStudentID, _strStudentName, _strMajor, _decCost)
        objStudentCostsFile.WriteRecord()

        'Return the calculate cost
        Return _decCost
    End Function
End Class
