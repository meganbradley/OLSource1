        public InspectorWrapper(Outlook.Inspector Inspector)
        {
            inspector = Inspector;
            ((Outlook.InspectorEvents_Event)inspector).Close +=
                new Outlook.InspectorEvents_CloseEventHandler(InspectorWrapper_Close);
            
            taskPane = Globals.ThisAddIn.CustomTaskPanes.Add(
                new TaskPaneControl(), "My task pane", inspector);
            taskPane.VisibleChanged += new EventHandler(TaskPane_VisibleChanged);
        }