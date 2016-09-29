        partial void DeleteCustomer_Execute()
        {
            Customer cust =
                this.Customers.SelectedItem;

            if (Customers.CanDelete)
            {
                cust.Delete();
            }
        }