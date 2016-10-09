    <Personalizable(PersonalizationScope.[Shared]), _
        WebBrowsable(True), WebDisplayName("Path to Employee Data File"), _
        WebDescription("Location of the XML file that contains employee data")> _
    Public Property DataFilePath() As String
        Get
            Return xmlFilePath
        End Get
        Set(ByVal value As String)
            xmlFilePath = value
        End Set
    End Property