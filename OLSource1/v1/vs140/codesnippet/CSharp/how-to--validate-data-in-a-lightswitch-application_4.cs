        partial void Orders_Validate
            (Order entity, EntitySetValidationResultsBuilder results)
        {
            if (!CustomerCreditApproval(entity.Customer))
            {
                results.AddEntityError
                    ("Customer Credit has not yet been approved");
            }
        }

        private bool CustomerCreditApproval(Customer entity)
        {
            //Some custom code to check the customer's credit status.
            return true;
        }
