            try
            {
                productTableAdapter.Fill(productDataSet.Product);
                Console.WriteLine("The local dataset is filled.");

                serverDocument1 = new ServerDocument(workbookPath);
                CachedDataHostItem dataHostItem1 =
                    serverDocument1.CachedData.HostItems["AdventureWorksReport.Sheet1"];
                CachedDataItem dataItem1 = dataHostItem1.CachedData["adventureWorksLTDataSet"];

                // Initialize the worksheet dataset with the local dataset.
                if (dataItem1 != null)
                {
                    dataItem1.SerializeDataInstance(productDataSet);
                    serverDocument1.Save();
                    Console.WriteLine("The data is saved to the data cache.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The data object is not found in the data cache.");
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("The specified workbook does not exist.");
            }
            finally
            {
                if (serverDocument1 != null)
                {
                    serverDocument1.Close();
                }

                Console.WriteLine("\n\nPress Enter to close the application.");
                Console.ReadLine();
            }