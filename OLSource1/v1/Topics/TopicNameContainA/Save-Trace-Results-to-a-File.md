---
title: Save Trace Results to a File
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 74f80667-62f3-4e14-bb1a-f0c2b6ef3402
manager: jhubbard
---
# Save Trace Results to a File
You can save trace results to a file. A trace file is a file where the trace results are written. A trace file can be located either in a local directory (such as C:\\*foldername*\\*filename.trc*) or a network directory (such as \\\computername\sharename\filename.trc).  
  
 You can use the trace files to do the following:  
  
-   Replay traces  
  
-   Audit [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]  
  
-   Conduct performance analysis  
  
-   Correlate trace events with performance counters to enhance problem detection  
  
-   Perform Database Engine Tuning Advisor analysis  
  
-   Carry out query optimization  
  
 [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] saves trace results to a file when a path and file name are specified for the **@tracefile** argument of the stored procedure **sp_trace_create**.  
  
> [!NOTE]  
>  If a path is specified to the **sp_trace_create** stored procedure for saving the trace file, the directory must be accessible to the server. Also be aware that if a local directory is specified to **sp_trace_create**, it is a local directory on the server computer.  
  
 If [!INCLUDE[ssSqlProfiler](../../Topics/TopicNameContainA/includes/ssSqlProfiler_md.md)] is used, it allows you to save trace results to a file or to a table. Saving trace results to a table allows the same access as saving the trace to a file plus you can query the table to search for specific events.  
  
 For more information about saving trace results, see [Save Trace Results to a Table (SQL Server Profiler)](../../Topics/TopicNameContainA/Save-Trace-Results-to-a-Table--SQL-Server-Profiler-.md) and [Save Trace Results to a File (SQL Server Profiler)](../../Topics/TopicNameContainA/Save-Trace-Results-to-a-File--SQL-Server-Profiler-.md).  
  
## See Also  
 [sp_trace_create (Transact-SQL)](assetId:///f3a43597-4c5a-4520-bcab-becdbbf81d2e)   
 [Create a Trace (Transact-SQL)](../../Topics/TopicNameContainA/Create-a-Trace--Transact-SQL-.md)   
 [Create a Trace (SQL Server Profiler)](../../Topics/TopicNameContainA/Create-a-Trace--SQL-Server-Profiler-.md)