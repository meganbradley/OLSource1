        private void AutoFill()
        {
            Excel.Range rng = this.Application.get_Range("B1");
            rng.AutoFill(this.Application.get_Range("B1","B5"), 
                Excel.XlAutoFillType.xlFillWeekdays); 

            rng = this.Application.get_Range("C1"); 
            rng.AutoFill(this.Application.get_Range("C1","C5"),
                Excel.XlAutoFillType.xlFillMonths);

            rng = this.Application.get_Range("D1","D2");
            rng.AutoFill(this.Application.get_Range("D1","D5"),
                Excel.XlAutoFillType.xlFillSeries); 
        }