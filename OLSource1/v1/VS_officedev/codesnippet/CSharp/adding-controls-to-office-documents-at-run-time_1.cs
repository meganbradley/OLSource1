            Excel.Range range1 = Globals.Sheet1.Range["A1", "D5"];
            Microsoft.Office.Tools.Excel.NamedRange namedRange1 =
                Globals.Sheet1.Controls.AddNamedRange(range1, "ChartSource");