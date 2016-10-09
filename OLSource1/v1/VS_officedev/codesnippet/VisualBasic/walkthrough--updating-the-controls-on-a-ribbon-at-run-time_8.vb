    Private Sub PopulateMailItem(ByVal addressToLine As String)
        Dim application As Outlook.Application = Globals.ThisAddIn.Application
        Dim inspector As Outlook.Inspector = application.ActiveInspector()
        Dim myMailItem As Outlook.MailItem = _
            CType(inspector.CurrentItem, Outlook.MailItem)

        myMailItem.To = ""
        Dim tempArray As [String]() = addressToLine.Split(New [Char]() {"|"c})
        myMailItem.To = tempArray(1) + "@example.com"
        myMailItem.Subject = "Following up on your order"
        myMailItem.Body = "Hello " + tempArray(1) + "," _
            + ControlChars.Lf + "We would like to get your feedback" + _
            "on the following products that you recently ordered: "
    End Sub