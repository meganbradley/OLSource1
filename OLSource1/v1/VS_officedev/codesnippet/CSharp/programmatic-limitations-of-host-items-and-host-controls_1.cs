            this.Range["A1"].Value2 = "Monday";
            this.Range["A2"].Value2 = "Tuesday";

            Microsoft.Office.Tools.Excel.NamedRange dayRange = 
                this.Controls.AddNamedRange(this.Range["A1", "A7"], "dayRange");
            this.Range["A1", "A2"].AutoFill(dayRange.InnerObject, Excel.XlAutoFillType.xlFillDays);