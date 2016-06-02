---
title: Filter a Trace
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 019c10ab-68f6-4e40-a5e8-735b2e1270db
---
# Filter a Trace
  Filters limit the events collected in a trace. If a filter is not set, all events of the selected event classes are returned in the trace output. For example, limiting the Windows user names in a trace to specific users reduces the output data to those users only.  
  
 It is not mandatory to set a filter for a trace. However, a filter minimizes the overhead that is incurred during a trace. A filter returns focused data and thus makes performance analysis and audits easier.  
  
 To filter the event data captured within a trace, select trace event criteria that return only relevant data from the trace. For example, you can include or exclude monitoring the activity of a specific application from the trace.  
  
> [!NOTE]  
>  When [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] creates traces, it filters out its own activity by default.  
  
 As an additional example, if you monitor queries to determine the batches that take the longest time to execute, set the trace event criteria to monitor only those batches that take longer than 30 seconds to execute \(a CPU minimum value of 30,000 milliseconds\).  
  
## Filter Creation Guidelines  
 In general, follow these steps to filter a trace.  
  
1.  Identify the events that you want to include in the trace.  
  
2.  Identify the data and data columns that contain the information you need.  
  
3.  Identify a subset of the data you need and define filters based on that subset of data.  
  
 For example, you may be interested only in events that take longer than a certain length of time. You could create a trace that includes events where the **Duration** data column is greater than 300 milliseconds. Your trace will not include events that finish in less than 300 milliseconds.  
  
 You can create filters by using SQL Server Profiler or Transact\-SQL stored procedures.  
  
 **To filter events in a trace template**  
  
 [Filter Events in a Trace &#40;SQL Server Profiler&#41;](../Topic/Filter%20Events%20in%20a%20Trace%20\(SQL%20Server%20Profiler\).md)  
  
 [Set a Trace Filter &#40;Transact-SQL&#41;](../Topic/Set%20a%20Trace%20Filter%20\(Transact-SQL\).md)  
  
 **To modify filters**  
  
 [Modify a Filter &#40;SQL Server Profiler&#41;](../Topic/Modify%20a%20Filter%20\(SQL%20Server%20Profiler\).md)  
  
 Filter availability depends on the data column. Some data columns cannot be filtered. The data columns that can be filtered are filterable only by certain relational operators, as shown in the following table.  
  
|Relational operator|Operator symbol|Description|  
|-------------------------|---------------------|-----------------|  
|Like|LIKE|Specifies that the trace event data must be like the text entered. Allows multiple values.|  
|Not like|NOT LIKE|Specifies that the trace event data must not be like the text entered. Allows multiple values.|  
|Equals|\=|Specifies that the trace event data must equal the value entered. Allows multiple values.|  
|Not equal to|\<\>|Specifies that the trace event data must not equal the value entered. Allows multiple values.|  
|Greater than|\>|Specifies that the trace event data must be greater than the value entered.|  
|Greater than or equal to|\>\=|Specifies that the trace event data must be greater than or equal to the value entered.|  
|Less than|\<|Specifies that the trace event data must be less than the value entered.|  
|Less than or equal to|\<\=|Specifies that the trace event data must be less than or equal to the value entered.|  
  
 The following table lists the filterable data columns and the available relational operators.  
  
|Data columns|Relational operators|  
|------------------|--------------------------|  
|**ApplicationName**|LIKE, NOT LIKE|  
|**BigintData1**|\=, \<\>, \>\=, \<\=|  
|**BigintData2**|\=, \<\>, \>\=, \<\=|  
|**BinaryData**|Use [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] to filter events in this data column. For more information, see [Filter Traces with SQL Server Profiler](../../Topics\TopicNameNotContainA/Filter-Traces-with-SQL-Server-Profiler.md).|  
|**ClientProcessID**|\=, \<\>, \>\=, \<\=|  
|**ColumnPermissions**|\=, \<\>, \>\=, \<\=|  
|**CPU**|\=, \<\>, \>\=, \<\=|  
|**DatabaseID**|\=, \<\>, \>\=, \<\=|  
|**DatabaseName**|LIKE, NOT LIKE|  
|**DBUserName**|LIKE, NOT LIKE|  
|**Duration**|\=, \<\>, \>\=, \<\=|  
|**EndTime**|\>\=, \<\=|  
|**Error**|\=, \<\>, \>\=, \<\=|  
|**EventSubClass**|\=, \<\>, \>\=, \<\=|  
|**FileName**|LIKE, NOT LIKE|  
|**GUID**|Use [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] to filter events in this data column. For more information, see [Filter Traces with SQL Server Profiler](../../Topics\TopicNameNotContainA/Filter-Traces-with-SQL-Server-Profiler.md).|  
|**Handle**|\=, \<\>, \>\=, \<\=|  
|**HostName**|LIKE, NOT LIKE|  
|**IndexID**|\=, \<\>, \>\=, \<\=|  
|**IntegerData**|\=, \<\>, \>\=, \<\=|  
|**IntegerData2**|\=, \<\>, \>\=, \<\=|  
|**IsSystem**|\=, \<\>, \>\=, \<\=|  
|**LineNumber**|\=, \<\>, \>\=, \<\=|  
|**LinkedServerName**|LIKE, NOT LIKE|  
|**LoginName**|LIKE, NOT LIKE|  
|**LoginSid**|Use [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] to filter events in this data column. For more information, see [Filter Traces with SQL Server Profiler](../../Topics\TopicNameNotContainA/Filter-Traces-with-SQL-Server-Profiler.md).|  
|**MethodName**|LIKE, NOT LIKE|  
|**Mode**|\=, \<\>, \>\=, \<\=|  
|**NestLevel**|\=, \<\>, \>\=, \<\=|  
|**NTDomainName**|LIKE, NOT LIKE|  
|**NTUserName**|LIKE, NOT LIKE|  
|**ObjectID**|\=, \<\>, \>\=, \<\=|  
|**ObjectID2**|\=, \<\>, \>\=, \<\=|  
|**ObjectName**|LIKE, NOT LIKE|  
|**ObjectType**|\=, \<\>, \>\=, \<\=|  
|**Offset**|\=, \<\>, \>\=, \<\=|  
|**OwnerID**|\=, \<\>, \>\=, \<\=|  
|**OwnerName**|LIKE, NOT LIKE|  
|**ParentName**|LIKE, NOT LIKE|  
|**Permissions**|\=, \<\>, \>\=, \<\=|  
|**ProviderName**|LIKE, NOT LIKE|  
|**Reads**|\=, \<\>, \>\=, \<\=|  
|**RequestID**|\=, \<\>, \>\=, \<\=|  
|**RoleName**|LIKE, NOT LIKE|  
|**RowCounts**|\=, \<\>, \>\=, \<\=|  
|**SessionLoginName**|LIKE, NOT LIKE|  
|**Severity**|\=, \<\>, \>\=, \<\=|  
|**SourceDatabaseID**|\=, \<\>, \>\=, \<\=|  
|**SPID**|\=, \<\>, \>\=, \<\=|  
|**SqlHandle**|Use [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] to filter events in this data column. For more information, see [Filter Traces with SQL Server Profiler](../../Topics\TopicNameNotContainA/Filter-Traces-with-SQL-Server-Profiler.md).|  
|**StartTime**|\>\=, \<\=|  
|**State**|\=, \<\>, \>\=, \<\=|  
|**Success**|\=, \<\>, \>\=, \<\=|  
|**TargetLoginName**|LIKE, NOT LIKE|  
|**TargetLoginSid**|Use [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] to filter events in this data column. For more information, see [Filter Traces with SQL Server Profiler](../../Topics\TopicNameNotContainA/Filter-Traces-with-SQL-Server-Profiler.md).|  
|**TargetUserName**|LIKE, NOT LIKE|  
|**TextData** \*|LIKE, NOT LIKE|  
|**TransactionID**|\=, \<\>, \>\=, \<\=|  
|**Type**|\=, \<\>, \>\=, \<\=|  
|**Writes**|\=, \<\>, \>\=, \<\=|  
|**XactSequence**|\=, \<\>, \>\=, \<\=|  
  
 \* If tracing events from the **osql** utility or the **sqlcmd** utility, always append **%** to filters on the **TextData** data column.  
  
 As a security precaution, SQL Trace automatically omits from the trace any information from security\-related stored procedures that affect passwords. This security mechanism is nonconfigurable and is always in effect. It prevents users, who otherwise have permissions to trace all activity on [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], from capturing passwords.  
  
 The following security\-related stored procedures are monitored, but no output is written to the **TextData** data column:  
  
 [sp_addapprole &#40;Transact-SQL&#41;](../Topic/sp_addapprole%20\(Transact-SQL\).md)  
  
 [sp_adddistpublisher &#40;Transact-SQL&#41;](../Topic/sp_adddistpublisher%20\(Transact-SQL\).md)  
  
 [sp_adddistributiondb &#40;Transact-SQL&#41;](../Topic/sp_adddistributiondb%20\(Transact-SQL\).md)  
  
 [sp_adddistributor &#40;Transact-SQL&#41;](../Topic/sp_adddistributor%20\(Transact-SQL\).md)  
  
 [sp_addlinkedserver &#40;Transact-SQL&#41;](../Topic/sp_addlinkedserver%20\(Transact-SQL\).md)  
  
 [sp_addlinkedsrvlogin &#40;Transact-SQL&#41;](../Topic/sp_addlinkedsrvlogin%20\(Transact-SQL\).md)  
  
 [sp_addlogin &#40;Transact-SQL&#41;](../Topic/sp_addlogin%20\(Transact-SQL\).md)  
  
 [sp_addmergepullsubscription_agent &#40;Transact-SQL&#41;](../Topic/sp_addmergepullsubscription_agent%20\(Transact-SQL\).md)  
  
 [sp_addpullsubscription_agent &#40;Transact-SQL&#41;](../Topic/sp_addpullsubscription_agent%20\(Transact-SQL\).md)  
  
 [sp_addremotelogin &#40;Transact-SQL&#41;](../Topic/sp_addremotelogin%20\(Transact-SQL\).md)  
  
 [sp_addsubscriber &#40;Transact-SQL&#41;](../Topic/sp_addsubscriber%20\(Transact-SQL\).md)  
  
 [sp_approlepassword &#40;Transact-SQL&#41;](../Topic/sp_approlepassword%20\(Transact-SQL\).md)  
  
 [sp_changedistpublisher &#40;Transact-SQL&#41;](../Topic/sp_changedistpublisher%20\(Transact-SQL\).md)  
  
 [sp_changesubscriber &#40;Transact-SQL&#41;](../Topic/sp_changesubscriber%20\(Transact-SQL\).md)  
  
 [sp_dsninfo &#40;Transact-SQL&#41;](../Topic/sp_dsninfo%20\(Transact-SQL\).md)  
  
 [sp_helpsubscription_properties &#40;Transact-SQL&#41;](../Topic/sp_helpsubscription_properties%20\(Transact-SQL\).md)  
  
 [sp_link_publication &#40;Transact-SQL&#41;](../Topic/sp_link_publication%20\(Transact-SQL\).md)  
  
 [sp_password &#40;Transact-SQL&#41;](../Topic/sp_password%20\(Transact-SQL\).md)  
  
 [sp_setapprole &#40;Transact-SQL&#41;](../Topic/sp_setapprole%20\(Transact-SQL\).md)  
  
  