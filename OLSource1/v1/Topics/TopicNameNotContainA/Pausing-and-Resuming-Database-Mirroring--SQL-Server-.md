---
title: "Pausing and Resuming Database Mirroring (SQL Server)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c67802c6-ee8c-4cbd-a6d4-f7b80413a4ab
caps.latest.revision: 33
manager: jhubbard
---
# Pausing and Resuming Database Mirroring (SQL Server)
The database owner can pause and later resume a database mirroring session at any time. Pausing preserves the session state while suspending mirroring. During bottlenecks, pausing might be useful to improve performance on the principal server.  
  
 When a session is paused, the principal database remains available. Pausing sets the state of the mirroring session to SUSPENDED, and the mirror database no longer keeps up with the principal database, causing the principal database to run exposed.  
  
 We recommend that you resume a paused session quickly, because as long as a database mirroring session remains paused, the transaction log cannot be truncated. Therefore, if a database mirroring session is paused for too long, the transaction log fills up, making the database unavailable. For an explanation of why this happens, see "How Pausing and Resuming Affect Log Truncation," later in this topic.  
  
> [!IMPORTANT]  
>  Following a forced service, when the original principal server reconnects mirroring is suspended. Resuming mirroring in this situation could possibly cause data loss on the original principal server. For information about managing the potential data loss, see [Database Mirroring Operating Modes](../../Topics/TopicNameNotContainA/Database-Mirroring-Operating-Modes.md).  
  
 **In this Topic:**  
  
-   [How Pausing and Resuming Affect Log Truncation](#EffectOnLogTrunc)  
  
-   [Avoid a Full Transaction Log](#AvoidFullLog)  
  
-   [Related Tasks](#RelatedTasks)  
  
##  <a name="EffectOnLogTrunc"></a> How Pausing and Resuming Affect Log Truncation  
 Normally, when an automatic checkpoint is performed on a database, its transaction log is truncated to that checkpoint after the next log backup. While a database mirroring session remains paused, all of the current log records remain active because the principal server is waiting to send them to the mirror server. The unsent log records accumulate in the transaction log of the principal database until the session resumes and the principal server has sent the log records to the mirror server.  
  
 When the session is resumed, the principal server immediately begins sending the accumulated log records to the mirror server. After the mirror server confirms that it has queued the log record corresponding to the oldest automatic checkpoint, the principal server truncates the log of the principal database to that checkpoint. The mirror server truncates the redo queue at the same log record. As this process is repeated for each successive checkpoint, the log is truncated in stages, checkpoint by checkpoint.  
  
> [!NOTE]  
>  For more information about the checkpoints and log truncation, see [Database Checkpoints (SQL Server)](../../Topics/TopicNameNotContainA/Database-Checkpoints--SQL-Server-.md).  
  
##  <a name="AvoidFullLog"></a> Avoid a Full Transaction Log  
 If the log fills up (either because it reaches its maximum size or the server instance runs out of space), the database cannot perform any more updates. To avoid this problem, you have two alternatives:  
  
-   Resume the database mirroring session before the log fills up, or add more log space. Resuming database mirroring lets the principal server send its accumulated active log to the mirror server and puts the mirror database in the SYNCHRONIZING state. The mirror server can then harden the log to disk and start to redo it.  
  
-   Stop the database mirroring session by removing mirroring.  
  
     Unlike pausing a session, removing mirroring drops all information about the mirroring session. Each partner server instance retains its own copy of the database. If the former mirror copy is recovered, it will have diverged from the former principal copy and be behind by the amount of time that has elapsed since the session was paused. For more information, see [Removing Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Removing-Database-Mirroring--SQL-Server-.md).  
  
##  <a name="RelatedTasks"></a> Related Tasks  
 **To pause or resume database mirroring**  
  
-   [Pause or Resume a Database Mirroring Session (SQL Server)](../../Topics/TopicNameContainA/Pause-or-Resume-a-Database-Mirroring-Session--SQL-Server-.md)  
  
 **To stop database mirroring**  
  
-   [Remove Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Remove-Database-Mirroring--SQL-Server-.md)  
  
## See Also  
 [ALTER DATABASE](assetId:///15f8affd-8f39-4021-b092-0379fc6983da)   
 [Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Database-Mirroring--SQL-Server-.md)   
 [Removing Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Removing-Database-Mirroring--SQL-Server-.md)