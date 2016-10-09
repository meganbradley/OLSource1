    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim items As New SPCalendarItemCollection()
        Dim thisWeb As SPWeb = SPControl.GetContextWeb(Context)

        Dim item As ListItem
        For Each item In CheckBoxList1.Items
            If item.Selected = True Then
                Dim calendarList As SPList = thisWeb.Lists(item.Text)
                Dim dtStart As DateTime = DateTime.Now.AddDays(-7)
                Dim dtEnd As DateTime = dtStart.AddMonths(1).AddDays(7)
                Dim query As New SPQuery()
                query.Query = [String].Format("<Query>" + "<Where><And>" + _
                                              "<Geq><FieldRef Name=""{0}"" />" + _
                                              "<Value Type=""DateTime"">{1}</Value></Geq>" + _
                                              "<Leq><FieldRef Name=""{0}"" />" + _
                                              "<Value Type=""DateTime"">{2}</Value></Leq>" + _
                                              "</And></Where><OrderBy><FieldRef Name=""{0}"" /></OrderBy>" + _
                                              "</Query>", "Start Time", dtStart.ToShortDateString(), dtEnd.ToShortDateString())

                Dim listItem As SPListItem
                For Each listItem In calendarList.GetItems(query)
                    Dim calItem As New SPCalendarItem()
                    With calItem
                        .ItemID = listItem("ID").ToString()
                        .Title = listItem("Title").ToString()
                        .CalendarType = Convert.ToInt32(SPCalendarType.Gregorian)
                        .StartDate = CType(listItem("Start Time"), DateTime)
                        .ItemID = listItem.ID.ToString()
                        .WorkSpaceLink = [String].Format("/Lists/{0}/DispForm.aspx", calendarList.Title)
                        .DisplayFormUrl = [String].Format("/Lists/{0}/DispForm.aspx", calendarList.Title)
                        .EndDate = CType(listItem("End Time"), DateTime)
                        .Description = listItem("Description").ToString()
                    End With

                    If Not (listItem("Location") Is Nothing) Then
                        calItem.Location = listItem("Location").ToString()
                    End If
                    items.Add(calItem)
                Next listItem
                MonthlyCalendarView1.DataSource = items
            End If
        Next item

    End Sub