        partial void Orders_Inserting(Order entity)
        {
            foreach (Order_Detail detail in entity.Order_Details)
            {
                detail.Product.UnitsInStock = 
                    (short?)(detail.Product.UnitsInStock - detail.Quantity);
            }
        }