        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Outlook.MAPIFolder calendar =
                Application.Session.GetDefaultFolder(
                 Outlook.OlDefaultFolders.olFolderCalendar);

            Outlook.Items calendarItems = calendar.Items;

            Outlook.AppointmentItem item =
                calendarItems["Test Appointment"] as Outlook.AppointmentItem;

            Outlook.RecurrencePattern pattern =
                item.GetRecurrencePattern();
            Outlook.AppointmentItem itemDelete = pattern.
                GetOccurrence(new DateTime(2006, 6, 28, 8, 0, 0));

            if (itemDelete != null)
            {
                itemDelete.Delete();
            }
        }