        private void addText_Click(object sender, System.EventArgs e)
        {
            if (this.getName.Text != String.Empty) 
            {
                Globals.ThisDocument.showName.Text = this.getName.Text;
            }

            if (this.getAddress.Text != String.Empty)
            {
                Globals.ThisDocument.showAddress.Text = this.getAddress.Text;
            }

            this.getName.Text = String.Empty;
            this.getAddress.Text = String.Empty;
        }