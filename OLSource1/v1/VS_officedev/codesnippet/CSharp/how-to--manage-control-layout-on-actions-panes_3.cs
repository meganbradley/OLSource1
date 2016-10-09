        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            this.ActionsPane.OrientationChanged += new EventHandler(ActionsPane_OrientationChanged);
        }