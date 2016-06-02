---
title: Modify an Existing Trace (Transact-SQL)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8792b43f-2510-44e3-9239-e73ad8227b89
---
# Modify an Existing Trace (Transact-SQL)
  This topic describes how to use stored procedures to modify an existing trace.  
  
### To modify an existing trace  
  
1.  If the trace is already running, execute **sp\_trace\_setstatus** by specifying **@status \= 0** to stop the trace.  
  
2.  To modify trace events, execute **sp\_trace\_setevent** by specifying the changes through the parameters. Listed in order, the parameters are:  
  
    -   **@traceid** \(Trace ID\)  
  
    -   **@eventid** \(Event ID\)  
  
    -   **@columnid** \(Column ID\)  
  
    -   **@on** \(ON\)  
  
     When you modify the **@on** parameter, keep in mind its interaction with the **@columnid** parameter:  
  
    |ON|Column ID|Result|  
    |--------|---------------|------------|  
    |ON \(**1**\)|NULL|Event is turned on. All columns are cleared.|  
    ||NOT NULL|Column is turned on for the specified event.|  
    |OFF \(**0**\)|NULL|Event is turned off. All columns are cleared.|  
    ||NOT NULL|Column is turned off for the specified event.|  
  
> [!IMPORTANT]  
>  Unlike regular stored procedures, parameters of all [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] stored procedures \(**sp\_trace\_*xx***\) are strictly typed and do not support automatic data type conversion. If these parameters are not called with the correct input parameter data types, as specified in the argument description, the stored procedure returns an error.  
  
## See Also  
 [sp_trace_setevent &#40;Transact-SQL&#41;](../Topic/sp_trace_setevent%20\(Transact-SQL\).md)   
 [sp_trace_setstatus &#40;Transact-SQL&#41;](../Topic/sp_trace_setstatus%20\(Transact-SQL\).md)   
 [System Stored Procedures &#40;Transact-SQL&#41;](../Topic/System%20Stored%20Procedures%20\(Transact-SQL\).md)   
 [SQL Server Profiler Stored Procedures &#40;Transact-SQL&#41;](../Topic/SQL%20Server%20Profiler%20Stored%20Procedures%20\(Transact-SQL\).md)  
  
  