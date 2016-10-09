        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            ((Excel.AppEvents_Event)this.Application).NewWorkbook += 
                new Excel.AppEvents_NewWorkbookEventHandler(ThisWorkbook_NewWorkbook);
        }

        void ThisWorkbook_NewWorkbook(Excel.Workbook Wb)
        {
            // Perform some work here.
        }