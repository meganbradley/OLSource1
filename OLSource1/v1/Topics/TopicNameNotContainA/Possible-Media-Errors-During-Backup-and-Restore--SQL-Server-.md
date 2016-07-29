---
title: "Possible Media Errors During Backup and Restore (SQL Server)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 83a27b29-1191-4f8d-9648-6e6be73a9b7c
caps.latest.revision: 37
manager: jhubbard
---
# Possible Media Errors During Backup and Restore (SQL Server)
[!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] gives you the option of recovering a database despite detected errors. An important new error-detection mechanism is the optional creation of a backup checksum that can be created by a backup operation and validated by a restore operation. You can control whether an operation checks for errors and whether the operation stops or continues on encountering an error. If a backup contains a backup checksum, RESTORE and RESTORE VERIFYONLY statements can check for errors.  
  
> [!NOTE]  
>  Mirrored backups provide up to four copies (mirrors) of a media set, providing alternative copies for recovering from errors caused by damaged media. For more information, see [Mirrored Backup Media Sets (SQL Server)](../../Topics/TopicNameNotContainA/Mirrored-Backup-Media-Sets--SQL-Server-.md).  
  
 **In this Topic:**  
  
-   [Backup Checksums](#BckChecksums)  
  
-   [Response to Page Checksum Errors During a Backup or Restore Operation](#ResponsetoPageChecksumErrors)  
  
-   [Related Tasks](#RelatedTasks)  
  
##  <a name="BckChecksums"></a> Backup Checksums  
 [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] supports three types of checksums: a checksum on pages, a checksum in log blocks, and a backup checksum. When generating a backup checksum, BACKUP verifies that the data read from the database is consistent with any checksum or torn-page indication that is present in the database.  
  
 The BACKUP statement optionally computes a backup checksum on the backup stream; if page-checksum or torn-page information is present on a given page, when backing up the page, BACKUP also verifies the checksum and torn-page status and the page ID, of the page. When creating a backup checksum, a backup operation does not add any checksums to pages. Pages are backed up as they exist in the database, and the pages are unmodified by backup.  
  
 Due to the overhead verifying and generating backup checksums, using backup checksums poses a potential performance impact. Both the workload and the backup throughput may be affected. Therefore, using backup checksums is optional. When deciding to generate checksums during a backup, carefully monitor the CPU overhead incurred as well as the impact on any concurrent workload on the system.  
  
 BACKUP never modifies the source page on disk nor the contents of a page.  
  
 When backup checksums are enabled, a backup operation performs the following steps:  
  
1.  Before writing a page to the backup media, the backup operation verifies the page-level information (page checksum or torn page detection), if either exists. If neither exists, backup cannot verify the page. Unverified the pages are included as is, and their contents are added to the overall backup checksum.  
  
     If the backup operation encounters a page error during verification, the backup fails.  
  
    > [!NOTE]  
    >  For more information about page checksums and torn page detection, see the PAGE_VERIFY option of the ALTER DATABASE statement. For more information, see [ALTER DATABASE SET Options (Transact-SQL)](assetId:///f76fbd84-df59-4404-806b-8ecb4497c9cc).  
  
2.  Regardless of whether page checksums are present, BACKUP generates a separate backup checksum for the backup streams. Restore operations can optionally use the backup checksum to validate that the backup is not corrupted. The backup checksum is stored on the backup media, not on the database pages. The backup checksum can optionally be used at restore time.  
  
3.  The backup set is flagged as containing backup checksums (in the **has_backup_checksums** column of **msdb..backupset)**. For more information, see [backupset (Transact-SQL)](assetId:///6ff79bbf-4acf-4f75-926f-38637ca8a943).  
  
 During a restore operation, if backup checksums are present on the backup media, by default, both the RESTORE and RESTORE VERIFYONLY statements verify the backup checksums and page checksums. If there is no backup checksum, either restore operation proceeds without any verification; this is because without a backup checksum, restore cannot reliably verify page checksums.  
  
## Response to Page Checksum Errors During a Backup or Restore Operation  
 By default, after encountering a page checksum error, a BACKUP or RESTORE operation fails and a RESTORE VERIFYONLY operation continues. However, you can control whether a given operation fails on encountering an error or continues as best it can.  
  
 If a BACKUP operation continues after encountering errors, the operation performs the following steps:  
  
1.  Flags the backup set on the backup media as containing errors and tracks the page in the **suspect_pages** table in the **msdb** database. For more information, see [suspect_pages (Transact-SQL)](assetId:///119c8d62-eea8-44fb-bf72-de469c838c50).  
  
2.  Logs the error in the SQL Server error log.  
  
3.  Marks the backup set as containing this type of error (in the **is_damaged** column of **msdb.backupset)**. For more information, see [backupset (Transact-SQL)](assetId:///6ff79bbf-4acf-4f75-926f-38637ca8a943).  
  
4.  Issues a message that the backup was successfully generated, but contains page errors.  
  
##  <a name="RelatedTasks"></a> Related Tasks  
 **To enable or disable backup checksums**  
  
-   [Enable or Disable Backup Checksums During Backup or Restore (SQL Server)](../../Topics/TopicNameNotContainA/Enable-or-Disable-Backup-Checksums-During-Backup-or-Restore--SQL-Server-.md)  
  
 **To control the response to a error during a backup operation**  
  
-   [Specify Whether a Backup or Restore Operation Continues or Stops After Encountering an Error (SQL Server)](../../Topics/TopicNameContainA/Specify-Whether-a-Backup-or-Restore-Operation-Continues-or-Stops-After-Encountering-an-Error--SQL-Server-.md)  
  
## See Also  
 [ALTER DATABASE (Transact-SQL)](assetId:///15f8affd-8f39-4021-b092-0379fc6983da)   
 [BACKUP (Transact-SQL)](assetId:///89a4658a-62f1-4289-8982-f072229720a1)   
 [backupset (Transact-SQL)](assetId:///6ff79bbf-4acf-4f75-926f-38637ca8a943)   
 [Mirrored Backup Media Sets (SQL Server)](../../Topics/TopicNameNotContainA/Mirrored-Backup-Media-Sets--SQL-Server-.md)   
 [RESTORE (Transact-SQL)](assetId:///877ecd57-3f2e-4237-890a-08f16e944ef1)   
 [RESTORE VERIFYONLY (Transact-SQL)](assetId:///cba3b6a0-b48e-4c94-812b-5b3cbb408bd6)