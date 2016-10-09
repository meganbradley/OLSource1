    Private Sub NamedRange1_SelectionChange(ByVal Target As Microsoft.Office.Interop.Excel.Range) _
        Handles NamedRange1.SelectionChange

        With Me.NamedRange2
            .Value2 = "The SelectionChange event occurred."
            .AddComment("SelectionChange always occurs before BeforeDoubleClick.")
            .Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
        End With
    End Sub