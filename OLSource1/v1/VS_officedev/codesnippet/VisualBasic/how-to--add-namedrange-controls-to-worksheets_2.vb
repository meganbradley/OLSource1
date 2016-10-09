    Private Sub AddNamedRange()
        Dim textInCell As Microsoft.Office.Tools.Excel.NamedRange

        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim cell As Excel.Range = worksheet.Range("A1")
        textInCell = worksheet.Controls.AddNamedRange(cell, "MyNamedRange")
        textInCell.Value2 = "Hello World"
    End Sub