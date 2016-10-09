        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            this.Open += new 
                Microsoft.Office.Interop.Excel.WorkbookEvents_OpenEventHandler(ThisWorkbook_Open);
        }

        private void ThisWorkbook_Open()
        {
            GetInputString inputForm = new GetInputString();
            inputForm.ShowDialog();
        }