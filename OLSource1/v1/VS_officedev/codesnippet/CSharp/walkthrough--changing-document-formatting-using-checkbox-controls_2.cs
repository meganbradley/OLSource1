        private void applyBoldFont_Click(object sender, System.EventArgs e)
        {
            if (this.applyBoldFont.Checked == true)
            {
                this.fontText.Bold = WordTrue;
            }
            else
            {
                this.fontText.Bold = WordFalse;
            }
        }