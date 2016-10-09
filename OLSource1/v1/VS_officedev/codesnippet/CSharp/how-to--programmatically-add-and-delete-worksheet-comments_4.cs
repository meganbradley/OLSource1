            Excel.Range dateComment = this.Application.get_Range("A1");
            if (dateComment.Comment != null)
            {
                dateComment.Comment.Delete();
            }