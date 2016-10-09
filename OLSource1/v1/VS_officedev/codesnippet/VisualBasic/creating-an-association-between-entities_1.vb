    Public Shared Function ContactToSalesOrder(ByVal contactID As Integer) As IEnumerable(Of SalesOrderHeader)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim orderList As IEnumerable(Of SalesOrderHeader) = _
            From orders In dataContext.SalesOrderHeaders _
            Where orders.ContactID = contactID _
                  Select orders
        Return orderList

    End Function