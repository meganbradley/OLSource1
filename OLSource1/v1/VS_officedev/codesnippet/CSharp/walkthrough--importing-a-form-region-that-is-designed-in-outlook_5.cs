        private void TaskFormRegion_FormRegionShowing
            (object sender, EventArgs e)
        {
            populateComboBox();
            RefreshTaskListBox();
            this.addDependentTask.Click += new
            Microsoft.Office.Interop.Outlook.
                OlkCommandButtonEvents_ClickEventHandler(AddDependentTask_Click);

        }