        private void PopulateMailItem(string addressToLine)
        {
            Outlook.Application application = Globals.ThisAddIn.Application;
            Outlook.Inspector inspector = application.ActiveInspector();
            Outlook.MailItem myMailItem = (Outlook.MailItem)inspector.CurrentItem;

            myMailItem.To = "";
            String[] tempArray = addressToLine.Split(new Char[] { '|' });
            myMailItem.To = tempArray[0] + "@example.com";
            myMailItem.Subject = "Following up on your order";
            myMailItem.Body = "Hello " + tempArray[0] + "," +
                "\n" + "We would like to get your feedback on the " +
                "following products that you recently ordered: ";
        }