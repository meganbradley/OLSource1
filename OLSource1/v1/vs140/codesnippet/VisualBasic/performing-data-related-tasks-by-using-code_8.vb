        Private Sub Orders_Inserting(entity As Order1)
            For Each detail In entity.Order_Details
                detail.Product.UnitsInStock = detail.Product.UnitsInStock - detail.Quantity
            Next
            Me.DataWorkspace.ProductDataSource.SaveChanges()

        End Sub