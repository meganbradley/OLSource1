        void Inspectors_NewInspector(Outlook.Inspector Inspector)
        {
            if (Inspector.CurrentItem is Outlook.MailItem)
            {
                inspectorWrappersValue.Add(Inspector, new InspectorWrapper(Inspector));
            }
        }