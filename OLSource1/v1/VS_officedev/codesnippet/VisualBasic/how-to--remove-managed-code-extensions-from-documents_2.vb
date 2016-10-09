        Dim documentPath As String = System.Environment.GetFolderPath( _
            Environment.SpecialFolder.Desktop) & "\WordDocument1.docx"
        Dim runtimeVersion As Integer = 0

        Try
            runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath)
            If runtimeVersion = 3 Then
                ServerDocument.RemoveCustomization(documentPath)
                System.Windows.Forms.MessageBox.Show("The customization has been removed.")
            End If
        Catch ex As FileNotFoundException
            System.Windows.Forms.MessageBox.Show("The specified document does not exist.")
        Catch ex As IOException
            System.Windows.Forms.MessageBox.Show("The specified document is read-only.")
        Catch ex As InvalidOperationException
            System.Windows.Forms.MessageBox.Show("The customization could not be removed." & _
                vbLf & ex.Message)
        End Try