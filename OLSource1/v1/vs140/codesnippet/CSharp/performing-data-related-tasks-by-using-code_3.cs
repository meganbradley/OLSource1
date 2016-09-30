        partial void RetrieveSalesOrders_Execute()
        {
            Customer cust = this.Customers.SelectedItem;

            foreach (Order order in cust.Orders)
            {
                if (order.OrderDate == DateTime.Today)
                {
                    //perform some task on the order entity.
                }
            }
        }