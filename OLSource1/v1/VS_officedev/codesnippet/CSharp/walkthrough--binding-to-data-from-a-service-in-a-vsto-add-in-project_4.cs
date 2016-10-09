        void richTextContentControl_Entering(object sender, ContentControlEnteringEventArgs e)
        {
            document[0] = new ContentService.requestedDocument();
            document[0].type = ContentService.documentTypes.primary;
            document[0].selector = "Mtps.Xhtml";

            request.contentIdentifier = "ed59e522-dd6e-4c82-8d49-f5dbcfcc950d";
            request.locale = "en-us";
            request.version = "VS.90";
            request.requestedDocuments = document;

            response = proxy.GetContent(appId, request);
            primaryDocumentsBindingSource.DataSource =
                response.primaryDocuments[0].Any.InnerText;
            richTextContentControl.DataBindings.Add("Text",
                primaryDocumentsBindingSource.DataSource, "", true,
                System.Windows.Forms.DataSourceUpdateMode.OnValidation);
        }