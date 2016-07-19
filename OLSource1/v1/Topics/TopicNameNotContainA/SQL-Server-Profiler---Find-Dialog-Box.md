---
title: SQL Server Profiler - Find Dialog Box
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dfaeec04-93d3-4214-9fc1-38b80179b36b
manager: jhubbard
---
# SQL Server Profiler - Find Dialog Box
Use the **Find** dialog box to search a trace for specific characters or words. To cancel a search in progress, press ESC.  
  
 To open this dialog box in [!INCLUDE[ssSqlProfiler](../../Topics/TopicNameContainA/includes/ssSqlProfiler_md.md)], on the **Edit** menu, click **Find**.  
  
## Options  
 **Find what**  
 Enter the text that you want to search for. The search matches any string containing the specified string. For example, searching for "Completed" matches "SQL:BatchCompleted." Wild card characters (*, ?, etc.) are not supported.  
  
 **Search in column**  
 Click a data column to search, or click **<All columns\>** to search all the data columns in the trace.  
  
 **Match case**  
 Finds text that has the same case as the **Find what** box. Clear this check box to find examples in the trace that are in both uppercase and lowercase text characters.  
  
 **Match whole word**  
 Restricts the search to entire words. Clear the **Match whole word** check box to search for characters within a word.  
  
 **Find Next**  
 Finds the next example of the characters in the **Find what** box.  
  
 **Find Previous**  
 Searches backwards in the trace, to find the previous example of the characters in the **Find what** box.  
  
## See Also  
 [Find a Value or Data Column While Tracing (SQL Server Profiler)](../../Topics/TopicNameContainA/Find-a-Value-or-Data-Column-While-Tracing--SQL-Server-Profiler-.md)   
 [Create a Trace (SQL Server Profiler)](../../Topics/TopicNameContainA/Create-a-Trace--SQL-Server-Profiler-.md)   
 [Open a Trace Table (SQL Server Profiler)](../../Topics/TopicNameContainA/Open-a-Trace-Table--SQL-Server-Profiler-.md)   
 [Open a Trace File (SQL Server Profiler)](../../Topics/TopicNameContainA/Open-a-Trace-File--SQL-Server-Profiler-.md)   
 [SQL Server Profiler Templates and Permissions](../../Topics/TopicNameNotContainA/SQL-Server-Profiler-Templates-and-Permissions.md)   
 [SQL Server Profiler](../../Topics/TopicNameNotContainA/SQL-Server-Profiler.md)