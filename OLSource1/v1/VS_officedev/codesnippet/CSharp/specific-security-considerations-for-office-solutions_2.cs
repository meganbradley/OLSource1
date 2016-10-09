        private void TrustedCode()
        {
            Microsoft.Office.Interop.Outlook.MailItem mailItem1 =
                this.Application.CreateItem(
                Microsoft.Office.Interop.Outlook.OlItemType.olMailItem) as
                Microsoft.Office.Interop.Outlook.MailItem;
            mailItem1.To = "someone@example.com";
            MessageBox.Show(mailItem1.To);
        }