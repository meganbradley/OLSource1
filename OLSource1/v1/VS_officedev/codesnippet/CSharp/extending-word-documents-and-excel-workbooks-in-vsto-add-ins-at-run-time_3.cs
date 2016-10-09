            Microsoft.Office.Interop.Excel.Worksheet nativeWorksheet =
                Globals.ThisAddIn.Application.ActiveSheet;
            if (nativeWorksheet != null)
            {
                Microsoft.Office.Tools.Excel.Worksheet vstoSheet = 
                    Globals.Factory.GetVstoObject(nativeWorksheet);
            }