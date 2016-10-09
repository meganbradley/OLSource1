        private void BindControlsToCustomXmlPart()
        {
            string xPathName = "ns:employees/ns:employee/ns:name";
            this.plainTextContentControl1.XMLMapping.SetMapping(xPathName,
                prefix, employeeXMLPart);

            string xPathDate = "ns:employees/ns:employee/ns:hireDate";
            this.datePickerContentControl1.DateDisplayFormat = "MMMM d, yyyy";
            this.datePickerContentControl1.XMLMapping.SetMapping(xPathDate,
                prefix, employeeXMLPart);

            string xPathTitle = "ns:employees/ns:employee/ns:title";
            this.dropDownListContentControl1.XMLMapping.SetMapping(xPathTitle,
                prefix, employeeXMLPart);
        }