        private void InitializeServiceObjects()
        {
            request = new ContentService.getContentRequest();
            proxy = new ContentService.ContentServicePortTypeClient();
            document = new ContentService.requestedDocument[1];
            response = new ContentService.getContentResponse();
            appId = new ContentService.appId();
            components = new System.ComponentModel.Container();
            primaryDocumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
        }