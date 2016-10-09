        void projectService_ProjectAdded(object sender, Microsoft.VisualStudio.SharePoint.SharePointProjectEventArgs e)
        {
            EnvDTE.Project dteProject = e.Project.ProjectService.Convert<
                Microsoft.VisualStudio.SharePoint.ISharePointProject, EnvDTE.Project>(e.Project);

            if (dteProject != null)
            {
                // Use the Visual Studio automation object model to add a folder to the project.
                dteProject.ProjectItems.AddFolder("Data");
            }
        }