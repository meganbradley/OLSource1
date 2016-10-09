    Public Sub OnTextButton(ByVal control As Office.IRibbonControl)
        Dim currentRange As Word.Range = Globals.ThisAddIn.Application.Selection.Range
        currentRange.Text = "This text was added by the Ribbon."
    End Sub