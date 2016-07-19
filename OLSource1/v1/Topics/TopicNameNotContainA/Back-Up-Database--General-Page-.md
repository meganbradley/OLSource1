---
title: Back Up Database (General Page)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5c344dfd-1ad3-41cc-98cd-732973b4a162
manager: jhubbard
---
# Back Up Database (General Page)
Use the **General** page of the **Back Up Database** dialog box to view or modify settings for a database back up operation.  
  
 For more information about basic backup concepts, see [Backup Overview (SQL Server)](../../Topics/TopicNameNotContainA/Backup-Overview--SQL-Server-.md).  
  
> [!NOTE]  
>  When you specify a backup task by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], you can generate the corresponding [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)][BACKUP](assetId:///89a4658a-62f1-4289-8982-f072229720a1) script by clicking the **Script** button and then selecting a destination for the script.  
  
 **To use SQL Server Management Studio to create a backup**  
  
-   [Create a Full Database Backup (SQL Server)](../../Topics/TopicNameContainA/Create-a-Full-Database-Backup--SQL-Server-.md)  
  
-   [Create a Differential Database Backup (SQL Server)](../../Topics/TopicNameContainA/Create-a-Differential-Database-Backup--SQL-Server-.md)  
  
    > [!IMPORTANT]  
    >  You can define a database maintenance plan to create database backups. For more information, see [Database Maintenance Plans](http://msdn.microsoft.com/library/ms187658.aspx) in [!INCLUDE[ssKilimanjaro](../../Topics/TopicNameContainA/includes/ssKilimanjaro_md.md)] Books Online.  
  
 **To create a partial backup**  
  
-   For a partial backup, you must use the [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] [BACKUP](assetId:///89a4658a-62f1-4289-8982-f072229720a1) statement with the PARTIAL option.  
  
## Options  
  
### Source  
 The options of the **Source** panel identify the database and specify the backup type and component for the back up operation.  
  
 **Database**  
 Select the database to back up.  
  
 **Recovery model**  
 View the recovery model (SIMPLE, FULL, or BULK_LOGGED) displayed for the selected database.  
  
 **Backup type**  
 Select the type of backup you want to perform on the specified database.  
  
|Backup type|Available for|Restrictions|  
|-----------------|-------------------|------------------|  
|Full|Databases, files, and filegroups|On the **master** database, only full backups are possible.<br /><br /> Under the Simple Recovery Model, file and filegroup backups are available only for read-only filegroups.|  
|Differential|Databases, files, and filegroups|Under the Simple Recovery Model, file and filegroup backups are available only for read-only filegroups.|  
|Transaction Log|Transaction logs|Transaction log backups are not available for the Simple Recovery Model.|  
  
 **Copy Only Backup**  
 Select to create a copy-only backup. A *copy-only backup* is a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] backup that is independent of the sequence of conventional [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] backups. For more information, see [Copy-Only Backups (SQL Server)](../../Topics/TopicNameNotContainA/Copy-Only-Backups--SQL-Server-.md).  
  
> [!NOTE]  
>  When the **Differential** option is selected, you cannot create a copy-only backup.  
  
 **Backup component**  
 Select the database component to be backed up. If **Transaction Log** is selected in the **Backup type** list, this option is not activated.  
  
 Select one of the following option buttons:  
  
|||  
|-|-|  
|**Database**|Specifies that the entire database be backed up.|  
|**Files and filegroups**|Specifies that the specified files and/or filegroups be backed up.<br /><br /> Selecting this option, opens the **Select Files and Filegroups** dialog box. After you select the filegroups or files you want to back up and click **Ok**, your selections appear in the **Filegroups and files** box.|  
  
### Destination  
 The options of the **Destination** panel allow for you to specify the type of backup device for the back up operation and find an existing logical or physical backup device.  
  
> [!NOTE]  
>  For information about [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] backup devices, see [Backup Devices (SQL Server)](../../Topics/TopicNameNotContainA/Backup-Devices--SQL-Server-.md).  
  
 **Back up to**  
 Select one of the following types of media to which to back up. The destinations you select appear in the **Back up to** list.  
  
|||  
|-|-|  
|**Disk**|Backs up to disk. This may be a system file or a disk-based logical backup device created for the database. The currently selected disks appear in the **Back up to** list. You can select up to 64 disk devices for your backup operation.|  
|**Tape**|Backs up to tape. This may be a local tape drive or a tape-based logical backup device created for the database. The currently selected tapes appear in the **Back up to** list. The maximum number is 64. If there are no tape devices attached to the server, this option is deactivated. The tapes you select are listed in the **Back up to** list.<br /><br /> Note: Support for tape backup devices will be removed in a future version of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. Avoid using this feature in new development work, and plan to modify applications that currently use this feature.|  
|**URL**|Backs up to Windows Azure Blob storage.|  
  
 The next set of options displayed depends on the type of destination selected. If you select Disk or Tape, the following options are displayed.  
  
 **Add**  
 Adds a file or device to the **Back up to** list. You can back up to 64 devices simultaneously on a local disk or remote disk. To specify a file on a remote disk, use the fully qualified universal naming convention (UNC) name. For more information, see [Backup Devices (SQL Server)](../../Topics/TopicNameNotContainA/Backup-Devices--SQL-Server-.md).  
  
 **Remove**  
 Removes one or more currently selected devices from the **Back up to** list.  
  
 **Contents**  
 Displays the media contents for the selected device.  
  
 If you select URL as the backup destination, the following options are displayed:  
  
 **File Name**  
 Specify the name of the backup file.  
  
 **SQL credential**  
 Select a SQL Credential used to authenticate to  Windows Azure Storage. If you do not have an existing SQL Credential you can use, click the **Create** button to create a new SQL Credential.  
  
> [!IMPORTANT]  
>  The dialog that opens when you click **Create** requires a management certificate or the publishing profile for the subscription. If you do not have access to the management certificate or publishing profile, you can create a SQL Credential by specifying the storage account name and access key information using Transact-SQL or SQL Server Management Studio. See the sample code in the in the [Create a Credential](../../Topics/TopicNameNotContainA/SQL-Server-Backup-to-URL.md#credential) topic to create a credential using Transact-SQL. Alternatively, using SQL Server Management Studio, from the database engine instance, right click **Security**, select **New**, and select **Credential**. Specify the storage account name for **Identity** and the access key in the **Password** field.  
  
 **Azure storage container**  
 Specify the name of the Windows Azure storage container  
  
 **URL prefix:**  
 This is automatically generated based on the storage account information stored in the SQL Credential, and Azure storage container name you specified. We recommend that you do not edit the information in this field unless you are using a domain that uses a format other than **<storage account\>.blob.core.windows.net**.  
  
## See Also  
 [Back Up a Transaction Log (SQL Server)](../../Topics/TopicNameContainA/Back-Up-a-Transaction-Log--SQL-Server-.md)   
 [Back Up Files and Filegroups (SQL Server)](../../Topics/TopicNameNotContainA/Back-Up-Files-and-Filegroups--SQL-Server-.md)   
 [Define a Logical Backup Device for a Disk File (SQL Server)](../../Topics/TopicNameContainA/Define-a-Logical-Backup-Device-for-a-Disk-File--SQL-Server-.md)   
 [Define a Logical Backup Device for a Tape Drive (SQL Server)](../../Topics/TopicNameContainA/Define-a-Logical-Backup-Device-for-a-Tape-Drive--SQL-Server-.md)   
 [Recovery Models (SQL Server)](../../Topics/TopicNameNotContainA/Recovery-Models--SQL-Server-.md)