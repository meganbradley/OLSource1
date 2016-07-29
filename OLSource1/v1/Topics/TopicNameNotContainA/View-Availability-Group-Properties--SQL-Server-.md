---
title: "View Availability Group Properties (SQL Server)"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 61243c87-bd62-4510-863f-2a8f347caf1f
caps.latest.revision: 14
manager: jhubbard
---
# View Availability Group Properties (SQL Server)
This topic describes how to view the properties of an availability group for an Always On availability group by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)].  
  
-   **To view availability group properties, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
 **To view and change the properties an availability group**  
  
1.  In Object Explorer, connect to the server instance that hosts the primary replica, and expand the server tree.  
  
2.  Expand the **Always On High Availability** node and the **Availability Groups** node.  
  
3.  Right-click the availability group whose properties you want to view, and select the **Properties** command.  
  
4.  In the **Availability Group Properties** dialog box, use the **General** and **Backup Preferences** pages to view and, in some cases, change properties of the selected availability group. For more information, see [Availability Group Properties: New Availability Group (General Page)](../Topic/Availability%20Group%20Properties:%20New%20Availability%20Group%20\(General%20Page\).md) and [Availability Group Properties: New Availability Group (Backup Preferences Page)](../Topic/Availability%20Group%20Properties:%20New%20Availability%20Group%20\(Backup%20Preferences%20Page\).md).  
  
     Use the **Permissions** page to view the current logins, roles, and explicit permissions associated with the availability group. For more information, see [Permissions or Securables Page](../../Topics/TopicNameNotContainA/Permissions-or-Securables-Page.md).  
  
   
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
 **To view the properties and state of an availability group**  
  
 To query the properties and states of the availability groups for which the server instance hosts an availability replica, use the following views:  
  
 [sys.availability_groups](assetId:///da7fa55f-c008-45d9-bcfc-3513b02d9e71)  
 Returns a row for each availability group for which the local instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] hosts an availability replica. Each row contains a cached copy of the availability group metadata.  
  
 **Column names:** group_id, name, resource_id, resource_group_id, failure_condition_level, health_check_timeout, automated_backup_preference, automated_backup_preference_desc  
  
 [sys.availability_groups_cluster](assetId:///d0f4683f-cdf0-4227-8b68-720ffe58f158)  
 Returns a row for each availability group in the WSFC cluster. Each row contains the availability group metadata from the Windows Server Failover Clustering (WSFC) cluster.  
  
 **Column names:** group_id, name, resource_id, resource_group_id, failure_condition_level, health_check_timeout, automated_backup_preference, automated_backup_preference_desc  
  
 [sys.dm_hadr_availability_group_states](assetId:///d18019dd-f8dc-4492-b035-b1a639369b65)  
 Returns a row for each availability group that possesses an availability replica on the local instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. Each row displays the states that define the health of a given availability group.  
  
 **Column names:** group_id, primary_replica, primary_recovery_health, primary_recovery_health_desc, secondary_recovery_health, secondary_recovery_health_desc, synchronization_health, synchronization_health_desc  
  
   
  
##  <a name="RelatedTasks"></a> Related Tasks  
 **To view information about availability groups**  
  
-   [View Availability Replica Properties (SQL Server)](../../Topics/TopicNameNotContainA/View-Availability-Replica-Properties--SQL-Server-.md)  
  
-   [View Availability Group Listener Properties (SQL Server)](../../Topics/TopicNameNotContainA/View-Availability-Group-Listener-Properties--SQL-Server-.md)  
  
-   [Always On Policies for Operational Issues with Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Always-On-Policies-for-Operational-Issues-with-Always-On-Availability-Groups--SQL-Server-.md)  
  
-   [Use the Always On Dashboard (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/Use-the-Always-On-Dashboard--SQL-Server-Management-Studio-.md)  
  
-   [Monitor Availability Groups (Transact-SQL)](../../Topics/TopicNameNotContainA/Monitor-Availability-Groups--Transact-SQL-.md)  
  
 **To configure an existing availability group**  
  
-   [Add a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Add-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove a Secondary Replica from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Secondary-Replica-from-an-Availability-Group--SQL-Server-.md)  
  
-   [Add a Database to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Add-a-Database-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove a Secondary Database from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Secondary-Database-from-an-Availability-Group--SQL-Server-.md)  
  
-   [Create or Configure an Availability Group Listener (SQL Server)](../../Topics/TopicNameNotContainA/Create-or-Configure-an-Availability-Group-Listener--SQL-Server-.md)  
  
-   [Remove an Availability Group Listener (SQL Server)](../../Topics/TopicNameNotContainA/Remove-an-Availability-Group-Listener--SQL-Server-.md)  
  
-   [Remove a Primary Database from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Primary-Database-from-an-Availability-Group--SQL-Server-.md)  
  
-   [Remove an Availability Group (SQL Server)](../../Topics/TopicNameNotContainA/Remove-an-Availability-Group--SQL-Server-.md)  
  
 **To manually fail over an availability group**  
  
-   [Perform a Planned Manual Failover of an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Perform-a-Planned-Manual-Failover-of-an-Availability-Group--SQL-Server-.md)  
  
-   [Perform a Forced Manual Failover of an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Perform-a-Forced-Manual-Failover-of-an-Availability-Group--SQL-Server-.md)  
  
   
  
## See Also  
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)   
 [Monitor Availability Groups (Transact-SQL)](../../Topics/TopicNameNotContainA/Monitor-Availability-Groups--Transact-SQL-.md)   
 [Always On Policies for Operational Issues with Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Always-On-Policies-for-Operational-Issues-with-Always-On-Availability-Groups--SQL-Server-.md)