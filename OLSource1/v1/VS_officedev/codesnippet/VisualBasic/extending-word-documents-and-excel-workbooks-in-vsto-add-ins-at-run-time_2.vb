        Dim NativeWorkbook As Microsoft.Office.Interop.Excel.Workbook =
            Globals.ThisAddIn.Application.ActiveWorkbook
        If NativeWorkbook IsNot Nothing Then
            Dim vstoWorkbook As Microsoft.Office.Tools.Excel.Workbook =
                Globals.Factory.GetVstoObject(NativeWorkbook)
        End If