        Private Sub TopNSalesOrders_PreprocessQuery _
            (ByVal TopN As System.Nullable(Of Short), _
             ByRef query As System.Linq.IQueryable(Of LS_Queries_VB.Customer))
            query = From myCustomer In query
                   Where myCustomer.Orders.Count > 0
                   Select myCustomer
                   Order By myCustomer.Orders.Count Descending
                   Take (TopN)
        End Sub