            Excel.Style style = this.Application.ActiveWorkbook.Styles.Add("NewStyle");

            style.Font.Name = "Verdana";
            style.Font.Size = 12;
            style.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            style.Interior.Pattern = Excel.XlPattern.xlPatternSolid;