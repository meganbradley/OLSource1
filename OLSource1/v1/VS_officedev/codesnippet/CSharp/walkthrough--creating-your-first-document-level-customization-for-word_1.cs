        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            this.Paragraphs[1].Range.InsertParagraphAfter();
            this.Paragraphs[2].Range.Text = "This text was added by using code.";
        }