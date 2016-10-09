        private Microsoft.Office.Tools.Word.RichTextContentControl richTextControl2;

        private void AddRichTextControlAtRange()
        {
            Word.Document currentDocument = this.Application.ActiveDocument;
            currentDocument.Paragraphs[1].Range.InsertParagraphBefore();

            Document extendedDocument = Globals.Factory.GetVstoObject(currentDocument);

            richTextControl2 = extendedDocument.Controls.AddRichTextContentControl(
                currentDocument.Paragraphs[1].Range, "richTextControl2");
            richTextControl2.PlaceholderText = "Enter your first name";
        }