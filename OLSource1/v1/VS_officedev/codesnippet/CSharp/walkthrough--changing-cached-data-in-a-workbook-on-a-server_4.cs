            try
            {
                serverDocument1 = new ServerDocument(workbookPath);
                CachedDataHostItem dataHostItem1 =
                    serverDocument1.CachedData.HostItems["AdventureWorksReport.Sheet1"];
                CachedDataItem dataItem1 = dataHostItem1.CachedData["adventureWorksLTDataSet"];

                if (dataItem1 != null)
                {
                    Console.WriteLine("Before reading data from the cache dataset, the local dataset has " +
                        "{0} rows.", productDataSet.Product.Rows.Count.ToString());

                    // Read the cached data from the worksheet dataset into the local dataset.
                    System.IO.StringReader schemaReader = new System.IO.StringReader(dataItem1.Schema);
                    System.IO.StringReader xmlReader = new System.IO.StringReader(dataItem1.Xml);
                    productDataSet.ReadXmlSchema(schemaReader);
                    productDataSet.ReadXml(xmlReader);

                    Console.WriteLine("After reading data from the cache dataset, the local dataset has " +
                        "{0} rows.", productDataSet.Product.Rows.Count.ToString());

                    // Modify the prices of each product in the local dataset.
                    foreach (AdventureWorksDataSet.AdventureWorksLTDataSet.ProductRow row in 
                             productDataSet.Product.Rows)
                    {
                        if (row.ProductCategoryID < 20)
                        {
                            row.ListPrice = row.ListPrice + (row.ListPrice * (Decimal).10);
                        }
                        else
                        {
                            row.ListPrice = row.ListPrice - (row.ListPrice * (Decimal).10);
                        }
                    }

                    // Write the modified local dataset to the worksheet dataset using the DiffGram format.
                    System.Text.StringBuilder stringIn = new System.Text.StringBuilder();
                    System.IO.StringWriter stringOut = new System.IO.StringWriter(stringIn);
                    productDataSet.WriteXml(stringOut, System.Data.XmlWriteMode.DiffGram);
                    dataItem1.Xml = stringIn.ToString();

                    serverDocument1.Save();
                    Console.WriteLine("The product prices have been modified.");
                }
                else
                {
                    Console.WriteLine("The data object is not found in the data cache.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("The specified workbook does not exist.");
            }
            catch (System.Xml.XmlException)
            {
                Console.WriteLine("The data object has invalid XML information.");
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