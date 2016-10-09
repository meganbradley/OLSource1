    Public Shared Function Create(ByVal newContact As Contact) As Contact
        Const ServerName As String = "MySQLServerName"
        Dim dataContext As AdventureWorksDataContext = _
            New AdventureWorksDataContext("Data Source=" & ServerName & _
                ";Initial Catalog=AdventureWorks;Integrated Security=True")

        Dim TempContact As New Contact()

        With TempContact
            .FirstName = newContact.FirstName
            .LastName = newContact.LastName
            .EmailAddress = newContact.EmailAddress
            .Phone = newContact.Phone
            .EmailPromotion = newContact.EmailPromotion
            .NameStyle = newContact.NameStyle
            .PasswordHash = newContact.PasswordHash
            .PasswordSalt = newContact.PasswordSalt
            .ModifiedDate = DateTime.Now
            .rowguid = Guid.NewGuid()
        End With

        dataContext.Contacts.InsertOnSubmit(TempContact)
        dataContext.SubmitChanges()
        Return TempContact

    End Function