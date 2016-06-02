---
title: Event Pairing Target
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3c87dcfb-543a-4bd8-a73d-1390bdf4ffa3
---
# Event Pairing Target
  The event pairing target matches two events using one or more columns of data that are present in each event. Many events come in pairs, for example, lock acquires and lock releases. After an event sequence is paired, both events are discarded. Discarding matched sets allows for easy detection of lock acquisitions that have not been released.  
  
 By using event\-level filters, the pairing target can be used to only capture events that do not match pre\-set criteria.  
  
 When you use the event pairing target, you can choose two events that will be matched, together with a sequence of columns to perform the matching on. All the columns in this sequence must be of the same type.  
  
 The following table describes the available options for configuring event pairing.  
  
|Option|Allowed values|Description|  
|------------|--------------------|-----------------|  
|begin\_event|Any event name that is present in the current session.|The event name specifying the beginning event in a paired sequence.|  
|end\_event|Any event name that is present in the current session.|The event name specifying the ending event in a paired sequence.|  
|begin\_matching\_columns|A comma\-delimited, ordered list of column names.|The columns to perform matching on.|  
|end\_matching\_columns|A comma\-delimited, ordered list of column names.|The columns to perform matching on.|  
|begin\_matching\_actions|A comma\-delimited, ordered list of actions.|The actions to perform matching on.|  
|end\_matching\_actions|A comma\-delimited, ordered list of actions.|The actions to perform matching on.|  
|respond\_to\_memory\_pressure|0 \= Do not respond.<br /><br /> 1 \= Stop adding new orphans to the list when there is memory pressure.|The target response to memory events. If set to 1 and the server is low on memory, unpaired information that is being maintained is removed.|  
|max\_orphans||Specifies the total number of unpaired events that will be collected in the target. Once the limit is reached, unpaired events are removed on a first\-in, first\-out \(FIFO\) basis. Default \= 10,000.|  
  
 All the data associated with an event is captured and stored for future pairing. In addition, data added by actions is also collected. The collected event data is stored in memory, and therefore has a finite limit. This limit is based on system capacity and activity. Instead of taking the maximum amount of memory to be used as a parameter, the amount of memory used will be based on available system resources. When these are not available, unpaired events that have been retained will be dropped. If an event has not been paired and is dropped, the matching event will appear as an unpaired event.  
  
 The pairing target serializes unpaired events to an XML format. This format does not conform to any schema. The format only contains two element types. The **\<unpaired\>** element is the root, followed by one. **\<event\>** element for each unpaired event that is currently being tracked. The **\<event\>** element contains one attribute that contains the name of the unpaired event.  
  
## Adding the Target to a Session  
 To add the pair matching target to an Extended Events session, you must include the following statement when you create or alter an event session:  
  
```  
ADD TARGET package0.pair_matching   
```  
  
 You would follow this with a SET statement, to define the beginning and ending events, and which actions or columns to match. The following example shows sample syntax for pair matching the sqlserver.lock\_acquired and sqlserver.lock\_released events.  
  
```  
   ( SET begin_event = 'sqlserver.lock_acquired',  
      begin_matching_columns = 'database_id, resource_0, resource_1, resource_2, transaction_id, mode',  
      end_event = 'sqlserver.lock_released',  
      end_matching_columns = 'database_id, resource_0, resource_1, resource_2, transaction_id, mode',  
   respond_to_memory_pressure = 1)  
```  
  
 For more information, see [Determine Which Queries Are Holding Locks](../../Topics\TopicNameNotContainA/Determine-Which-Queries-Are-Holding-Locks.md).  
  
## Reviewing the Target Output  
 To review the output for the pair matching target, you can use the following query, replacing *session\_name* with the name of the event session.  
  
```  
SELECT name, target_name, CAST(xet.target_data AS xml)  
FROM sys.dm_xe_session_targets AS xet  
JOIN sys.dm_xe_sessions AS xe  
   ON (xe.address = xet.event_session_address)  
WHERE xe.name = 'session_name'  
```  
  
 The following example shows the pairing target output format.  
  
```  
<unpaired truncated = "0" matchedCount = "[matched count]" memoryPressureDroppedCount = " [lost count]">  
    <event name  = "[event name]" package = "[package]" id= "[event ID value]" version = "[event version]">  
    <data name = "[column name]">   
    <type name = "[column type]" package = "[type package]" />   
    <value>[column value]</value>  
    <text value>[text value]</text>>  
        </data>  
    </event>  
</unpaired>  
```  
  
## See Also  
 [SQL Server Extended Events Targets](../../Topics\TopicNameNotContainA/SQL-Server-Extended-Events-Targets.md)   
 [sys.dm_xe_session_targets &#40;Transact-SQL&#41;](../Topic/sys.dm_xe_session_targets%20\(Transact-SQL\).md)   
 [CREATE EVENT SESSION &#40;Transact-SQL&#41;](../Topic/CREATE%20EVENT%20SESSION%20\(Transact-SQL\).md)   
 [ALTER EVENT SESSION &#40;Transact-SQL&#41;](../Topic/ALTER%20EVENT%20SESSION%20\(Transact-SQL\).md)  
  
  