---
title: Select Initial Data Synchronization Page (Always On Availability Group Wizards)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 457b1140-4819-4def-8f7c-54a406e6db12
---
# Select Initial Data Synchronization Page (Always On Availability Group Wizards)
  Use the Always On **Select Initial Data Synchronization** page to indicate your preference for initial data synchronization of new secondary databases. This page is shared by three wizards—the [!INCLUDE[ssAoNewAgWiz](../../Token\Other/ssAoNewAgWiz_md.md)], the [!INCLUDE[ssAoAddRepWiz](../../Token\Other/ssAoAddRepWiz_md.md)], and the [!INCLUDE[ssAoAddDbWiz](../../Token\Other/ssAoAddDbWiz_md.md)].  
  
 The possible choices include **Full**, **Join only**, or **Skip initial data synchronization**. Before you select **Full** or **Join only** ensure that your environment meets the prerequisites.  
  
 **In this topic:**  
  
-   [Recommendations](#Recommendations)  
  
-   [Full](#Full)  
  
-   [Join only](#Joinonly)  
  
-   [Skip initial data synchronization](#Skip)  
  
-   [To Prepare Secondary Databases Manually](#PrepareSecondaryDbs)  
  
-   [Related Tasks](#LaunchWiz)  
  
##  <a name="Recommendations"></a> Recommendations  
  
-   Suspend log backup tasks for the primary databases during initial data synchronization.  
  
-   For large database, full backup and restore operations can take extensive time and resources. In such cases, we recommend that you prepare secondary databases yourself. For more information, see [To Prepare Secondary Databases Manually](#PrepareSecondaryDbs), later in this topic.  
  
-   Full initial data synchronization requires you to specify a network share. Before you use a wizard to perform full initial data synchronization, we recommend that you implement a security plan for the access permissions on the network share folder. This precaution is important because potentially sensitive data in the backup file can be accessed by anyone who has a READ permission on the folder. Also, to protect your backup and restore operations, we recommend that you secure the network channels between every server instance that hosts an availability replica and the network share folder.  
  
     If your backup and restore operations must be highly secured, we recommend that you select either the **Join only** or **Skip initial data synchronization** option.  
  
##  <a name="Full"></a> Full  
 For each primary database, the **Full** option performs several operations in one workflow:  create a full and log backup of the primary database, create the corresponding secondary databases by restoring these backups on every server instance that is hosting a secondary replica, and join each secondary database to availability group.  
  
 Select this option only if your environment meets the following prerequisites for using full initial data synchronization, and you want the wizard to automatically start data synchronization.  
  
 **Prerequisites for using full initial data synchronization**  
  
-   All the database\-file paths must be identical on every server instance that hosts a replica for the availability group.  
  
    > [!NOTE]  
    >  If the backup and restore file paths differ between the server instance where you run the wizard and any server instance that is to host a secondary replica. The backup and restore operations must be performed manually using the WITH MOVE option. For more information, see [To Prepare Secondary Databases Manually](#PrepareSecondaryDbs), later in this topic.  
  
-   No primary database name can exist on any server instance that hosts a secondary replica. This means that none of the new secondary databases can exist yet.  
  
-   You will need to specify a network share in order for the wizard to create and access backups. For the primary replica, the account used to start the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] must have read and write file\-system permissions on a network share. For secondary replicas, the account must have read permission on the network share.  
  
    > [!IMPORTANT]  
    >  The log backups will be part of your log backup chain. Store the log backup files appropriately.  
  
 **If prerequisites are not met**  
  
 The wizard cannot create the secondary databases for this availability group. For information on how to prepare them, see [To Prepare Secondary Databases Manually](#PrepareSecondaryDbs), later in this topic.  
  
 **If prerequisites are met**  
  
 If these prerequisites are all met and you want the wizard to perform full initial data synchronization, select the **Full** option and specify a network share. This will cause  the wizard to create full database and log backups of every selected database and to place these backups on the network share that you specify. Then, on every server instance that hosts one of the new secondary replicas, the wizard will create the secondary databases by restoring backups using RESTORE WITH NORECOVERY. After creating each of the secondary databases, the wizard will join the new secondary database to the availability group. As soon as a secondary database is joined, data synchronizations starts on that database.  
  
 **Specify a shared network location accessible by all replicas**  
 To create and restore backups, the wizard requires that you specify a network share. The account used to start the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] on each server instance that will host an availability replica must have read and write file\-system permissions on the network share.  
  
> [!IMPORTANT]  
>  The log backups will be part of your log backup chain. Store their backup files appropriately.  
  
##  <a name="Joinonly"></a> Join only  
 Select this option only if the new secondary databases already exist on each server instance that hosts a secondary replica for the availability group. For information about preparing secondary databases, see [To Prepare Secondary Databases Manually](#PrepareSecondaryDbs), later in this section.  
  
 If you select **Join only**, the wizard will attempt to join each existing secondary database to the availability group.  
  
## <a name="Skip"></a> Skip initial data synchronization  
 Select this option if you want to perform your own database and log backups of every primary database, restore them to every server instance that hosts a secondary replica. After you exit the wizard, you will then need to join every secondary database on every secondary replica.  
  
> [!NOTE]  
>  For more information, see [Start Data Movement on an Always On Secondary Database &#40;SQL Server&#41;](../Topic/Start%20Data%20Movement%20on%20an%20Always%20On%20Secondary%20Database%20\(SQL%20Server\).md).  
  
##  <a name="PrepareSecondaryDbs"></a> To Prepare Secondary Databases Manually  
 To prepare secondary databases independently of any [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)] wizard, you can use either of the following approaches:  
  
-   Manually restore a recent database backup of the primary database using RESTORE WITH NORECOVERY, and then restore each subsequent log backup using RESTORE WITH NORECOVERY. If the primary and secondary databases have different file paths, you must use the WITH MOVE option. Perform this restore sequence on every server instance that hosts a secondary replica for the availability group.  You can use [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] or PowerShell to perform these backup and restore operations.  
  
     **For more information:**  
  
     [Manually Prepare a Secondary Database for an Availability Group &#40;SQL Server&#41;](../Topic/Manually%20Prepare%20a%20Secondary%20Database%20for%20an%20Availability%20Group%20\(SQL%20Server\).md)  
  
-   If you are adding one or more log shipping primary databases to an availability group, you might be able to migrate one or more of the corresponding secondary databases from log shipping to [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)]. For more information, see [Prerequisites for Migrating from Log Shipping to Always On Availability Groups &#40;SQL Server&#41;](../Topic/Prerequisites%20for%20Migrating%20from%20Log%20Shipping%20to%20Always%20On%20Availability%20Groups%20\(SQL%20Server\).md).  
  
    > [!NOTE]  
    >  After you have created all the secondary databases for the availability group, if you want to perform backups on secondary replicas, you will need to re\-configure the automated backup preference of the availability group.  
  
     **For more information:**  
  
     [Prerequisites for Migrating from Log Shipping to Always On Availability Groups &#40;SQL Server&#41;](../Topic/Prerequisites%20for%20Migrating%20from%20Log%20Shipping%20to%20Always%20On%20Availability%20Groups%20\(SQL%20Server\).md)  
  
     [Configure Backup on Availability Replicas &#40;SQL Server&#41;](../Topic/Configure%20Backup%20on%20Availability%20Replicas%20\(SQL%20Server\).md)  
  
 After creating a secondary database, apply all current log backups to the new secondary database.  
  
 Optionally, you can prepare all the secondary databases before you run the wizard. Then, on the wizard's **Specify Initial Data Synchronization** page, select **Join only** to automatically join your new secondary databases to the availability group.  
  
##  <a name="LaunchWiz"></a> Related Tasks  
  
-   [Use the New Availability Group Dialog Box &#40;SQL Server Management Studio&#41;](../Topic/Use%20the%20New%20Availability%20Group%20Dialog%20Box%20\(SQL%20Server%20Management%20Studio\).md)  
  
-   [Use the Add Replica to Availability Group Wizard &#40;SQL Server Management Studio&#41;](../Topic/Use%20the%20Add%20Replica%20to%20Availability%20Group%20Wizard%20\(SQL%20Server%20Management%20Studio\).md)  
  
-   [Use the Add Database to Availability Group Wizard &#40;SQL Server Management Studio&#41;](../Topic/Use%20the%20Add%20Database%20to%20Availability%20Group%20Wizard%20\(SQL%20Server%20Management%20Studio\).md)  
  
-   [Use the Fail Over Availability Group Wizard &#40;SQL Server Management Studio&#41;](../Topic/Use%20the%20Fail%20Over%20Availability%20Group%20Wizard%20\(SQL%20Server%20Management%20Studio\).md)  
  
-   [Start Data Movement on an Always On Secondary Database &#40;SQL Server&#41;](../Topic/Start%20Data%20Movement%20on%20an%20Always%20On%20Secondary%20Database%20\(SQL%20Server\).md)  
  
-   [Join a Secondary Database to an Availability Group &#40;SQL Server&#41;](../Topic/Join%20a%20Secondary%20Database%20to%20an%20Availability%20Group%20\(SQL%20Server\).md)  
  
-   [Use the New Availability Group Dialog Box &#40;SQL Server Management Studio&#41;](../Topic/Use%20the%20New%20Availability%20Group%20Dialog%20Box%20\(SQL%20Server%20Management%20Studio\).md)  
  
## See Also  
 [Overview of Always On Availability Groups &#40;SQL Server&#41;](../Topic/Overview%20of%20Always%20On%20Availability%20Groups%20\(SQL%20Server\).md)  
  
  