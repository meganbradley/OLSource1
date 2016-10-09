        public static void Delete(int salesOrderID, int salesOrderDetailID)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            SalesOrderDetail SalesOrderDetail =
                   (from SalesOrderDetails in dataContext.SalesOrderDetails.AsEnumerable().Take(20)
                    where SalesOrderDetails.SalesOrderID == salesOrderID &&
                    SalesOrderDetails.SalesOrderDetailID == salesOrderDetailID
                    select SalesOrderDetails).Single();

            dataContext.SalesOrderDetails.DeleteOnSubmit(SalesOrderDetail);
            dataContext.SubmitChanges();
        }