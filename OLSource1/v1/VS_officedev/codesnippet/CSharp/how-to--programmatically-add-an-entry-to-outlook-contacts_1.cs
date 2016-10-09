        private void AddContact()
        {
            Outlook.ContactItem newContact = (Outlook.ContactItem)
                this.Application.CreateItem(Outlook.OlItemType.olContactItem);
            try
            {
                newContact.FirstName = "Jo";
                newContact.LastName = "Berry";
                newContact.Email1Address = "somebody@example.com";
                newContact.CustomerID = "123456";
                newContact.PrimaryTelephoneNumber = "(425)555-0111";
                newContact.MailingAddressStreet = "123 Main St.";
                newContact.MailingAddressCity = "Redmond";
                newContact.MailingAddressState = "WA";
                newContact.Save();
                newContact.Display(true);
            }
            catch
            {
                MessageBox.Show("The new contact was not saved.");
            }
        }