        private Outlook.TaskItem FindTaskBySubjectName(string subjectName)
        {
            Outlook.Application Application = new Outlook.Application();
            Outlook.NameSpace outlookNameSpace = Application.GetNamespace("MAPI");
            Outlook.MAPIFolder tasksFolder =
                outlookNameSpace.GetDefaultFolder(
            Microsoft.Office.Interop.Outlook.
                OlDefaultFolders.olFolderTasks);
            Outlook.Items taskItems = tasksFolder.Items;
            foreach (Outlook.TaskItem taskItem in taskItems)
            {
                if (taskItem.Subject == subjectName)
                {
                    return taskItem;
                }
            }
            return null;
        }