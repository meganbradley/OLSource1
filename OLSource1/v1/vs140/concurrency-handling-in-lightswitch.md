---
title: "Concurrency Handling in LightSwitch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2c617b25-4f22-4cad-bd71-d87a38105a5d
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Concurrency Handling in LightSwitch
[!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] automatically detects concurrency conflicts, but you can improve the performance of an application in some cases by understanding how [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] handles that process .  
  
 Problems can occur in applications when multiple users are allowed to edit the same record at the same time. Applications that detect concurrency conflicts first determine whether another user has changed a record, and they handle any conflicting values appropriately.  
  
## Concurrency in LightSwitch  
 [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] uses the OData protocol for communication between the client and server. The OData protocol uses the `ETag` part of the HTTP protocol to detect concurrency conflicts. Every property that will be used to detect concurrency conflicts has its original value serialized into the `ETag` value when the item is read. This value is sent to the client application along with all other values of the entity that's being read. A client that tries an update will submit the `ETag` value along with the updated property values to the server. The server will verify whether the `ETag` still matches the original value. If the value has changed, the update is rejected, and the application must handle the conflict.  
  
 [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] handles conflicts slightly differently depending on what data source is being used.  
  
### Intrinsic Data Source  
 When you create a table in the [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] intrinsic database, a generated column that's named `RowVersion` is added to your table. The `RowVersion` column utilizes the `rowversion` data type in SQL Server. The `rowversion` column is automatically updated each time that any other column in the record is updated. Rather than serializing all column values into an `Etag`, only the 8-byte value in `RowVersion` is used to detect conflicts. This strategy helps to improve performance by reducing the amount of data that's sent to the server.  
  
 You can’t display the `RowVersion` column in the Entity Designer, but that column appears in the Screen Designer. You can write code for the `RowVersion` column by using the `RowVersion_Changed`, `RowVersion_IsReadOnly`, and `RowVersion_Validate` methods.  
  
 You can also create a query in the Query Designer by using `RowVersion`. For example, you might want to detect whether a record has been changed since the most recent time that it was read. To detect such changes, you can create a query with `Id` and `RowVersion` parameters. You can pass in a record’s `Id` and current `RowVersion` values into the parameters of this query. If no record is returned, the record has been modified or deleted. If a record is returned, the record hasn't changed in the database.  
  
### Attached Data Source  
 When you connect to an existing database in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] and a `rowversion` column exists in a table, [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] uses that `rowversion` column to detect concurrency conflicts. If you attach to an external database that doesn’t contain a `rowversion` column, [!INCLUDE[smb_current_long](../vs140/includes/smb_current_long_md.md)] uses all available columns to detect concurrency conflicts. The latter strategy could result in poor performance, especially with large sets of data.  
  
 We recommend that you add a `rowversion` column to external database tables, which you can do by using SQL Server Management Studio or the **SQL Server Object Explorer** in Visual Studio.  
  
### WCF RIA Service Data Source  
 When you attach to a Windows Communication Foundation (WCF) Rich Internet Application (RIA)  data source, [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] uses one of three attributes of WCF RIA Services to determine whether a property should be used to detect concurrency conflicts: `TimestampAttribute`, `ConcurrencyCheckAttribute`, or `RoundTripOriginalAttribute`. Any property that's marked with one of these attributes on your WCF RIA entity is used to detect concurrency conflicts. If the entity doesn’t have any of these attributes on its properties, all properties are used to detect concurrency conflicts. The latter strategy could result in poor performance, especially with large sets of data.  
  
## See Also  
 [rowversion](http://go.microsoft.com/fwlink/?LinkId=209262)   
 [TimestampAttribute](http://go.microsoft.com/fwlink/?LinkId=210358)   
 [ConcurrencyCheckAttribute](http://go.microsoft.com/fwlink/?LinkId=259517)   
 [RoundtripOriginalAttribute](http://go.microsoft.com/fwlink/?LinkId=259518)   
 [How to: Retrieve Data From a Query By Using Code](../vs140/how-to--retrieve-data-from-a-query-by-using-code.md)   
 [Data: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)