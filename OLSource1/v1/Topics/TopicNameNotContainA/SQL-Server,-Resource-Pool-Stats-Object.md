---
title: SQL Server, Resource Pool Stats Object
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bb46e029-fcf9-4aeb-a066-be41e7668fb9
---
# SQL Server, Resource Pool Stats Object
  The SQLServer:Resource Pool Stats object contains performance counters that report information about Resource Governor resource pool statistics.  
  
 Each active resource pool creates an instance of the SQLServer:Resource Pool Stats performance object that has the same instance name as the Resource Governor resource pool name. The following table describes counters supported on this instance.  
  
|Counter name|Description|  
|------------------|-----------------|  
|CPU usage %|The CPU bandwidth usage by all requests in all workload groups belonging to this pool. This is measured relative to the computer and normalized to all CPUs on the system. This value will change as the amount of CPU available to the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] process changes. It is not normalized to what the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] process receives.|  
|CPU usage target %|The target value of CPU usage % for the resource pool based on the resource pool configuration settings and system load.|  
|CPU control effect %|The effect of Resource Governor on the resource pool. Calculated as \(CPU usage %\) \/ \(CPU usage % without Resource Governor.|  
|Compile memory target \(KB\)|The current memory broker target, in kilobytes \(KB\), for query compiles.|  
|Cache memory target \(KB\)|The current memory broker target, in kilobytes \(KB\), for cache.|  
|Query exec memory target \(KB\)|The current memory broker target, in kilobytes \(KB\), for query execution memory grant. This information is also available in [sys.dm\_exec\_query\_memory\_grants](../Topic/sys.dm_exec_query_memory_grants%20\(Transact-SQL\).md).|  
|Memory grants\/sec|The number of memory grants occurring in this resource pool per second.|  
|Active memory grants count|Current total count of memory grants. This information is also available in [sys.dm\_exec\_query\_memory\_grants](../Topic/sys.dm_exec_query_memory_grants%20\(Transact-SQL\).md).|  
|Memory grant timeouts\/sec|The number of memory grant time\-outs per second.|  
|Active memory grant amount \(KB\)|The current total amount, in kilobytes \(KB\), of granted memory. This information is also available in [sys.dm\_exec\_query\_resource\_semaphores](../Topic/sys.dm_exec_query_resource_semaphores%20\(Transact-SQL\).md).|  
|Pending memory grant count|The number of requests for memory grants pending in the queues. This information is also available in [sys.dm\_exec\_query\_resource\_semaphores](../Topic/sys.dm_exec_query_resource_semaphores%20\(Transact-SQL\).md).|  
|Max memory \(KB\)|The maximum amount, in kilobytes \(KB\), of memory that the resource pool can have based on the resource pool settings and server state.|  
|Used memory \(KB\)|The amount of memory used, in kilobytes \(KB\), for the resource pool.|  
|Target memory \(KB\)|The target amount, in kilobytes \(KB\), of memory the resource pool is trying to obtain based on the resource pool settings and server state.|  
|Disk Read IO\/sec|Number of read operations from the disk in the last second.|  
|Disk Read IO Throttled\/sec|Number of read operations throttled in the last second.|  
|Disk Read Bytes\/sec|Number of bytes read from the disk in the last second.|  
|Avg Disk Read IO \(ms\)|Average time, in milliseconds, of a read operation from the disk.|  
|Disk Write IO\/sec|Number of write operations to the disk in the last second.|  
|Disk Write IO Throttled\/sec|Number of write operations throttled in the last second.|  
|Disk Write Bytes\/sec|Number of bytes written to the disk in the last second.|  
|Avg Disk Write IO \(ms\)|Average time, in milliseconds, of a write operation to the disk.|  
  
## See Also  
 [Monitor Resource Usage &#40;System Monitor&#41;](../Topic/Monitor%20Resource%20Usage%20\(System%20Monitor\).md)   
 [SQL Server, Workload Group Stats Object](../../Topics\TopicNameNotContainA/SQL-Server,-Workload-Group-Stats-Object.md)   
 [Resource Governor](../../Topics\TopicNameNotContainA/Resource-Governor.md)  
  
  