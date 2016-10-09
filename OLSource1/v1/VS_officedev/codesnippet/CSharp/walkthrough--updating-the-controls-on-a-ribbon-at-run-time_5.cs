        private void PopulateSalesOrderInfo()
        {
            String[] tempArray = comboBox1.Text.Split(new Char[] { '|' });
            menu1.Items.Clear();

            orderTable = nwDataSet.Orders;
            orderDetailsTable = nwDataSet.Order_Details;
            productsTable = nwDataSet.Products;

            ordersTableAdapter.Fill(orderTable);
            detailsTableAdapter.Fill(orderDetailsTable);
            productsTableAdapter.Fill(productsTable);

            var orderQuery = from orders in orderTable.AsEnumerable()
                             where orders.Field<string>("Customer ID") == tempArray[1]
                             select new { OrderID = orders.Field<int>("Order ID") };

            foreach (var orderItem in orderQuery)
            {
                menu1.Items.Add(CreateRibbonMenu());

                RibbonMenu orderMenu = (RibbonMenu)menu1.Items.Last();
                orderMenu.Dynamic = true;
                orderMenu.Label = orderItem.OrderID.ToString();
                orderMenu.Tag = orderItem.OrderID;

                var productQuery = from orderDetail in orderDetailsTable.AsEnumerable()
                                   join product in productsTable.AsEnumerable() on
                                       orderDetail.Field<int>("Product ID")
                                   equals product.Field<int>("Product ID")
                                   where orderDetail.Field<int>("Order ID") ==
                                       orderItem.OrderID
                                   select new { ProductName = product.Field<string>("Product Name") };

                foreach (var productItem in productQuery)
                {
                    RibbonButton button = CreateRibbonButton();
                    button.Label = productItem.ProductName;
                    orderMenu.Items.Add(button);
                }
            }
        }