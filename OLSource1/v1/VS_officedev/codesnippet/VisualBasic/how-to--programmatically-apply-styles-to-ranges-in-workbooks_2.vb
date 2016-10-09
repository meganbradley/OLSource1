        Dim rangeStyles As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "rangeStyles")

        rangeStyles.Value2 = "'Style Test"
        rangeStyles.Style = "NewStyle"
        rangeStyles.Columns.AutoFit()