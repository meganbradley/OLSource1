        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet = _
            Application.ActiveSheet

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet = _
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim list1 As Microsoft.Office.Tools.Excel.ListObject
        list1 = worksheet.Controls.AddListObject(worksheet.Range("$A$1:$B$3"), "MyListObject")