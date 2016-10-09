        private Microsoft.Office.Tools.Word.RichTextContentControl deletableControl;
        private Microsoft.Office.Tools.Word.RichTextContentControl editableControl;

        private void AddProtectedContentControls()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            Word.Range range1 = this.Paragraphs[1].Range;

            deletableControl = this.Controls.AddRichTextContentControl(range1,
                "deletableControl");
            deletableControl.PlaceholderText = "You can delete this control, " +
                "but you cannot edit it";
            deletableControl.LockContents = true;

            range1.InsertParagraphAfter();
            Word.Range range2 = this.Paragraphs[2].Range;

            editableControl = this.Controls.AddRichTextContentControl(range2,
                "editableControl");
            editableControl.PlaceholderText = "You can edit this control, " +
                "but you cannot delete it";
            editableControl.LockContentControl = true;
        }