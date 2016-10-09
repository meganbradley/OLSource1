        void InspectorWrapper_Close()
        {
            if (taskPane != null)
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(taskPane);
            }

            taskPane = null;
            Globals.ThisAddIn.InspectorWrappers.Remove(inspector);
            ((Outlook.InspectorEvents_Event)inspector).Close -=
                new Outlook.InspectorEvents_CloseEventHandler(InspectorWrapper_Close);
            inspector = null;
        }