        private void ListSheets()
        {
            int index = 0;

            Microsoft.Office.Tools.Excel.NamedRange NamedRange1 =
                Globals.Sheet1.Controls.AddNamedRange(
                Globals.Sheet1.Range["A1"], "NamedRange1");

            foreach (Excel.Worksheet displayWorksheet in Globals.ThisWorkbook.Worksheets)
            {
                NamedRange1.Offset[index, 0].Value2 = displayWorksheet.Name;
                index++;
            }
        }