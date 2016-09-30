        private void FindControlInList()
        {
            int index = 0;

            foreach (Customer cust in this.Customers)
            {
                if (cust.CompanyName == "Great Lakes Food Market")
                {
                    this.FindControlInCollection("CompanyName",
                    this.Customers.ElementAt(index)).IsVisible = false;
                    this.FindControlInCollection("CompanyName",
                    this.Customers.ElementAt(index)).IsReadOnly = true;
                }

                index++;
            }

        }