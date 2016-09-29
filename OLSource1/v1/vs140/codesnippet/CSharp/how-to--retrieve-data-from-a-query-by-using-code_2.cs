        private void Good_Customer_Discount2(Order_Detail entity)
        {
            IDataServiceQueryable<Customer> query;

            query = from myCustomer in this.DataWorkspace.NorthwindData.
                        TopNSalesOrders(10)
                    where myCustomer.CustomerID == entity.Order.Customer.CustomerID
                    select myCustomer;
                 
            if (query.SingleOrDefault() != null)
            {
                entity.Discount = 0.1F;
            }
        }
        }