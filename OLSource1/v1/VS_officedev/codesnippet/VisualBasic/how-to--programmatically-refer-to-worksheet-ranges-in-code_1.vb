        Dim NamedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "NamedRange1")

        NamedRange1.Value2 = "Range value"