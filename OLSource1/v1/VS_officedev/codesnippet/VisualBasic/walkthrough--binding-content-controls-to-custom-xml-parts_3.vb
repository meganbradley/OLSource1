    Private Sub AddCustomXmlPart(ByVal xmlData As String)
        If xmlData IsNot Nothing Then

            employeeXMLPart = Me.CustomXMLParts.SelectByID(employeeXMLPartID)
            If (employeeXMLPart Is Nothing) Then
                employeeXMLPart = Me.CustomXMLParts.Add(xmlData)
                employeeXMLPart.NamespaceManager.AddNamespace("ns", _
                    "http://schemas.microsoft.com/vsto/samples")
                employeeXMLPartID = employeeXMLPart.Id
            End If
        End If
    End Sub