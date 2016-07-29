---
title: "Removing Database Mirroring (SQL Server)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 40c72091-8f03-4037-8b55-5e95309fe145
caps.latest.revision: 32
manager: jhubbard
---
# Removing Database Mirroring (SQL Server)
The database owner can manually stop a database mirroring session at any time, at either partner.  
  
## Impact of Removing Mirroring  
 When mirroring is removed, the following occurs:  
  
-   The relationship between the partners and between each partner and the witness breaks permanently, if any relationship exists.  
  
     If the partners are communicating with each other when the session is stopped, their relationship is immediately broken on both computers. If the partners are not communicating (the database is in a DISCONNECTED state at the time of stopping), the relationship is broken immediately on the partner from which mirroring is stopped; when the other partner tries to reconnect, it discovers that the database mirroring session has ended.  
  
-   Information about the mirroring session is dropped, unlike when pausing a session. Mirroring is removed on both the principal database and the mirror database. In **sys.databases**, the **mirroring_state** column and all other mirroring columns are set to NULL. For more information, see [sys.databases (Transact-SQL)](assetId:///480de2b0-2c16-497d-a6a3-bf7f52a7c9a0).  
  
-   Each partner server instance is left with a separate copy of the database.  
  
-   The mirror database is left in the RESTORING state (see the **state** column of **sys.databases**), because the mirror database was created by using RESTORE WITH NORECOVERY. At this point, you can drop the former mirror database or restore it using WITH RECOVERY. When you recover the database, it will have diverged from the former principal database because the recovery starts a new recovery fork.  
  
> [!NOTE]  
>  To continue mirroring after stopping a session, you must establish a new database mirroring session. If you create a log backup after stopping mirroring, you must apply it to the mirror database before restarting mirroring.  
  
##  <a name="RelatedTasks"></a> Related Tasks  
 **To remove database mirroring**  
  
-   [Remove Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Remove-Database-Mirroring--SQL-Server-.md)  
  
 **To start database mirroring**  
  
-   [Establish a Database Mirroring Session Using Windows Authentication (SQL Server Management Studio)](../../Topics/TopicNameContainA/Establish-a-Database-Mirroring-Session-Using-Windows-Authentication--SQL-Server-Management-Studio-.md)  
  
-   [Establish a Database Mirroring Session Using Windows Authentication (Transact-SQL)](../../Topics/TopicNameContainA/Establish-a-Database-Mirroring-Session-Using-Windows-Authentication--Transact-SQL-.md)  
  
   
  
## See Also  
 [ALTER DATABASE Database mirroring](assetId:///27a032ef-1cf6-4959-8e67-03d28c4b3465)   
 [Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Database-Mirroring--SQL-Server-.md)   
 [Pausing and Resuming Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Pausing-and-Resuming-Database-Mirroring--SQL-Server-.md)   
 [sys.databases (Transact-SQL)](assetId:///46c288c1-3410-4d68-a027-3bbf33239289)