        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            myUserControl1 = new MyUserControl();
            myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "Calendar");
            myCustomTaskPane.Visible = true;
        }