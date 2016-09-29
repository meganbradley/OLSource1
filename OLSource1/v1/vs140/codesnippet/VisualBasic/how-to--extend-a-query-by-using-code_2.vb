        Private Sub CustomersWhoBoughtProduct_PreprocessQuery _
            (ByVal ProductID As System.Nullable(Of Short), _
             ByRef query As System.Linq.IQueryable(Of LS_Queries_VB.Customer))
            query = From myCustomers In query
                From myOrders In myCustomers.Orders
                From myOrderDetails In myOrders.Order_Details
                Where myOrderDetails.Product.ProductID = ProductID
                Select Customers
        End Sub