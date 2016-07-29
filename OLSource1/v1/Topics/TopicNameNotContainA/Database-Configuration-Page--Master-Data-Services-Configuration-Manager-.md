---
title: "Database Configuration Page (Master Data Services Configuration Manager)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dd72220e-a599-465d-8b84-9bb6a7433216
caps.latest.revision: 8
manager: jhubbard
---
# Database Configuration Page (Master Data Services Configuration Manager)
Use the **Database Configuration** page to edit system settings of a [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database. System settings affect all web applications and web services associated with the selected [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database. You must select or create a [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database before system settings are enabled and available for configuration.  
  
## Current Database  
 Select an existing [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database or create a new database for which to edit system settings. The new database will be selected after it is created.  
  
|Control Name|Description|  
|------------------|-----------------|  
|**SQL Server instance**|Displays the name of the selected [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance. This is blank until you connect to an instance, and then select or create a [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database.|  
|**Master Data Services database**|Displays the name of the selected [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database. This is blank until you connect to an instance, and then select or create a [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database.|  
|**Master Data Services database version**|The version of the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database schema.|  
|**Create Database**|Opens the **Create Database** wizard from which you connect to a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance and create a [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database for that instance.|  
|**Select Database**|Opens the **Connect to Database** dialog box from which you connect to a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance and select a [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database.|  
|**Upgrade Database**|Opens a wizard from which you can upgrade a specified [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database. This button is enabled only when the specified database requires upgrade.|  
|**Repair Database**|Click this button to ensure the MDS database is installed correctly. This can be useful if you backup and restore an MDS database to a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance that has never hosted an MDS database.|  
  
## System Settings  
 Edit system settings for all the web applications and web services associated with the selected [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database.  
  
 These settings are available in [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)] and are stored in the database in the System Settings table (mdm.tblSystemSetting). For a list of all settings, see [System Settings (Master Data Services)](../../Topics/TopicNameNotContainA/System-Settings--Master-Data-Services-.md).  
  
## See Also  
 [Get Started with Master Data Services (SQL Server 2016)](../../Topics/TopicNameNotContainA/Get-Started-with-Master-Data-Services--SQL-Server-2016-.md)   
 [Database Requirements (Master Data Services)](../../Topics/TopicNameNotContainA/Database-Requirements--Master-Data-Services-.md)