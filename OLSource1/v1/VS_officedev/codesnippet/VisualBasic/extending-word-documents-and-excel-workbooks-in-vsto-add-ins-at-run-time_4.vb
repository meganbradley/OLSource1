        Dim sheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveSheet
        If sheet.ListObjects.Count > 0 Then
            Dim listObject As Excel.ListObject = sheet.ListObjects(1)
            Dim vstoListObject As Microsoft.Office.Tools.Excel.ListObject =
                Globals.Factory.GetVstoObject(listObject)
        End If