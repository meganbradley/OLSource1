        private ISharePointProject sharePointProject;
        private IVsBuildPropertyStorage projectStorage;
        private const string ProjectFilePropertyId = "ContosoCustomProjectFileProperty";
        private const string ProjectFilePropertyDefaultValue = "Default";

        public CustomProjectProperties(ISharePointProject myProject)
        {
            sharePointProject = myProject;
            projectStorage = sharePointProject.ProjectService.Convert<ISharePointProject, IVsBuildPropertyStorage>(sharePointProject);
        }

        [DisplayName("Custom Project File Property")]
        [DescriptionAttribute("This property is saved to the .csproj/.vbproj file.")]
        [DefaultValue(ProjectFilePropertyDefaultValue)]
        public string CustomProjectFileProperty
        {
            get
            {
                string propertyValue;
                int hr = projectStorage.GetPropertyValue(ProjectFilePropertyId, string.Empty, 
                    (uint)_PersistStorageType.PST_PROJECT_FILE, out propertyValue);

                // Try to get the current value from the project file; if it does not yet exist, return a default value.
                if (!ErrorHandler.Succeeded(hr) || String.IsNullOrEmpty(propertyValue))
                {
                    propertyValue = ProjectFilePropertyDefaultValue;
                }

                return propertyValue;
            }

            set
            {
                // Do not save the default value.
                if (value != ProjectFilePropertyDefaultValue)
                {
                    projectStorage.SetPropertyValue(ProjectFilePropertyId, string.Empty, 
                        (uint)_PersistStorageType.PST_PROJECT_FILE, value);
                }
            }
        }