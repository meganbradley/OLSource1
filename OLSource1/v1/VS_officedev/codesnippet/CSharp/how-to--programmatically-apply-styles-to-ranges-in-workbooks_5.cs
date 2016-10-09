            Excel.Range rangeStyles = this.Application.get_Range("A1");

            rangeStyles.Value2 = "'Style Test";
            rangeStyles.Style = "NewStyle";
            rangeStyles.Columns.AutoFit();