---
title: Tail-Log Backups (SQL Server)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 313ddaf6-ec54-4a81-a104-7ffa9533ca58
manager: jhubbard
---
# Tail-Log Backups (SQL Server)
This topic is relevant only for backup and restore of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] databases that are using the full or bulk-logged recovery models.  
  
 A *tail-log backup* captures any log records that have not yet been backed up (the *tail of the log*) to prevent work loss and to keep the log chain intact. Before you can recover a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] database to its latest point in time, you must back up the tail of its transaction log. The tail-log backup will be the last backup of interest in the recovery plan for the database.  
  
> [!NOTE]  
>  Not all restore scenarios require a tail-log backup. You do not need a tail-log backup if the recovery point is contained in an earlier log backup. Also, a tail-log backup is unnecessary if you are moving or replacing (overwriting) a database and do not need to restore it to a point of time after its most recent backup.  
  
 **In this Topic:**  
  
-   [Scenarios That Require a Tail-Log Backup](#TailLogScenarios)  
  
-   [Tail-Log Backups That Have Incomplete Backup Metadata](#IncompleteMetadata)  
  
-   [Related Tasks](#RelatedTasks)  
  
-   [Related Content](#RelatedContent)  
  
##  <a name="TailLogScenarios"></a> Scenarios That Require a Tail-Log Backup  
 We recommend that you take a tail-log backup in the following scenarios:  
  
-   If the database is online and you plan to perform a restore operation on the database, begin by backing up the tail of the log. To avoid an error for an online database, you must use the … WITH NORECOVERY option of the [BACKUP](assetId:///89a4658a-62f1-4289-8982-f072229720a1)[!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statement.  
  
-   If a database is offline and fails to start and you need to restore the database, first back up the tail of the log. Because no transactions can occur at this time, using the WITH NORECOVERY is optional.  
  
-   If a database is damaged, try to take a tail-log backup by using the WITH CONTINUE_AFTER_ERROR option of the BACKUP statement.  
  
     On a damaged database backing up the tail of the log can succeed only if the log files are undamaged, the database is in a state that supports tail-log backups, and the database does not contain any bulk-logged changes. If a tail-log backup cannot be created, any transactions committed after the latest log backup are lost.  
  
 The following table summarizes the BACKUP NORECOVERY and CONTINUE_AFTER_ERROR options.  
  
|BACKUP LOG option|Comments|  
|-----------------------|--------------|  
|NORECOVERY|Use NORECOVERY whenever you intend to continue with a restore operation on the database. NORECOVERY takes the database into the restoring state. This guarantees that the database does not change after the tail-log backup. The log will be truncated unless the NO_TRUNCATE option or COPY_ONLY option is also specified.<br /><br /> **\*\* Important \*\*** Avoid using NO_TRUNCATE, except when the database is damaged.|  
|CONTINUE_AFTER_ERROR|Use CONTINUE_AFTER_ERROR only if you are backing up the tail of a damaged database.<br /><br /> When you use back up the tail of the log on a damaged database, some of the metadata ordinarily captured in log backups might be unavailable. For more information, see [Tail-Log Backups That Have Incomplete Backup Metadata](#IncompleteMetadata), later in this topic.|  
  
##  <a name="IncompleteMetadata"></a> Tail-Log Backups That Have Incomplete Backup Metadata  
 Tail log backups capture the tail of the log even if the database is offline, damaged, or missing data files. This might cause incomplete metadata from the restore information commands and **msdb**. However, only the metadata is incomplete; the captured log is complete and usable.  
  
 If a tail-log backup has incomplete metadata, in the [backupset](assetId:///6ff79bbf-4acf-4f75-926f-38637ca8a943) table, **has_incomplete_metadata** is set to **1**. Also, in the output of [RESTORE HEADERONLY](assetId:///4b88e98c-49c4-4388-ab0e-476cc956977c), **HasIncompleteMetadata** is set to **1**.  
  
 If the metadata in a tail-log backup is incomplete, the [backupfilegroup](assetId:///d26e8fbe-f5c5-4e10-b2bd-0d8e16ea21f9) table will be missing most of the information about filegroups at the time of the tail-log backup. Most of the **backupfilegroup** table columns are NULL; the only meaningful columns are as follows:  
  
-   **backup_set_id**  
  
-   **filegroup_id**  
  
-   **type**  
  
-   **type_desc**  
  
-   **is_readonly**  
  
##  <a name="RelatedTasks"></a> Related Tasks  
 To create a tail-log backup, see [Back Up the Transaction Log When the Database Is Damaged (SQL Server)](../../Topics/TopicNameNotContainA/Back-Up-the-Transaction-Log-When-the-Database-Is-Damaged--SQL-Server-.md).  
  
 To restore a transaction log backup, see [Restore a Transaction Log Backup (SQL Server)](../../Topics/TopicNameContainA/Restore-a-Transaction-Log-Backup--SQL-Server-.md).  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="RelatedContent"></a> Related Content  
 None.  
  
 [&#91;Top&#93;](#Top)  
  
## See Also  
 [BACKUP (Transact-SQL)](assetId:///89a4658a-62f1-4289-8982-f072229720a1)   
 [RESTORE (Transact-SQL)](assetId:///877ecd57-3f2e-4237-890a-08f16e944ef1)   
 [Back Up and Restore of SQL Server Databases](../../Topics/TopicNameNotContainA/Back-Up-and-Restore-of-SQL-Server-Databases.md)   
 [Copy-Only Backups (SQL Server)](../../Topics/TopicNameNotContainA/Copy-Only-Backups--SQL-Server-.md)   
 [Transaction Log Backups (SQL Server)](../../Topics/TopicNameNotContainA/Transaction-Log-Backups--SQL-Server-.md)   
 [Apply Transaction Log Backups (SQL Server)](../../Topics/TopicNameNotContainA/Apply-Transaction-Log-Backups--SQL-Server-.md)