            Word.Range rng = this.Sentences[2];

            string startPosition = rng.Start.ToString();
            string endPosition = rng.End.ToString();

            MessageBox.Show("Start: " + startPosition + " End: " + endPosition, "Range Information");