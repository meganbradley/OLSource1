        [SharePointCommand("Contoso.Commands.UpgradeSolution")]
        private void UpgradeSolution(ISharePointCommandContext context, string fullWspPath)
        {
            SPSolution solution = SPFarm.Local.Solutions[Path.GetFileName(fullWspPath)];

            if (solution == null)
            {
                throw new InvalidOperationException("The solution has not been deployed.");
            }

            solution.Upgrade(fullWspPath);
        }