---
title: "Create an Availability Group (SQL Server PowerShell)"
ms.custom: na
ms.date: 2016-05-17
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bc69a7df-20fa-41e1-9301-11317c5270d2
caps.latest.revision: 42
manager: jhubbard
---
# Create an Availability Group (SQL Server PowerShell)
This topic describes how to use PowerShell cmdlets to create and configure an Always On availability group by using PowerShell in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)]. An *availability group* defines a set of user databases that will fail over as a single unit and a set of failover partners, known as *availability replicas*, which support failover.  
  
> [!NOTE]  
>  For an introduction to availability groups, see [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md).  
  
-   **Before you begin:**  
  
     [Prerequisites, Restrictions, and Recommendations](#PrerequisitesRestrictions)  
  
     [Security](#Security)  
  
     [Summary of Tasks and Corresponding PowerShell Cmdlets](#SummaryPSStatements)  
  
     [To Set Up and Use the SQL Server PowerShell Provider](#PsProviderLinks)  
  
-   **To create and configure an availability group, using:**  [Using PowerShell to Create and Configure an Availability Group](#PowerShellProcedure)  
  
-   **Examples:**  [Using PowerShell to Create an Availability Group](#ExampleConfigureGroup)  
  
-   [Related Tasks](#RelatedTasks)  
  
-   [Related Content](#RelatedContent)  
  
> [!NOTE]  
>  As an alternative to using PowerShell cmdlets, you can use the Create Availability Group wizard or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)]. For more information, see [Use the New Availability Group Dialog Box (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/Use-the-New-Availability-Group-Dialog-Box--SQL-Server-Management-Studio-.md) or [Create an Availability Group (Transact-SQL)](../../Topics/TopicNameNotContainA/Create-an-Availability-Group--Transact-SQL-.md).  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
 We strongly recommend that you read this section before attempting to create your first availability group.  
  
###  <a name="PrerequisitesRestrictions"></a> Prerequisites, Restrictions, and Recommendations  
  
-   Before creating an availability group, verify that the host instances of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] each resides on a different Windows Server Failover Clustering (WSFC) node of a single WSFC failover cluster. Also, verify that your server instances met the other server-instance prerequisites and that all of the other [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] requirements are meet and that you are aware of the recommendations. For more information, we strongly recommend that you read [Prerequisites, Restrictions, and Recommendations for Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Prerequisites--Restrictions--and-Recommendations-for-Always-On-Availability-Groups--SQL-Server-.md).  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 Requires membership in the **sysadmin** fixed server role and either CREATE AVAILABILITY GROUP server permission, ALTER ANY AVAILABILITY GROUP permission, or CONTROL SERVER permission.  
  
###  <a name="SummaryPSStatements"></a> Summary of Tasks and Corresponding PowerShell Cmdlets  
 The following table lists the basic tasks involved in configuring an availability group and indicates those that are supported by PowerShell cmdlets. The [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] tasks must be performed in the sequence in which they are presented in the table.  
  
|Task|PowerShell Cmdlets (if Available) or Transact-SQL Statement|Where to Perform Task**\***|  
|----------|--------------------------------------------------------------------|---------------------------------|  
|Create database mirroring endpoint (once per [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance)|**New-SqlHadrEndPoint**|Execute on each server instance that lacks database mirroring endpoint.<br /><br /> Note: To alter an existing database mirroring endpoint, use **Set-SqlHadrEndpoint**.|  
|Create availability group|First, use the **New-SqlAvailabilityReplica** cmdlet with the **-AsTemplate** parameter to create an in-memory availability-replica object for each of the two availability replicas that you plan to include in the availability group.<br /><br /> Then, create the availability group by using the **New-SqlAvailabilityGroup** cmdlet and referencing your availability-replica objects.|Execute on the server instance that is to host the initial primary replica.|  
|Join secondary replica to availability group|**Join-SqlAvailabilityGroup**|Execute on each server instance that is hosts a secondary replica.|  
|Prepare the secondary database|**Backup-SqlDatabase** and **Restore-SqlDatabase**|Create backups on the server instance that hosts the primary replica.<br /><br /> Restore backups on each server instance that hosts a secondary replica, using the **NoRecovery** restore parameter. If the file paths differ between the computers that host the primary replica and the target secondary replica, also use the **RelocateFile** restore parameter.|  
|Start data synchronization by joining each secondary database to availability group|**Add-SqlAvailabilityDatabase**|Execute on each server instance that hosts a secondary replica.|  
  
 \*To perform a given task, change directory (**cd**) to the indicated server instance or instances.  
  
###  <a name="PsProviderLinks"></a> To Set Up and Use the SQL Server PowerShell Provider  
  
-   [SQL Server PowerShell Provider](../../Topics/TopicNameNotContainA/SQL-Server-PowerShell-Provider.md)  
  
-   [Get Help SQL Server PowerShell](../../Topics/TopicNameNotContainA/Get-Help-SQL-Server-PowerShell.md)  
  
##  <a name="PowerShellProcedure"></a> Using PowerShell to Create and Configure an Availability Group  
  
> [!NOTE]  
>  To view the syntax and an example of a given cmdlet, use the **Get-Help** cmdlet in the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] PowerShell environment. For more information, see [Get Help SQL Server PowerShell](../../Topics/TopicNameNotContainA/Get-Help-SQL-Server-PowerShell.md).  
  
1.  Change directory (**cd**) to the server instance that is to host the primary replica.  
  
2.  Create an in-memory availability-replica object for the primary replica.  
  
3.  Create an in-memory availability-replica object for each of the secondary replicas.  
  
4.  Create the availability group.  
  
    > [!NOTE]  
    >  The maximum length for an availability group name is 128 characters.  
  
5.  Join the new secondary replica to the availability group. For more information, see [Join a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md).  
  
6.  For each database in the availability group, create a secondary database by restoring recent backups of the primary database, using RESTORE WITH NORECOVERY.  
  
7.  Join every new secondary database to the availability group. For more information, see [Join a Secondary Replica to an Availability Group (SQL Server)](../../Topics/TopicNameContainA/Join-a-Secondary-Replica-to-an-Availability-Group--SQL-Server-.md).  
  
8.  Optionally, use the Windows **dir** command to verify the contents of the new availability group.  
  
> [!NOTE]  
>  If the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] service accounts of the server instances run under different domain user accounts, on each server instance, create a login for the other server instance and grant this login CONNECT permission to the local database mirroring endpoint.  
  
##  <a name="ExampleConfigureGroup"></a> Example: Using PowerShell to Create an Availability Group  
 The following PowerShell example creates and configures a simple availability group named `MyAG` with two availability replicas and one availability database. The example:  
  
1.  Backs up `MyDatabase` and its transaction log.  
  
2.  Restores `MyDatabase` and its transaction log, using the **-NoRecovery** option.  
  
3.  Creates an in-memory representation of the primary replica, which will be hosted by the local instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] (named `PrimaryComputer\Instance`).  
  
4.  Creates an in-memory representation of the secondary replica, which will be hosted by an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] (named `SecondaryComputer\Instance`).  
  
5.  Creates an availability group named `MyAG`.  
  
6.  Joins the secondary replica to the availability group.  
  
7.  Joins the secondary database to the availability group.  
  
```  
# Backup my database and its log on the primary  
Backup-SqlDatabase `  
    -Database "MyDatabase" `  
    -BackupFile "\\share\backups\MyDatabase.bak" `  
    -ServerInstance "PrimaryComputer\Instance"  
  
Backup-SqlDatabase `  
    -Database "MyDatabase" `  
    -BackupFile "\\share\backups\MyDatabase.log" `  
    -ServerInstance "PrimaryComputer\Instance" `  
    -BackupAction Log   
  
# Restore the database and log on the secondary (using NO RECOVERY)  
Restore-SqlDatabase `  
    -Database "MyDatabase" `  
    -BackupFile "\\share\backups\MyDatabase.bak" `  
    -ServerInstance "SecondaryComputer\Instance" `  
    -NoRecovery  
  
Restore-SqlDatabase `  
    -Database "MyDatabase" `  
    -BackupFile "\\share\backups\MyDatabase.log" `  
    -ServerInstance "SecondaryComputer\Instance" `  
    -RestoreAction Log `  
    -NoRecovery  
  
# Create an in-memory representation of the primary replica.  
$primaryReplica = New-SqlAvailabilityReplica `  
    -Name "PrimaryComputer\Instance" `  
    -EndpointURL "TCP://PrimaryComputer.domain.com:5022" `  
    -AvailabilityMode "SynchronousCommit" `  
    -FailoverMode "Automatic" `  
    -Version 12 `  
    -AsTemplate  
  
# Create an in-memory representation of the secondary replica.  
$secondaryReplica = New-SqlAvailabilityReplica `  
    -Name "SecondaryComputer\Instance" `  
    -EndpointURL "TCP://SecondaryComputer.domain.com:5022" `  
    -AvailabilityMode "SynchronousCommit" `  
    -FailoverMode "Automatic" `  
    -Version 12 `  
    -AsTemplate  
  
# Create the availability group  
New-SqlAvailabilityGroup `  
    -Name "MyAG" `  
    -Path "SQLSERVER:\SQL\PrimaryComputer\Instance" `  
    -AvailabilityReplica @($primaryReplica,$secondaryReplica) `  
    -Database "MyDatabase"  
  
# Join the secondary replica to the availability group.  
Join-SqlAvailabilityGroup -Path "SQLSERVER:\SQL\SecondaryComputer\Instance" -Name "MyAG"  
  
# Join the secondary database to the availability group.  
Add-SqlAvailabilityDatabase -Path "SQLSERVER:\SQL\SecondaryComputer\Instance\AvailabilityGroups\MyAG" -Database "MyDatabase"  
```  
  
##  <a name="RelatedTasks"></a> Related Tasks  
 **To configure a server instance for Always On Availability Groups**  
  
-   [Enable and Disable Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Enable-and-Disable-Always-On-Availability-Groups--SQL-Server-.md)  
  
-   [Create a Database Mirroring Endpoint for Always On Availability Groups (SQL Server PowerShell)](../../Topics/TopicNameContainA/Create-a-Database-Mirroring-Endpoint-for-Always-On-Availability-Groups--SQL-Server-PowerShell-.md)  
  
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
  
-   [Use the New Availability Group Dialog Box (SQL Server Management Studio)](../../Topics/TopicNameNotContainA/Use-the-New-Availability-Group-Dialog-Box--SQL-Server-Management-Studio-.md)  
  
-   [Create an Availability Group (Transact-SQL)](../../Topics/TopicNameNotContainA/Create-an-Availability-Group--Transact-SQL-.md)  
  
 **To troubleshoot Always On Availability Groups configuration**  
  
-   [Troubleshoot Always On Availability Groups Configuration (SQL Server)](../../Topics/TopicNameNotContainA/Troubleshoot-Always-On-Availability-Groups-Configuration--SQL-Server-.md)  
  
-   [Troubleshoot a Failed Add-File Operation (Always On Availability Groups)](../../Topics/TopicNameContainA/Troubleshoot-a-Failed-Add-File-Operation--Always-On-Availability-Groups-.md)  
  
##  <a name="RelatedContent"></a> Related Content  
  
-   **Blogs:**  
  
     [Always On - HADRON Learning Series: Worker Pool Usage for HADRON Enabled Databases](http://blogs.msdn.com/b/psssql/archive/2012/05/17/Always%20On-hadron-learning-series-worker-pool-usage-for-hadron-enabled-databases.aspx)  
  
     [Configuring Always On with SQL Server PowerShell](http://blogs.msdn.com/b/sqlAlways%20On/archive/2012/02/03/configuring-Always%20On-with-sql-server-powershell.aspx)  
  
     [SQL Server Always On Team Blogs: The official SQL Server Always On Team Blog](http://blogs.msdn.com/b/sqlAlways%20On/)  
  
     [CSS SQL Server Engineers Blogs](http://blogs.msdn.com/b/psssql/)  
  
-   **Videos:**  
  
     [Microsoft SQL Server Code-Named "Denali" Always On Series,Part 1: Introducing the Next Generation High Availability Solution](http://channel9.msdn.com/Events/TechEd/NorthAmerica/2011/DBI302)  
  
     [Microsoft SQL Server Code-Named "Denali" Always On Series,Part 2: Building a Mission-Critical High Availability Solution Using Always On](http://channel9.msdn.com/Events/TechEd/NorthAmerica/2011/DBI404)  
  
-   **Whitepapers:**  
  
     [Microsoft SQL Server Always On Solutions Guide for High Availability and Disaster Recovery](http://go.microsoft.com/fwlink/?LinkId=227600)  
  
     [Microsoft White Papers for SQL Server 2012](http://msdn.microsoft.com/library/hh403491.aspx)  
  
     [SQL Server Customer Advisory Team Whitepapers](http://sqlcat.com/)  
  
## See Also  
 [The Database Mirroring Endpoint (SQL Server)](../../Topics/TopicNameNotContainA/The-Database-Mirroring-Endpoint--SQL-Server-.md)   
 [Overview of Always On Availability Groups (SQL Server)](../../Topics/TopicNameNotContainA/Overview-of-Always-On-Availability-Groups--SQL-Server-.md)