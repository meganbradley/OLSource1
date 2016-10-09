    Public Overrides Sub ItemAdded(ByVal properties As SPItemEventProperties)
        properties.ListItem("Patient Name") = "Scott Brown"
        properties.ListItem.Update()
        MyBase.ItemAdded(properties)
    End Sub