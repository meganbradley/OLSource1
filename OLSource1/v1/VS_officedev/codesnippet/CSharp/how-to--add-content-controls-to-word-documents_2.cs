        private Microsoft.Office.Tools.Word.RichTextContentControl richTextControl2;

        private void AddRichTextControlAtRange()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();

            richTextControl2 = this.Controls.AddRichTextContentControl(this.Paragraphs[1].Range,
                "richTextControl2");
            richTextControl2.PlaceholderText = "Enter your first name";
        }