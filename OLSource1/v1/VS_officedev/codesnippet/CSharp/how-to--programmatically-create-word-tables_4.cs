            Word.Range tableLocation = 
                this.Application.ActiveDocument.Range(0, 0);
            this.Application.ActiveDocument.Tables.Add(
                tableLocation, 3, 4);