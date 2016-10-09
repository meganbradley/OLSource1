    Public Shared Sub Delete(ByVal salesOrderID As Integer, ByVal salesOrderDetailID As Integer)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim SalesOrderDetail As SalesOrderDetail = _
            (From SalesOrderDetails In dataContext.SalesOrderDetails.AsEnumerable().Take(20) _
            Where SalesOrderDetails.SalesOrderID = salesOrderID And _
                  SalesOrderDetails.SalesOrderDetailID = salesOrderDetailID _
            Select SalesOrderDetails).Single()

        dataContext.SalesOrderDetails.DeleteOnSubmit(SalesOrderDetail)
        dataContext.SubmitChanges()

    End Sub