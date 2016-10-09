    Public Sub ButtonClick(ByVal control As Office.IRibbonControl)
        If control.Id = "BoldButton" Then
            If Globals.ThisDocument.selectedBookmark.Bold = _
                Globals.ThisDocument.WordTrue Then
                Globals.ThisDocument.selectedBookmark.Bold = _
                    Globals.ThisDocument.WordFalse
            Else
                Globals.ThisDocument.selectedBookmark.Bold = _
                    Globals.ThisDocument.WordTrue
            End If
        ElseIf control.Id = "ItalicButton" Then
            If Globals.ThisDocument.selectedBookmark.Italic = _
                Globals.ThisDocument.WordTrue Then
                Globals.ThisDocument.selectedBookmark.Italic = _
                    Globals.ThisDocument.WordFalse
            Else
                Globals.ThisDocument.selectedBookmark.Italic = _
                    Globals.ThisDocument.WordTrue
            End If
        End If
    End Sub