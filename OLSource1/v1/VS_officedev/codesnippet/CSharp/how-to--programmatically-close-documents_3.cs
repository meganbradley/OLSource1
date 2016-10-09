            Word._Document doc = Application.Documents["NewDocument.docx"] as Word._Document;
            doc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);