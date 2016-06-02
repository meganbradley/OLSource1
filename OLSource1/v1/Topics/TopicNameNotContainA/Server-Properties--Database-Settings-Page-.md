---
title: Server Properties (Database Settings Page)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1cebdbd3-cbfd-4a02-bba6-a5addf4e3ada
---
# Server Properties (Database Settings Page)
  Use this page to view or modify your database settings.  
  
## Options  
 **Default index fill factor**  
 Specifies how full [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] should make each page when it creates a new index using existing data. The fill factor affects performance because [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] must take time to split pages when they fill up.  
  
 The default value is 0; valid values range from 0 through 100. A fill factor of 0 or 100 creates clustered indexes with full data pages and nonclustered indexes with full leaf pages, but it leaves some space within the upper level of the index tree. Fill factor values 0 and 100 are identical in all respects.  
  
 Small fill factor values cause [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] to create indexes with pages that are not full. Each index takes more storage space, but there is more room for subsequent insertions without requiring page splits.  
  
 **Wait indefinitely**  
 Specifies that [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] will never time out while waiting for a new backup tape.  
  
 **Try once**  
 Specifies that [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] will time out if a backup tape is not available when needed.  
  
 **Try for minute\(s\)**  
 Specifies that [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] will time out if a backup tape is not available within the period specified.  
  
 **Default backup media retention \(in days\)**  
 Provides a system\-wide default for the length of time to retain each backup medium after it has been used for a database or transaction log backup. This option helps protect backups from being overwritten until the specified number of days has elapsed.  
  
 **Compress backup**  
 In [!INCLUDE[ssEnterpriseEd10](../../Token\Other/ssEnterpriseEd10_md.md)] \(or later versions\), indicates the current setting of the **backup compression default** option. This option determines the server\-level default for compressing backups, as follows:  
  
-   If the **Compress backup** box is blank, new backups are uncompressed by default.  
  
-   If the **Compress backup** box is checked, new backups are compressed by default.  
  
    > [!IMPORTANT]  
    >  By default, compression significantly increases CPU usage, and the additional CPU consumed by the compression process might adversely affect concurrent operations. Therefore, you might want to create low\-priority compressed backups in a session whose CPU usage is limited by [Resource Governor](../../Topics\TopicNameNotContainA/Resource-Governor.md). For more information, see [Use Resource Governor to Limit CPU Usage by Backup Compression &#40;Transact-SQL&#41;](../Topic/Use%20Resource%20Governor%20to%20Limit%20CPU%20Usage%20by%20Backup%20Compression%20\(Transact-SQL\).md).  
  
 If you are a member of the **sysadmin** or **serveradmin** fixed server role, you can change the setting by clicking the **Compress backup** box.  
  
 For more information, see [View or Configure the backup compression default Server Configuration Option](../../Topics\TopicNameNotContainA/View-or-Configure-the-backup-compression-default-Server-Configuration-Option.md) and [Backup Compression &#40;SQL Server&#41;](../Topic/Backup%20Compression%20\(SQL%20Server\).md).  
  
 **Recovery interval \(minutes\)**  
 Sets the maximum number of minutes per database to recover databases. The default is 0, indicating automatic configuration by [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. In practice, this means a recovery time of less than one minute and a checkpoint approximately every one minute for active databases. For more information, see [Configure the recovery interval Server Configuration Option](../../Topics\TopicNameNotContainA/Configure-the-recovery-interval-Server-Configuration-Option.md).  
  
 **Data**  
 Specifies the default location for data files. Click the browse button to navigate to a new default location. Does not take effect until [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] is restarted.  
  
 **Log**  
 Specifies the default location for log files. Click the browse button to navigate to a new default location. Does not take effect until [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] is restarted.  
  
 **Configured Values**  
 Displays the configured values for the options on this pane. If you change these values, click **Running Values** to see whether the changes have taken effect. If they have not, the instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] must be restated first.  
  
 **Running Values**  
 View the currently running values for the options on this pane. These values are read\-only.  
  
## See Also  
 [Server Configuration Options &#40;SQL Server&#41;](../Topic/Server%20Configuration%20Options%20\(SQL%20Server\).md)   
 [Specify Fill Factor for an Index](../../Topics\TopicNameNotContainA/Specify-Fill-Factor-for-an-Index.md)  
  
  