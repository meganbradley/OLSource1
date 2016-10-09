        public static IEnumerable<SalesOrderDetail> ContactToSalesOrderDetail(int contactID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            IEnumerable<SalesOrderDetail> orderList =
                from orders in dataContext.SalesOrderHeaders
                join orderDetails in dataContext.SalesOrderDetails on
                    orders.SalesOrderID equals orderDetails.SalesOrderID
                where orders.ContactID == contactID
                select orderDetails;
            return orderList;
        }