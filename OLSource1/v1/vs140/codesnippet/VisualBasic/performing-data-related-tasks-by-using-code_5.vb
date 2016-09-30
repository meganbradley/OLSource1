        Private Sub Orders_Inserting(entity As Order)
            For Each detail In entity.Order_Details
                detail.Product.UnitsInStock =
                    detail.Product.UnitsInStock - detail.Quantity
            Next
        End Sub