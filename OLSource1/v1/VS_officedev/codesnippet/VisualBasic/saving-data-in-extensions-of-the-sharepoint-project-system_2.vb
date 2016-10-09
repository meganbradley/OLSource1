        Private sharePointProject As ISharePointProject
        Private projectStorage As IVsBuildPropertyStorage
        Private Const ProjectFilePropertyId As String = "ContosoCustomProjectFileProperty"
        Private Const ProjectFilePropertyDefaultValue As String = "Default"

        Public Sub New(ByVal myProject As ISharePointProject)
            sharePointProject = myProject
            projectStorage = sharePointProject.ProjectService.Convert(Of ISharePointProject, IVsBuildPropertyStorage)(sharePointProject)
        End Sub

        <DisplayName("Custom Project File Property")> _
        <DescriptionAttribute("This property is saved to the .csproj/.vbproj file.")> _
        <DefaultValue(ProjectFilePropertyDefaultValue)> _
        Public Property CustomProjectFileProperty As String
            Get
                Dim propertyValue As String = String.Empty
                Dim hr As Integer = projectStorage.GetPropertyValue(ProjectFilePropertyId, String.Empty, _
                    CUInt(_PersistStorageType.PST_PROJECT_FILE), propertyValue)

                ' Try to get the current value from the project file; if it does not yet exist, return a default value.
                If Not ErrorHandler.Succeeded(hr) Or String.IsNullOrEmpty(propertyValue) Then
                    propertyValue = ProjectFilePropertyDefaultValue
                End If
                Return propertyValue
            End Get
            Set(ByVal value As String)
                ' Do not save the default value.
                If value <> ProjectFilePropertyDefaultValue Then
                    projectStorage.SetPropertyValue(ProjectFilePropertyId, String.Empty, _
                        CUInt(_PersistStorageType.PST_PROJECT_FILE), value)
                End If
            End Set
        End Property