    Private Sub NamedRange1_Change(ByVal Target As Microsoft.Office.Interop.Excel.Range) _
        Handles NamedRange1.Change

        With Me.NamedRange2
            .Value2 = "The Change event occurred."
            .Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
            .Font.Italic = False
        End With
    End Sub