        Private Sub ProjectItemPropertiesRequested(ByVal Sender As Object,
            ByVal e As SharePointProjectItemPropertiesRequestedEventArgs)
            Dim propertyObject As CustomProperties = Nothing

            ' If the properties object already exists, get it from the project item's annotations.
            If False = e.ProjectItem.Annotations.TryGetValue(propertyObject) Then
                ' Otherwise, create a new properties object and add it to the annotations.
                propertyObject = New CustomProperties(e.ProjectItem)
                e.ProjectItem.Annotations.Add(propertyObject)
            End If
            e.PropertySources.Add(propertyObject)
        End Sub