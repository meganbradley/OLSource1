        //Declare the Northwind dataset.
        Northwind40DataSet nwDataSet = new Northwind40DataSet();

        //Declare the data tables.

        Northwind40DataSet.CustomersDataTable customerTable;
        Northwind40DataSet.OrdersDataTable orderTable;
        Northwind40DataSet.Order_DetailsDataTable orderDetailsTable;
        Northwind40DataSet.ProductsDataTable productsTable;

        //Declare the data table adapters for each table.

        CustomersTableAdapter customerTableAdapter = new CustomersTableAdapter();
        OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();
        Order_DetailsTableAdapter detailsTableAdapter = new Order_DetailsTableAdapter();
        ProductsTableAdapter productsTableAdapter = new ProductsTableAdapter();