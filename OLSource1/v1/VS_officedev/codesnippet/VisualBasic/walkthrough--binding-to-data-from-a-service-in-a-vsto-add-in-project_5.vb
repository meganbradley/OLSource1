    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        AddRichTextControlAtRange()
        InitializeServiceObjects()
    End Sub