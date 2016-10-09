        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            FindContactEmailByName("John", "Evans");
        }

        private void FindContactEmailByName(string firstName, string lastName)
        {
            Outlook.NameSpace outlookNameSpace = this.Application.GetNamespace("MAPI");
            Outlook.MAPIFolder contactsFolder =
                outlookNameSpace.GetDefaultFolder(
                Microsoft.Office.Interop.Outlook.
                OlDefaultFolders.olFolderContacts);

            Outlook.Items contactItems = contactsFolder.Items;

            try
            {
                Outlook.ContactItem contact =
                    (Outlook.ContactItem)contactItems.
                    Find(String.Format("[FirstName]='{0}' and "
                    + "[LastName]='{1}'", firstName, lastName));
                if (contact != null)
                {
                    contact.Display(true);
                }
                else
                {
                    MessageBox.Show("The contact information was not found.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
