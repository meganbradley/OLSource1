    Public Overrides Sub FeatureDeactivating(ByVal properties As SPFeatureReceiverProperties)
        Try
            ' Get reference to SharePoint site.
            Dim site As SPSite = New SPSite("http://localhost")
            Dim web As SPWeb = site.OpenWeb("/")
            ' Get reference to Announcements list.
            Dim announcementsList As SPList = web.Lists("Announcements")
            ' Add new announcement to Announcements list.
            Dim oListItem As SPListItem = announcementsList.Items.Add
            oListItem("Title") = ("Deactivated Feature: " + properties.Definition.DisplayName)
            oListItem("Body") = (properties.Definition.DisplayName + (" was deactivated on: " + DateTime.Now.ToString))
            oListItem.Update()
        Catch e As Exception
            Console.WriteLine(("Error: " + e.ToString))
        End Try
    End Sub