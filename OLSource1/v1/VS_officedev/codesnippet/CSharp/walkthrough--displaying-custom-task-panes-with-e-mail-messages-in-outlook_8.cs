        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            inspectors = this.Application.Inspectors;
            inspectors.NewInspector +=
                new Outlook.InspectorsEvents_NewInspectorEventHandler(
                Inspectors_NewInspector);

            foreach (Outlook.Inspector inspector in inspectors)
            {
                Inspectors_NewInspector(inspector);
            }
        }