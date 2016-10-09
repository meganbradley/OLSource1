            Microsoft.VisualStudio.Shell.ServiceProvider serviceProvider =
                new Microsoft.VisualStudio.Shell.ServiceProvider(
                _applicationObject as Microsoft.VisualStudio.OLE.Interop.IServiceProvider);

            Microsoft.VisualStudio.SharePoint.ISharePointProjectService projectService = 
                serviceProvider.GetService(typeof(Microsoft.VisualStudio.SharePoint.ISharePointProjectService))
                as Microsoft.VisualStudio.SharePoint.ISharePointProjectService;

            if (projectService != null)
            {
                projectService.Logger.WriteLine("This message was written by using the SharePoint project service.",
                    Microsoft.VisualStudio.SharePoint.LogCategory.Message);
            }