        protected void Button1_Click(object sender, EventArgs e)
        {
            SPCalendarItemCollection items = new SPCalendarItemCollection();
            SPWeb thisWeb = SPControl.GetContextWeb(Context);

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected == true)
                {
                    SPList calendarList = thisWeb.Lists[item.Text];
                    DateTime dtStart = DateTime.Now.AddDays(-7);
                    DateTime dtEnd = dtStart.AddMonths(1).AddDays(7);
                    SPQuery query = new SPQuery();
                    query.Query = String.Format(
                        "<Query>" +
                        "<Where><And>" +
                        "<Geq><FieldRef Name=\"{0}\" />" +
                        "<Value Type=\"DateTime\">{1}</Value></Geq>" +
                        "<Leq><FieldRef Name=\"{0}\" />" +
                        "<Value Type=\"DateTime\">{2}</Value></Leq>" +
                        "</And></Where><OrderBy><FieldRef Name=\"{0}\" /></OrderBy>" +
                        "</Query>",
                        "Start Time",
                        dtStart.ToShortDateString(),
                        dtEnd.ToShortDateString());

                    foreach (SPListItem listItem in calendarList.GetItems(query))
                    {
                        SPCalendarItem calItem = new SPCalendarItem();
                        calItem.ItemID = listItem["ID"].ToString();
                        calItem.Title = listItem["Title"].ToString();
                        calItem.CalendarType = Convert.ToInt32(SPCalendarType.Gregorian);
                        calItem.StartDate = (DateTime)listItem["Start Time"];
                        calItem.ItemID = listItem.ID.ToString();
                        calItem.WorkSpaceLink = String.Format(
                            "/Lists/{0}/DispForm.aspx", calendarList.Title);
                        calItem.DisplayFormUrl = String.Format(
                            "/Lists/{0}/DispForm.aspx", calendarList.Title);
                        calItem.EndDate = (DateTime)listItem["End Time"];
                        calItem.Description = listItem["Description"].ToString();
                        if (listItem["Location"] != null)
                        {
                            calItem.Location = listItem["Location"].ToString();
                        }
                        items.Add(calItem);
                    }
                    MonthlyCalendarView1.DataSource = items;
                }

            }

        }