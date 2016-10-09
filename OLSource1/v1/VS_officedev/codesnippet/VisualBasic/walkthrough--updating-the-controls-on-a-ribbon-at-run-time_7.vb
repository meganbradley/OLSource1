    Private Sub Button_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs)
        Dim application As Outlook.Application = Globals.ThisAddIn.Application
        Dim inspector As Outlook.Inspector = application.ActiveInspector()
        Dim myMailItem As Outlook.MailItem = CType(inspector.CurrentItem,  _
            Outlook.MailItem)
        Dim myButton As RibbonButton = CType(sender, RibbonButton)
        myMailItem.Subject = "Following up on your order"
        myMailItem.Body = myMailItem.Body + ControlChars.Lf + "* " _
            + myButton.Label
    End Sub