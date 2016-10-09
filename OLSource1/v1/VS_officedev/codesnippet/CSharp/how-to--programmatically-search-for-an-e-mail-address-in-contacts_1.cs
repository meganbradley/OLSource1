        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            SearchforEmail("example.com");
        }

        private void SearchforEmail(string partialAddress)
        {
            string contactMessage = string.Empty;
            Outlook.MAPIFolder contacts = (Outlook.MAPIFolder)
                this.Application.ActiveExplorer().Session.GetDefaultFolder
                 (Outlook.OlDefaultFolders.olFolderContacts);
            foreach (Outlook.ContactItem foundContact in contacts.Items)
            {
                if (foundContact.Email1Address != null)
                {
                    if (foundContact.Email1Address.Contains(partialAddress))
                    {
                        contactMessage = contactMessage + "New contact"
                        + foundContact.FirstName + " " + foundContact.LastName
                        + " Email Address is " + foundContact.Email1Address +
                        ". \n";
                    }
                }
            }
            if (!(contactMessage.Length > 0))
            {
                contactMessage = "No Contacts were found.";
            }
            MessageBox.Show(contactMessage);
        }