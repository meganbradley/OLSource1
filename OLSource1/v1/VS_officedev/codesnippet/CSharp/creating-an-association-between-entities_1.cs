        public static IEnumerable<SalesOrderHeader> ContactToSalesOrder(int contactID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            IEnumerable<SalesOrderHeader> orderList = 
                from orders in dataContext.SalesOrderHeaders
                     where orders.ContactID == contactID
                     select orders;
            return orderList;
        }