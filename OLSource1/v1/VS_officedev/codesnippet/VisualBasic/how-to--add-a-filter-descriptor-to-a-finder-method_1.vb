    Public Shared Function ReadList(ByVal OrderDateParam As DateTime) As IEnumerable(Of SalesOrderHeader)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim NoValuePassedIn As DateTime = Convert.ToDateTime("1/1/1900 12:00:00 AM")
        Dim DefaultDateTime As DateTime = Convert.ToDateTime("2001-09-01 00:00:00.000")

        ' If the user does not provide a value for the filter.
        If OrderDateParam = NoValuePassedIn Then
            ' Use a default date time value.
            OrderDateParam = DefaultDateTime
        End If

        Dim SalesOrderHeader As IEnumerable(Of SalesOrderHeader) = _
            From SalesOrderHeaders In dataContext.SalesOrderHeaders _
            Where SalesOrderHeaders.OrderDate = OrderDateParam _
            Select SalesOrderHeaders
        Return SalesOrderHeader
    End Function