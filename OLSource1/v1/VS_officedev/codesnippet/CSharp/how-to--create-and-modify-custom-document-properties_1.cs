        void TestProperties()
        {
            Microsoft.Office.Core.DocumentProperties properties;
            properties = (Office.DocumentProperties)this.CustomDocumentProperties;

            if (ReadDocumentProperty("Project Name") != null)
            {
                properties["Project Name"].Delete();
            }

            properties.Add("Project Name", false,
                Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString,
                "White Papers");
        }

        private string ReadDocumentProperty(string propertyName)
        {
            Office.DocumentProperties properties;
            properties = (Office.DocumentProperties)this.CustomDocumentProperties;

            foreach (Office.DocumentProperty prop in properties)
            {
                if (prop.Name == propertyName)
                {
                    return prop.Value.ToString();
                }
            }
            return null;
        }