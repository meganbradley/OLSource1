---
title: Considerations for Replaying Traces (SQL Server Profiler)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 73fa339f-b71a-4be4-97ca-d4ae84c8b90b
---
# Considerations for Replaying Traces (SQL Server Profiler)
  [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] cannot replay the following kinds of traces:  
  
-   Traces that contain transactional replication and other transaction log activity. These events are skipped. Other types of replication do not mark the transaction log so they are not affected.  
  
-   Traces that contain operations that involve globally unique identifiers \(GUID\). These events will be skipped.  
  
-   Traces that contain operations on **text**, **ntext**, and **image** columns involving the **bcp** utility, the BULK INSERT, READTEXT, WRITETEXT, and UPDATETEXT statements, and full\-text operations. These events are skipped.  
  
-   Traces that contain session binding: **sp\_getbindtoken** and **sp\_bindsession** system stored procedures. These events are skipped.  
  
> [!NOTE]  
>  If you do not use the preconfigured replay template \(**TSQL\_Replay**\), and do not capture all required data, [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] does not replay the trace. For more information, see [Replay Requirements](../../Topics\TopicNameNotContainA/Replay-Requirements.md).  
  
 For information about what permissions are required to replay a trace, see [Permissions Required to Run SQL Server Profiler](../../Topics\TopicNameNotContainA/Permissions-Required-to-Run-SQL-Server-Profiler.md).  
  
## See Also  
 [bcp Utility](../../Topics\TopicNameNotContainA/bcp-Utility.md)   
 [SQL Server Event Class Reference](../../Topics\TopicNameNotContainA/SQL-Server-Event-Class-Reference.md)   
 [sp_getbindtoken &#40;Transact-SQL&#41;](../Topic/sp_getbindtoken%20\(Transact-SQL\).md)   
 [sp_bindsession &#40;Transact-SQL&#41;](../Topic/sp_bindsession%20\(Transact-SQL\).md)   
 [BULK INSERT &#40;Transact-SQL&#41;](../Topic/BULK%20INSERT%20\(Transact-SQL\).md)   
 [READTEXT &#40;Transact-SQL&#41;](../Topic/READTEXT%20\(Transact-SQL\).md)   
 [WRITETEXT &#40;Transact-SQL&#41;](../Topic/WRITETEXT%20\(Transact-SQL\).md)   
 [UPDATETEXT &#40;Transact-SQL&#41;](../Topic/UPDATETEXT%20\(Transact-SQL\).md)  
  
  