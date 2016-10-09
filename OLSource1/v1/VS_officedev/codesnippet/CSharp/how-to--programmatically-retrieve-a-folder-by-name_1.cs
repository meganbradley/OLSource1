        private void SetCurrentFolder()
        {
            string folderName = "TestFolder";
            Outlook.MAPIFolder inBox = (Outlook.MAPIFolder)
                this.Application.ActiveExplorer().Session.GetDefaultFolder
                (Outlook.OlDefaultFolders.olFolderInbox);
            try
            {
                this.Application.ActiveExplorer().CurrentFolder = inBox.
                    Folders[folderName];
                this.Application.ActiveExplorer().CurrentFolder.Display();
            }
            catch
            {
                MessageBox.Show("There is no folder named " + folderName +
                    ".", "Find Folder Name");
            }
        }