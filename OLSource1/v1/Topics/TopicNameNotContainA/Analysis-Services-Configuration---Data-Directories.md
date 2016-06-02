---
title: Analysis Services Configuration - Data Directories
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ef732855-b7af-4f40-a619-5573c1c354bb
---
# Analysis Services Configuration - Data Directories
  The default directories in the following table are user\-configurable during [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup. Permission to access these files is granted to local administrators and to members of the SQLServerMSASUser$\<instance\> security group that is created and provisioned during Setup.  
  
## UIElement List  
  
|Description|Default directory|Recommendations|  
|-----------------|-----------------------|---------------------|  
|Data root directory|C:\\Program Files\\Microsoft SQL Server\\MSAS12.\<InstanceID\>\\OLAP\\Data\\|Ensure that the \\Program files\\Microsoft SQL Server\\ folder is protected with limited permissions. [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] performance depends, in many configurations, on the performance of the storage on which the data directory is located. Place this directory on the highest performing storage that is attached to the system. For failover cluster installations, ensure that data directories are placed on the shared disk.|  
|Log file directory|C:\\Program Files\\Microsoft SQL Server\\MSAS12.\<InstanceID\>\\OLAP\\Log\\|This is the directory for [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] log files, and it includes the FlightRecorder log. If you increase the flight recorder duration, ensure that the log directory has adequate space.|  
|Temp directory|C:\\Program Files\\Microsoft SQL Server\\MSAS12.\<InstanceID\>\\OLAP\\Temp\\|Place the Temp directory on the high performance storage subsystem.|  
|Backup directory|C:\\Program Files\\Microsoft SQL Server\\MSAS12.\<InstanceID\>\\OLAP\\Backup\\|This is the directory for [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] default backup files. For [!INCLUDE[ssGemini](../../Token\Other/ssGemini_md.md)] for SharePoint installations, it also where the [!INCLUDE[ssGemini](../../Token\Other/ssGemini_md.md)] System Services caches [!INCLUDE[ssGemini](../../Token\Other/ssGemini_md.md)] data files.<br /><br /> Ensure appropriate permissions are set to prevent data loss, and that the user group for the [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] service has adequate permissions to write to the backup directory. Using a mapped drive for backup directories is not supported.|  
  
## Notes  
  
-   [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] instances that are deployed on a SharePoint farm store application files, data files, and properties in content databases and service application databases.  
  
-   When you add features to an existing installation, you cannot change the location of a previously installed feature, nor can you specify the location for a new feature.  
  
-   If you specify non\-default installation directories, ensure that the installation folders are unique to this instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. None of the directories in this dialog box should be shared with directories from other instances of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. The [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] and [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] components within an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] should also be installed to separate directories.  
  
-   Program files and data files cannot be installed in the following situations:  
  
    -   On a removable disk drive  
  
    -   On a file system that uses compression  
  
    -   To a directory where system files are located  
  
## See Also  
 [File Locations for Default and Named Instances of SQL Server](../../Topics\TopicNameNotContainA/File-Locations-for-Default-and-Named-Instances-of-SQL-Server.md)  
  
  