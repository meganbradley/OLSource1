        partial void RequiredDate_Validate(EntityValidationResultsBuilder results)
        {
            if (this.RequiredDate < this.OrderDate)
            {
                results.AddEntityError
                    ("Required data cannot be earlier than the order date"); 
            }

        }