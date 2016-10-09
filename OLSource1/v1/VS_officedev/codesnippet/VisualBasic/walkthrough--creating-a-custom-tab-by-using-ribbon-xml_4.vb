    Public Sub OnTableButton(ByVal control As Office.IRibbonControl)
        Dim missing As Object = System.Type.Missing

        Dim currentRange As Word.Range = Globals.ThisAddIn.Application.Selection.Range
        Dim newTable As Word.Table = Globals.ThisAddIn.Application.ActiveDocument.Tables.Add( _
                   currentRange, 3, 4)

        ' Get all of the borders except for the diagonal borders.
        Dim borders() As Word.Border = New Word.Border(6) {}
        borders(0) = newTable.Borders(Word.WdBorderType.wdBorderLeft)
        borders(1) = newTable.Borders(Word.WdBorderType.wdBorderRight)
        borders(2) = newTable.Borders(Word.WdBorderType.wdBorderTop)
        borders(3) = newTable.Borders(Word.WdBorderType.wdBorderBottom)
        borders(4) = newTable.Borders(Word.WdBorderType.wdBorderHorizontal)
        borders(5) = newTable.Borders(Word.WdBorderType.wdBorderVertical)

        ' Format each of the borders.
        For Each border As Word.Border In borders
            border.LineStyle = Word.WdLineStyle.wdLineStyleSingle
            border.Color = Word.WdColor.wdColorBlue
        Next
    End Sub