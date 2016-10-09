        Dim documentPath As String = System.Environment.GetFolderPath( _
             Environment.SpecialFolder.Desktop) + "\WordDocument1.docx"
        Dim runtimeVersion As Integer = 0

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)

            ' Make sure that this document does not yet have any Visual Studio Tools 
            ' for Office customizations.
            If runtimeVersion = 0 Then
                Dim deployManifestPath As String = System.Environment.GetFolderPath( _
                    Environment.SpecialFolder.Desktop) & "\Publish\WordDocument1.vsto"
                Dim deploymentManifestUri As New Uri(deployManifestPath)
                ServerDocument.AddCustomization(documentPath, deploymentManifestUri)
                System.Windows.Forms.MessageBox.Show("The document was successfully customized.")
            Else
                System.Windows.Forms.MessageBox.Show("The document is already customized.")
            End If
        Catch ex As FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As DocumentNotCustomizedException
            System.Windows.Forms.MessageBox.Show("The document could not be customized." & _
                vbLf & ex.Message)
        End Try