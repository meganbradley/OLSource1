        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Outlook.MAPIFolder inbox =
                this.Application.ActiveExplorer().Session.GetDefaultFolder
                (Outlook.OlDefaultFolders.olFolderInbox);

            Outlook.Items unreadItems = inbox.
                Items.Restrict("[Unread]=true");

            MessageBox.Show(
                string.Format("Unread items in Inbox = {0}", unreadItems.Count));
        }