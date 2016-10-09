        private Microsoft.Office.Tools.Word.GroupContentControl groupControl1;

        private void ProtectFirstParagraph()
        {
            this.Paragraphs[1].Range.InsertParagraphBefore();
            Word.Range range1 = this.Paragraphs[1].Range;

            range1.Text = "You cannot edit or change the formatting of text " +
                "in this sentence, because this sentence is in a GroupContentControl.";
            range1.Select();
            groupControl1 = this.Controls.AddGroupContentControl("groupControl1");
        }