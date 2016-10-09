        private void applyItalicFont_Click(object sender, System.EventArgs e)
        {
            if (this.applyItalicFont.Checked == true)
            {
                this.fontText.Italic = WordTrue;
            }
            else
            {
                this.fontText.Italic = WordFalse;
            }
        }