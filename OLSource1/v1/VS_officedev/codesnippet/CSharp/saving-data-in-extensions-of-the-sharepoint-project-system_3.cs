        private const string UserFilePropertyId = "ContosoCustomUserFileProperty";
        private const string UserFilePropertyDefaultValue = "Default";

        [DisplayName("Custom Project User File Property")]
        [DescriptionAttribute("This property is saved to the .user file.")]
        [DefaultValue(UserFilePropertyDefaultValue)]
        public string CustomUserFileProperty
        {
            get
            {
                string propertyValue = string.Empty;
                
                // Try to get the current value from the .user file; if it does not yet exist, return a default value.
                if (!sharePointProject.ProjectUserFileData.TryGetValue(UserFilePropertyId, out propertyValue))
                {
                    propertyValue = UserFilePropertyDefaultValue; 
                }

                return propertyValue; 
            }
            
            set
            {
                // Do not save the default value.
                if (value != UserFilePropertyDefaultValue)
                {
                    sharePointProject.ProjectUserFileData[UserFilePropertyId] = value;
                }
            }
        }                