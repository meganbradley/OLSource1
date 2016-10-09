            Excel.Worksheet worksheet = (Excel.Worksheet)this.Application.ActiveWorkbook.Worksheets[1];
            // Create a workhseet host item.
            Worksheet extendedWorksheet = Globals.Factory.GetVstoObject(worksheet);
            
