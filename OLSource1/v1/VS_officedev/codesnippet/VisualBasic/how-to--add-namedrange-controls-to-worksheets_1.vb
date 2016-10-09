        Dim textInCell As Microsoft.Office.Tools.Excel.NamedRange
        textInCell = Me.Controls.AddNamedRange(Me.Range("A1"), "cellText")

        textInCell.Value2 = "Hello world!"