        private void AddRichTextControlAtRange()
        {
            Word.Document currentDocument = this.Application.ActiveDocument;
            currentDocument.Paragraphs[1].Range.InsertParagraphBefore();

            Document extendedDocument = Globals.Factory.GetVstoObject(currentDocument);

            richTextContentControl = extendedDocument.Controls.AddRichTextContentControl(
                currentDocument.Paragraphs[1].Range, "richTextContentControl");
            richTextContentControl.PlaceholderText =
                "Click here to download MSDN Library information about content controls.";
        }