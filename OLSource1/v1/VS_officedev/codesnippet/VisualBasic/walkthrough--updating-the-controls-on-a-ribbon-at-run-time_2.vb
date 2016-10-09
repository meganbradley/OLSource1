    'Declare the Northwind data set.

    Dim nwDataSet As Northwind40DataSet = New Northwind40DataSet()

    'Declare the data tables.

    Dim customerTable As Northwind40DataSet.CustomersDataTable
    Dim orderTable As Northwind40DataSet.OrdersDataTable
    Dim orderDetailsTable As Northwind40DataSet.Order_DetailsDataTable
    Dim productsTable As Northwind40DataSet.ProductsDataTable

    'Declare the data table adapters for each table.

    Dim customersTableAdapter As CustomersTableAdapter = New CustomersTableAdapter()
    Dim ordersTableAdapter As OrdersTableAdapter = New OrdersTableAdapter()
    Dim detailsTableAdapter As Order_DetailsTableAdapter = New Order_DetailsTableAdapter()
    Dim productsTableAdapter As ProductsTableAdapter = New ProductsTableAdapter()
