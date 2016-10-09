            object value = rng.Value2;

            if (value != null)
            {
                if (value is double)
                {
                    dt = DateTime.FromOADate((double)value);
                }
                else
                {
                    DateTime.TryParse((string)value, out dt);
                }
            }
            System.Windows.Forms.MessageBox.Show(dt.ToString());