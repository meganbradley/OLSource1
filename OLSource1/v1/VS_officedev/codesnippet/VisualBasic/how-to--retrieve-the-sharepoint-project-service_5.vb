        Dim serviceProvider As Microsoft.VisualStudio.Shell.ServiceProvider = _
            New Microsoft.VisualStudio.Shell.ServiceProvider( _
                TryCast(_applicationObject, Microsoft.VisualStudio.OLE.Interop.IServiceProvider))

        Dim projectService As Microsoft.VisualStudio.SharePoint.ISharePointProjectService = _
            TryCast(serviceProvider.GetService(GetType(Microsoft.VisualStudio.SharePoint.ISharePointProjectService)), _
                Microsoft.VisualStudio.SharePoint.ISharePointProjectService)

        If projectService IsNot Nothing Then
            projectService.Logger.WriteLine("This message was written by using the SharePoint project service.", _
                Microsoft.VisualStudio.SharePoint.LogCategory.Message)
        End If