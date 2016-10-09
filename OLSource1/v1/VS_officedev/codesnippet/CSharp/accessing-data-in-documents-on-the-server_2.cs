                    serverDocument1 = new ServerDocument(documentPath);
                    CachedDataHostItem hostItem1 = 
                        serverDocument1.CachedData.HostItems["ExcelWorkbook1.Sheet1"];
                    CachedDataItem dataItem1 = hostItem1.CachedData["CachedString"];

                    if (dataItem1 != null &&
                        Type.GetType(dataItem1.DataType) == typeof(string))
                    {
                        dataItem1.SerializeDataInstance("This is the new cached string value.");
                        serverDocument1.Save();
                    }