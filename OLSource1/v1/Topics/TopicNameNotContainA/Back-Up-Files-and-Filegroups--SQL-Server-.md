---
title: Back Up Files and Filegroups (SQL Server)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a0d3a567-7d8b-4cfe-a505-d197b9a51f70
manager: jhubbard
---
# Back Up Files and Filegroups (SQL Server)
This topic describes how to back up files and filegroups in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)], or PowerShell. When the database size and performance requirements make a full database backup impractical, you can create a file backup instead. A *file backup* contains all the data in one or more files (or filegroups). For more information about file backups, see [Full File Backups (SQL Server)](../../Topics/TopicNameNotContainA/Full-File-Backups--SQL-Server-.md) and [Differential Backups (SQL Server)](../../Topics/TopicNameNotContainA/Differential-Backups--SQL-Server-.md).  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Limitations and Restrictions](#Restrictions)  
  
     [Recommendations](#Recommendations)  
  
     [Security](#Security)  
  
-   **To back up files and filegroups, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
     [PowerShell](#PowerShellProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a> Limitations and Restrictions  
  
-   The BACKUP statement is not allowed in an explicit or implicit transaction.  
  
-   Under the simple recovery model, read/write files must all be backed up together. This helps make sure that the database can be restored to a consistent point in time. Instead of individually specifying each read/write file or filegroup, use the READ_WRITE_FILEGROUPS option. This option backs up all the read/write filegroups in the database. A backup that is created by specifying READ_WRITE_FILEGROUPS is known as a *partial backup*. For more information, see [Partial Backups (SQL Server)](../../Topics/TopicNameNotContainA/Partial-Backups--SQL-Server-.md).  
  
-   For more information about limitations and restrictions, see [Backup Overview (SQL Server)](../../Topics/TopicNameNotContainA/Backup-Overview--SQL-Server-.md).  
  
###  <a name="Recommendations"></a> Recommendations  
  
-   By default, every successful backup operation adds an entry in the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] error log and in the system event log. If you back up the log very frequently, these success messages accumulate quickly, resulting in huge error logs that can make finding other messages difficult. In such cases you can suppress these log entries by using trace flag 3226 if none of your scripts depend on those entries. For more information, see [Trace Flags (Transact-SQL)](assetId:///b971b540-1ac2-435b-b191-24399eb88265).  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 BACKUP DATABASE and BACKUP LOG permissions default to members of the **sysadmin** fixed server role and the **db_owner** and **db_backupoperator** fixed database roles.  
  
 Ownership and permission problems on the backup device's physical file can interfere with a backup operation. [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] must be able to read and write to the device; the account under which the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] service runs must have write permissions. However, [sp_addumpdevice](assetId:///c2d2ae49-0808-46d8-8444-db69a69d0ec3), which adds an entry for a backup device in the system tables, does not check file access permissions. Such problems on the backup device's physical file may not appear until the physical resource is accessed when the backup or restore is attempted.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To back up database files and filegroups  
  
1.  After connecting to the appropriate instance of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)], in Object Explorer, click the server name to expand the server tree.  
  
2.  Expand **Databases**, and, depending on the database, either select a user database or expand **System Databases** and select a system database.  
  
3.  Right-click the database, point to **Tasks**, and then click **Back Up**. The **Back Up Database** dialog box appears.  
  
4.  In the **Database** list, verify the database name. You can optionally select a different database from the list.  
  
5.  In the **Backup type** list, select **Full** or **Differential**.  
  
6.  For the **Backup component** option, click **File and Filegroups**.  
  
7.  In the **Select Files and Filegroups** dialog box, select the files and filegroups you want to back up. You can select one or more individual files or check the box for a filegroup to automatically select all the files in that filegroup.  
  
8.  Either accept the default backup set name suggested in the **Name** text box, or enter a different name for the backup set.  
  
9. Optionally, in the **Description** text box, enter a description of the backup set.  
  
10. Specify when the backup set will expire:  
  
    -   To have the backup set expire after a specific number of days, click **After** (the default option). Then, enter the number of days after set creation that the set will expire. This value can be from 0 to 99999 days; a value of 0 days means that the backup set will never expire.  
  
         The default value is set in the **Default backup media retention (in days)** option of the **Server Properties** dialog box (**Database Settings** page). To access this option, right-click the server name in Object Explorer and select properties; then select the **Database Settings** page.  
  
    -   To have the backup set expire on a specific date, click **On**, and enter the date on which the set will expire.  
  
11. Choose the type of backup destination by clicking **Disk** or **Tape**. To select the paths of up to 64 disk or tape drives that contain a single media set, click **Add**. The selected paths are displayed in the **Backup to** list.  
  
    > [!NOTE]  
    >  To remove a backup destination, select it and click **Remove**. To view the contents of a backup destination, select it and click **Contents**.  
  
12. To view or select the advanced options, click **Options** in the **Select a page** pane.  
  
13. Select an **Overwrite Media** option, by clicking one of the following:  
  
    -   **Back up to the existing media set**  
  
         For this option, click either **Append to the existing backup set** or **Overwrite all existing backup sets**. For information about backing up to an existing media set, see [Media Sets, Media Families, and Backup Sets (SQL Server)](../../Topics/TopicNameNotContainA/Media-Sets--Media-Families--and-Backup-Sets--SQL-Server-.md).  
  
         Optionally, select **Check media set name and backup set expiration** to cause the backup operation to verify the date and time at which the media set and backup set expire.  
  
         Optionally, enter a name in the **Media set name** text box. If no name is specified, a media set with a blank name is created. If you specify a media set name, the media (tape or disk) is checked to see whether the actual name matches the name that you enter here.  
  
         If you leave the media name blank and check the box to check it against the media, success will equal the media name on the media also being blank.  
  
    -   **Back up to a new media set, and erase all existing backup sets**  
  
         For this option, enter a name in the **New media set name** text box, and, optionally, describe the media set in the **New media set description** text box. For more information about creating a new media set, see [Media Sets, Media Families, and Backup Sets (SQL Server)](../../Topics/TopicNameNotContainA/Media-Sets--Media-Families--and-Backup-Sets--SQL-Server-.md).  
  
14. In the **Reliability** section, optionally check:  
  
    -   **Verify backup when finished**.  
  
    -   **Perform checksum before writing to media**, and, optionally, **Continue on checksum error**. For more information about checksums, see [Possible Media Errors During Backup and Restore (SQL Server)](../../Topics/TopicNameNotContainA/Possible-Media-Errors-During-Backup-and-Restore--SQL-Server-.md).  
  
15. If you are backing up to a tape drive (as specified in the **Destination** section of the **General** page), the **Unload the tape after backup** option is active. Clicking this option enables the **Rewind the tape before unloading** option.  
  
    > [!NOTE]  
    >  The options in the **Transaction log** section are inactive unless you are backing up a transaction log (as specified in the **Backup type** section of the **General** page).  
  
16. [!INCLUDE[ssEnterpriseEd10](../../Topics/TopicNameContainA/includes/ssEnterpriseEd10_md.md)] and later versions support [backup compression](../../Topics/TopicNameNotContainA/Backup-Compression--SQL-Server-.md). By default, whether a backup is compressed depends on the value of the **backup-compression default** server configuration option. However, regardless of the current server-level default, you can compress a backup by checking **Compress backup**, and you can prevent compression by checking **Do not compress backup**.  
  
     **To view the current backup compression default**  
  
    -   [View or Configure the backup compression default Server Configuration Option](../../Topics/TopicNameNotContainA/View-or-Configure-the-backup-compression-default-Server-Configuration-Option.md)  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
  
#### To back up files and filegroups  
  
1.  To create a file or filegroup backup, use a [BACKUP DATABASE <file_or_filegroup>](assetId:///89a4658a-62f1-4289-8982-f072229720a1) statement. Minimally, this statement must specify the following:  
  
    -   The database name.  
  
    -   A FILE or FILEGROUP clause for each file or filegroup, respectively.  
  
    -   The backup device on which the full backup will be written.  
  
     The basic [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] syntax for a file backup is:  
  
     BACKUP DATABASE *database*  
  
     { FILE **=***logical_file_name* &#124; FILEGROUP **=***logical_filegroup_name* } [ **,**...*f* ]  
  
     TO *backup_device* [ **,**...*n* ]  
  
     [ WITH *with_options* [ **,**...*o* ] ] ;  
  
    |Option|Description|  
    |------------|-----------------|  
    |*database*|Is the database from which the transaction log, partial database, or complete database is backed up.|  
    |FILE **=***logical_file_name*|Specifies the logical name of a file to include in the file backup.|  
    |FILEGROUP **=***logical_filegroup_name*|Specifies the logical name of a filegroup to include in the file backup. Under the simple recovery model, a filegroup backup is allowed only for a read-only filegroup.|  
    |[ **,**...*f* ]|Is a placeholder that indicates that multiple files and filegroups may be specified. The number of files or filegroups is unlimited.|  
    |*backup_device* [ **,**...*n* ]|Specifies a list of from 1 to 64 backup devices to use for the backup operation. You can specify a physical backup device, or you can specify a corresponding logical backup device, if already defined. To specify a physical backup device, use the DISK or TAPE option:<br /><br /> { DISK &#124; TAPE } **=***physical_backup_device_name*<br /><br /> For more information, see [Backup Devices (SQL Server)](../../Topics/TopicNameNotContainA/Backup-Devices--SQL-Server-.md).|  
    |WITH *with_options* [ **,**...*o* ]|Optionally, specifies one or more additional options, such as DIFFERENTIAL.<br /><br /> Note: A differential file backup requires a full file backup as a base. For more information, see [Create a Differential Database Backup (SQL Server)](../../Topics/TopicNameContainA/Create-a-Differential-Database-Backup--SQL-Server-.md).|  
  
2.  Under the full recovery model, you must also back up the transaction log. To use a complete set of full file backups to restore a database, you must also have enough log backups to span all the file backups, from the start of the first file backup. For more information, see [Back Up a Transaction Log (SQL Server)](../../Topics/TopicNameContainA/Back-Up-a-Transaction-Log--SQL-Server-.md).  
  
###  <a name="TsqlExample"></a> Examples (Transact-SQL)  
 The following examples back up one or more files of the secondary filegroups of the `Sales` database. This database uses the full recovery model and contains the following secondary filegroups:  
  
-   A filegroup named `SalesGroup1` that has the files `SGrp1Fi1` and `SGrp1Fi2`.  
  
-   A filegroup named `SalesGroup2` that has the files `SGrp2Fi1` and `SGrp2Fi2`.  
  
#### A. Creating a file backup of two files  
 The following example creates a differential file backup of only the `SGrp1Fi2` file of the `SalesGroup1` and the `SGrp2Fi2` file of the `SalesGroup2` filegroup.  
  
```tsql  
--Backup the files in the SalesGroup1 secondary filegroup.  
BACKUP DATABASE Sales  
   FILE = 'SGrp1Fi2',   
   FILE = 'SGrp2Fi2'   
   TO DISK = 'G:\SQL Server Backups\Sales\SalesGroup1.bck';  
GO  
```  
  
#### B. Creating a full file backup of the secondary filegroups  
 The following example creates a full file backup of every file in both of the secondary filegroups.  
  
```tsql  
--Back up the files in SalesGroup1.  
BACKUP DATABASE Sales  
   FILEGROUP = 'SalesGroup1',  
   FILEGROUP = 'SalesGroup2'  
   TO DISK = 'C:\MySQLServer\Backups\Sales\SalesFiles.bck';  
GO  
```  
  
#### C. Creating a differential file backup of the secondary filegroups  
 The following example creates a differential file backup of every file in both of the secondary filegroups.  
  
```tsql  
--Back up the files in SalesGroup1.  
BACKUP DATABASE Sales  
   FILEGROUP = 'SalesGroup1',  
   FILEGROUP = 'SalesGroup2'  
   TO DISK = 'C:\MySQLServer\Backups\Sales\SalesFiles.bck'  
   WITH   
      DIFFERENTIAL;  
GO  
```  
  
##  <a name="PowerShellProcedure"></a> Using PowerShell  
  
1.  Use the **Backup-SqlDatabase** cmdlet and specify **Files** for the value of the **-BackupAction** parameter. Also, specify one of the following parameters:  
  
    -   To back up a specific file, specify the **-DatabaseFile***String* parameter, where *String* is one or more database files to be backed up.  
  
    -   To back up all the files in a given filegroup, specify the **-DatabaseFileGroup***String* parameter, where *String* is one or more database filegroups to be backed up.  
  
     The following example creates a full file backup of every file in the secondary filegroups 'FileGroup1' and 'FileGroup2' in the `MyDB` database. The backups are created on the default backup location of the server instance `Computer\Instance`.  
  
    ```  
    --Enter this command at the PowerShell command prompt, C:\PS>  
    Backup-SqlDatabase -ServerInstance Computer\Instance -Database MyDB -BackupAction Files -DatabaseFileGroup "FileGroup1","FileGroup2"  
    ```  
  
 **To set up and use the SQL Server PowerShell provider**  
  
-   [SQL Server PowerShell Provider](../../Topics/TopicNameNotContainA/SQL-Server-PowerShell-Provider.md)  
  
## See Also  
 [Backup Overview (SQL Server)](../../Topics/TopicNameNotContainA/Backup-Overview--SQL-Server-.md)   
 [BACKUP](assetId:///89a4658a-62f1-4289-8982-f072229720a1)   
 [RESTORE (Transact-SQL)](assetId:///877ecd57-3f2e-4237-890a-08f16e944ef1)   
 [Backup History and Header Information (SQL Server)](../../Topics/TopicNameNotContainA/Backup-History-and-Header-Information--SQL-Server-.md)   
 [Back Up Database (General Page)](../../Topics/TopicNameNotContainA/Back-Up-Database--General-Page-.md)   
 [Back Up Database (Backup Options Page)](../../Topics/TopicNameNotContainA/Back-Up-Database--Backup-Options-Page-.md)   
 [Full File Backups (SQL Server)](../../Topics/TopicNameNotContainA/Full-File-Backups--SQL-Server-.md)   
 [Differential Backups (SQL Server)](../../Topics/TopicNameNotContainA/Differential-Backups--SQL-Server-.md)   
 [File Restores (Full Recovery Model)](../../Topics/TopicNameNotContainA/File-Restores--Full-Recovery-Model-.md)   
 [File Restores (Simple Recovery Model)](../../Topics/TopicNameNotContainA/File-Restores--Simple-Recovery-Model-.md)