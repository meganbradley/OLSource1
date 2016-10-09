    Public Overrides Sub ItemAdded(ByVal properties As SPItemEventProperties)
        MyBase.ItemAdded(properties)
        Dim web As SPWeb = properties.OpenWeb()
        properties.ListItem("Due Date") = "July 1, 2009"
        properties.ListItem("Description") = "This is a critical task."
        properties.ListItem.Update()
    End Sub