        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet = _
            Application.ActiveSheet

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet = _
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim namedRange1 As Microsoft.Office.Tools.Excel.NamedRange
        namedRange1 = worksheet.Controls.AddNamedRange(worksheet.Range("A1"), "MyNamedRange")