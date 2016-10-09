    Sub TestProperties()
        Dim properties As Microsoft.Office.Core.DocumentProperties
        properties = CType(Me.CustomDocumentProperties, Office.DocumentProperties)

        If ReadDocumentProperty("Project Name") <> Nothing Then
            properties("Project Name").Delete()
        End If

        properties.Add("Project Name", False, _
            Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString, _
            "White Papers")
    End Sub

    Private Function ReadDocumentProperty(ByVal propertyName As String) As String
        Dim properties As Office.DocumentProperties
        properties = CType(Me.CustomDocumentProperties, Office.DocumentProperties)

        Dim prop As Office.DocumentProperty

        For Each prop In properties
            If prop.Name = propertyName Then
                Return prop.Value.ToString()
            End If
        Next

        Return Nothing
    End Function