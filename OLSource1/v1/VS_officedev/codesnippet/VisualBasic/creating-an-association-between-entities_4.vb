    Public Shared Function SalesOrderDetailToContact(ByVal salesOrderID As Integer, ByVal salesOrderDetailID As Integer) As IEnumerable(Of Contact)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim TempContactID As Integer = _
            (From orders In dataContext.SalesOrderHeaders _
            Where orders.SalesOrderID = salesOrderID _
            Select orders.ContactID).[Single]()

        Dim contactList As IEnumerable(Of Contact) = _
            From contacts In dataContext.Contacts _
            Where contacts.ContactID = TempContactID _
            Select contacts
        Return contactList

    End Function