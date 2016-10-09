        private void ReplaceParagraphText()
        {
            Word.Document document = this.Application.ActiveDocument;
            Word.Range firstRange = document.Paragraphs[1].Range;
            Word.Range secondRange = document.Paragraphs[2].Range;

            string firstString = firstRange.Text;
            string secondString = secondRange.Text;

            firstRange.Text = secondString;
            secondRange.Text = firstString;

            firstRange.Select();
            MessageBox.Show(firstRange.Text);
            secondRange.Select();
            MessageBox.Show(secondRange.Text);

            object charUnit = Word.WdUnits.wdCharacter;
            object move = -1;  // move left 1

            firstRange.MoveEnd(ref charUnit, ref move);

            firstRange.Text = "New content for paragraph 1.";
            secondRange.Text = "New content for paragraph 2.";

            firstRange.Select();
            MessageBox.Show(firstRange.Text);
            secondRange.Select();
            MessageBox.Show(secondRange.Text);

            move = 1;  // move right 1
            firstRange.MoveEnd(ref charUnit, ref move);

            secondRange.Delete(ref missing, ref missing);

            firstRange.Text = firstString;

            firstRange.InsertAfter(secondString);
            firstRange.Select();
        }