    Private Sub ThisAddIn_Startup(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Startup

        myUserControl1 = New MyUserControl
        myCustomTaskPane = Me.CustomTaskPanes.Add(myUserControl1, "Calendar")
        myCustomTaskPane.Visible = True
    End Sub