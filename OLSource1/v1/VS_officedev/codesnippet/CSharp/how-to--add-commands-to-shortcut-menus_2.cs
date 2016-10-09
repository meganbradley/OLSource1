        public void GetButtonID(Office.IRibbonControl control)
        {
            Microsoft.Office.Interop.Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "This text was added by the context menu named My Button.";
        }