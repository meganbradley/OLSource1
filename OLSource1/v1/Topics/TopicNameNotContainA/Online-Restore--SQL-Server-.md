---
title: Online Restore (SQL Server)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7982a687-980a-4eb8-8e9f-6894148e7d8c
manager: jhubbard
---
# Online Restore (SQL Server)
Online restore is supported only on [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Enterprise edition. In this edition, a file, page, or piecemeal restore is online by default. This topic is relevant for databases that contain multiple files or filegroups (and, under the simple recovery model, only for read-only filegroups).  
  
 Restoring data while the database is online is called an *online restore*. A database is considered to be online whenever the primary filegroup is online, even if one or more of its secondary filegroups are offline. Under any recovery model, you can restore a file that is offline while the database is online. Under the full recovery model, you can also restore pages while the database is online.  
  
> [!NOTE]  
>  Online restore occurs automatically on [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Enterprise and requires no user action. If you do not want to use online restore, you can take a database offline before you start a restore. For more information, see [Taking a Database or File Offline](#taking_db_or_file_offline), later in this topic.  
  
 During an online file restore, any file being restored and its filegroup are offline. If any of these files is online when an online restore starts, the first restore statement takes the filegroup of the file offline. In contrast, during an online page restore, only the page is offline.  
  
 Every online restore scenario involves the following basic steps:  
  
1.  Restore the data.  
  
2.  Restore the log by using WITH RECOVERY for the last log restore. This brings the restored data online.  
  
 Occasionally, an uncommitted transaction cannot be rolled back because the data that is required by rollback is offline during startup. In this case, the transaction is deferred. For more information, see [Deferred Transactions (SQL Server)](../../Topics/TopicNameNotContainA/Deferred-Transactions--SQL-Server-.md).  
  
> [!NOTE]  
>  If the database is currently using the bulk-logged recovery model, we recommend that you switch to the full recovery model before you start an online restore. For more information, see [View or Change the Recovery Model of a Database (SQL Server)](../../Topics/TopicNameContainA/View-or-Change-the-Recovery-Model-of-a-Database--SQL-Server-.md).  
  
> [!IMPORTANT]  
>  If the backups were taken with multiple devices that were attached to the server, the same number of devices must be available during an online restore.  
  
> [!CAUTION]  
>  When using snapshot backups, you cannot perform an **Online Restore**. For more information about **Snapshot Backup**, see [File-Snapshot Backups for Database Files in Azure](../../Topics/TopicNameNotContainA/File-Snapshot-Backups-for-Database-Files-in-Azure.md).  
  
## Log Backups for Online Restore  
 In an online restore, the recovery point is the point when the data being restored was taken offline or made read-only for the last time. The transaction log backups leading up to and including this recovery point must all be available. Generally, a log backup is required after that point to cover the recovery point for the file. The only exception is during an online restore of read-only data from a data backup that was taken after the data became read-only. In this case, you do not have to have a log backup.  
  
 Generally, you may take transaction log backups while the database is online, even after the start of the restore sequence. The timing of the last log backup depends on the properties of the file being restored:  
  
-   For an online read-only file, you can take the last log backup that is required for recovery before or during the first restore sequence. A read-only filegroup may not require log backups if a data or differential backup was taken after the filegroup became read-only.  
  
    > [!NOTE]  
    >  The preceding information also applies to every offline file.  
  
-   A special case exists for a read/write file that was online when the first restore statement was issued and that was then automatically taken offline by that restore statement. In this case, you must take a log backup during the first *restore sequence* (the sequence of one or more RESTORE statements that restore, roll forward, and recover data). Generally, this log backup must occur after you restore all the full backups and before you recover the data. However, if there are multiple file backups for a specific filegroup, the minimal point of log backup is the time after the filegroup is offline. This post-data-restore log backup captures the point at which the file was taken offline. The post-data-restore log backup is necessary because the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)] cannot use online log for an online restore.  
  
    > [!NOTE]  
    >  Alternatively, you can manually take the file offline before the restore sequence. For more information, see "Taking a Database or File Offline" later in this topic.  
  
##  <a name="taking_db_or_file_offline"></a> Taking a Database or File Offline  
 If you do not want to use online restore, you can take the database offline before you start the restore sequence by using one of the following methods:  
  
-   Under any recovery model, you can take the database offline by using the following [ALTER DATABASE](assetId:///15f8affd-8f39-4021-b092-0379fc6983da) statement:  
  
     ALTER DATABASE *database_name* SET OFFLINE  
  
-   Alternatively, under the full recovery model, you can force a file or page restore to be offline, by using the following [BACKUP LOG](assetId:///89a4658a-62f1-4289-8982-f072229720a1) statement put the database in to the restoring state:  
  
     BACKUP LOG *database_name* WITH NORECOVERY.  
  
 As long as a database remains offline, all restores are offline restores.  
  
## Examples  
  
> [!NOTE]  
>  The syntax for an online restore sequence is the same as for an offline restore sequence.  
  
-   [Example: Piecemeal Restore of Database (Simple Recovery Model)](../Topic/Example:%20Piecemeal%20Restore%20of%20Database%20\(Simple%20Recovery%20Model\).md)  
  
-   [Example: Piecemeal Restore of Only Some Filegroups (Simple Recovery Model)](../Topic/Example:%20Piecemeal%20Restore%20of%20Only%20Some%20Filegroups%20\(Simple%20Recovery%20Model\).md)  
  
-   [Example: Online Restore of a Read-Only File (Simple Recovery Model)](../Topic/Example:%20Online%20Restore%20of%20a%20Read-Only%20File%20\(Simple%20Recovery%20Model\).md)  
  
-   [Example: Piecemeal Restore of Database (Full Recovery Model)](../Topic/Example:%20Piecemeal%20Restore%20of%20Database%20\(Full%20Recovery%20Model\).md)  
  
-   [Example: Piecemeal Restore of Only Some Filegroups (Full Recovery Model)](../Topic/Example:%20Piecemeal%20Restore%20of%20Only%20Some%20Filegroups%20\(Full%20Recovery%20Model\).md)  
  
-   [Example: Online Restore of a Read-Write File (Full Recovery Model)](../Topic/Example:%20Online%20Restore%20of%20a%20Read-Write%20File%20\(Full%20Recovery%20Model\).md)  
  
-   [Example: Online Restore of a Read-Only File (Full Recovery Model)](../Topic/Example:%20Online%20Restore%20of%20a%20Read-Only%20File%20\(Full%20Recovery%20Model\).md)  
  
##  <a name="RelatedTasks"></a> Related Tasks  
  
-   [Restore Files and Filegroups (SQL Server)](../../Topics/TopicNameNotContainA/Restore-Files-and-Filegroups--SQL-Server-.md)  
  
-   [Restore Pages (SQL Server)](../../Topics/TopicNameNotContainA/Restore-Pages--SQL-Server-.md)  
  
-   [Manage the suspect_pages Table (SQL Server)](../../Topics/TopicNameNotContainA/Manage-the-suspect_pages-Table--SQL-Server-.md)  
  
-   [Recover a Database Without Restoring Data (Transact-SQL)](../../Topics/TopicNameContainA/Recover-a-Database-Without-Restoring-Data--Transact-SQL-.md)  
  
-   [Remove Defunct Filegroups (SQL Server)](../../Topics/TopicNameNotContainA/Remove-Defunct-Filegroups--SQL-Server-.md)  
  
## See Also  
 [File Restores (Full Recovery Model)](../../Topics/TopicNameNotContainA/File-Restores--Full-Recovery-Model-.md)   
 [File Restores (Simple Recovery Model)](../../Topics/TopicNameNotContainA/File-Restores--Simple-Recovery-Model-.md)   
 [Restore Pages (SQL Server)](../../Topics/TopicNameNotContainA/Restore-Pages--SQL-Server-.md)   
 [Piecemeal Restores (SQL Server)](../../Topics/TopicNameNotContainA/Piecemeal-Restores--SQL-Server-.md)   
 [Restore and Recovery Overview (SQL Server)](../../Topics/TopicNameNotContainA/Restore-and-Recovery-Overview--SQL-Server-.md)