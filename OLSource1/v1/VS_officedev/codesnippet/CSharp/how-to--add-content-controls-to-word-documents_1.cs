        private Microsoft.Office.Tools.Word.RichTextContentControl richTextControl1;

        private void AddRichTextControlAtSelection()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            this.Paragraphs[1].Range.Select();

            richTextControl1 = this.Controls.AddRichTextContentControl("richTextControl1");
            richTextControl1.PlaceholderText = "Enter your first name";
        }