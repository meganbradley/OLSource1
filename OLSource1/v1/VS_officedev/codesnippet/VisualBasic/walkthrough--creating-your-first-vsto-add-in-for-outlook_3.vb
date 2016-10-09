    Private Sub inspectors_NewInspector(ByVal Inspector As Microsoft.Office.Interop.Outlook.Inspector) Handles inspectors.NewInspector
        Dim mailItem As Outlook.MailItem = TryCast(Inspector.CurrentItem, Outlook.MailItem)
        If Not (mailItem Is Nothing) Then
            If mailItem.EntryID Is Nothing Then
                mailItem.Subject = "This text was added by using code"
                mailItem.Body = "This text was added by using code"
            End If
        End If
    End Sub