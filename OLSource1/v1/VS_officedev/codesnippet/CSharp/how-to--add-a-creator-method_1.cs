        public static Contact Create(Contact newContact)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            Contact contact = new Contact();

            contact.FirstName = newContact.FirstName;
            contact.LastName = newContact.LastName;
            contact.EmailAddress = newContact.EmailAddress;
            contact.Phone = newContact.Phone;
            contact.EmailPromotion = newContact.EmailPromotion;
            contact.NameStyle = newContact.NameStyle;
            contact.PasswordHash = newContact.PasswordHash;
            contact.PasswordSalt = newContact.PasswordSalt;
            contact.ModifiedDate = DateTime.Now;
            contact.rowguid = Guid.NewGuid();

            dataContext.Contacts.InsertOnSubmit(contact);
            dataContext.SubmitChanges();
            return contact;

        }