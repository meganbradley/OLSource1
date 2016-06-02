---
title: Use OPENJSON with the Default Schema (SQL Server)
ms.custom: 
  - SQL2016_New_Updated
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-json
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8e28a8f8-71a8-4c25-96b8-0bbedc6f41c4
---
# Use OPENJSON with the Default Schema (SQL Server)
  Use **OPENJSON** with the default schema to returns a table with one row for each property of the object or for each element in the array.  
  
 Here are some examples that use **OPENJSON** with the default schema. For more info and more examples, see [OPENJSON &#40;Transact-SQL&#41;](../Topic/OPENJSON%20\(Transact-SQL\).md).  
  
## Example \- Return each property of an object  
 **Query**  
  
```tsql  
SELECT * FROM OPENJSON('{"name":"John","surname":"Doe","age":45}')  
```  
  
 **Results**  
  
|Key|Value|  
|---------|-----------|  
|name|John|  
|surname|Doe|  
|age|45|  
  
## Example \- Return each element of an array  
 **Query**  
  
```tsql  
SELECT [key], value FROM OPENJSON('["en-GB", "en-UK","de-AT","es-AR","sr-Cyrl"]')  
```  
  
 **Results**  
  
|Key|Value|  
|---------|-----------|  
|0|en\-GB|  
|1|en\-UK|  
|2|de\-AT|  
|3|es\-AR|  
|4|sr\-Cyrl|  
  
## Example \- Convert JSON to a temporary table  
 The following query returns all properties of the **info** object.  
  
```tsql  
SET @json = N'{  
    "info":{    
      "type":1,  
      "address":{    
        "town":"Bristol",  
        "county":"Avon",  
        "country":"England"  
      },  
      "tags":["Sport", "Water polo"]  
   },  
   "type":"Basic"  
}'  
  
SELECT * FROM OPENJSON(@json, N'lax $.info')  
```  
  
 **Results**  
  
|Key|Value|Type|  
|---------|-----------|----------|  
|type|1|0|  
|address|{ "town":"Bristol", "county":"Avon", "country":"England" }|5|  
|tags|\[ "Sport", "Water polo" \]|4|  
  
## Example \- Combine relational data and JSON data  
 In the following example, the SalesOrderHeader table has a SalesReason text column that contains an array of SalesOrderReasons in JSON format. The SalesOrderReasons objects contain properties like "Manufacturer" and "Quality". The example creates a report that joins every sales order row to the related sales reasons by expanding the JSON array of sales reasons as if the reasons were stored in a separate child table.  
  
```tsql  
SELECT SalesOrderID, OrderDate, value AS Reason  
FROM Sales.SalesOrderHeader  
	CROSS APPLY OPENJSON (SalesReasons)  
  
```  
  
 In this example, OPENJSON returns a table of sales reasons in which the reasons appear as the value column. The CROSS APPLY operator joins each sales order row to the rows returned by the OPENJSON table\-valued function.  
  
## See Also  
 [OPENJSON &#40;Transact-SQL&#41;](../Topic/OPENJSON%20\(Transact-SQL\).md)  
  
  