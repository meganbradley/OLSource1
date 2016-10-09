        Try
            productTableAdapter.Fill(productDataSet.Product)
            Console.WriteLine("The local dataset is filled.")

            serverDocument1 = New ServerDocument(workbookPath)
            Dim dataHostItem1 As CachedDataHostItem = _
                serverDocument1.CachedData.HostItems("AdventureWorksReport.Sheet1")
            Dim dataItem1 As CachedDataItem = dataHostItem1.CachedData("AdventureWorksLTDataSet")

            ' Initialize the worksheet dataset with the local dataset.
            If dataItem1 IsNot Nothing Then
                dataItem1.SerializeDataInstance(productDataSet)
                serverDocument1.Save()
                Console.WriteLine("The data is saved to the data cache.")
            Else
                Console.WriteLine("The data object is not found in the data cache.")
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Console.WriteLine(ex.Message)
        Catch ex As System.IO.FileNotFoundException
            Console.WriteLine("The specified workbook does not exist.")
        Finally
            If Not (serverDocument1 Is Nothing) Then
                serverDocument1.Close()
            End If
            Console.WriteLine(vbLf & vbLf & "Press Enter to close the application.")
            Console.ReadLine()
        End Try