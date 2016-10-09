            string documentPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop) + @"\WordDocument1.docx";
            int runtimeVersion = 0;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                if (runtimeVersion == 3)
                {
                    ServerDocument.RemoveCustomization(documentPath);
                    System.Windows.Forms.MessageBox.Show("The customization has been removed.");
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document is read-only.");
            }
            catch (InvalidOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show("The customization could not be removed.\n" +
                    ex.Message);
            }