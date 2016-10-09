        [Personalizable(PersonalizationScope.Shared), WebBrowsable(true),
        WebDisplayName("Path to Employee Data File"),
        WebDescription("Location of the XML file that contains employee data")]
        public string DataFilePath
        {
            get
            {
                return xmlFilePath;
            }
            set
            {
                xmlFilePath = value;
            }
        }