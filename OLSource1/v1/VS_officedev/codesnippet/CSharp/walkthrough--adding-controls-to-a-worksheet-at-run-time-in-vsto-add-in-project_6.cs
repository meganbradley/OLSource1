        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.WorkbookBeforeSave += 
                new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler
                    (Application_WorkbookBeforeSave);
        }