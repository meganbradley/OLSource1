        private void AddCustomXmlPart(string xmlData)
        {
            if (xmlData != null)
            {
                employeeXMLPart = this.CustomXMLParts.SelectByID(employeeXMLPartID);
                if (employeeXMLPart == null)
                {
                    employeeXMLPart = this.CustomXMLParts.Add(xmlData);
                    employeeXMLPart.NamespaceManager.AddNamespace("ns", 
                        @"http://schemas.microsoft.com/vsto/samples");
                    employeeXMLPartID = employeeXMLPart.Id;
                }
            }
        }