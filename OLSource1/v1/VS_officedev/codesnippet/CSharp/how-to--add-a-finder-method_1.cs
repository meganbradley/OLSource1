        public static IEnumerable<Contact> ReadList()
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            IEnumerable<Contact> Contacts =
                from contacts in dataContext.Contacts.Take(20)
                select contacts;
            return Contacts;

        }