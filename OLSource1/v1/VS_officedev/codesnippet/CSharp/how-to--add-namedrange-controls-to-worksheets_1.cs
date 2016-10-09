            Microsoft.Office.Tools.Excel.NamedRange textInCell;
            textInCell = this.Controls.AddNamedRange(this.get_Range("A1"), "cellText");

            textInCell.Value2 = "Hello world!";