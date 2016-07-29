---
title: "Copy Databases to Other Servers"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 978406d6-a3c8-4902-b1f4-4ced75234be5
caps.latest.revision: 43
manager: jhubbard
---
# Copy Databases to Other Servers
It is sometimes useful to copy a database from one computer to another, whether for testing, checking consistency, developing software, running reports, creating a mirror database, or, possibly, to make the database available to remote-branch operations.  
  
 There are several ways to copy a database:  
  
-   Using the Copy Database Wizard  
  
     You can use the Copy Database Wizard to copy or move databases between servers or to upgrade a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] database to a later version. For more information, see [Use the Copy Database Wizard](../../Topics/TopicNameNotContainA/Use-the-Copy-Database-Wizard.md).  
  
-   Restoring a database backup  
  
     To copy an entire database, you can use the BACKUP and RESTORE [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statements. Typically, restoring a full backup of a database is used to copy the database from one computer to another for a variety of reasons. For information on using backup and restore to copy a database, see [Copy Databases with Backup and Restore](../../Topics/TopicNameNotContainA/Copy-Databases-with-Backup-and-Restore.md).  
  
    > [!NOTE]  
    >  To set up a mirror database for database mirroring, you must restore the database onto the mirror server by using RESTORE DATABASE *<database_name>* WITH NORECOVERY. For more information, see [Prepare a Mirror Database for Mirroring (SQL Server)](../../Topics/TopicNameContainA/Prepare-a-Mirror-Database-for-Mirroring--SQL-Server-.md).  
  
-   Using the Generate Scripts Wizard to publish databases  
  
     You can use the Generate Scripts Wizard to transfer a database from a local computer to a Web hosting provider. For more information, see [Generate and Publish Scripts Wizard](../../Topics/TopicNameNotContainA/Generate-and-Publish-Scripts-Wizard.md).