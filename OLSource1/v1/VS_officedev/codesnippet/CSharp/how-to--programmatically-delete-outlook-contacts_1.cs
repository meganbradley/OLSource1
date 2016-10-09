        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            DeleteContact("Pinto", "Armando");
        }

        private void DeleteContact(string lastName, string firstName)
        {
            Outlook.ContactItem contact =
                this.Application.GetNamespace("MAPI").
            GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts).
            Items.
            Find(
            string.Format("[LastName]='{0}' AND [FirstName]='{1}'",
            lastName, firstName))
            as Outlook.ContactItem;

            if (contact != null)
            {
                contact.Delete();
            }
        }