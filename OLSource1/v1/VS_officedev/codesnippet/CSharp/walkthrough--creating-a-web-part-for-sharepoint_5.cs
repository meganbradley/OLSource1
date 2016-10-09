        public override WebPartVerbCollection Verbs
        {
            get
            {
                WebPartVerb customVerb = new WebPartVerb("Manager_Filter_Verb",
                    new WebPartEventHandler(CustomVerbEventHandler));

                customVerb.Text = verbText;
                customVerb.Description = "Shows only employees that are managers";

                WebPartVerb[] newVerbs = new WebPartVerb[] { customVerb };

                return new WebPartVerbCollection(base.Verbs, newVerbs);
            }
        }

        protected void CustomVerbEventHandler(object sender, WebPartEventArgs args)
        {
            int titleColumn = 2;

            foreach (DataGridItem item in grid.Items)
            {
                if (item.Cells[titleColumn].Text != "Manager")
                {
                    if (item.Visible == true)
                    {
                        item.Visible = false;
                    }
                    else
                    {
                        item.Visible = true;
                    }
                }

            }
            if (verbText == "Show Managers Only")
            {
                verbText = "Show All Employees";
            }
            else
            {
                verbText = "Show Managers Only";
            }
        }