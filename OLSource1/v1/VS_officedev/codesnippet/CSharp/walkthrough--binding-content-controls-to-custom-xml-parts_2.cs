        private string GetXmlFromResource()
        {
            System.Reflection.Assembly asm =
                System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream stream1 = asm.GetManifestResourceStream(
                "EmployeeControls.employees.xml");

            using (System.IO.StreamReader resourceReader =
                    new System.IO.StreamReader(stream1))
            {
                if (resourceReader != null)
                {
                    return resourceReader.ReadToEnd();
                }
            }

            return null;
        }