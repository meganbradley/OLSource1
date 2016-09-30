        partial void RetrieveCustomers_Execute()
        {
            foreach (Customer cust in this.DataWorkspace.NorthwindData.Customers)
            {
                if (cust.ContactName == "Bob")
                {
                    //Perform some task on the customer entity.
                }
            }
        }