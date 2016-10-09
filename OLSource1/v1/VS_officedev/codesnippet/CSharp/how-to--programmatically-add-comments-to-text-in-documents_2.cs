            object text = "Add a comment to the first paragraph.";
            this.Application.ActiveDocument.Comments.Add(
                this.Application.ActiveDocument.Paragraphs[1].Range, ref text);