        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveSheet
        If NativeWorksheet IsNot Nothing Then
            Dim vstoSheet As Microsoft.Office.Tools.Excel.Worksheet =
                Globals.Factory.GetVstoObject(NativeWorksheet)
        End If