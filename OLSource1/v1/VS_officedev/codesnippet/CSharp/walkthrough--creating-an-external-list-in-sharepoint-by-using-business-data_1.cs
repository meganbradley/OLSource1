        public static Contact ReadItem(int contactID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            Contact Contact =
                (from contacts in dataContext.Contacts.AsEnumerable().Take(20)
                 where contacts.ContactID == contactID
                 select contacts).Single();
            return Contact;
        }