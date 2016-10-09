        public void OnTextButton(Office.IRibbonControl control)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "This text was added by the Ribbon.";
        }