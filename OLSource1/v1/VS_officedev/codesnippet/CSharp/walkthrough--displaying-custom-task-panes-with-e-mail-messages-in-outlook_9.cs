        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            inspectors.NewInspector -=
                new Outlook.InspectorsEvents_NewInspectorEventHandler(
                Inspectors_NewInspector);
            inspectors = null;
            inspectorWrappersValue = null;
        }