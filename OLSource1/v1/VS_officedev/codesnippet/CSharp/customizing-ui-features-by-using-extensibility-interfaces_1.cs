    public class TaskPaneHelper : Office.ICustomTaskPaneConsumer
    {
        internal Office.CustomTaskPane taskPane;

        public void CTPFactoryAvailable(Office.ICTPFactory CTPFactoryInst)
        {
            if (CTPFactoryInst != null)
            {
                // Create a new task pane.
                taskPane = CTPFactoryInst.CreateCTP(
                    "Microsoft.Samples.Vsto.CS.TaskPaneUI",
                    "Contoso");
                taskPane.Visible = true;
            }
        }
    }

    [System.Runtime.InteropServices.ComVisible(true)]
    [System.Runtime.InteropServices.ProgId("Microsoft.Samples.Vsto.CS.TaskPaneUI")]
    [System.Runtime.InteropServices.Guid("FFA0920E-F7A5-453d-8AB2-249F4C25B4B2")]
    public class TaskPaneUI : UserControl
    {
    }