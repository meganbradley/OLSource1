        private void namedRange1_Change(Microsoft.Office.Interop.Excel.Range Target)
        {
            this.namedRange2.Value2 = "The Change event occurred.";
            this.namedRange2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
            this.namedRange2.Font.Italic = false;
        }