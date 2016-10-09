    Private Sub UntrustedCode()
        Dim application As New Microsoft.Office.Interop.Outlook.Application
        Dim mailItem1 As Microsoft.Office.Interop.Outlook.MailItem = _
            TryCast(application.CreateItem( _
            Microsoft.Office.Interop.Outlook.OlItemType.olMailItem),  _
            Microsoft.Office.Interop.Outlook.MailItem)
        mailItem1.To = "someone@example.com"
        MessageBox.Show(mailItem1.To)
    End Sub