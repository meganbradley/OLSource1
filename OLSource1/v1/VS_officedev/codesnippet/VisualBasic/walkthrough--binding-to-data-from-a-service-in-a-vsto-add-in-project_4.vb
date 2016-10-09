    Private Sub richTextContentControl_Entering _
        (ByVal sender As Object, ByVal e As ContentControlEnteringEventArgs) _
        Handles richTextContentControl.Entering

        document(0) = New ContentService.requestedDocument()
        With document(0)
            .type = ContentService.documentTypes.primary
            .selector = "Mtps.Xhtml"
        End With

        With request
            .contentIdentifier = "ed59e522-dd6e-4c82-8d49-f5dbcfcc950d"
            .locale = "en-us"
            .version = "VS.90"
            .requestedDocuments = document
        End With

        response = proxy.GetContent(appId, request)

        primaryDocumentsBindingSource.DataSource = _
            response.primaryDocuments(0).Any.InnerText
        richTextContentControl.DataBindings.Add("Text", _
            primaryDocumentsBindingSource.DataSource, "", True, _
            System.Windows.Forms.DataSourceUpdateMode.OnValidation)
    End Sub