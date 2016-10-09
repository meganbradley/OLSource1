        private void AddAppointment()
        {
            try
            {
                Outlook.AppointmentItem newAppointment =
                    (Outlook.AppointmentItem)
                this.Application.CreateItem(Outlook.OlItemType.olAppointmentItem);
                newAppointment.Start = DateTime.Now.AddHours(2);
                newAppointment.End = DateTime.Now.AddHours(3);
                newAppointment.Location = "ConferenceRoom #2345";
                newAppointment.Body =
                    "We will discuss progress on the group project.";
                newAppointment.AllDayEvent = false;
                newAppointment.Subject = "Group Project";
                newAppointment.Recipients.Add("Roger Harui");
                Outlook.Recipients sentTo = newAppointment.Recipients;
                Outlook.Recipient sentInvite = null;
                sentInvite = sentTo.Add("Holly Holt");
                sentInvite.Type = (int)Outlook.OlMeetingRecipientType
                    .olRequired;
                sentInvite = sentTo.Add("David Junca ");
                sentInvite.Type = (int)Outlook.OlMeetingRecipientType
                    .olOptional;
                sentTo.ResolveAll();
                newAppointment.Save();
                newAppointment.Display(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }