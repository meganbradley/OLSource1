            this.Application.DocumentBeforeSave += 
                new Word.ApplicationEvents4_DocumentBeforeSaveEventHandler(
                Application_DocumentBeforeSave);