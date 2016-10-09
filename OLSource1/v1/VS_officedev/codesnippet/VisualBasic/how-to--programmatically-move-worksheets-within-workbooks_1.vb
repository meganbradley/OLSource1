        Dim totalSheets As Integer = Application.ActiveWorkbook.Sheets.Count
        Globals.Sheet1.Move(After:=Globals.ThisWorkbook.Sheets(totalSheets))