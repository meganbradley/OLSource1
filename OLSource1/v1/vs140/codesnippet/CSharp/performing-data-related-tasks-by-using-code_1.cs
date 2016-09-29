        partial void RetrieveCustomer_Execute()
        {
            Customer cust = this.Customers.SelectedItem;
            if (cust.ContactName == "Bob")
            {
                //Perform some task on the customer entity.
            }
        }