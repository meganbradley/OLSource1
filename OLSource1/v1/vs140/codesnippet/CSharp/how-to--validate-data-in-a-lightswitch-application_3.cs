        partial void Customers_Validate(ScreenValidationResultsBuilder results)
        {
            if (this.DataWorkspace.NorthwindData.Details.HasChanges)
            {
                EntityChangeSet changeSet =
                this.DataWorkspace.NorthwindData.Details.GetChanges();
                foreach (IEntityObject entity in changeSet.DeletedEntities.OfType<Customer>())
                {
                    Customer cust = (Customer)entity;
                    if (cust.Country == "USA")
                    {
                        entity.Details.DiscardChanges();
                        results.AddScreenResult("Unable to remove this customer. " +
                        "Cannot delete customers that are located in the USA.",
                        ValidationSeverity.Informational);
                    }
                }
            }

        }