        private void ListObject_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet worksheet = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);


            string listObjectName = "MyListObject";

            if (((RibbonCheckBox)sender).Checked)
            {
                Excel.Range selection = Globals.ThisAddIn.Application.Selection as Excel.Range;
                if (selection != null)
                {
                    worksheet.Controls.AddListObject(selection, listObjectName);
                }
            }
            else
            {
                worksheet.Controls.Remove(listObjectName);
            }
        }