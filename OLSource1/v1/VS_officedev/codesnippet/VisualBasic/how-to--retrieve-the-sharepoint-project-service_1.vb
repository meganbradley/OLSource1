    <Export(GetType(ISharePointProjectExtension))> _
    Friend Class GetServiceInProject
        Implements ISharePointProjectExtension

        Private Sub Initialize(ByVal projectService As ISharePointProjectService) _
            Implements ISharePointProjectExtension.Initialize
            projectService.Logger.WriteLine("This message was written by using the " & _
                "project service in a project extension.", LogCategory.Message)
        End Sub
    End Class