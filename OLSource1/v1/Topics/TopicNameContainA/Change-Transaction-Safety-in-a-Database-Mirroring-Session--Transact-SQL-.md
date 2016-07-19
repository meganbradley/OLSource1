---
title: Change Transaction Safety in a Database Mirroring Session (Transact-SQL)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8b03bb82-8589-4558-8545-9942fe008391
manager: jhubbard
---
# Change Transaction Safety in a Database Mirroring Session (Transact-SQL)
Transaction safety is the attribute that controls the operating mode of the session. At any time, however, the database owner can change the transaction safety. By default, the level of transaction safety is set to FULL (synchronous operating mode).  
  
 Turning off transaction safety shifts the session into asynchronous operating mode, which maximizes performance. If the principal becomes unavailable, the mirror stops but is available as a warm standby (failover requires forcing service with possible data loss).  
  
### To turn on transaction safety  
  
1.  Connect to the principal server.  
  
2.  Issue the following Transact-SQL statement:  
  
    ```  
    ALTER DATABASE <database> SET PARTNER SAFETY FULL  
    ```  
  
     where *<database\>* is the name of the mirrored database.  
  
### To turn off transaction safety  
  
1.  Connect to the principal server.  
  
2.  Issue the following statement:  
  
    ```  
    ALTER DATABASE <database> SET PARTNER SAFETY OFF  
    ```  
  
     where *<database\>* is the mirrored database.  
  
## See Also  
 [ALTER DATABASE Database Mirroring (Transact-SQL)](assetId:///27a032ef-1cf6-4959-8e67-03d28c4b3465)   
 [Database Mirroring Operating Modes](../../Topics/TopicNameNotContainA/Database-Mirroring-Operating-Modes.md)