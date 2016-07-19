---
title: ADO NET Source Editor (Connection Manager Page)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7de3f438-bdd6-49b5-937a-47369e754943
manager: jhubbard
---
# ADO NET Source Editor (Connection Manager Page)
Use the **Connection Manager** page of the **ADO NET Source Editor** dialog box to select the [!INCLUDE[vstecado](../../Topics/TopicNameContainA/includes/vstecado_md.md)] connection manager for the source. This page also lets you select a table or view from the database.  
  
 To learn more about the ADO NET source, see [ADO NET Source](../../Topics/TopicNameNotContainA/ADO-NET-Source.md).  
  
 **To open the Connection Manager page**  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], open the [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] package that has the ADO NET source.  
  
2.  On the **Data Flow** tab, double-click the ADO NET source.  
  
3.  In the **ADO NET Source Editor**, click **Connection Manager**.  
  
## Static Options  
 **ADO.NET connection manager**  
 Select an existing connection manager from the list, or create a new connection by clicking **New**.  
  
 **New**  
 Create a new connection manager by using the **Configure ADO.NET Connection Manager** dialog box.  
  
 **Data access mode**  
 Specify the method for selecting data from the source.  
  
|Option|Description|  
|------------|-----------------|  
|Table or view|Retrieve data from a table or view in the [!INCLUDE[vstecado](../../Topics/TopicNameContainA/includes/vstecado_md.md)] data source.|  
|SQL command|Retrieve data from the [!INCLUDE[vstecado](../../Topics/TopicNameContainA/includes/vstecado_md.md)] data source by using a SQL query.|  
  
 **Preview**  
 Preview results by using the **Data View** dialog box. **Preview** can display up to 200 rows.  
  
> [!NOTE]  
>  When you preview data, columns with a CLR user-defined type do not contain data. Instead the values <value too big to display\> or System.Byte[] display. The former displays when the data source is accessed by using the [!INCLUDE[vstecado](../../Topics/TopicNameContainA/includes/vstecado_md.md)] provider, the latter when using the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Native Client provider.  
  
## Data Access Mode Dynamic Options  
  
### Data access mode = Table or view  
 **Name of the table or the view**  
 Select the name of the table or view from a list of those available in the data source.  
  
### Data access mode = SQL command  
 **SQL command text**  
 Enter the text of a SQL query, build the query by clicking **Build Query**, or locate the file that contains the query text by clicking **Browse**.  
  
 **Build query**  
 Use the **Query Builder** dialog box to construct the SQL query visually.  
  
 **Browse**  
 Use the **Open** dialog box to locate the file that contains the text of the SQL query.  
  
## See Also  
 [ADO NET Source Editor (Columns Page)](../../Topics/TopicNameNotContainA/ADO-NET-Source-Editor--Columns-Page-.md)   
 [ADO NET Source Editor (Error Output Page)](../../Topics/TopicNameNotContainA/ADO-NET-Source-Editor--Error-Output-Page-.md)   
 [ADO.NET Connection Manager](../../Topics/TopicNameNotContainA/ADO.NET-Connection-Manager.md)