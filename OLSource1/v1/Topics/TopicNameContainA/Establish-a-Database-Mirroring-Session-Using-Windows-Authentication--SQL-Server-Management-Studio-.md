---
title: Establish a Database Mirroring Session Using Windows Authentication (SQL Server Management Studio)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7cb418d6-dce1-4a0d-830e-9c5ccfe3bd72
manager: jhubbard
---
# Establish a Database Mirroring Session Using Windows Authentication (SQL Server Management Studio)
> [!NOTE]  
>  [!INCLUDE[ssNoteDepFutureAvoid](../../Topics/TopicNameContainA/includes/ssNoteDepFutureAvoid_md.md)] Use [!INCLUDE[ssHADR](../../Topics/TopicNameContainA/includes/ssHADR_md.md)] instead.  
  
 To establish a database mirroring session and to modify the properties of database mirroring for a database, use the **Mirroring** page of the **Database Properties** dialog box.Before you use the **Mirroring** page to configure database mirroring, ensure that the following requirements have been met:  
  
-   The principal and mirror server instances must be running the same edition of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]—either Standard or Enterprise. Also, we strongly recommend that they run on comparable systems that can handle identical workloads.  
  
    > [!NOTE]  
    >  A witness server instance is not available in every edition of [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)][!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. For a list of features that are supported by the editions of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], see [Features Supported by the Editions of SQL Server 2016](../../Topics/TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md).  
  
-   The mirror database must exist and be current.  
  
     Creating a mirror database requires restoring a recent backup of the principal database (using WITH NORECOVERY) on the mirror server instance. It also requires taking one or more log backups after the full backup and restoring them in sequence to the mirror database (using WITH NORECOVERY). For more information, see [Prepare a Mirror Database for Mirroring (SQL Server)](../../Topics/TopicNameContainA/Prepare-a-Mirror-Database-for-Mirroring--SQL-Server-.md).  
  
-   If the server instances are running under different domain user accounts, each requires a login in the **master** database of the others. If the login does not exist, you must create it before configuring mirroring. For more information, see [Allow Network Access to a Database Mirroring Endpoint Using Windows Authentication (SQL Server)](../../Topics/TopicNameContainA/Allow-Network-Access-to-a-Database-Mirroring-Endpoint-Using-Windows-Authentication--SQL-Server-.md).  
  
### To configure database mirroring  
  
1.  After connecting to the principal server instance, in Object Explorer, click the server name to expand the server tree.  
  
2.  Expand **Databases**, and select the database to be mirrored.  
  
3.  Right-click the database, select **Tasks**, and then click **Mirror**. This opens the **Mirroring** page of the **Database Properties** dialog box.  
  
4.  To begin configuring mirroring, click the **Configure Security** button to launch the Configure Database Mirroring Security Wizard.  
  
    > [!NOTE]  
    >  During a database mirroring session, you can use this wizard only to add or change the witness server instance.  
  
5.  The Configure Database Mirroring Security Wizard automatically creates the database mirroring endpoint (if none exists) on each server instance, and enters the server network addresses in the field corresponding to the role of the server instance (**Principal**, **Mirror**, or **Witness**).  
  
    > [!IMPORTANT]  
    >  When creating an endpoint, the Configure Database Mirroring Security Wizard always uses Windows Authentication. Before you can use the wizard with certificate-based authentication, the mirroring endpoint must already have been configured to use certificates on each of the server instances. Also, all the fields of the wizard's **Service Accounts** dialog box must remain empty. For information about creating a database mirroring endpoint to use certificates, see [CREATE ENDPOINT (Transact-SQL)](assetId:///6405e7ec-0b5b-4afd-9792-1bfa5a2491f6).  
  
