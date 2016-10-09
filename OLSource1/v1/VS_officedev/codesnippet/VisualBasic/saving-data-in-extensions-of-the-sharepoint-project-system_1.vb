        Private Const TestPropertyId As String = "Contoso.ExampleProperty"
        Private Const PropertyDefaultValue As String = "This is an example property."

        <DisplayName("Example Property")> _
        <DescriptionAttribute("This is an example property for project items.")> _
        <DefaultValue(PropertyDefaultValue)> _
        Public Property ExampleProperty As String
            Get
                Dim propertyValue As String = Nothing

                ' Get the current property value if it already exists; otherwise, return a default value.
                If False = projectItem.ExtensionData.TryGetValue(TestPropertyId, propertyValue) Then
                    propertyValue = PropertyDefaultValue
                End If
                Return propertyValue
            End Get
            Set(ByVal value As String)
                If value <> PropertyDefaultValue Then
                    ' Store the property value in the ExtensionData property of the project item.
                    ' Data in the ExtensionData property persists when the project is closed.
                    projectItem.ExtensionData(TestPropertyId) = value
                Else
                    ' Do not save the default value.
                    projectItem.ExtensionData.Remove(TestPropertyId)
                End If
            End Set
        End Property