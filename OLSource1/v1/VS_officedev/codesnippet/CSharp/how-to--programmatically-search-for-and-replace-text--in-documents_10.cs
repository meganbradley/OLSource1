        private void RangeFind()
        {
            object findText = "find me";

            Word.Document document = this.Application.ActiveDocument;
            Word.Range rng = document.Paragraphs[2].Range;

            rng.Find.ClearFormatting();

            if (rng.Find.Execute(ref findText,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing))
            {
                MessageBox.Show("Text found.");
            }
            else
            {
                MessageBox.Show("Text not found.");
            }

            rng.Select();
        }