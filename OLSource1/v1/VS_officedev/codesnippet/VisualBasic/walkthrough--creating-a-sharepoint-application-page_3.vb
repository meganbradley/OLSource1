        Private Sub GetItems()
            Dim CurrentUser As New SPFieldUserValue _
                (Me.Web, Me.Web.CurrentUser.ID, Me.Web.CurrentUser.Name)

            Dim ResultsList As New ArrayList()

            Dim ThisFarm As SPFarm = SPFarm.Local
            Dim Service As SPWebService = _
                ThisFarm.Services.GetValue(Of SPWebService)("")

            Dim WebApp As SPWebApplication
            For Each WebApp In Service.WebApplications
                Dim SiteCollection As SPSite
                For Each SiteCollection In WebApp.Sites
                    Dim Web As SPWeb
                    For Each Web In SiteCollection.AllWebs
                        Dim Lists As SPListCollection = Web.Lists
                        Dim List As SPList
                        For Each List In Lists
                            Dim Item As SPListItem
                            Try
                                For Each Item In List.Items
                                    If Item(DropDownList1.SelectedValue).ToString() = _
                                        CurrentUser.ToString() Then
                                        ResultsList.Add(Item)
                                    End If
                                Next Item
                            Catch exception As Exception
                                'Error in list. Move on to the next list.
                            End Try
                        Next List
                    Next Web
                Next SiteCollection
            Next WebApp
            CreateResultsTable(ResultsList)
        End Sub