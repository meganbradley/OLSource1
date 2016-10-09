        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            AddAttachment();
        }

        private void AddAttachment()
        {
            Outlook.MailItem mail =
                this.Application.CreateItem
                (Outlook.OlItemType.olMailItem)
                as Outlook.MailItem;

            mail.Subject = "An attachment for you!";

            OpenFileDialog attachment = new OpenFileDialog();

            attachment.Title = "Select a file to send";
            attachment.ShowDialog();

            if (attachment.FileName.Length > 0)
            {
                mail.Attachments.Add(
                    attachment.FileName,
                    Outlook.OlAttachmentType.olByValue,
                    1,
                    attachment.FileName);
                mail.Recipients.Add("Armando Pinto ");
                ((Outlook._MailItem)mail).Send();
            }
        }