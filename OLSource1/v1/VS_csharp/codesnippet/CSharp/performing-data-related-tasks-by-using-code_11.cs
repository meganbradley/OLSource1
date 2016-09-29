        partial void UndoAllCustomerUpdates_Execute()
        {
            foreach (Customer cust in 
                this.DataWorkspace.NorthwindData.Details.
                GetChanges().OfType<Customer>())
            {
                cust.Details.DiscardChanges();
            }
        }

        partial void UndoAllUpdates_Execute()
        {
            this.DataWorkspace.NorthwindData.Details.DiscardChanges();
        }

        partial void UndoCustomerEdit_Execute()
        {
            Customers.SelectedItem.Details.DiscardChanges();
        }