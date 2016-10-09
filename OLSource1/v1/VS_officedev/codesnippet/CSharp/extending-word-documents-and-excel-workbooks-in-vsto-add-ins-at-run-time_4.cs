            Microsoft.Office.Interop.Excel.Worksheet sheet =
                Globals.ThisAddIn.Application.ActiveSheet;
            if (sheet.ListObjects.Count > 0)
            {
                Excel.ListObject listObject = 
                    sheet.ListObjects[1];
                Microsoft.Office.Tools.Excel.ListObject vstoListObject =
                    Globals.Factory.GetVstoObject(listObject);
            }