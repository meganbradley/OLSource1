---
title: "Options (Query Results - SQL Server - Multi-Server)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d6768bd8-9cb5-4606-a726-a33a1df9e1bb
caps.latest.revision: 11
manager: jhubbard
---
# Options (Query Results - SQL Server - Multi-Server)
When you are querying multiple servers at the same time, use this page to specify the options for displaying result sets. Merge results combines the result sets from all servers into a single result set. When merging results, the first server to respond sets the schema for the result set. To merge the result sets, the query must return the same number of columns with the same column names from each server. When merging results, a message is displayed for each server that does not match the schema (column count and column names) that is returned by the first server to return results.  
  
 When you do not merge results, the result set from each server will be displayed in its own grid with its own schema.  
  
## UIElement List  
 **Merge results**  
 Select this check box to combine the result sets from several servers into the same grid.  
  
 **Add server name to the results**  
 Select this check box to include an additional column that provides the name of the server that produced each row.  
  
 **Add login name to the results**  
 Select this check box to include an additional column that provides the login that was used to connect to the server that provided each row.  
  
## See Also  
 [Create a Central Management Server and Server Group (SQL Server Management Studio)](../../Topics/TopicNameContainA/Create-a-Central-Management-Server-and-Server-Group--SQL-Server-Management-Studio-.md)   
 [Execute Statements Against Multiple Servers Simultaneously (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/Execute-Statements-Against-Multiple-Servers-Simultaneously--SQL-Server-Management-Studio-.md)