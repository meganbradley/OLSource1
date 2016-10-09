        private void SelectionFind() 
        { 
            object findText = "find me";

            Application.Selection.Find.ClearFormatting();

            if (Application.Selection.Find.Execute(ref findText,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, 
                ref missing, ref missing)) 
            { 
                MessageBox.Show("Text found.");
            } 
            else
            { 
                MessageBox.Show("The text could not be located.");
            } 
        }