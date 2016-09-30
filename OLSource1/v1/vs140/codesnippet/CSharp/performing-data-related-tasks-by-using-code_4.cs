        partial void RetrieveCustomer_Execute()
        {
            Order order = this.DataWorkspace.NorthwindData.Orders_Single
                (Orders.SelectedItem.OrderID);

            Customer cust = order.Customer;
            //Perform some task on the customer entity.

        }