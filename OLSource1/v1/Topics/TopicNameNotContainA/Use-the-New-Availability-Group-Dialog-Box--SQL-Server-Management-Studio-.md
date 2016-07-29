---
title: "Use the New Availability Group Dialog Box (SQL Server Management Studio)"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1b0a6421-fbd4-4bb4-87ca-657f4782c433
caps.latest.revision: 41
manager: jhubbard
---
# Use the New Availability Group Dialog Box (SQL Server Management Studio)
This topic contains information about how to use the **New Availability Group** dialog box of [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] to create an Always On availability group on instances of [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] that are enabled for [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)]. An *availability group* defines a set of user databases that will fail over as a single unit and a set of failover partners, known as *availability replicas*, that support failover.  
  
> [!NOTE]  
>  For an introduction to availability groups, see [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md).  
  
-   **Before you begin:**  
  
     [Prerequisites](#PrerequisitesRestrictions)  
  
     [Limitations](#Limitations)  
  
     [Security](#Security)  
  
-   **To create an availability group, using:**  [The New Availability Group Dialog Box](#SSMSProcedure)  
  
-   **Follow up:**  [After Using the New Availability Group Dialog Box to Create an Availability Group](#FollowUp)  
  
> [!NOTE]  
>  For information about alternative ways to create an availability group, see [Related Tasks](#RelatedTasks), later in this topic.  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
 We strongly recommend that you read this section before attempting to create your first availability group.  
  
###  <a name="PrerequisitesRestrictions"></a> Prerequisites  
  
-   Before creating an availability group, verify that the instances of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that host availability replicas reside on different Windows Server Failover Clustering (WSFC) node within the same WSFC failover cluster. Also, verify that each of the server instance is enabled for [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] and meets all other [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] prerequisites. For more information, we strongly recommend that you read [Prerequisites, Restrictions, and Recommendations for Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Prerequisites--Restrictions--and-Recommendations-for-Always-On-Availability-Groups--SQL-Server-.md).  
  
-   Before you create an availability group, ensure that every server instance that will host an availability replica has a fully functioning database mirroring endpoint. For more information, see [The Database Mirroring Endpoint (SQL Server)](../../Topics/TopicNameNotContainA/The-Database-Mirroring-Endpoint--SQL-Server-.md).  
  
-   To use the **New Availability Group** dialog box, you need to know the names of the server instances that will host availability replicas. Also, you need know the names of any databases that you intend to add to your new availability group, and you need to ensure that these databases meet the availability database prerequisites and restrictions described in [Prerequisites, Restrictions, and Recommendations for Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Prerequisites--Restrictions--and-Recommendations-for-Always-On-Availability-Groups--SQL-Server-.md). If you enter invalid values, the new availability group will not work.  
  
###  <a name="Limitations"></a> Limitations  
 The **New Availability Group** dialog box does not:  
  
-   Create an availability group listener.  
  
-   Join secondary replicas to the availability group.  
  
-   Perform initial data synchronization.  
  
 For information about these configuration tasks, see [Follow Up: After Creating an Availability Group](#FollowUp), later in this topic.  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 Requires membership in the **sysadmin** fixed server role and either CREATE AVAILABILITY GROUP server permission, ALTER ANY AVAILABILITY GROUP permission, or CONTROL SERVER permission.  
  
##  <a name="SSMSProcedure"></a> Using the New Availability Group Dialog Box (SQL Server Management Studio)  
 **To create an availability group**  
  
1.  In Object Explorer, connect to the server instance that hosts the primary replica, and click the server name.  
  
2.  Expand the **Always On High Availability** node.  
  
3.  Right-click the **Availability Groups** node, and select the **New Availability Group** command.  
  
4.  This command opens up the **New Availability Group** dialog box.  
  
5.  On the **General** page, use the **Availability group name** field to enter a name for the new availability group. This name must be a valid SQL Server identifier that is unique across all availability groups in the WSFC cluster. The maximum length for an availability group name is 128 characters.  
  
6.  In the **Availability Databases** grid, click **Add** and enter the name of a local database that you want to belong to this availability group. Repeat this for every database to be added. When you click **OK**, the dialog will verify whether your specified database meet the prerequisites for belonging to an availability group. For information about these prerequisites, see [Prerequisites, Restrictions, and Recommendations for Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Prerequisites--Restrictions--and-Recommendations-for-Always-On-Availability-Groups--SQL-Server-.md).  
  
7.  In the **Availability Databases** grid, click **Add** and enter the name of a server instance to host a secondary replica. The dialog will not attempt to connect to these instances. If you specify an incorrect server name, a secondary replica will be added but you will be unable to connect to that replica.  
  
    > [!TIP]  
    >  If you have added a replica and cannot connect to the host server instance, you can remove the replica and add a new one. For more information, see [Remove a Secondary Replica from an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Remove-a-Secondary-Replica-from-an-Availability-Group--SQL-Server-.md) and [Add a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Add-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md).  
  
8.  On the **Select a page** pane of the dialog box, click **Backup Preferences**. Then, on the **Backup Preferences** page, specify where backups should occur based on replica role and assign backup priorities to each server instances that will host an availability replica for this availability group. For more information, see [Availability Group Properties: New Availability Group (Backup Preferences Page)](../Topic/Availability%20Group%20Properties:%20New%20Availability%20Group%20\(Backup%20Preferences%20Page\).md).  
  
9. To create the availability group, click **OK**. This causes the dialog to verify whether that specified databases meet the prerequisites.  
  
     To exit the dialog box without creating the availability group, click **Cancel**.  
  
##  <a name="FollowUp"></a> Follow Up: After Using the New Availability Group Dialog Box to Create an Availability Group  
  
-   You will need to connect, in turn, to each server instance that is hosting a secondary replica for the availability group and complete the following steps:  
  
    1.  Join the secondary replica to the availability group. For more information, see [Join a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md).  
  
    2.  Restore current backups of each primary database and its transaction log (using RESTORE WITH NORECOVERY). For more information, see [Manually Prepare a Secondary Database for an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Manually-Prepare-a-Secondary-Database-for-an-Availability-Group--SQL-Server-.md).  
  
    3.  Immediately join each newly prepared secondary database to the availability group. For more information, see [Join a Secondary Database to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Database-to-an-Availability-Group--SQL-Server-.md).  
  
-   We recommend that you create an availability group listener for the new availability group. This requires that you be connected to the server instance that hosts the current primary replica. For more information, see [Create or Configure an Availability Group Listener (SQL Server)](../../Topics/TopicNameNotContainA/Create-or-Configure-an-Availability-Group-Listener--SQL-Server-.md).  
  
##  <a name="RelatedTasks"></a> Related Tasks  
 **To configure availability group and replica properties**  
  
-   [Change the Availability Mode of an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Change-the-Availability-Mode-of-an-Availability-Replica--SQL-Server-.md)  
  
-   [Change the Failover Mode of an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Change-the-Failover-Mode-of-an-Availability-Replica--SQL-Server-.md)  
  
-   [Create or Configure an Availability Group Listener (SQL Server)](../../Topics/TopicNameNotContainA/Create-or-Configure-an-Availability-Group-Listener--SQL-Server-.md)  
  
-   [Configure the Flexible Failover Policy to Control Conditions for Automatic Failover (Always On Availability Groups)](../../Topics/TopicNameNotContainA/Configure-the-Flexible-Failover-Policy-to-Control-Conditions-for-Automatic-Failover--Always-On-Availability-Groups-.md)  
  
-   [Specify the Endpoint URL When Adding or Modifying an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Specify-the-Endpoint-URL-When-Adding-or-Modifying-an-Availability-Replica--SQL-Server-.md)  
  
-   [Configure Backup on Availability Replicas (SQL Server)](../../Topics/TopicNameNotContainA/Configure-Backup-on-Availability-Replicas--SQL-Server-.md)  
  
-   [Configure Read-Only Access on an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Configure-Read-Only-Access-on-an-Availability-Replica--SQL-Server-.md)  
  
-   [Configure Read-Only Routing for an Availability Group (SQL Server)](../../Topics/TopicNameNotContainA/Configure-Read-Only-Routing-for-an-Availability-Group--SQL-Server-.md)  
  
-   [Change the Session-Timeout Period for an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Change-the-Session-Timeout-Period-for-an-Availability-Replica--SQL-Server-.md)  
  
 **To complete availability group configuration**  
  
-   [Join a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Manually Prepare a Secondary Database for an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Manually-Prepare-a-Secondary-Database-for-an-Availability-Group--SQL-Server-.md)  
  
-   [Join a Secondary Database to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Database-to-an-Availability-Group--SQL-Server-.md)  
  
-   [Create or Configure an Availability Group Listener (SQL Server)](../../Topics/TopicNameNotContainA/Create-or-Configure-an-Availability-Group-Listener--SQL-Server-.md)  
  
 **Alternative ways to create an availability group**  
  
-   [Use the Availability Group Wizard (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/Use-the-Availability-Group-Wizard--SQL-Server-Management-Studio-.md)  
  
-   [Create an Availability Group (Transact-SQL)](../../Topics/TopicNameNotContainA/Create-an-Availability-Group--Transact-SQL-.md)  
  
-   [Create an Availability Group (SQL Server PowerShell)](../../Topics/TopicNameNotContainA/Create-an-Availability-Group--SQL-Server-PowerShell-.md)  
  
 **To enable Always On Availability Groups**  
  
-   [Enable and Disable Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Enable-and-Disable-Always-On-Availability-Groups--SQL-Server-.md)  
  
 **To configure a database mirroring endpoint**  
  
-   [Create a Database Mirroring Endpoint for Always On Availability Groups (SQL Server PowerShell)](../../Topics/TopicNameContainA/Create-a-Database-Mirroring-Endpoint-for-Always-On-Availability-Groups--SQL-Server-PowerShell-.md)  
  
-   [Create a Database Mirroring Endpoint for Windows Authentication (Transact-SQL)](../../Topics/TopicNameContainA/Create-a-Database-Mirroring-Endpoint-for-Windows-Authentication--Transact-SQL-.md)  
  
-   [Use Certificates for a Database Mirroring Endpoint (Transact-SQL)](../../Topics/TopicNameContainA/Use-Certificates-for-a-Database-Mirroring-Endpoint--Transact-SQL-.md)  
  
-   [Specify the Endpoint URL When Adding or Modifying an Availability Replica (SQL Server)](../../Topics/TopicNameNotContainA/Specify-the-Endpoint-URL-When-Adding-or-Modifying-an-Availability-Replica--SQL-Server-.md)  
  
 **To troubleshoot Always On Availability Groups configuration**  
  
-   [Troubleshoot Always On Availability Groups Configuration (SQL Server)](../../Topics/TopicNameNotContainA/Troubleshoot-Always-On-Availability-Groups-Configuration--SQL-Server-.md)  
  
-   [Troubleshoot a Failed Add-File Operation (Always On Availability Groups)](../../Topics/TopicNameContainA/Troubleshoot-a-Failed-Add-File-Operation--Always-On-Availability-Groups-.md)  
  
##  <a name="RelatedContent"></a> Related Content  
  
-   [Microsoft SQL Server Always On Solutions Guide for High Availability and Disaster Recovery](http://go.microsoft.com/fwlink/?LinkId=227600)  
  
## See Also  
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)   
 [The Database Mirroring Endpoint (SQL Server)](../../Topics/TopicNameNotContainA/The-Database-Mirroring-Endpoint--SQL-Server-.md)   
 [Availability Group Listeners, Client Connectivity, and Application Failover (SQL Server)](../../Topics/TopicNameNotContainA/Availability-Group-Listeners--Client-Connectivity--and-Application-Failover--SQL-Server-.md)   
 [Prerequisites, Restrictions, and Recommendations for Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Prerequisites--Restrictions--and-Recommendations-for-Always-On-Availability-Groups--SQL-Server-.md)