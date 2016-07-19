---
title: View a Saved Trace (Transact-SQL)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3a95a816-aa89-4d5f-858c-968a9cb3ee87
manager: jhubbard
---
# View a Saved Trace (Transact-SQL)
This topic describes how to use built-in functions to view a saved trace.  
  
### To view a specific trace  
  
1.  Execute **fn_trace_getinfo** by specifying the ID of the trace about which information is needed. This function returns a table that lists the trace, trace property, and information about the property.  
  
     Invoke the function this way:  
  
    ```  
    SELECT *  
    FROM ::fn_trace_getinfo(trace_id)  
    ```  
  
### To view all existing traces  
  
1.  Execute **fn_trace_getinfo** by specifying `0` or `default`. This function returns a table that lists all the traces, their properties, and information about these properties.  
  
     Invoke the function as follows:  
  
    ```  
    SELECT *  
    FROM ::fn_trace_getinfo(default)  
    ```  
  
## .NET Framework Security  
 To run the built-in function **fn_trace_getinfo**, the user needs the following permission:  
  
 ALTER TRACE on the server.  
  
## See Also  
 [Viewing and Analyzing Traces with SQL Server Profiler](assetId:///04b140fe-110a-47b8-98b5-e4c161beb6c9)   
 [View and Analyze Traces with SQL Server Profiler](../../Topics/TopicNameNotContainA/View-and-Analyze-Traces-with-SQL-Server-Profiler.md)