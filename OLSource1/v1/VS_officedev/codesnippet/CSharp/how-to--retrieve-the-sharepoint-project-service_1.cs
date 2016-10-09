    [Export(typeof(ISharePointProjectExtension))]
    internal class GetServiceInProject : ISharePointProjectExtension
    {
        public void Initialize(ISharePointProjectService projectService)
        {
            projectService.Logger.WriteLine("This message was written by using the " +
                "project service in a project extension.", LogCategory.Message);
        }
    }