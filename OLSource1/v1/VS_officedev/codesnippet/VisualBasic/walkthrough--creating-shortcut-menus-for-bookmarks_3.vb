    Public Function GetVisible(ByVal control As Office.IRibbonControl) As Boolean
        If control.Id = "BoldButton" Then
            If Globals.ThisDocument.ShowBoldButton = True Then
                Globals.ThisDocument.ShowBoldButton = False
                Return True
            Else
                Return False
            End If
        ElseIf control.Id = "ItalicButton" Then
            If Globals.ThisDocument.ShowItalicButton = True Then
                Globals.ThisDocument.ShowItalicButton = False
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function