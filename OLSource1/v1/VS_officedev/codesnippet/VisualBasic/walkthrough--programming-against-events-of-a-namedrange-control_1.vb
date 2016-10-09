    Private Sub NamedRange1_BeforeDoubleClick( _
        ByVal Target As Microsoft.Office.Interop.Excel.Range, ByRef Cancel As Boolean) _
        Handles NamedRange1.BeforeDoubleClick

        With Me.NamedRange2
            .Value2 = "The BeforeDoubleClick event occurred."
            .Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
            .Font.Italic = True
        End With
    End Sub