6.  Optionally, change the operating mode. The availability of certain operating mode(s) depends on whether you have specified a TCP address for a witness. The options are as follows:  
  
    |Option|Witness?|Explanation|  
    |------------|--------------|-----------------|  
    |**High performance (asynchronous)**|Null (if exists, not used but the session requires a quorum)|To maximize performance, the mirror database always lags somewhat behind the principal database, never quite catching up. However, the gap between the databases is typically small. The loss of a partner has the following effect:<br /><br /> If the mirror server instance becomes unavailable, the principal continues.<br /><br /> If the principal server instance becomes unavailable, the mirror stops; but if the session has no witness (as recommended) or the witness is connected to the mirror server, the mirror server is accessible as a warm standby; the database owner can force service to the mirror server instance (with possible data loss).<br /><br /> <br /><br /> For more information, see [Role Switching During a Database Mirroring Session (SQL Server)](../../Topics/TopicNameContainA/Role-Switching-During-a-Database-Mirroring-Session--SQL-Server-.md).|  
    |**High safety without automatic failover (synchronous)**|No|All committed transactions are guaranteed to be written to disk on the mirror server.<br /><br /> Manual failover is possible when the partners are connected to each other and the database is synchronized.<br /><br /> The loss of a partner has the following effect:<br /><br /> If the mirror server instance becomes unavailable, the principal continues.<br /><br /> If the principal server instance becomes unavailable, the mirror stops but is accessible as a warm standby; the database owner can force service to the mirror server instance (with possible data loss).<br /><br /> <br /><br /> For more information, see [Role Switching During a Database Mirroring Session (SQL Server)](../../Topics/TopicNameContainA/Role-Switching-During-a-Database-Mirroring-Session--SQL-Server-.md).|  
    |**High safety with automatic failover (synchronous)**|Yes (required)|All committed transactions are guaranteed to be written to disk on the mirror server.<br /><br /> Availability is maximized by including a witness server instance to support automatic failover. Note that you can select the **High safety with automatic failover (synchronous)** option only if you have first specified a witness server address.<br /><br /> Manual failover is possible when the partners are connected to each other and the database is synchronized.<br /><br /> In the presence of a witness, the loss of a partner has the following effect:<br /><br /> If the principal server instance becomes unavailable, automatic failover occurs. The mirror server instance switches to the role of principal, and it offers its database as the principal database.<br /><br /> If the mirror server instance becomes unavailable, the principal continues.<br /><br /> <br /><br /> For more information, see [Role Switching During a Database Mirroring Session (SQL Server)](../../Topics/TopicNameContainA/Role-Switching-During-a-Database-Mirroring-Session--SQL-Server-.md).<br /><br /> **\*\* Important \*\*** If the witness becomes disconnected, the partners must be connected to each other for the database to be available. For more information, see [Quorum: How a Witness Affects Database Availability (Database Mirroring)](../Topic/Quorum:%20How%20a%20Witness%20Affects%20Database%20Availability%20\(Database%20Mirroring\).md).|  
  
7.  When all of the following conditions exist, click **Start Mirroring** to begin mirroring:  
  
    -   You are currently connected to the principal server instance.  
  
    -   Security has been configured correctly.  
  
    -   The fully-qualified TCP addresses of the principal and mirror server instances are specified (in the **Server network addresses** section).  
  
    -   If the operating mode is set to **High safety with automatic failover (synchronous)**, the fully-qualified TCP address of the witness server instance is also specified.  
  
8.  After mirroring begins, you can change the operating mode and save the change by clicking **OK**. Note that you can switch to high-safety mode with automatic failover only if you have first specified a witness server address.  
  
    > [!NOTE]  
    >  To remove the witness, delete its server network address from the **Witness** field. If you switch from high-safety mode with automatic failover to high-performance mode, the **Witness** field is automatically cleared.  
  
## See Also  
 [Role Switching During a Database Mirroring Session (SQL Server)](../../Topics/TopicNameContainA/Role-Switching-During-a-Database-Mirroring-Session--SQL-Server-.md)   
 [Prepare a Mirror Database for Mirroring (SQL Server)](../../Topics/TopicNameContainA/Prepare-a-Mirror-Database-for-Mirroring--SQL-Server-.md)   
 [Database Properties (Mirroring Page)](../../Topics/TopicNameNotContainA/Database-Properties--Mirroring-Page-.md)   
 [Pause or Resume a Database Mirroring Session (SQL Server)](../../Topics/TopicNameContainA/Pause-or-Resume-a-Database-Mirroring-Session--SQL-Server-.md)   
 [Set Up a Mirror Database to Use the Trustworthy Property (Transact-SQL)](../../Topics/TopicNameContainA/Set-Up-a-Mirror-Database-to-Use-the-Trustworthy-Property--Transact-SQL-.md)   
 [Remove Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Remove-Database-Mirroring--SQL-Server-.md)   
 [Management of Logins and Jobs After Role Switching (SQL Server)](../../Topics/TopicNameNotContainA/Management-of-Logins-and-Jobs-After-Role-Switching--SQL-Server-.md)   
 [Setting Up Database Mirroring (SQL Server)](../../Topics/TopicNameNotContainA/Setting-Up-Database-Mirroring--SQL-Server-.md)   
 [Manage Metadata When Making a Database Available on Another Server Instance (SQL Server)](../../Topics/TopicNameContainA/Manage-Metadata-When-Making-a-Database-Available-on-Another-Server-Instance--SQL-Server-.md)   
 [Add or Replace a Database Mirroring Witness (SQL Server Management Studio)](../../Topics/TopicNameContainA/Add-or-Replace-a-Database-Mirroring-Witness--SQL-Server-Management-Studio-.md)