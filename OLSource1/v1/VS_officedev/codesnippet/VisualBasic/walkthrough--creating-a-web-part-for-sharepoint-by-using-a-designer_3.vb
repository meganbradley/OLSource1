    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MonthlyCalendarView1 = New MonthlyCalendarView()
        Me.Controls.Add(MonthlyCalendarView1)
        Dim items As New SPCalendarItemCollection()
        Dim thisWeb As SPWeb = SPControl.GetContextWeb(Context)

        If CheckBoxList1.Items.Count = 0 Then
            Dim listItem As SPList
            For Each listItem In thisWeb.Lists
                If listItem.BaseTemplate = SPListTemplateType.Events Then
                    CheckBoxList1.Items.Add(New ListItem(listItem.Title))
                End If
            Next listItem
        End If
        MonthlyCalendarView1.ItemTemplateName = "CalendarViewMonthItemTemplate"
        MonthlyCalendarView1.ItemAllDayTemplateName = "CalendarViewMonthItemAllDayTemplate"
        MonthlyCalendarView1.ItemMultiDayTemplateName = "CalendarViewMonthItemMultiDayTemplate"
    End Sub