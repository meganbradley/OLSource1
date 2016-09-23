        partial void Orders_Inserting(Order1 entity)
        {
            foreach (Order_Detail1 detail in entity.Order_Details)
            {
                detail.Product.UnitsInStock = (short?)
                    (detail.Product.UnitsInStock - detail.Quantity);
            }
            this.DataWorkspace.ProductDataSource.SaveChanges();

        }