        public static IEnumerable<SalesOrderHeader> ReadList(DateTime OrderDateParam)
        {
            const string ServerName = "MySQLServerName";
            AdventureWorksDataContext dataContext = new AdventureWorksDataContext
                  ("Data Source=" + ServerName + ";" +
                   "Initial Catalog=AdventureWorks;Integrated Security=True");

            DateTime NoValuePassedIn = Convert.ToDateTime("1/1/1900 12:00:00 AM");
            DateTime DefaultDateTime = Convert.ToDateTime("2001-09-01 00:00:00.000");

            // If the user does not provide a value for the filter.
            if (OrderDateParam == NoValuePassedIn)
            {
                // Use a default date time value.
                OrderDateParam = DefaultDateTime;
            }

            IEnumerable<SalesOrderHeader> SalesOrderHeader =
                from salesOrderHeaders in dataContext.SalesOrderHeaders
                where salesOrderHeaders.OrderDate == OrderDateParam
                select salesOrderHeaders;
            return SalesOrderHeader;
        }