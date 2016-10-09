        public override void ItemAdded(SPItemEventProperties properties)
       {
           base.ItemAdded(properties);
           SPWeb web = properties.OpenWeb();
           properties.ListItem["Due Date"] = "July 1, 2009";
           properties.ListItem["Description"] = "This is a critical task.";
           properties.ListItem.Update(); 
       }  