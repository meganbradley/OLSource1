        private void Good_Customer_Discount(Order_Detail entity)
        {
            foreach (Customer cust in this.DataWorkspace.NorthwindData.
         TopNSalesOrders(10))
            {
                if (cust.CustomerID == entity.Order.Customer.CustomerID)
                {
                    entity.Discount = 0.1F;
                }
            }
        }