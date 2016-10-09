                serverDocument1 = New ServerDocument(documentPath)
                Dim hostItem1 As CachedDataHostItem = _
                    serverDocument1.CachedData.HostItems("ExcelWorkbook1.Sheet1")
                Dim dataItem1 As CachedDataItem = hostItem1.CachedData("CachedString")