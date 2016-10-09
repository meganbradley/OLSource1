        private void ShowOrHideComments(bool show)
        {
            for (int i = 1; i <= this.Comments.Count; i++)
            {
                this.Comments[i].Visible = show;
            }
        }