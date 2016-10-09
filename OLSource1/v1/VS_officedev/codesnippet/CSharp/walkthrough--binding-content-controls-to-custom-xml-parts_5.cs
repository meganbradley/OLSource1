            string xmlData = GetXmlFromResource();

            if (xmlData != null)
            {
                AddCustomXmlPart(xmlData);
                BindControlsToCustomXmlPart();
            }