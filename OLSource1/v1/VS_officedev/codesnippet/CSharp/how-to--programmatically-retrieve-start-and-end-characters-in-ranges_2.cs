            Word.Range rng = this.Application.ActiveDocument.Sentences[2];

            string startPosition = rng.Start.ToString();
            string endPosition = rng.End.ToString();

            MessageBox.Show("Start: " + startPosition + " End: " + endPosition, "Range Information");