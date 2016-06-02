---
title: Configure Advanced Options for SQL Server Managed Backup to Microsoft Azure
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-backup-restore
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ffd28159-8de8-4d40-87da-1586bfef3315
---
# Configure Advanced Options for SQL Server Managed Backup to Microsoft Azure
  The following tutorial describes how to set advanced options for [!INCLUDE[ss_smartbackup](../../Token\Other/ss_smartbackup_md.md)]. These procedures are only necessary if you require the features they offer. Otherwise, you can enable [!INCLUDE[ss_smartbackup](../../Token\Other/ss_smartbackup_md.md)] and depend on the default behavior.  
  
 In each scenario, the backup is specified using the `database_name` parameter. When `database_name` is NUL or \*, then the changes affect the default settings at an Instance level. Instance level settings also affect new databases created after the change.  
  
 Once you have specified these settings, you can then enable managed backup for the database or instance using the system stored procedure [managed_backup.sp_backup_config_basic &#40;Transact-SQL&#41;](../Topic/managed_backup.sp_backup_config_basic%20\(Transact-SQL\).md). For more information, see [Enable SQL Server Managed Backup to Microsoft Azure](../../Topics\TopicNameNotContainA/Enable-SQL-Server-Managed-Backup-to-Microsoft-Azure.md).  
  
> [!WARNING]  
>  You should always configure the advanced options and custom scheduling options before enabling [!INCLUDE[ss_smartbackup](../../Token\Other/ss_smartbackup_md.md)] with [managed_backup.sp_backup_config_basic &#40;Transact-SQL&#41;](../Topic/managed_backup.sp_backup_config_basic%20\(Transact-SQL\).md). Otherwise, it is possible that unwanted backup operations will occur during the window of time between enabling [!INCLUDE[ss_smartbackup](../../Token\Other/ss_smartbackup_md.md)] and configuring these settings.  
  
## Configure Encryption  
 The following steps describe how to specify encryption settings using the stored procedure  [managed_backup.sp_backup_config_advanced &#40;Transact-SQL&#41;](../Topic/managed_backup.sp_backup_config_advanced%20\(Transact-SQL\).md).  
  
1.  **Determine the Encryption Algorithm:** First determine the name of the encryption algorithm to use. Select from one of the following algorithms.  
  
    -   AES\_128  
  
    -   AES\_192  
  
    -   AES\_256  
  
    -   TRIPLE\_DES\_3KEY  
  
    -   NO\_ENCRYPTION  
  
2.  **Create a Database Master Key:** Choose a password for encrypting the copy of the master key that will be stored in the database.  
  
    ```  
    -- Creates a database master key.  
    -- The key is encrypted using the password "<master key password>"  
    USE Master;  
    GO  
       CREATE MASTER KEY ENCRYPTION BY PASSWORD = '<master key password>';  
    GO  
    ```  
  
3.  **Create a Backup Certificate or Asymmetric Key:** You can use either a certificate or an asymmetric key for use with the encryption. The following example creates a backup certificate to use for the encryption.  
  
    ```tsql  
    USE Master;  
    GO  
       CREATE CERTIFICATE MyTestDBBackupEncryptCert  
          WITH SUBJECT = 'MyTestDBBackupEncryptCert';  
    GO  
    ```  
  
4.  **Set Managed Backup Encryption:** Call the **managed\_backup.sp\_backup\_config\_advanced** stored procedure with the corresponding values. For example, the following example configures the `MyDB` database for encryption using a certificate named `MyTestDBBackupEncryptCert` and the `AES_128` encryption algorithm.  
  
    ```  
    USE msdb;  
    GO  
       EXEC managed_backup.sp_backup_config_advanced  
          @database_name = 'MyDB'                
          ,@encryption_algorithm ='AES_128'  
          ,@encryptor_type = 'CERTIFICATE'  
          ,@encryptor_name = 'MyTestDBBackupEncryptCert';  
    GO  
    ```  
  
    > [!WARNING]  
    >  If `@database_name` is NULL in the previous example, the settings apply to the SQL Server Instance.  
  
## Configure a Custom Backup Schedule  
 The following steps describe how to set a custom schedule with the stored procedure [managed_backup.sp_backup_config_schedule &#40;Transact-SQL&#41;](../Topic/managed_backup.sp_backup_config_schedule%20\(Transact-SQL\).md).  
  
1.  **Determine the frequency for full backups:** Determine how often to take full backups of the database. You can choose between 'Daily' and 'Weekly' full backups.  
  
2.  **Determine the frequency for log backups:** Determine how often to take a log backup. This value is in minutes or hours.  
  
3.  **Determine the day of the week for weekly backups:** If the backup is weekly, choose a day of the week for the full backup.  
  
4.  **Determine the start time for the bakup:** Using 24\-hour notation, choose a time for the backup to start.  
  
5.  **Determine the length of time to allow for the backup:** This specifies the amount of time that a backup has to complete.  
  
6.  **Set the custom backup schedule:** The following stored procedure defines a custom schedule for the `MyDB` database. Full backups are taken weekly on `Monday` at `17:30`. Log backups are taken every `5` minutes. Backups have two hours to complete.  
  
    ```  
    USE msdb;  
    GO  
    EXEC managed_backup.sp_backup_config_schedule   
         @database_name =  'MyDB'  
        ,@scheduling_option = 'Custom'  
        ,@full_backup_freq_type = 'Weekly'  
        ,@days_of_week = 'Monday'  
        ,@backup_begin_time =  '17:30'  
        ,@backup_duration = '02:00'  
        ,@log_backup_freq = '00:05'  
    GO  
  
    ```  
  
## Next Steps  
 After configuring advanced options and custom schedules, you must enable [!INCLUDE[ss_smartbackup](../../Token\Other/ss_smartbackup_md.md)] on the target database or SQL Server instance. For more information, see [Enable SQL Server Managed Backup to Microsoft Azure](../../Topics\TopicNameNotContainA/Enable-SQL-Server-Managed-Backup-to-Microsoft-Azure.md).  
  
## See Also  
 [SQL Server Managed Backup to Microsoft Azure](../../Topics\TopicNameNotContainA/SQL-Server-Managed-Backup-to-Microsoft-Azure.md)  
  
  