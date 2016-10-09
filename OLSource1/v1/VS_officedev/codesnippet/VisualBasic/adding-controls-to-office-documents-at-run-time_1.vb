        Dim range1 As Excel.Range = Globals.Sheet1.Range("A1", "D5")
        Dim namedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Globals.Sheet1.Controls.AddNamedRange(range1, "ChartSource")