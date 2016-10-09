    Private Sub ListSheets()
        Dim index As Integer = 0

        Dim NamedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Globals.Sheet1.Controls.AddNamedRange( _
            Globals.Sheet1.Range("A1"), "NamedRange1")

        For Each displayWorksheet As Excel.Worksheet In Globals.ThisWorkbook.Worksheets
            NamedRange1.Offset(index, 0).Value2 = displayWorksheet.Name
            index += 1
        Next displayWorksheet
    End Sub