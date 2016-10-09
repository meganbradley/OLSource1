            Excel.Worksheet worksheet1 = ((Excel.Worksheet)Application.ActiveWorkbook.Worksheets[1]);
            Excel.Worksheet worksheet3 = ((Excel.Worksheet)Application.ActiveWorkbook.Worksheets[3]);
            worksheet1.Copy(worksheet3);