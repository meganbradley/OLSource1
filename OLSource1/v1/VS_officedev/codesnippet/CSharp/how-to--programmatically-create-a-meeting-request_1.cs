        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Outlook.AppointmentItem agendaMeeting = (Outlook.AppointmentItem)
                this.Application.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.
                olAppointmentItem);

            if (agendaMeeting != null)
            {
                agendaMeeting.MeetingStatus =
                    Microsoft.Office.Interop.Outlook.OlMeetingStatus.olMeeting;
                agendaMeeting.Location = "Conference Room";
                agendaMeeting.Subject = "Discussing the Agenda";
                agendaMeeting.Body = "Let's discuss the agenda.";
                agendaMeeting.Start = new DateTime(2005, 5, 5, 5, 0, 0);
                agendaMeeting.Duration = 60;
                Outlook.Recipient recipient =
                    agendaMeeting.Recipients.Add("Nate Sun");
                recipient.Type =
                    (int)Outlook.OlMeetingRecipientType.olRequired;
                ((Outlook._AppointmentItem)agendaMeeting).Send();
            }
        }