    Private Sub ThisWorkbook_Open() Handles Me.Open
        Dim inputForm As New GetInputString()
        inputForm.ShowDialog()
    End Sub