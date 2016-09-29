        partial void TopNSalesOrders_PreprocessQuery
            (short? TopN, ref IQueryable<Customer> query)
        {
            query = (from myCustomer in query
                     where myCustomer.Orders.Count() > 0
                     orderby myCustomer.Orders.Count() descending
                     select myCustomer).Take(System.Convert.ToInt16(TopN));
        }