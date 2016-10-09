            Word.Document document = this.Application.ActiveDocument;
            Word.Range firstRange = document.Paragraphs[1].Range;
            Word.Range secondRange = document.Paragraphs[2].Range;

            string firstString = firstRange.Text;
            string secondString = secondRange.Text;