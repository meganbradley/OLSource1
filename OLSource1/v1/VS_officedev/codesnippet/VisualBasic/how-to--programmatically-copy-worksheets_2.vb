        Dim worksheet1 As Excel.Worksheet = CType(Application.ActiveWorkbook.Worksheets(1),  _
        Excel.Worksheet)
        Dim worksheet3 As Excel.Worksheet = CType(Application.ActiveWorkbook.Worksheets(3),  _
        Excel.Worksheet)
        worksheet1.Copy(After:=worksheet3)