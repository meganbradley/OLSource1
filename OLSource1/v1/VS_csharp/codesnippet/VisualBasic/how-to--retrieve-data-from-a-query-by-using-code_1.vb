        Private Sub Good_Customer_Discount(ByVal entity As Order_Detail)
            For Each cust As Customer In _
                Me.DataWorkspace.NorthwindData.TopNSalesOrders(10)
                If cust.CustomerID = entity.Order.Customer.CustomerID Then
                    entity.Discount = 0.1
                End If
            Next

        End Sub