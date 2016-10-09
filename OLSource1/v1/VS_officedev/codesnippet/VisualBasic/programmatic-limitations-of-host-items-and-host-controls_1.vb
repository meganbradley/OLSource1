        Me.Range("A1").Value2 = "Monday"
        Me.Range("A2").Value2 = "Tuesday"

        Dim dayRange As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1", "A7"), "dayRange")
        Me.Range("A1", "A2").AutoFill(dayRange.InnerObject, Excel.XlAutoFillType.xlFillDays)