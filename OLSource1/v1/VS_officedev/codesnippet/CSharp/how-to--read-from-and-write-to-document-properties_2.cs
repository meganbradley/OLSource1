            if (prop.Value == null)
            {
                prop.Value = 1;
            }
            else
            {
                int revision;
                if (int.TryParse((string)prop.Value, out revision))
                {
                    prop.Value = revision + 1;
                    MessageBox.Show("Revision Number = " + revision);
                }
                else
                {
                    MessageBox.Show("Revision Number = invalid value");
                }
            }