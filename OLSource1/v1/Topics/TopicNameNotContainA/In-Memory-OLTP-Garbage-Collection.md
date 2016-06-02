---
title: In-Memory OLTP Garbage Collection
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine-imoltp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 940140a7-4785-46fc-8bf4-151435dccd3c
---
# In-Memory OLTP Garbage Collection
  A data row is considered stale if it was deleted by a transaction that is no longer active. A stale row is eligible for garbage collection. The following are characteristics of garbage collection in [!INCLUDE[hek_2](../../Token\Other/hek_2_md.md)]:  
  
-   Non\-blocking. Garbage collection is distributed over time with minimal impact on the workload.  
  
-   Cooperative. User transactions participate in garbage collection with main garbage\-collection thread.  
  
-   Efficient. User transactions delink stale rows in the access path \(the index\) being used. This reduces the work required when the row is finally removed.  
  
-   Responsive. Memory pressure leads to aggressive garbage collection.  
  
-   Scalable. After commit, user transactions do part of the work of garbage collection. The more transaction activity, the more the transactions delink stale rows.  
  
 Garbage collection is controlled by the main garbage collection thread. The main garbage collection thread runs every minute, or when the number of committed transactions exceeds an internal threshold. The task of the garbage collector is to:  
  
-   Identify transactions that have deleted or updated a set of rows and have committed before the oldest active transaction.  
  
-   Identity row versions created by these old transactions.  
  
-   Group old rows into one or more units of 16 rows each. This is done to distribute the work of the garbage collector into smaller units.  
  
-   Move these work units into the garbage collection queue, one for each scheduler. Refer to the garbage collector DMVs for the details: [sys.dm_xtp_gc_stats &#40;Transact-SQL&#41;](../Topic/sys.dm_xtp_gc_stats%20\(Transact-SQL\).md), [sys.dm_db_xtp_gc_cycle_stats &#40;Transact-SQL&#41;](../Topic/sys.dm_db_xtp_gc_cycle_stats%20\(Transact-SQL\).md), and [sys.dm_xtp_gc_queue_stats &#40;Transact-SQL&#41;](../Topic/sys.dm_xtp_gc_queue_stats%20\(Transact-SQL\).md).  
  
 After a user transaction commits, it identifies all queued items associated with the scheduler it ran on and then releases the memory. If the garbage collection queue on the scheduler is empty, it searches for any non\-empty queue in the current NUMA node. If there is low transactional activity and there is memory pressure, the main garbage\-collection thread can access garbage collect rows from any queue. If there is no transactional activity after \(for example\) deleting a large number of rows and there is no memory pressure, the deleted rows will not be garbage collected until the transactional activity resumes or there is memory pressure.  
  
## See Also  
 [Managing Memory for In-Memory OLTP](../../Topics\TopicNameNotContainA/Managing-Memory-for-In-Memory-OLTP.md)  
  
  