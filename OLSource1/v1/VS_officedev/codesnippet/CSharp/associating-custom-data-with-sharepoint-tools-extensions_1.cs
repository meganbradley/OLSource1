        void projectItemTypeDefinition_ProjectItemPropertiesRequested(object sender, 
            SharePointProjectItemPropertiesRequestedEventArgs e)
        {
            CustomProperties property;

            // If the properties object already exists, get it from the project item's annotations.
            if (!e.ProjectItem.Annotations.TryGetValue(out property))
            {
                // Otherwise, create a new properties object and add it to the annotations.
                property = new CustomProperties(e.ProjectItem);
                e.ProjectItem.Annotations.Add(property);
            }

            e.PropertySources.Add(property);
        }