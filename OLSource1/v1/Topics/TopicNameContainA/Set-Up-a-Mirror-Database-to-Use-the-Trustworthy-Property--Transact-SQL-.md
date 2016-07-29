---
title: "Set Up a Mirror Database to Use the Trustworthy Property (Transact-SQL)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6993b076-78ef-453e-b0ea-e341b8e5ee3e
caps.latest.revision: 16
manager: jhubbard
---
# Set Up a Mirror Database to Use the Trustworthy Property (Transact-SQL)
When a database is backed up, the TRUSTWORTHY database property is set to OFF. Therefore, on a new mirror database TRUSTWORTHY is always OFF. If the database needs to be trustworthy after a failover, extra setup steps are necessary after mirroring begins.  
  
> [!NOTE]  
>  For information about this database property, see [TRUSTWORTHY Database Property](../../Topics/TopicNameNotContainA/TRUSTWORTHY-Database-Property.md).  
  
## Procedure  
  
#### To setup a mirror database to use the Trustworthy Property  
  
1.  On the principal server instance, verify that the principal database has the Trustworthy property turned on.  
  
    ```  
    SELECT name, database_id, is_trustworthy_on FROM sys.databases   
    ```  
  
     For more information, see [sys.databases (Transact-SQL)](assetId:///46c288c1-3410-4d68-a027-3bbf33239289).  
  
2.  After starting mirroring, verify that the database is currently the principal database, the session is using a synchronous operating mode, and the session is already synchronized.  
  
    ```  
    SELECT database_id, mirroring_role, mirroring_safety_level_desc, mirroring_state_desc FROM sys.database_mirroring  
    ```  
  
     For more information, see [sys.database_mirroring (Transact-SQL)](assetId:///480de2b0-2c16-497d-a6a3-bf7f52a7c9a0).  
  
3.  Once the mirroring session is synchronized, manually fail over to the mirror database.  
  
     This can be done in either SQL Server Management Studio or using Transact-SQL:  
  
    -   [Manually Fail Over a Database Mirroring Session (SQL Server Management Studio)](../../Topics/TopicNameContainA/Manually-Fail-Over-a-Database-Mirroring-Session--SQL-Server-Management-Studio-.md)  
  
    -   [Manually Fail Over a Database Mirroring Session (Transact-SQL)](../../Topics/TopicNameContainA/Manually-Fail-Over-a-Database-Mirroring-Session--Transact-SQL-.md)  
  
4.  Turn on the trustworthy database property using the following ALTER DATABASE command:  
  
    ```  
    ALTER DATABASE <database_name> SET TRUSTWORTHY ON  
    ```  
  
     For more information, see[ALTER DATABASE (Transact-SQL)](assetId:///15f8affd-8f39-4021-b092-0379fc6983da).  
  
5.  Optionally, manually failover again to return to the original principal.  
  
6.  Optionally, switch to asynchronous, high-performance mode by setting SAFETY to OFF and ensuring that WITNESS is also set to OFF.  
  
     In Transact-SQL:  
  
    -   [Change Transaction Safety in a Database Mirroring Session (Transact-SQL)](../../Topics/TopicNameContainA/Change-Transaction-Safety-in-a-Database-Mirroring-Session--Transact-SQL-.md)  
  
    -   [Remove the Witness from a Database Mirroring Session (SQL Server)](../../Topics/TopicNameContainA/Remove-the-Witness-from-a-Database-Mirroring-Session--SQL-Server-.md)  
  
     In SQL Server Management Studio:  
  
    -   [Establish a Database Mirroring Session Using Windows Authentication (SQL Server Management Studio)](../../Topics/TopicNameContainA/Establish-a-Database-Mirroring-Session-Using-Windows-Authentication--SQL-Server-Management-Studio-.md)  
  
## See Also  
 [TRUSTWORTHY Database Property](../../Topics/TopicNameNotContainA/TRUSTWORTHY-Database-Property.md)   
 [Set Up an Encrypted Mirror Database](../../Topics/TopicNameNotContainA/Set-Up-an-Encrypted-Mirror-Database.md)