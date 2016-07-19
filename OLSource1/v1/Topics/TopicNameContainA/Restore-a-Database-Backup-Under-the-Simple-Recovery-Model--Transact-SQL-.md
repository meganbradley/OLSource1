---
title: Restore a Database Backup Under the Simple Recovery Model (Transact-SQL)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a928fa36-e285-476f-9a7b-6840a8bb7283
manager: jhubbard
---
# Restore a Database Backup Under the Simple Recovery Model (Transact-SQL)
This topic explains how to restore a full database backup.  
  
> [!IMPORTANT]  
>  The system administrator restoring the full database backup must be the only person currently using the database to be restored.  
  
## Prerequisites and Recommendations  
  
-   To restore a database that is encrypted, you must have access to the certificate or asymmetric key that was used to encrypt the database. Without the certificate or asymmetric key, the database cannot be restored. As a result, the certificate that is used to encrypt the database encryption key must be retained as long as the backup is needed. For more information, see [SQL Server Certificates and Asymmetric Keys](../../Topics/TopicNameNotContainA/SQL-Server-Certificates-and-Asymmetric-Keys.md).  
  
-   For security purposes, we recommend that you do not attach or restore databases from unknown or untrusted sources. Such databases could contain malicious code that might execute unintended [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] code or cause errors by modifying the schema or the physical database structure. Before you use a database from an unknown or untrusted source, run [DBCC CHECKDB](assetId:///2c506167-0b69-49f7-9282-241e411910df) on the database on a nonproduction server and also examine the code, such as stored procedures or other user-defined code, in the database.  
  
## Database Compatibility Level After Upgrade  
 The compatibility levels of the **tempdb**, **model**, **msdb** and **Resource** databases are set to the compatibility level of [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] after upgrade. The **master** system database retains the compatibility level it had before upgrade, unless that level was less than 100. If the compatibility level of **master** was less than 100 before upgrade, it is set to 100 after upgrade.  
  
 If the compatibility level of a user database was 100 or higher before upgrade, it remains the same after upgrade. If the compatibility level was 90 before upgrade, in the upgraded database, the compatibility level is set to 100, which is the lowest supported compatibility level in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)].  
  
> [!NOTE]  
>  New user databases will inherit the compatibility level of the **model** database.  
  
## Procedures  
  
#### To restore a full database backup  
  
1.  Execute the RESTORE DATABASE statement to restore the full database backup, specifying:  
  
    -   The name of the database to restore.  
  
    -   The backup device from where the full database backup is restored.  
  
    -   The NORECOVERY clause if you have a transaction log or differential database backup to apply after restoring the full database backup.  
  
    > [!IMPORTANT]  
    >  To restore a database that is encrypted, you must have access to the certificate or asymmetric key that was used to encrypt the database. Without the certificate or asymmetric key, the database cannot be restored. As a result, the certificate that is used to encrypt the database encryption key must be retained as long as the backup is needed. For more information, see [SQL Server Certificates and Asymmetric Keys](../../Topics/TopicNameNotContainA/SQL-Server-Certificates-and-Asymmetric-Keys.md).  
  
2.  Optionally, specify:  
  
    -   The FILE clause to identify the backup set on the backup device to restore.  
  
> [!NOTE]  
>  If you restore an earlier version database to [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)], the database is automatically upgraded. Typically, the database becomes available immediately. However, if a [!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)] database has full-text indexes, the upgrade process either imports, resets, or rebuilds them, depending on the setting of the  **upgrade_option** server property. If the upgrade option is set to import (**upgrade_option** = 2) or rebuild (**upgrade_option** = 0), the full-text indexes will be unavailable during the upgrade. Depending the amount of data being indexed, importing can take several hours, and rebuilding can take up to ten times longer. Note also that when the upgrade option is set to import, the associated full-text indexes are rebuilt if a full-text catalog is not available. To change the setting of the **upgrade_option** server property, use [sp_fulltext_service](assetId:///17a91433-f9b6-4a40-88c4-8c704ec2de9f).  
  
## Example  
  
### Description  
 This example restores the [!INCLUDE[ssSampleDBobject](../../Topics/TopicNameContainA/includes/ssSampleDBobject_md.md)] full database backup from tape.  
  
### Example  
  
```  
USE master;  
GO  
RESTORE DATABASE AdventureWorks2012  
   FROM TAPE = '\\.\Tape0';  
GO  
```  
  
## See Also  
 [Complete Database Restores (Full Recovery Model)](../../Topics/TopicNameNotContainA/Complete-Database-Restores--Full-Recovery-Model-.md)   
 [Complete Database Restores (Simple Recovery Model)](../../Topics/TopicNameNotContainA/Complete-Database-Restores--Simple-Recovery-Model-.md)   
 [Full Database Backups (SQL Server)](../../Topics/TopicNameNotContainA/Full-Database-Backups--SQL-Server-.md)   
 [RESTORE](assetId:///877ecd57-3f2e-4237-890a-08f16e944ef1)   
 [Backup History and Header Information (SQL Server)](../../Topics/TopicNameNotContainA/Backup-History-and-Header-Information--SQL-Server-.md)   
 [Rebuild System Databases](../../Topics/TopicNameNotContainA/Rebuild-System-Databases.md)