        private void NamedRange_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);


            string Name = "MyNamedRange";

            if (((RibbonCheckBox)sender).Checked)
            {
                Excel.Range selection = Globals.ThisAddIn.Application.Selection as Excel.Range;
                if (selection != null)
                {
                    worksheet.Controls.AddNamedRange(selection, Name);
                }
            }
            else
            {
                worksheet.Controls.Remove(Name);
            }
        }