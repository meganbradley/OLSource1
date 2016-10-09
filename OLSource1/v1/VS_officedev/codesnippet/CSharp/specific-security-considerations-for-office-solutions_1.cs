        private void UntrustedCode()
        {
            Microsoft.Office.Interop.Outlook.Application application =
                new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem1 =
                application.CreateItem(
                Microsoft.Office.Interop.Outlook.OlItemType.olMailItem) as
                Microsoft.Office.Interop.Outlook.MailItem;
            mailItem1.To = "someone@example.com";
            MessageBox.Show(mailItem1.To);
        }