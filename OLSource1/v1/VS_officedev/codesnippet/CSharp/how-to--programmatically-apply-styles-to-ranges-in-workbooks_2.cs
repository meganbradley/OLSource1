            Microsoft.Office.Tools.Excel.NamedRange rangeStyles =
                this.Controls.AddNamedRange(this.Range["A1"], "rangeStyles");

            rangeStyles.Value2 = "'Style Test";
            rangeStyles.Style = "NewStyle";
            rangeStyles.Columns.AutoFit();