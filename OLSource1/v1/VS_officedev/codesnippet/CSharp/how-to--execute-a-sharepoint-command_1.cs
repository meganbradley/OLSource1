        public void Execute(IDeploymentContext context)
        {
            context.Logger.WriteLine("Upgrading solution: " + solutionName, LogCategory.Status);
            context.Project.SharePointConnection.ExecuteCommand("Contoso.Commands.UpgradeSolution",
                solutionFullPath);
        }