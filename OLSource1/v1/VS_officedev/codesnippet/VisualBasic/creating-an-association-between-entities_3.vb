    Public Shared Function ContactToSalesOrderDetail(ByVal contactID As Integer) As IEnumerable(Of SalesOrderDetail)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim orderList As IEnumerable(Of SalesOrderDetail) = _
            From orders In dataContext.SalesOrderHeaders _
            Join orderDetails In dataContext.SalesOrderDetails On _
                orders.SalesOrderID Equals orderDetails.SalesOrderID _
            Where orders.ContactID = contactID _
            Select orderDetails
        Return orderList

    End Function