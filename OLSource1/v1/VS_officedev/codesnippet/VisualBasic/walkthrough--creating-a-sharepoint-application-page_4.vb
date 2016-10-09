        Private Sub CreateResultsTable(ByVal ResultsList As ArrayList)
            Dim CurrentList As String = ""
            Dim CurrentSite As String = ""
            Table1.Rows.Clear()

            Dim Item As SPListItem
            For Each Item In ResultsList
                If Item.ParentList.ParentWeb.Title <> CurrentSite Then
                    CurrentSite = Item.ParentList.ParentWeb.Title

                    Dim NewSiteCell As New TableCell()
                    NewSiteCell.Text = CurrentSite

                    Dim NewSiteRow As New TableRow()
                    With NewSiteRow
                        .Cells.Add(NewSiteCell)
                        .Font.Bold = True
                        .Font.Size = FontUnit.Larger
                        .Font.Underline = True
                    End With
                    Table1.Rows.Add(NewSiteRow)

                End If

                If Item.ParentList.Title <> CurrentList Then
                    CurrentList = Item.ParentList.Title
                    Dim NewListCell As New TableCell()
                    NewListCell.Text = CurrentList

                    Dim NewListRow As New TableRow()
                    With NewListRow
                        .Cells.Add(NewListCell)
                        .Font.Bold = True
                    End With
                    Table1.Rows.Add(NewListRow)

                    Dim ItemHeading As New TableCell()
                    With ItemHeading
                        .Text = "Item"
                        .Font.Italic = True
                    End With

                    Dim CreatedHeading As New TableCell()
                    With CreatedHeading
                        .Text = "Created"
                        .Font.Italic = True
                    End With


                    Dim ModifiedHeading As New TableCell()
                    With ModifiedHeading
                        .Text = "Last Modified"
                        .Font.Italic = True
                    End With

                    Dim HeadingRow As New TableRow()
                    HeadingRow.Cells.Add(ItemHeading)
                    HeadingRow.Cells.Add(CreatedHeading)
                    HeadingRow.Cells.Add(ModifiedHeading)

                    Table1.Rows.Add(HeadingRow)
                End If

                Dim ItemName As New TableCell()
                Dim ItemLink As New HyperLink()
                Try
                    ItemLink.NavigateUrl = Item.ParentList.ParentWeb.Url & _
                        "/" & Item.ParentList.Forms(PAGETYPE.PAGE_DISPLAYFORM).Url & _
                        "?ID=" & Item.ID
                Catch exception As Exception
                    ' Some items might not have a form page. Ignore the exception.
                End Try
                ItemLink.Text = Item.DisplayName
                ItemName.Controls.Add(ItemLink)

                Dim Created As New TableCell()
                Created.Text = Item("Created").ToString()

                Dim Modified As New TableCell()
                Modified.Text = Item("Modified").ToString()

                Dim DataRow As New TableRow()
                DataRow.Cells.Add(ItemName)
                DataRow.Cells.Add(Created)
                DataRow.Cells.Add(Modified)

                Table1.Rows.Add(DataRow)
            Next Item
        End Sub