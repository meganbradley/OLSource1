        void button_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Application application = Globals.ThisAddIn.Application;
            Outlook.Inspector inspector = application.ActiveInspector();
            Outlook.MailItem myMailItem = (Outlook.MailItem)inspector.CurrentItem;
            RibbonButton myCheckBox = (RibbonButton)sender;
            myMailItem.Subject = "Following up on your order";
            myMailItem.Body = myMailItem.Body + "\n" + "* " + myCheckBox.Label;
        }