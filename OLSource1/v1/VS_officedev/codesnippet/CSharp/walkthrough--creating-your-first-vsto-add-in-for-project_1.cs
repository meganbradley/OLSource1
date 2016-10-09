        void Application_NewProject(Microsoft.Office.Interop.MSProject.Project pj)
        {
            MSProject.Task newTask = pj.Tasks.Add
                ("This text was added by using code", missing);
            newTask.Start = DateTime.Now;
            newTask.Duration = "3";
            newTask.ResourceNames = "Rob Caron, Kelly Krout";
        }