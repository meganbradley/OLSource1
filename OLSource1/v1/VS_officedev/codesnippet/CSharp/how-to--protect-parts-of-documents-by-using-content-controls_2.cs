        private Microsoft.Office.Tools.Word.RichTextContentControl deletableControl;
        private Microsoft.Office.Tools.Word.RichTextContentControl editableControl;

        private void AddProtectedContentControls()
        {
            Microsoft.Office.Tools.Word.Document vstoDocument = 
                Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            vstoDocument.Paragraphs[1].Range.InsertParagraphBefore();
            Word.Range range1 = vstoDocument.Paragraphs[1].Range;

            deletableControl = vstoDocument.Controls.AddRichTextContentControl(range1,
                "deletableControl");
            deletableControl.PlaceholderText = "You can delete this control, " +
                "but you cannot edit it";
            deletableControl.LockContents = true;

            range1.InsertParagraphAfter();
            Word.Range range2 = vstoDocument.Paragraphs[2].Range;

            editableControl = vstoDocument.Controls.AddRichTextContentControl(range2,
                "editableControl");
            editableControl.PlaceholderText = "You can edit this control, " +
                "but you cannot delete it.";
            editableControl.LockContentControl = true;
        }