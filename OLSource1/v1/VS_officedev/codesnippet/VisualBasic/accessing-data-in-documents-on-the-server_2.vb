                serverDocument1 = New ServerDocument(documentPath)
                Dim hostItem1 As CachedDataHostItem = _
                    serverDocument1.CachedData.HostItems("ExcelWorkbook1.Sheet1")
                Dim dataItem1 As CachedDataItem = hostItem1.CachedData("CachedString")

                If dataItem1 IsNot Nothing AndAlso _
                    Type.GetType(dataItem1.DataType).Equals(GetType(String)) Then

                    dataItem1.SerializeDataInstance("This is the new cached string value.")
                    serverDocument1.Save()
                End If