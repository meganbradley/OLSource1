    Private Sub codeActivity1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ' Get reference to SharePoint site.
            Dim site As SPSite = New SPSite("http://MyServer")
            Dim web As SPWeb = site.OpenWeb("SPD2/")
            ' Get reference to Announcements list.
            Dim announcementsList As SPList = web.Lists("Announcements")
            ' Add announcement to Announcements list for the Task.
            Dim oListItem As SPListItem = announcementsList.Items.Add
            oListItem("Title") = ("Assigned task on " + DateTime.Now.ToString)
            oListItem.Update()
        Catch err As Exception
            Console.WriteLine(("Error: " + err.ToString))
        End Try
    End Sub