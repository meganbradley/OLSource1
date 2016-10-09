        private void applyUnderlineFont_Click(object sender, EventArgs e)
        {
            if (this.applyUnderlineFont.Checked == true)
            {
                this.textFont.Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle;
            }
            else
            {
                this.textFont.Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleNone;
            }
        }