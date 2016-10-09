        private void AddNamedRange()
        {
            Microsoft.Office.Tools.Excel.NamedRange textInCell;

            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);


            Excel.Range cell = worksheet.Range["A1"]; 
            textInCell = worksheet.Controls.AddNamedRange(cell, "MyNamedRange");
            textInCell.Value2 = "Hello World";
         }