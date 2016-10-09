            string documentPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop) + @"\WordDocument1.docx";
            int runtimeVersion = 0;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                // Make sure that this document does not yet have any Visual Studio Tools 
                // for Office customizations.
                if (runtimeVersion == 0)
                {
                    string deployManifestPath = System.Environment.GetFolderPath(
                        Environment.SpecialFolder.Desktop) + @"\Publish\WordDocument1.vsto";

                    Uri deploymentManifestUri = new Uri(deployManifestPath);
                    ServerDocument.AddCustomization(documentPath, deploymentManifestUri);
                    System.Windows.Forms.MessageBox.Show("The document was successfully customized.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The document is already customized.");
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (DocumentNotCustomizedException ex)
            {
                System.Windows.Forms.MessageBox.Show("The document could not be customized.\n" +
                    ex.Message);
            }