            int totalSheets = this.Application.ActiveWorkbook.Sheets.Count;
            Globals.Sheet1.Move(Globals.ThisWorkbook.Sheets[totalSheets]);