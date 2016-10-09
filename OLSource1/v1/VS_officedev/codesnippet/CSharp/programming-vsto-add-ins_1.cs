        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.DocumentOpen +=
    new Word.ApplicationEvents4_DocumentOpenEventHandler(WorkWithDocument);

            ((Word.ApplicationEvents4_Event)this.Application).NewDocument +=
                new Word.ApplicationEvents4_NewDocumentEventHandler(WorkWithDocument);  
        }
        
        private void WorkWithDocument(Microsoft.Office.Interop.Word.Document Doc)
        {
            try
            {
                Word.Range rng = Doc.Range(0, 0);
                rng.Text = "New Text";
                rng.Select();
            }
            catch (Exception ex)
            {
                // Handle exception if for some reason the document is not available.
            }
        }