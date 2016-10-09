        private void MyRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            Globals.ThisWorkbook.ActionsPane.Controls.Add(actionsPane1);
            Globals.ThisWorkbook.ActionsPane.Controls.Add(actionsPane2);
            actionsPane1.Hide();
            actionsPane2.Hide();
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = false;

            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(
                this.button1_Click);
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(
                this.button2_Click);
            this.toggleButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(
                this.toggleButton1_Click);


        }