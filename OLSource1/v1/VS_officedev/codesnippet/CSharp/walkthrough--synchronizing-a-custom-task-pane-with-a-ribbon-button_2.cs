        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            taskPaneControl1 = new TaskPaneControl();
            taskPaneValue = this.CustomTaskPanes.Add(
                taskPaneControl1, "MyCustomTaskPane");
            taskPaneValue.VisibleChanged +=
                new EventHandler(taskPaneValue_VisibleChanged);
        }