        public static IEnumerable<Contact> SalesOrderDetailToContact(int salesOrderID, int salesOrderDetailID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");
                
            int TempContactID = (from orders in dataContext.SalesOrderHeaders
                                 where orders.SalesOrderID == salesOrderID
                                 select orders.ContactID).Single();

            IEnumerable<Contact> contactList = from contacts in dataContext.Contacts
                                               where contacts.ContactID == TempContactID
                                               select contacts;
            return contactList;
        }