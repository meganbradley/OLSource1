---
title: "Change Roles Between Primary and Secondary Log Shipping Servers (SQL Server)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2d7cc40a-47e8-4419-9b2b-7c69f700e806
caps.latest.revision: 21
manager: jhubbard
---
# Change Roles Between Primary and Secondary Log Shipping Servers (SQL Server)
After you have failed over a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] log shipping configuration to a secondary server, you can configure your secondary database to act as the primary database. Then, you will be able to swap primary and secondary databases as needed.  
  
## Performing the Initial Role Change  
 The first time you want to fail over to the secondary database and make it your new primary database, there is a series of steps you must take. After you have followed these initial steps, you will be able to swap roles between the primary database and the secondary database easily.  
  
1.  Manually fail over from the primary database to a secondary database. Be sure to back up the active transaction log on your primary server with NORECOVERY. For more information, see [Fail Over to a Log Shipping Secondary (SQL Server)](../../Topics/TopicNameContainA/Fail-Over-to-a-Log-Shipping-Secondary--SQL-Server-.md).  
  
2.  Disable the log shipping backup job on the original primary server, and the copy and restore jobs on the original secondary server.  
  
3.  On your secondary database (the database you want to be the new primary), configure log shipping using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]. For more information, see [Configure Log Shipping (SQL Server)](../../Topics/TopicNameNotContainA/Configure-Log-Shipping--SQL-Server-.md). Include the following steps:  
  
    1.  Use the same share for creating backups that you created for the original primary server.  
  
    2.  When adding the secondary database, in the **Secondary Database Settings** dialog box, enter the name of the original primary database in the **Secondary database** box.  
  
    3.  In the **Secondary Database Settings** dialog box, select **No, the secondary database is initialized**.  
  
4.  If log shipping monitoring was enabled on your former log shipping configuration, reconfigure log shipping monitoring to monitor the new log shipping configuration.  Execute the following commands, replacing *database_name* with the name of your database:  
  
    1.  **On the new primary server**  
  
         Execute the following [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statements:  
  
        ```  
        -- Statement to execute on the new primary server  
        USE msdb  
        GO  
        EXEC master.dbo.sp_change_log_shipping_secondary_database @secondary_database = N'database_name', @threshold_alert_enabled = 0;  
        GO  
        ```  
  
    2.  **On the new secondary server**  
  
         Execute the following [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statements:  
  
        ```  
        -- Statement to execute on the new secondary server  
        USE msdb  
        GO  
        EXEC master.dbo.sp_change_log_shipping_primary_database @database=N'database_name', @threshold_alert_enabled = 0;  
        GO  
        ```  
  
## Swapping Roles  
 After you have completed the steps above for the initial role change, you can change roles between the primary database and the secondary database by following the steps in this section. To perform a role change, follow these general steps:  
  
1.  Bring the secondary database online, backing up the transaction log on the primary server with NORECOVERY.  
  
2.  Disable the log shipping backup job on the original primary server, and the copy and restore jobs on the original secondary server.  
  
3.  Enable the log shipping backup job on the secondary server (the new primary server), and the copy and restore jobs on the primary server (the new secondary server).  
  
> [!IMPORTANT]  
>  When you change a secondary database to the primary database, to provide a consistent experience to users and applications, you might have to re-create some or all of the metadata for the database, such as logins and jobs, on the new primary server instance. For more information, see [Manage Metadata When Making a Database Available on Another Server Instance (SQL Server)](../../Topics/TopicNameContainA/Manage-Metadata-When-Making-a-Database-Available-on-Another-Server-Instance--SQL-Server-.md).  
  
##  <a name="RelatedTasks"></a> Related Tasks  
  
-   [Fail Over to a Log Shipping Secondary (SQL Server)](../../Topics/TopicNameContainA/Fail-Over-to-a-Log-Shipping-Secondary--SQL-Server-.md)  
  
-   [Management of Logins and Jobs After Role Switching (SQL Server)](../../Topics/TopicNameNotContainA/Management-of-Logins-and-Jobs-After-Role-Switching--SQL-Server-.md)  
  
## See Also  
 [Log Shipping Tables and Stored Procedures](../../Topics/TopicNameNotContainA/Log-Shipping-Tables-and-Stored-Procedures.md)