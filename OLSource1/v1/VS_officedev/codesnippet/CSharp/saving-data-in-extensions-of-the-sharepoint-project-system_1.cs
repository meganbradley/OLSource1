        private const string PropertyId = "Contoso.ExampleProperty";
        private const string PropertyDefaultValue = "This is an example property.";

        [DisplayName("Example Property")]
        [DescriptionAttribute("This is an example property for project items.")]
        [DefaultValue(PropertyDefaultValue)]
        public string ExampleProperty
        {
            get
            {
                string propertyValue;

                // Get the current property value if it already exists; otherwise, return a default value.
                if (!projectItem.ExtensionData.TryGetValue(PropertyId, out propertyValue))
                {
                    propertyValue = PropertyDefaultValue;
                }
                return propertyValue;
            }
            set
            {
                if (value != PropertyDefaultValue)
                {
                    // Store the property value in the ExtensionData property of the project item. 
                    // Data in the ExtensionData property persists when the project is closed.
                    projectItem.ExtensionData[PropertyId] = value;
                }
                else
                {
                    // Do not save the default value.
                    projectItem.ExtensionData.Remove(PropertyId);
                }
            }
        }