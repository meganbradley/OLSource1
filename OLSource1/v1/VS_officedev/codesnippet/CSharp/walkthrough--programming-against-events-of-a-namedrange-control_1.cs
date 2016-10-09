        private void namedRange1_BeforeDoubleClick(
            Microsoft.Office.Interop.Excel.Range Target, ref bool Cancel)
        {
            this.namedRange2.Value2 = "The BeforeDoubleClick event occurred.";
            this.namedRange2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            this.namedRange2.Font.Italic = true;
        }