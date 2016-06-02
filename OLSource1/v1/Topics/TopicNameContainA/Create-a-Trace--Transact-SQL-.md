---
title: Create a Trace (Transact-SQL)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 79dd4254-e3c6-467a-bb6f-f99e51757e99
---
# Create a Trace (Transact-SQL)
  This topic describes how to use stored procedures to create a trace.  
  
### To create a trace  
  
1.  Execute **sp\_trace\_create** with the required parameters to create a new trace. The new trace will be in a stopped state \(*status* is **0**\).  
  
2.  Execute **sp\_trace\_setevent** with the required parameters to select the events and columns to trace.  
  
3.  Optionally, execute **sp\_trace\_setfilter** to set any or a combination of filters.  
  
     **sp\_trace\_setevent** and **sp\_trace\_setfilter** can be executed only on existing traces that are stopped.  
  
    > [!IMPORTANT]  
    >  Unlike regular stored procedures, parameters of all SQL Server Profiler stored procedures \(**sp\_trace\_*xx***\) are strictly typed and do not support automatic data type conversion. If these parameters are not called with the correct input parameter data types, as specified in the argument description, the stored procedure returns an error.  
  
## Example  
 The following code demonstrates creating a trace using [!INCLUDE[tsql](../../Token\Other/tsql_md.md)]. It is in three sections: creating the trace, populating the trace file, and stopping the trace. Customize the trace by adding the events that you want to trace. For the list of events and columns, see [sp_trace_setevent &#40;Transact-SQL&#41;](../Topic/sp_trace_setevent%20\(Transact-SQL\).md).  
  
 The following code creates a trace, adds events to the trace, and then starts the trace:  
  
```  
DECLARE @RC int, @TraceID int, @on BIT  
EXEC @rc = sp_trace_create @TraceID output, 0, N'C:\SampleTrace'  
  
-- Select the return code to see if the trace creation was successful.  
SELECT RC = @RC, TraceID = @TraceID  
  
-- Set the events and data columns you need to capture.  
SELECT @on = 1  
  
-- 10 is RPC:Completed event. 1 is TextData column.   
EXEC sp_trace_setevent @TraceID, 10, 1, @on   
-- 13 is SQL:BatchStarting, 11 is LoginName  
EXEC sp_trace_setevent @TraceID, 13, 11, @on   
-- 13 is SQL:BatchStarting, 14 is StartTime  
EXEC sp_trace_setevent @TraceID, 13, 14, @on   
-- 12 is SQL:BatchCompleted, 15 is EndTime  
EXEC sp_trace_setevent @TraceID, 12, 15, @on   
-- 13 is SQL:BatchStarting, 1 is TextData  
EXEC sp_trace_setevent @TraceID, 13, 1, @on   
  
-- Set any filter. Not provided in this example  
--EXEC sp_trace_setfilter 1, 10, 0, 6, N'%Profiler%'  
  
-- Start Trace (status 1 = start)  
EXEC @RC = sp_trace_setstatus @TraceID, 1  
GO  
  
```  
  
## Example  
 Now that the trace has been created and started, execute the following code to populate the trace with activity.  
  
```  
SELECT * FROM master.sys.databases  
GO  
SELECT * FROM ::fn_trace_getinfo(default)  
GO  
  
```  
  
## Example  
 The trace can be stopped and restarted at any time. In this example, execute the following code to stop the trace, close the trace, and delete the trace definition.  
  
```  
DECLARE @TraceID int  
-- Populate a variable with the trace_id of the current trace  
SELECT  @TraceID = TraceID FROM ::fn_trace_getinfo(default) WHERE VALUE = N'C:\SampleTrace.trc'  
  
-- First stop the trace.   
EXEC sp_trace_setstatus @TraceID, 0  
  
-- Close and then delete its definition from SQL Server.   
EXEC sp_trace_setstatus @TraceID, 2  
  
```  
  
## Example  
 To examine the trace file, open the SampleTrace.trc file using [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)].  
  
## See Also  
 [SQL Server Profiler Stored Procedures &#40;Transact-SQL&#41;](../Topic/SQL%20Server%20Profiler%20Stored%20Procedures%20\(Transact-SQL\).md)   
 [sp_trace_create &#40;Transact-SQL&#41;](../Topic/sp_trace_create%20\(Transact-SQL\).md)   
 [sp_trace_setevent &#40;Transact-SQL&#41;](../Topic/sp_trace_setevent%20\(Transact-SQL\).md)   
 [sp_trace_setfilter &#40;Transact-SQL&#41;](../Topic/sp_trace_setfilter%20\(Transact-SQL\).md)  
  
  