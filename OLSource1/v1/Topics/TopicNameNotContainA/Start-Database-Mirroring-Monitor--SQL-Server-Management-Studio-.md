---
title: "Start Database Mirroring Monitor (SQL Server Management Studio)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 53165335-97ca-4f88-8e78-22f1839dee98
caps.latest.revision: 21
manager: jhubbard
---
# Start Database Mirroring Monitor (SQL Server Management Studio)
The Database Mirroring Monitor is part of the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Monitor, which is launched from [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)].  
  
> [!NOTE]  
>  Database Mirroring Monitor is not available in every edition of [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)][!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. For a list of features that are supported by the editions of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], see [Features Supported by the Editions of SQL Server 2016](../../Topics/TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md).  
  
### To launch the Database Mirroring Monitor  
  
1.  After connecting to the principal server instance, in Object Explorer, click the server name to expand the server tree.  
  
2.  Expand **Databases**, and select the database to be monitored.  
  
3.  Right-click the database, select **Tasks**, and then click **Launch Database Mirroring Monitor**.  
  
4.  In the **Database Mirroring Monitor** dialog box, click **Register Mirrored Database** to register one or more mirrored database.  
  
    > [!NOTE]  
    >  When you register a database at one partner, the database is automatically registered at the other partner. If the monitor already has connection credentials for the other partner instance, those are used to connect. Otherwise the monitor attempts to connect using Windows Authentication. If you want to change the credentials used to connect to either server instance, click **Show the Manage Server Connections dialog box when I click OK**.  
  
 For more information about Database Mirroring Monitor, see [Database Mirroring Monitor Overview](../../Topics/TopicNameNotContainA/Database-Mirroring-Monitor-Overview.md).  
  
## See Also  
 [Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Database-Mirroring--SQL-Server-.md)   
 [Establish a Database Mirroring Session Using Windows Authentication (SQL Server Management Studio)](../../Topics/TopicNameContainA/Establish-a-Database-Mirroring-Session-Using-Windows-Authentication--SQL-Server-Management-Studio-.md)