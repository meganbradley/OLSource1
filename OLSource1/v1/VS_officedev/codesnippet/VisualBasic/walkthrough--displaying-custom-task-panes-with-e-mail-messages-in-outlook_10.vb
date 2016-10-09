    Sub Inspectors_NewInspector(ByVal Inspector As Outlook.Inspector) _
        Handles inspectors.NewInspector

        If TypeOf Inspector.CurrentItem Is Outlook.MailItem Then
            inspectorWrappersValue.Add(Inspector, New InspectorWrapper(Inspector))
        End If
    End Sub