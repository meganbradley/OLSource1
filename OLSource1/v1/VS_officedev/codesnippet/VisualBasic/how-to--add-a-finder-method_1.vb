    Public Shared Function ReadList() As IEnumerable(Of Contact)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim Contacts As IEnumerable(Of Contact) = _
            From TempContacts In dataContext.Contacts.Take(20) _
                  Select TempContacts
        Return Contacts
    End Function