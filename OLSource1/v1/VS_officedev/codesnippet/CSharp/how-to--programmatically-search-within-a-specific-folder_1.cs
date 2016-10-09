        private void SearchInBox()
        {
            Outlook.MAPIFolder inbox = this.Application.ActiveExplorer().Session.
                GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
            Outlook.Items items = inbox.Items;
            Outlook.MailItem mailItem = null;
            object folderItem;
            string subjectName = string.Empty;
            string filter = "[Subject] > 's' And [Subject] <'u'";
            folderItem = items.Find(filter);
            while (folderItem != null)
            {
                mailItem = folderItem as Outlook.MailItem;
                if (mailItem != null)
                {
                    subjectName += "\n" + mailItem.Subject;
                }
                folderItem = items.FindNext();
            }
            subjectName = " The following e-mail messages were found: " +
                subjectName;
            MessageBox.Show(subjectName);
        }
