            int totalSheets = this.Application.ActiveWorkbook.Sheets.Count;
            ((Excel.Worksheet)Application.ActiveSheet).Move(
                this.Application.Worksheets[totalSheets]);