        // Ensure that the schema is in the library and registered with the document.
        private bool CheckSchema()
        {
            const string namespaceUri = "http://schemas.contoso.com/projects";
            bool namespaceFound = false;
            bool namespaceRegistered = false;

            foreach (Word.XMLNamespace n in Application.XMLNamespaces)
            {
                if (n.URI == namespaceUri)
                {
                    namespaceFound = true;
                }
            }

            if (!namespaceFound)
            {
                MessageBox.Show("XML Schema is not in library.");
                return false;
            }

            foreach (Word.XMLSchemaReference r in this.XMLSchemaReferences) 
            {
                if (r.NamespaceURI == namespaceUri)
                {
                    namespaceRegistered = true;
                }
            }

            if (!namespaceRegistered)
            {
                MessageBox.Show("XML Schema is not registered for this document.");
                return false;
            }
            
            return true;
        }