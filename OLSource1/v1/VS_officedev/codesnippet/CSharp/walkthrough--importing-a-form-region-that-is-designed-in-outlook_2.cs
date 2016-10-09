        void AddDependentTask_Click()
        {
            Outlook.TaskItem tempTaskItem = FindTaskBySubjectName(comboBox1.Text);
            if (tempTaskItem != null)
            {
                this.listBox1.AddItem(tempTaskItem.PercentComplete.ToString()
    + "% Complete -- " + tempTaskItem.Subject, System.Type.Missing);
                this.olkTextBox3.Text = this.olkTextBox3.Text + "|" + 
                    tempTaskItem.Subject;
            }
        }