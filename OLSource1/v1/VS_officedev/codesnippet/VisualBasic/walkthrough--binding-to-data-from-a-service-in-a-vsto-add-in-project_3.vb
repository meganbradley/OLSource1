    Private Sub InitializeServiceObjects()
        request = New ContentService.getContentRequest()
        proxy = New ContentService.ContentServicePortTypeClient()
        document = New ContentService.requestedDocument(0) {}
        response = New ContentService.getContentResponse()
        appId = New ContentService.appId()
        components = New System.ComponentModel.Container()
        primaryDocumentsBindingSource = New System.Windows.Forms.BindingSource(components)
    End Sub