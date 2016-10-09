        void TaskPane_VisibleChanged(object sender, EventArgs e)
        {
            Globals.Ribbons[inspector].ManageTaskPaneRibbon.toggleButton1.Checked = 
                taskPane.Visible;
        }