        protected void Page_Load(object sender, EventArgs e)
        {
            MonthlyCalendarView1 = new MonthlyCalendarView();
            this.Controls.Add(MonthlyCalendarView1);
            SPCalendarItemCollection items = new SPCalendarItemCollection();
            SPWeb thisWeb = SPControl.GetContextWeb(Context);

            if (CheckBoxList1.Items.Count == 0)
            {
                foreach (SPList listItem in thisWeb.Lists)
                {
                    if (listItem.BaseTemplate == SPListTemplateType.Events)
                    {
                        CheckBoxList1.Items.Add(new ListItem(listItem.Title));
                    }
                }
            }
            MonthlyCalendarView1.ItemTemplateName =
                "CalendarViewMonthItemTemplate";
            MonthlyCalendarView1.ItemAllDayTemplateName =
                "CalendarViewMonthItemAllDayTemplate";
            MonthlyCalendarView1.ItemMultiDayTemplateName =
                "CalendarViewMonthItemMultiDayTemplate";
        }