        void Application_WorkbookBeforeSave(Microsoft.Office.Interop.Excel.Workbook workbook, 
            bool SaveAsUI, ref bool Cancel)
        {
            Excel.Worksheet worksheet =
                workbook.Worksheets[1] as Excel.Worksheet;
            
            if (Globals.Factory.HasVstoObject(worksheet) && 
                Globals.Factory.GetVstoObject(worksheet).Controls.Count > 0)
            {
                Worksheet vstoWorksheet = Globals.Factory.GetVstoObject(worksheet);
            
           
                
                while (vstoWorksheet.Controls.Count > 0)
                {
                    object vstoControl = vstoWorksheet.Controls[0];
                    vstoWorksheet.Controls.Remove(vstoControl);
                }
 
            }
        }