        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            this.ActionsPane.OrientationChanged += new EventHandler(ActionsPane_OrientationChanged);
        }

        private void ActionsPane_OrientationChanged(object sender, EventArgs e)
        {
            if (ActionsPane.Orientation == Orientation.Horizontal)
            {
                this.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromLeft;
            }
            else
            {
                this.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromTop;
            }
        }