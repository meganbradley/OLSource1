    Private Sub AddListObject()
        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim list1 As Microsoft.Office.Tools.Excel.ListObject
        Dim cell As Excel.Range = worksheet.Range("$A$1:$D$4")
        list1 = worksheet.Controls.AddListObject(cell, "MyListObject")
    End Sub