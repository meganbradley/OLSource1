        private void CreateHtmlFolder()
        {
            Outlook.MAPIFolder newView = null;
            string viewName = "HtmlView";
            Outlook.MAPIFolder inBox = (Outlook.MAPIFolder)
                this.Application.ActiveExplorer().Session.GetDefaultFolder(Outlook
                .OlDefaultFolders.olFolderInbox);
            Outlook.Folders searchFolders = (Outlook.Folders)inBox.Folders;
            bool foundView = false;
            foreach (Outlook.MAPIFolder searchFolder in searchFolders)
            {
                if (searchFolder.Name == viewName)
                {
                    newView = inBox.Folders[viewName];
                    foundView = true;
                }
            }
            if (!foundView)
            {
                newView = (Outlook.MAPIFolder)inBox.Folders.
                    Add("HtmlView", Outlook.OlDefaultFolders.olFolderInbox);
                newView.WebViewURL = "http://www.microsoft.com";
                newView.WebViewOn = true;
            }
            Application.ActiveExplorer().SelectFolder(newView);
            Application.ActiveExplorer().CurrentFolder.Display();
        }