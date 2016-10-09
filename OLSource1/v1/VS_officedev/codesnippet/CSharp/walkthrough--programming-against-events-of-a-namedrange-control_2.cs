            this.namedRange1.BeforeDoubleClick += new Microsoft.Office.Interop.Excel.
                DocEvents_BeforeDoubleClickEventHandler(namedRange1_BeforeDoubleClick);   

            this.namedRange1.Change += new Microsoft.Office.Interop.Excel.
                DocEvents_ChangeEventHandler(namedRange1_Change);

            this.namedRange1.SelectionChange +=new Microsoft.Office.Interop.Excel.
                DocEvents_SelectionChangeEventHandler(namedRange1_SelectionChange);