        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            this.bookmark1.BeforeRightClick += new ClickEventHandler(bookmark_BeforeRightClick);
            this.bookmark2.BeforeRightClick += new ClickEventHandler(bookmark_BeforeRightClick);
        }