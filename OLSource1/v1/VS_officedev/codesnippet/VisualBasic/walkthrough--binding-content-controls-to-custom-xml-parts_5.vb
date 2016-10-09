        Dim xmlData As String = GetXmlFromResource()
        If xmlData IsNot Nothing Then
            AddCustomXmlPart(xmlData)
            BindControlsToCustomXmlPart()
        End If