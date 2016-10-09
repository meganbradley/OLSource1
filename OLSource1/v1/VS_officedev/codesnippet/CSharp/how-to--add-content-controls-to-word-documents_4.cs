        private Microsoft.Office.Tools.Word.RichTextContentControl richTextControl1;

        private void AddRichTextControlAtSelection()
        {
            Word.Document currentDocument = this.Application.ActiveDocument;
            currentDocument.Paragraphs[1].Range.InsertParagraphBefore();
            currentDocument.Paragraphs[1].Range.Select();

            Document extendedDocument = Globals.Factory.GetVstoObject(currentDocument);

            richTextControl1 = extendedDocument.Controls.AddRichTextContentControl("richTextControl1");
            richTextControl1.PlaceholderText = "Enter your first name";
        }