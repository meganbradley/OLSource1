            object start = 0;
            object end = 0;
            Word.Range tableLocation = this.Range(ref start, ref end);
            this.Tables.Add(tableLocation, 3, 4);