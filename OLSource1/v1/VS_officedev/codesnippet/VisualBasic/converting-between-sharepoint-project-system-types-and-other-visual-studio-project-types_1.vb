    Private Sub projectService_ProjectAdded(ByVal sender As Object, _
        ByVal e As Microsoft.VisualStudio.SharePoint.SharePointProjectEventArgs)

        Dim dteProject As EnvDTE.Project = e.Project.ProjectService.Convert( _
            Of Microsoft.VisualStudio.SharePoint.ISharePointProject, EnvDTE.Project)(e.Project)
        If dteProject IsNot Nothing Then
            ' Use the Visual Studio automation object model to add a folder to the project.
            dteProject.ProjectItems.AddFolder("Data")
        End If
    End Sub