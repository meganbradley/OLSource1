        private void AddListObject()
        {
            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);

            Microsoft.Office.Tools.Excel.ListObject list1;
            Excel.Range cell = worksheet.Range["$A$1:$D$4"];
            list1 = worksheet.Controls.AddListObject(cell, "list1");
        }