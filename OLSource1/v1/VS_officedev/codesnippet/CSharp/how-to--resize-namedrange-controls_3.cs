
            Worksheet worksheet = Globals.Factory.GetVstoObject(Application.ActiveSheet);


            Microsoft.Office.Tools.Excel.NamedRange namedRange1 = worksheet.Controls.AddNamedRange(
                worksheet.Range["A1"], "MyNamedRange");