        Private Sub Good_Customer_Discount2(ByVal entity As Order_Detail)
            Dim query As IDataServiceQueryable(Of Customer)
            query = From mycustomer In Me.DataWorkspace.NorthwindData.TopNSalesOrders(10)
                    Where mycustomer.CustomerID = entity.Order.Customer.CustomerID
                    Select mycustomer

            If Not IsNothing(query.SingleOrDefault) Then
                entity.Discount = 0.01
            End If

        End Sub