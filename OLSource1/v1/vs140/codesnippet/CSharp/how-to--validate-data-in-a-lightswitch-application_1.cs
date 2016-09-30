        partial void ShippedDate_Validate(EntityValidationResultsBuilder results)
        {
            if (this.ShippedDate > DateTime.Today)
            {
                results.AddPropertyError("Shipped date cannot be later than today");
            }

        }