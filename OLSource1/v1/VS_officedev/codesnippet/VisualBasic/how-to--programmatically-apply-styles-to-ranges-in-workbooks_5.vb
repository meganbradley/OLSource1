        Dim rangeStyles As Excel.Range = Me.Application.Range("A1")

        rangeStyles.Value2 = "'Style Test"
        rangeStyles.Style = "NewStyle"
        rangeStyles.Columns.AutoFit()