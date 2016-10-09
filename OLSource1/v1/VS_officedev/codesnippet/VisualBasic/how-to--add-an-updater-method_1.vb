    Public Shared Sub Update(ByVal contact As Contact)
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim ContactToUpdate As Contact = (From Contacts In dataContext.Contacts.AsEnumerable().Take(20) _
             Where Contacts.ContactID = contact.ContactID _
             Select Contacts).Single()

        With ContactToUpdate
            .FirstName = contact.FirstName
            .LastName = contact.LastName
            .EmailAddress = contact.EmailAddress
            .Phone = contact.Phone
            .EmailPromotion = contact.EmailPromotion
            .NameStyle = contact.NameStyle
            .PasswordHash = contact.PasswordHash
            .PasswordSalt = contact.PasswordSalt
        End With

        dataContext.SubmitChanges()

    End Sub