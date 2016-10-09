        public string GetCustomUI(string ribbonID)
        {
            string ribbonXML = String.Empty;

            if (ribbonID == "Microsoft.InfoPath.Designer")
            {
                ribbonXML = GetResourceText("MyInfoPathProject.Ribbon.xml");
            }

            return ribbonXML;
        }