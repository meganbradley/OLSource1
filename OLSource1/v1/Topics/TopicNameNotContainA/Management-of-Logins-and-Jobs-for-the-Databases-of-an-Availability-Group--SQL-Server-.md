---
title: "Management of Logins and Jobs for the Databases of an Availability Group (SQL Server)"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d7da14d3-848c-44d4-8e49-d536a1158a61
caps.latest.revision: 19
manager: jhubbard
---
# Management of Logins and Jobs for the Databases of an Availability Group (SQL Server)
You should routinely maintain the same set of user logins and [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Agent jobs on every primary database of an Always On availability group and the corresponding secondary databases. The logins and jobs must be reproduced on every instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that hosts an availability replica for the availability group.  
  
-   **[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Agent jobs**  
  
     You need to manually copy relevant jobs from the server instance that hosts the original primary replica to the server instances that host the original secondary replicas. For all databases, you need to add logic at the beginning of each relevant job to make the job execute only on the primary database, that is, only when the local replica is the primary replica for the database.  
  
     The server instances that host the availability replicas of an availability group might be configured differently, with different tape drive letters or such. The jobs for each availability replica must allow for any such differences.  
  
     Notice that backup jobs can use the [sys.fn_hadr_is_preferred_backup_replica](assetId:///61b9be77-e2f6-4da1-b2ae-a62cbe226145) function to identify whether the local replica is the preferred one for backups, according to the availability group backup preferences. Backup jobs created using the [Maintenance Plan Wizard](../../Topics/TopicNameNotContainA/Use-the-Maintenance-Plan-Wizard.md) natively use this function. For other backup jobs, we recommend that you use this function as a condition in your backup jobs, so they execute only on the preferred replica. For more information, see [Active Secondaries: Backup on Secondary Replicas (Always On Availability Groups)](../Topic/Active%20Secondaries:%20Backup%20on%20Secondary%20Replicas%20\(Always%20On%20Availability%20Groups\).md).  
  
-   **Logins**  
  
     If you are using contained databases, you can configure contained users in the databases, and for these users, you do not need to create logins on the server instances that host a secondary replica. For a non-contained availability database, you will need to create users for the logins on the server instances that host the availability replicas. For more information, see [CREATE USER (Transact-SQL)](assetId:///01de7476-4b25-4d58-85b7-1118fe64aa80).  
  
     If any of your applications use [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Authentication or a local Windows login, see [Logins Of Applications That Use SQL Server Authentication or a Local Windows Login](../../Topics/TopicNameNotContainA/Management-of-Logins-and-Jobs-for-the-Databases-of-an-Availability-Group--SQL-Server-.md#SSauthentication), later in this topic.  
  
    > [!NOTE]  
    >  A database user for which the SQL Server login is undefined or is incorrectly defined on a server instance cannot log in to the instance. Such a user is said to be an *orphaned user* of the database on that server instance. If a user is orphaned on a given server instance, you can set up the user logins at any time. For more information, see [Troubleshoot Orphaned Users (SQL Server)](../../Topics/TopicNameNotContainA/Troubleshoot-Orphaned-Users--SQL-Server-.md).  
  
-   **Additional metadata**  
  
     Logins and jobs are not the only information that need to be recreated on each of the server instances that hosts an secondary replica for a given availability group. For example, you might need to recreate server configuration settings, credentials, encrypted data, permissions, replication settings, service broker applications, triggers (at server level), and so forth. For more information, see [Manage Metadata When Making a Database Available on Another Server Instance (SQL Server)](../../Topics/TopicNameContainA/Manage-Metadata-When-Making-a-Database-Available-on-Another-Server-Instance--SQL-Server-.md).  
  
##  <a name="SSauthentication"></a> Logins Of Applications That Use SQL Server Authentication or a Local Windows Login  
 If an application uses SQL Server Authentication or a local Windows login, mismatched SIDs can prevent the application's login from resolving on a remote instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. The mismatched SIDs cause the login to become an orphaned user on the remote server instance. This issue can occur when an application connects to a mirrored or log shipping database after a failover or to a replication subscriber database that was initialized from a backup.  
  
 To prevent this issue, we recommend that you take preventative measures when you set up such an application to use a database that is hosted by a remote instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. Prevention involves transferring the logins and the passwords from the local instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] to the remote instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. For more information about how to prevent this issue, see KB article 918992—[How to transfer the logins and the passwords between instances of SQL Server](http://support.microsoft.com/kb/918992/)).  
  
> [!NOTE]  
>  This problem affects Windows local accounts on different computers. However, this problem does not occur for domain accounts because the SID is the same on each of the computers.  
  
 For more information, see [Orphaned Users with Database Mirroring and Log Shipping](http://blogs.msdn.com/b/sqlserverfaq/archive/2009/04/13/orphaned-users-with-database-mirroring-and-log-shipping.aspx) (a Database Engine blog).  
  
##  <a name="RelatedTasks"></a> Related Tasks  
  
-   [Create a Login](../../Topics/TopicNameContainA/Create-a-Login.md)  
  
-   [Create a Database User](../../Topics/TopicNameContainA/Create-a-Database-User.md).  
  
-   [Create a Job](assetId:///b35af2b6-6594-40d1-9861-4d5dd906048c)  
  
-   [Manage Metadata When Making a Database Available on Another Server Instance (SQL Server)](../../Topics/TopicNameContainA/Manage-Metadata-When-Making-a-Database-Available-on-Another-Server-Instance--SQL-Server-.md)  
  
## See Also  
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)   
 [Contained Databases](../../Topics/TopicNameNotContainA/Contained-Databases.md)   
 [Create Jobs](assetId:///465fb7fc-7622-4252-a178-ea51691c935b)