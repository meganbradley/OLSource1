        private void namedRange1_SelectionChange(Microsoft.Office.Interop.Excel.Range Target)
        {
            this.namedRange2.Value2 = "The SelectionChange event occurred.";
            this.namedRange2.AddComment("SelectionChange always occurs before BeforeDoubleClick.");
            this.namedRange2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
        }