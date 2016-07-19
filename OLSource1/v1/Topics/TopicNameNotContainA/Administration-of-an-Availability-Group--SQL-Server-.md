---
title: Administration of an Availability Group (SQL Server)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0b7542fa-235e-413d-81bf-3eff9ee07480
manager: jhubbard
---
# Administration of an Availability Group (SQL Server)
Managing an existing Always On availability group in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] involves one or more of the following tasks:  
  
-   Altering the properties of an existing availability replica, for example to change client connection access (for configuring readable secondary replicas), changing its failover mode, availability mode, or session timeout setting.  
  
-   Adding or removing secondary replicas.  
  
-   Adding or removing a database.  
  
-   Suspending or resuming a database.  
  
-   Performing a planned manual failover (a *manual failover*) or a forced manual failover (a *forced failover*).  
  
-   Creating or configuring an availability group listener.  
  
-   Managing [readable secondary replicas](../Topic/Active%20Secondaries:%20Readable%20Secondary%20Replicas%20\(Always%20On%20Availability%20Groups\).md) for a given availability group. This involves configuring one or more replicas to read-only access when running under the secondary role, and configuring read-only routing.  
  
-   Managing [backups on secondary replicas](../Topic/Active%20Secondaries:%20Backup%20on%20Secondary%20Replicas%20\(Always%20On%20Availability%20Groups\).md) for a given availability group. This involves configuring where you prefer that backup jobs run and then scripting backup jobs to implement your backup preference. you need to script backup jobs for every database in the availability group on every instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that hosts an availability replica.  
  
-   Deleting an availability group.  
  
-   Cross-cluster migration of Always On Availability Groups for OS upgrade  
  
##  <a name="RelatedTasks"></a> Related Tasks  
 **To configure an existing availability group**  
  
-   [Add a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Add-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove a Secondary Replica from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Secondary-Replica-from-an-Availability-Group--SQL-Server-.md)  
  
-   [Add a Database to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Add-a-Database-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove a Secondary Database from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Secondary-Database-from-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove a Primary Database from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Primary-Database-from-an-Availability-Group--SQL-Server-.md)  
  
-   [Configure the Flexible Failover Policy to Control Conditions for Automatic Failover (Always On Availability Groups)](../../Topics/TopicNameNotContainA/Configure-the-Flexible-Failover-Policy-to-Control-Conditions-for-Automatic-Failover--Always-On-Availability-Groups-.md)  
  
 **To manage an availability group**  
  
-   [Configure Backup on Availability Replicas (SQL Server)](../../Topics/TopicNameNotContainA/Configure-Backup-on-Availability-Replicas--SQL-Server-.md)  
  
-   [Perform a Planned Manual Failover of an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Perform-a-Planned-Manual-Failover-of-an-Availability-Group--SQL-Server-.md)  
  
-   [Perform a Forced Manual Failover of an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Perform-a-Forced-Manual-Failover-of-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove an Availability Group (SQL Server)](../../Topics/TopicNameNotContainA/Remove-an-Availability-Group--SQL-Server-.md)  
  
 **To manage an availability replica**  
  
-   [Add a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Add-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Join a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove a Secondary Replica from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Secondary-Replica-from-an-Availability-Group--SQL-Server-.md)  
  
-   [Change the Availability Mode of an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Change-the-Availability-Mode-of-an-Availability-Replica--SQL-Server-.md)  
  
-   [Change the Failover Mode of an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Change-the-Failover-Mode-of-an-Availability-Replica--SQL-Server-.md)  
  
-   [Configure Backup on Availability Replicas (SQL Server)](../../Topics/TopicNameNotContainA/Configure-Backup-on-Availability-Replicas--SQL-Server-.md)  
  
-   [Configure Read-Only Access on an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Configure-Read-Only-Access-on-an-Availability-Replica--SQL-Server-.md)  
  
-   [Configure Read-Only Routing for an Availability Group (SQL Server)](../../Topics/TopicNameNotContainA/Configure-Read-Only-Routing-for-an-Availability-Group--SQL-Server-.md)  
  
-   [Change the Session-Timeout Period for an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Change-the-Session-Timeout-Period-for-an-Availability-Replica--SQL-Server-.md)  
  
 **To manage an availability database**  
  
