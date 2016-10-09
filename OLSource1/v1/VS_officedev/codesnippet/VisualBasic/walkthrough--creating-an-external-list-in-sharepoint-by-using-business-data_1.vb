    Public Shared Function ReadItem(ByVal contactID As Integer) As Contact
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim Contact As Contact = _
            (From TempContacts In dataContext.Contacts.AsEnumerable().Take(20) _
            Where TempContacts.ContactID = contactID _
            Select TempContacts).[Single]()
        Return Contact
    End Function