        internal TaskPaneHelper taskPaneHelper1;

        protected override object RequestService(Guid serviceGuid)
        {
            if (serviceGuid == typeof(Office.ICustomTaskPaneConsumer).GUID)
            {
                if (taskPaneHelper1 == null)
                {
                    taskPaneHelper1 = new TaskPaneHelper();
                }
                return taskPaneHelper1;
            }

            return base.RequestService(serviceGuid);
        }