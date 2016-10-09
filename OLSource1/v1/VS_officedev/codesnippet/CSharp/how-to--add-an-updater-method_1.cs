        public static void Update(Contact contact)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");
           
            var contactToUpdate = (from contacts in dataContext.Contacts
                                    where contacts.ContactID == contact.ContactID
                                    select contacts).Single();

            contactToUpdate.FirstName = contact.FirstName;
            contactToUpdate.LastName = contact.LastName;
            contactToUpdate.EmailAddress = contact.EmailAddress;
            contactToUpdate.Phone = contact.Phone;
            contactToUpdate.EmailPromotion = contact.EmailPromotion;
            contactToUpdate.NameStyle = contact.NameStyle;
            contactToUpdate.PasswordHash = contact.PasswordHash;
            contactToUpdate.PasswordSalt = contact.PasswordSalt;
            contactToUpdate.ModifiedDate = DateTime.Now;
            contactToUpdate.rowguid = Guid.NewGuid();
            dataContext.SubmitChanges();

        }