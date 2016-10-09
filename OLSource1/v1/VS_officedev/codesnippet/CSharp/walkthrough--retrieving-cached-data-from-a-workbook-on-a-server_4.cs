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