-   [Add a Database to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Add-a-Database-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Join a Secondary Database to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Database-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove a Primary Database from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Primary-Database-from-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove a Secondary Database from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Secondary-Database-from-an-Availability-Group--SQL-Server-.md)  
  
-   [Suspend an Availability Database (SQL Server)](../../Topics/TopicNameNotContainA/Suspend-an-Availability-Database--SQL-Server-.md)  
  
-   [Resume an Availability Database (SQL Server)](../../Topics/TopicNameNotContainA/Resume-an-Availability-Database--SQL-Server-.md)  
  
 **To monitor an availability group**  
  
-   [Monitoring of Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Monitoring-of-Availability-Groups--SQL-Server-.md)  
  
 **To support migrating availability groups to a new WSFC cluster (cross-cluster migration)**  
  
-   [Change the HADR Cluster Context of Server Instance (SQL Server)](../../Topics/TopicNameNotContainA/Change-the-HADR-Cluster-Context-of-Server-Instance--SQL-Server-.md)  
  
-   [Take an Availability Group Offline (SQL Server)](../../Topics/TopicNameNotContainA/Take-an-Availability-Group-Offline--SQL-Server-.md)  
  
##  <a name="RelatedContent"></a> Related Content  
  
-   **Blogs:**  
  
     [SQL Server Always On Team Blogs: The official SQL Server Always On Team Blog](http://blogs.msdn.com/b/sqlAlways%20On/)  
  
     [CSS SQL Server Engineers Blogs](http://blogs.msdn.com/b/psssql/)  
  
-   **Videos:**  
  
     [Microsoft SQL Server Code-Named "Denali" Always On Series,Part 1: Introducing the Next Generation High Availability Solution](http://channel9.msdn.com/Events/TechEd/NorthAmerica/2011/DBI302)  
  
     [Microsoft SQL Server Code-Named "Denali" Always On Series,Part 2: Building a Mission-Critical High Availability Solution Using Always On](http://channel9.msdn.com/Events/TechEd/NorthAmerica/2011/DBI404)  
  
-   **White papers:**  
  
     [Microsoft White Papers for SQL Server 2012](http://msdn.microsoft.com/library/hh403491.aspx)  
  
     [SQL Server Customer Advisory Team Whitepapers](http://sqlcat.com/)  
  
## See Also  
 [Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Always-On-Availability-Groups--SQL-Server-.md)   
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)   
 [Configuration of a Server Instance for Always On Availability Groups (SQL Server)](../../Topics/TopicNameContainA/Configuration-of-a-Server-Instance-for-Always-On-Availability-Groups--SQL-Server-.md)   
 [Creation and Configuration of Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Creation-and-Configuration-of-Availability-Groups--SQL-Server-.md)   
 [Active Secondaries: Readable Secondary Replicas (Always On Availability Groups)](../Topic/Active%20Secondaries:%20Readable%20Secondary%20Replicas%20\(Always%20On%20Availability%20Groups\).md)   
 [Active Secondaries: Backup on Secondary Replicas (Always On Availability Groups)](../Topic/Active%20Secondaries:%20Backup%20on%20Secondary%20Replicas%20\(Always%20On%20Availability%20Groups\).md)   
 [Availability Group Listeners, Client Connectivity, and Application Failover (SQL Server)](../../Topics/TopicNameNotContainA/Availability-Group-Listeners--Client-Connectivity--and-Application-Failover--SQL-Server-.md)   
 [Always On Policies for Operational Issues with Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Always-On-Policies-for-Operational-Issues-with-Always-On-Availability-Groups--SQL-Server-.md)   
 [Monitoring of Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Monitoring-of-Availability-Groups--SQL-Server-.md)   
 [Always On Availability Groups: Interoperability (SQL Server)](../Topic/Always%20On%20Availability%20Groups:%20Interoperability%20\(SQL%20Server\).md)   
 [Overview of Transact-SQL Statements for Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Transact-SQL-Statements-for-Always-On-Availability-Groups--SQL-Server-.md)   
 [Overview of PowerShell Cmdlets for Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-PowerShell-Cmdlets-for-Always-On-Availability-Groups--SQL-Server-.md)