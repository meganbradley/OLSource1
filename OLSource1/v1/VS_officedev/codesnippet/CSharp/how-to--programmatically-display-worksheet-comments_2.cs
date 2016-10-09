        private void ShowOrHideComments(bool show)
        {
            Excel.Worksheet worksheet = (Excel.Worksheet)Application.ActiveSheet;
            for (int i = 1; i <= worksheet.Comments.Count; i++)
            {
                worksheet.Comments[i].Visible = show;
            }
        }