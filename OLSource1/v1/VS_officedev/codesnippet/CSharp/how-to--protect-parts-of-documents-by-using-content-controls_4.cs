        private Microsoft.Office.Tools.Word.GroupContentControl groupControl1;

        private void ProtectFirstParagraph()
        {
            Microsoft.Office.Tools.Word.Document vstoDocument =
                Globals.Factory.GetVstoObject(this.Application.ActiveDocument);

 
            vstoDocument.Paragraphs[1].Range.InsertParagraphBefore();

            Word.Range range1 = vstoDocument.Paragraphs[1].Range;
            range1.Text = "You cannot edit or change the formatting of text " +
                "in this sentence, because this sentence is in a GroupContentControl.";
            range1.Select();

            groupControl1 = vstoDocument.Controls.AddGroupContentControl("groupControl1");
        }