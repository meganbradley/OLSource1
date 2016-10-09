        private void AddCustomXmlPartToActiveDocument(Word.Document document)
        {
            string xmlString =
                "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
                "<employees xmlns=\"http://schemas.microsoft.com/vsto/samples\">" +
                    "<employee>" +
                        "<name>Karina Leal</name>" +
                        "<hireDate>1999-04-01</hireDate>" +
                        "<title>Manager</title>" +
                    "</employee>" +
                "</employees>";

            Office.CustomXMLPart employeeXMLPart = document.CustomXMLParts.Add(xmlString, missing);
        }