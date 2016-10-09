        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = true;
            actionsPane2.Hide();
            actionsPane1.Show();
            toggleButton1.Checked = false;
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = true;
            actionsPane1.Hide();
            actionsPane2.Show();
            toggleButton1.Checked = false;

        }

        private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
        {
            if (toggleButton1.Checked == true)
            {
                Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = false;
            }
            else
            {
                Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = true;
            }

        }