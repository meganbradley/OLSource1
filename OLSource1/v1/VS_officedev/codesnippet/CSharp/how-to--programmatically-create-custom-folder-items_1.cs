        private void CreateCustomFolder()
        {
            Outlook.MAPIFolder inBox = (Outlook.MAPIFolder)
                this.Application.ActiveExplorer().Session.GetDefaultFolder
                (Outlook.OlDefaultFolders.olFolderInbox);
            string userName = (string)this.Application.ActiveExplorer()
                .Session.CurrentUser.Name;
            Outlook.MAPIFolder customFolder = null;
            try
            {
                customFolder = (Outlook.MAPIFolder)inBox.Folders.Add(userName,
                    Outlook.OlDefaultFolders.olFolderInbox);
                MessageBox.Show("You have created a new folder named " +
                    userName + ".");
                inBox.Folders[userName].Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }