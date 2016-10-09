        Private Const UserFilePropertyId As String = "ContosoCustomUserFileProperty"
        Private Const UserFilePropertyDefaultValue As String = "Default"

        <DisplayName("Custom Project User File Property")> _
        <DescriptionAttribute("This property is saved to the .user file.")> _
        <DefaultValue(UserFilePropertyDefaultValue)> _
        Public Property CustomUserFileProperty As String
            Get
                Dim propertyValue As String = String.Empty
                ' Try to get the current value from the .user file; if it does not yet exist, return a default value.
                If Not sharePointProject.ProjectUserFileData.TryGetValue(UserFilePropertyId, propertyValue) Then
                    propertyValue = UserFilePropertyDefaultValue
                End If
                Return propertyValue
            End Get
            Set(ByVal value As String)
                ' Do not save the default value.
                If value <> UserFilePropertyDefaultValue Then
                    sharePointProject.ProjectUserFileData(UserFilePropertyId) = value
                End If
            End Set
        End Property