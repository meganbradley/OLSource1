        private void populateComboBox()
        {
            Outlook.Application Application = new Outlook.Application();
            Outlook.NameSpace outlookNameSpace = Application.GetNamespace("MAPI");
            Outlook.MAPIFolder taskFolder = outlookNameSpace.GetDefaultFolder(
                Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderTasks);
            Outlook.Items taskItems = taskFolder.Items;
            foreach (Outlook.TaskItem task in taskItems)
            {
                if (task.Subject != null)
                {
                    comboBox1.AddItem(task.Subject, System.Type.Missing);
                }
            }
            comboBox1.Text = comboBox1.GetItem(0);
        }