        private Word.Document document1 = null;

        private void CreateDocument1()
        {
            document1 = this.Application.Documents.Add(ref missing,
                ref missing, ref missing, ref missing);
            this.Application.DocumentBeforeSave += 
                new Word.ApplicationEvents4_DocumentBeforeSaveEventHandler(
                Application_DocumentBeforeSave);
        }

        private void Application_DocumentBeforeSave(Word.Document Doc, 
            ref bool SaveAsUI, ref bool Cancel)
        {
            if (Type.ReferenceEquals(Doc, document1)) 
            {
                Cancel = true;
            }
        }