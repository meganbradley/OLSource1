            
            Worksheet worksheet = Globals.Factory.GetVstoObject(Application.ActiveSheet);

            Microsoft.Office.Tools.Excel.ListObject list1;    
            list1 = worksheet.Controls.AddListObject(worksheet.Range["$A$1:$B$3"], "MyListObject");