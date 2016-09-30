        partial void ImportCustomers_Execute()
        {
            foreach (SharePointCustomer spCust in
        this.DataWorkspace.SharePointData.NewCustomersInSharePoint())
            {
                Customer newCust = new Customer();

                newCust.ContactName = spCust.FirstName + " " + spCust.LastName;
                newCust.Address = spCust.Address;
                newCust.City = spCust.City;
                newCust.PostalCode = spCust.PostalCode;
                newCust.Region = spCust.Region;

                //Set the CopiedToDatabase field of the item in SharePoint.
                spCust.CopiedToDatabase = "Yes";
            }
            this.DataWorkspace.SharePointData.SaveChanges();


        }