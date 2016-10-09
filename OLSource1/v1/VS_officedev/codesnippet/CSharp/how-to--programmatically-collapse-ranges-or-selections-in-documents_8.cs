            Word.Range rng = this.Application.ActiveDocument.Paragraphs[1].Range;

            rng.Collapse(Word.WdCollapseDirection.wdCollapseStart);

            rng.Text = " New Text ";
            rng.Select();