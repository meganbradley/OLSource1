---
title: Restore a Database to a New Location (SQL Server)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4da76d61-5e11-4bee-84f5-b305240d9f42
manager: jhubbard
---
# Restore a Database to a New Location (SQL Server)
This topic describes how to restore a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] database to a new location, and optionally rename the database, in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)]. You can move a database to a new directory path or create a copy of a database on either the same server instance or a different server instance.  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Limitations and Restrictions](#Restrictions)  
  
     [Prerequisites](#Prerequisites)  
  
     [Recommendations](#Recommendations)  
  
     [Security](#Security)  
  
-   **To restore a database to a new location, and optionally rename the database, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
-   [Related Tasks](#RelatedTasks)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a> Limitations and Restrictions  
  
-   The system administrator restoring a full database backup must be the only person currently using the database to be restored.  
  
###  <a name="Prerequisites"></a> Prerequisites  
  
-   Under the full or bulk-logged recovery model, before you can restore a database, you must back up the active transaction log. For more information, see [Back Up a Transaction Log (SQL Server)](../../Topics/TopicNameContainA/Back-Up-a-Transaction-Log--SQL-Server-.md).  
  
###  <a name="Recommendations"></a> Recommendations  
  
-   To restore a database that is encrypted, you must have access to the certificate or asymmetric key that was used to encrypt the database. Without the certificate or asymmetric key, the database cannot be restored. As a result, the certificate that is used to encrypt the database encryption key must be retained as long as the backup is needed. For more information, see [SQL Server Certificates and Asymmetric Keys](../../Topics/TopicNameNotContainA/SQL-Server-Certificates-and-Asymmetric-Keys.md).  
  
-   For information about additional considerations for moving a database, see [Copy Databases with Backup and Restore](../../Topics/TopicNameNotContainA/Copy-Databases-with-Backup-and-Restore.md).  
  
-   If you restore a [!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)] or higher  database to [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)], the database is automatically upgraded. Typically, the database becomes available immediately. However, if a [!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)] database has full-text indexes, the upgrade process either imports, resets, or rebuilds them, depending on the setting of the  **upgrade_option** server property. If the upgrade option is set to import (**upgrade_option** = 2) or rebuild (**upgrade_option** = 0), the full-text indexes will be unavailable during the upgrade. Depending the amount of data being indexed, importing can take several hours, and rebuilding can take up to ten times longer. Note also that when the upgrade option is set to import, the associated full-text indexes are rebuilt if a full-text catalog is not available. To change the setting of the **upgrade_option** server property, use [sp_fulltext_service](assetId:///17a91433-f9b6-4a40-88c4-8c704ec2de9f).  
  
###  <a name="Security"></a> Security  
 For security purposes, we recommend that you do not attach or restore databases from unknown or untrusted sources. Such databases could contain malicious code that might execute unintended [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] code or cause errors by modifying the schema or the physical database structure. Before you use a database from an unknown or untrusted source, run [DBCC CHECKDB](assetId:///2c506167-0b69-49f7-9282-241e411910df) on the database on a nonproduction server and also examine the code, such as stored procedures or other user-defined code, in the database.  
  
####  <a name="Permissions"></a> Permissions  
 If the database being restored does not exist, the user must have CREATE DATABASE permissions to be able to execute RESTORE. If the database exists, RESTORE permissions default to members of the **sysadmin** and **dbcreator** fixed server roles and the owner (**dbo**) of the database.  
  
 RESTORE permissions are given to roles in which membership information is always readily available to the server. Because fixed database role membership can be checked only when the database is accessible and undamaged, which is not always the case when RESTORE is executed, members of the **db_owner** fixed database role do not have RESTORE permissions.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To restore a database to a new location, and optionally rename the database  
  
1.  Connect to the appropriate instance of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)], and then in Object Explorer, click the server name to expand the server tree.  
  
2.  Right-click **Databases**, and then click **Restore Database**. The **Restore Database** dialog box opens.  
  
3.  On the **General** page, use the **Source** section to specify the source and location of the backup sets to restore. Select one of the following options:  
  
    -   **Database**  
  
         Select the database to restore from the drop-down list. The list contains only databases that have been backed up according to the **msdb** backup history.  
  
    > [!NOTE]  
    >  If the backup is taken from a different server, the destination server will not have the backup history information for the specified database. In this case, select **Device** to manually specify the file or device to restore.  
  
    1.  **Device**  
  
         Click the browse (**...**) button to open the **Select backup devices** dialog box. In the **Backup media type** box, select one of the listed device types. To select one or more devices for the **Backup media** box, click **Add**.  
  
         After you add the devices you want to the **Backup media** list box, click **OK** to return to the **General** page.  
  
         In the **Source: Device: Database** list box, select the name of the database which should be restored.  
  
         **Note** This list is only available when **Device** is selected. Only databases that have backups on the selected device will be available.  
  
4.  In the **Destination** section, the **Database** box is automatically populated with the name of the database to be restored. To change the name of the database, enter the new name in the **Database** box.  
  
5.  In the **Restore to** box, leave the default as **To the last backup taken** or click on **Timeline** to access the **Backup Timeline** dialog box to manually select a point in time to stop the recovery action. See [Backup Timeline](../../Topics/TopicNameNotContainA/Backup-Timeline.md) for more information on designating a specific point in time.  
  
6.  In the **Backup sets to restore** grid, select the backups to restore. This grid displays the backups available for the specified location. By default, a recovery plan is suggested. To override the suggested recovery plan, you can change the selections in the grid. Backups that depend on the restoration of an earlier backup are automatically deselected when the earlier backup is deselected.  
  
     For information about the columns in the **Backup sets to restore** grid, see [Restore Database (General Page)](../../Topics/TopicNameNotContainA/Restore-Database--General-Page-.md).  
  
7.  To specify the new location of the database files, select the **Files** page, and then click **Relocate all files to folder**. Provide a new location for the **Data file folder** and **Log file folder**. For more information about this grid, see [Restore Database (Files Page)](../../Topics/TopicNameNotContainA/Restore-Database--Files-Page-.md).  
  
8.  On the **Options** page, adjust the options if you want. For more information about these options, see [Restore Database (Options Page)](../../Topics/TopicNameNotContainA/Restore-Database--Options-Page-.md).  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
  
#### To restore a database to a new location, and optionally rename the database  
  
1.  Optionally, determine the logical and physical names of the files in the backup set that contains the full database backup that you want to restore. This statement returns a list of the database and log files contained in the backup set. The basic syntax is as follows:  
  
     RESTORE FILELISTONLY FROM *<backup_device>* WITH FILE = *backup_set_file_number*  
  
     Here, *backup_set_file_number* indicates the position of the backup in the media set. You can obtain the position of a backup set by using the [RESTORE HEADERONLY](assetId:///4b88e98c-49c4-4388-ab0e-476cc956977c) statement. For more information, see "Specifying a Backup Set" in [RESTORE Arguments (Transact-SQL)](assetId:///4bfe5734-3003-4165-afd4-b1131ea26e2b).  
  
     This statement also supports a number of WITH options. For more information, see [RESTORE FILELISTONLY (Transact-SQL)](assetId:///0b4b4d11-eb9d-4f3e-9629-6c79cec7a81a).  
  
2.  Use the [RESTORE DATABASE](assetId:///877ecd57-3f2e-4237-890a-08f16e944ef1) statement to restore the full database backup. By default, data and log files are restored to their original locations. To relocate a database, use the MOVE option to relocate each of the database files and to avoid collisions with existing files.  
  
     The basic [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] syntax for restoring the database to a new location and a new name is:  
  
     RESTORE DATABASE *new_database_name*  
  
     FROM *backup_device* [ ,...*n* ]  
  
     [ WITH  
  
     {  
  
     [ **RECOVERY** &#124; NORECOVERY ]  
  
     [ , ] [ FILE ={ *backup_set_file_number* &#124; @*backup_set_file_number* } ]  
  
     [ , ] MOVE '*logical_file_name_in_backup*' TO '*operating_system_file_name*' [ ,...*n* ]  
  
     }  
  
     ;  
  
    > [!NOTE]  
    >  When preparing to relocate a database on a different disk, you should verify that sufficient space is available and identify any potential collisions with existing files. This involves using a [RESTORE VERIFYONLY](assetId:///cba3b6a0-b48e-4c94-812b-5b3cbb408bd6) statement that specifies the same MOVE parameters that you plan to use in your RESTORE DATABASE statement.  
  
     The following table describes arguments of this RESTORE statement in terms of restoring a database to a new location. For more information about these arguments, see [RESTORE (Transact-SQL)](assetId:///877ecd57-3f2e-4237-890a-08f16e944ef1).  
  
     *new_database_name*  
     The new name for the database.  
  
    > [!NOTE]  
    >  If you are restoring the database to a different server instance, you can use the original database name instead of a new name.  
  
     *backup_device* [ **,**...*n* ]  
     Specifies a comma-separated list of from 1 to 64 backup devices from which the database backup is to be restored. You can specify a physical backup device, or you can specify a corresponding logical backup device, if defined. To specify a physical backup device, use the DISK or TAPE option:  
  
     { DISK &#124; TAPE } **=***physical_backup_device_name*  
  
     For more information, see [Backup Devices (SQL Server)](../../Topics/TopicNameNotContainA/Backup-Devices--SQL-Server-.md).  
  
     { **RECOVERY** &#124; NORECOVERY }  
     If the database uses the full recovery model, you might need to apply transaction log backups after you restore the database. In this case, specify the NORECOVERY option.  
  
     Otherwise, use the RECOVERY option, which is the default.  
  
     FILE = { *backup_set_file_number* &#124; @*backup_set_file_number* }  
     Identifies the backup set to be restored. For example, a *backup_set_file_number* of **1** indicates the first backup set on the backup medium and a *backup_set_file_number* of **2** indicates the second backup set. You can obtain the *backup_set_file_number* of a backup set by using the [RESTORE HEADERONLY](assetId:///4b88e98c-49c4-4388-ab0e-476cc956977c) statement.  
  
     When this option is not specified, the default is to use the first backup set on the backup device.  
  
     For more information, see "Specifying a Backup Set," in [RESTORE Arguments (Transact-SQL)](assetId:///4bfe5734-3003-4165-afd4-b1131ea26e2b).  
  
     MOVE **'***logical_file_name_in_backup***'** TO **'***operating_system_file_name***'** [ **,**...*n* ]  
     Specifies that the data or log file specified by *logical_file_name_in_backup* is to be restored to the location specified by *operating_system_file_name*. Specify a MOVE statement for every logical file you want to restore from the backup set to a new location.  
  
    |Option|Description|  
    |------------|-----------------|  
    |*logical_file_name_in_backup*|Specifies the logical name of a data or log file in the backup set. The logical file name of a data or log file in a backup set matches its logical name in the database when the backup set was created.<br /><br /> <br /><br /> Note: To obtain a list of the logical files from the backup set, use [RESTORE FILELISTONLY](assetId:///0b4b4d11-eb9d-4f3e-9629-6c79cec7a81a).|  
    |*operating_system_file_name*|Specifies a new location for the file specified by *logical_file_name_in_backup*. The file will be restored to this location.<br /><br /> Optionally, *operating_system_file_name* specifies a new file name for the restored file. This is necessary if you are creating a copy of an existing database on the same server instance.|  
    |*n*|Is a placeholder indicating that you can specify additional MOVE statements.|  
  
###  <a name="TsqlExample"></a> Example (Transact-SQL)  
 This example creates a new database named `MyAdvWorks` by restoring a backup of the [!INCLUDE[ssSampleDBobject](../../Topics/TopicNameContainA/includes/ssSampleDBobject_md.md)] sample database, which includes two files: [!INCLUDE[ssSampleDBobject](../../Topics/TopicNameContainA/includes/ssSampleDBobject_md.md)]_Data and [!INCLUDE[ssSampleDBobject](../../Topics/TopicNameContainA/includes/ssSampleDBobject_md.md)]_Log. This database uses the simple recovery model. The [!INCLUDE[ssSampleDBobject](../../Topics/TopicNameContainA/includes/ssSampleDBobject_md.md)] database already exists on the server instance, so the files in the backup must be restored to a new location. The RESTORE FILELISTONLY statement is used to determine the number and names of the files in the database being restored. The database backup is the first backup set on the backup device.  
  
> [!NOTE]  
>  The examples of backing up and restoring the transaction log, including point-in-time restores, use the `MyAdvWorks_FullRM` database that is created from [!INCLUDE[ssSampleDBobject](../../Topics/TopicNameContainA/includes/ssSampleDBobject_md.md)] just like the following `MyAdvWorks` example. However, the resulting `MyAdvWorks_FullRM` database must be changed to use the full recovery model by using the following [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statement: ALTER DATABASE <database_name> SET RECOVERY FULL.  
  
```tsql  
USE master;  
GO  
-- First determine the number and names of the files in the backup.  
-- AdventureWorks2012_Backup is the name of the backup device.  
RESTORE FILELISTONLY  
   FROM AdventureWorks2012_Backup;  
-- Restore the files for MyAdvWorks.  
RESTORE DATABASE MyAdvWorks  
   FROM AdventureWorks2012_Backup  
   WITH RECOVERY,  
   MOVE 'AdventureWorks2012_Data' TO 'D:\MyData\MyAdvWorks_Data.mdf',   
   MOVE 'AdventureWorks2012_Log' TO 'F:\MyLog\MyAdvWorks_Log.ldf';  
GO  
  
```  
  
 For an example of how to create a full database backup of the [!INCLUDE[ssSampleDBobject](../../Topics/TopicNameContainA/includes/ssSampleDBobject_md.md)] database, see [Create a Full Database Backup (SQL Server)](../../Topics/TopicNameContainA/Create-a-Full-Database-Backup--SQL-Server-.md).  
  
##  <a name="RelatedTasks"></a> Related Tasks  
  
-   [Create a Full Database Backup (SQL Server)](../../Topics/TopicNameContainA/Create-a-Full-Database-Backup--SQL-Server-.md)  
  
-   [Restore a Database Backup Using SSMS](../../Topics/TopicNameContainA/Restore-a-Database-Backup-Using-SSMS.md)  
  
-   [Back Up a Transaction Log (SQL Server)](../../Topics/TopicNameContainA/Back-Up-a-Transaction-Log--SQL-Server-.md)  
  
-   [Restore a Transaction Log Backup (SQL Server)](../../Topics/TopicNameContainA/Restore-a-Transaction-Log-Backup--SQL-Server-.md)  
  
## See Also  
 [Manage Metadata When Making a Database Available on Another Server Instance (SQL Server)](../../Topics/TopicNameContainA/Manage-Metadata-When-Making-a-Database-Available-on-Another-Server-Instance--SQL-Server-.md)   
 [RESTORE](assetId:///877ecd57-3f2e-4237-890a-08f16e944ef1)   
 [Copy Databases with Backup and Restore](../../Topics/TopicNameNotContainA/Copy-Databases-with-Backup-and-Restore.md)