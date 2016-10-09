            string result = "Spelled incorrectly.";

            object startLocation = this.Content.Start;
            object endLocation = this.Content.End;
            bool spellCheck = this.Application.CheckSpelling(
                this.Range(ref startLocation, ref endLocation).Text);

            if (spellCheck == true)
            {
                result = "Spelled correctly.";
            }

            MessageBox.Show(result);