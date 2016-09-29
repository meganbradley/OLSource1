        partial void CustomersWhoBoughtProduct_PreprocessQuery
            (short? ProductID, ref IQueryable<Customer> query)
        {
            query = from myCustomers in query
                    from myOrders in myCustomers.Orders
                    from myOrderDetails in myOrders.Order_Details
                    where myOrderDetails.Product.ProductID == ProductID
                    select myCustomers;
        }