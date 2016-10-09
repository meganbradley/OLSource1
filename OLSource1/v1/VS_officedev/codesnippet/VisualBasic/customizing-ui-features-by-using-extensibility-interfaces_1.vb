Public Class TaskPaneHelper
    Implements Office.ICustomTaskPaneConsumer

    Friend taskPane As Office.CustomTaskPane

    Public Sub CTPFactoryAvailable(ByVal CTPFactoryInst As Office.ICTPFactory) _
        Implements Office.ICustomTaskPaneConsumer.CTPFactoryAvailable

        If CTPFactoryInst IsNot Nothing Then
            ' Create a new task pane.
            taskPane = CTPFactoryInst.CreateCTP( _
                "Microsoft.Samples.Vsto.VB.TaskPaneUI", "Contoso")
            taskPane.Visible = True
        End If
    End Sub
End Class

<System.Runtime.InteropServices.ComVisible(True)> _
<System.Runtime.InteropServices.ProgId("Microsoft.Samples.Vsto.VB.TaskPaneUI")> _
<System.Runtime.InteropServices.Guid("FFA0920E-F7A5-453d-8AB2-249F4C25B4B2")> _
Public Class TaskPaneUI
    Inherits UserControl
End Class