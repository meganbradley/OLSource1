        Try
            serverDocument1 = New ServerDocument(workbookPath)
            Dim dataHostItem1 As CachedDataHostItem = _
                serverDocument1.CachedData.HostItems("AdventureWorksReport.Sheet1")
            Dim dataItem1 As CachedDataItem = dataHostItem1.CachedData("AdventureWorksLTDataSet")

            If dataItem1 IsNot Nothing Then
                Console.WriteLine("Before reading data from the cache dataset, the local dataset has " & _
                    "{0} rows.", productDataSet.Product.Rows.Count.ToString())

                ' Read the cached data from the worksheet dataset into the local dataset.
                Dim schemaReader As New System.IO.StringReader(dataItem1.Schema)
                Dim xmlReader As New System.IO.StringReader(dataItem1.Xml)
                productDataSet.ReadXmlSchema(schemaReader)
                productDataSet.ReadXml(xmlReader)

                Console.WriteLine("After reading data from the cache dataset, the local dataset has " & _
                    "{0} rows.", productDataSet.Product.Rows.Count.ToString())
            Else
                Console.WriteLine("The data object is not found in the data cache.")
            End If
        Catch ex As System.IO.FileNotFoundException
            Console.WriteLine("The specified workbook does not exist.")
        Catch ex As System.Xml.XmlException
            Console.WriteLine("The data object has invalid XML information.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
            Console.WriteLine(vbLf & vbLf & "Press Enter to close the application.")
            Console.ReadLine()
        End Try