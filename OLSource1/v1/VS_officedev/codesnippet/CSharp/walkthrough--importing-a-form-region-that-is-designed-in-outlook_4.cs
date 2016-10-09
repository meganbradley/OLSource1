        void RefreshTaskListBox()
        {
            listBox1.Clear();
            Outlook.TaskItem tempTaskItem;
            String[] tempArray = olkTextBox3.Text.Split(new Char[] { '|' });

            foreach (string tempString in tempArray)
            {
                tempTaskItem = FindTaskBySubjectName(tempString);
                if (tempTaskItem != null)
                {
                    this.listBox1.AddItem(tempTaskItem.PercentComplete.ToString()
                        + "% Complete -- " + tempTaskItem.Subject, 
                            System.Type.Missing);
                }
            }
        }