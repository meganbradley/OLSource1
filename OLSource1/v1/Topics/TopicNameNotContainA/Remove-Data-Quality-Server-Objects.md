---
title: "Remove Data Quality Server Objects"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1b7c6dbb-b40e-4822-9caa-608e1056af8e
caps.latest.revision: 15
manager: jhubbard
---
# Remove Data Quality Server Objects
Uninstalling [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] from an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], or completely removing an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that has [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] does not delete some [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] objects, including the DQS databases. This implies that you do not lose your DQS data if you uninstall [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] using the SQL Server setup. You must manually delete these [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] objects after the uninstall process is complete.  
  
> [!NOTE]  
>  -   Before uninstalling [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)], consider backing up all your existing knowledge bases by exporting it to a .dqsb file, and use the file later to import all the knowledge bases back to a new [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] installation. Exporting and importing of all DQS knowledge bases can only be done by running DQSInstaller.exe with appropriate command line parameters from the command prompt. For more information, see [Export and Import DQS Knowledge Bases Using DQSInstaller.exe](../../Topics/TopicNameNotContainA/Export-and-Import-DQS-Knowledge-Bases-Using-DQSInstaller.exe.md).  
> -   Before deleting the DQS databases, consider backing up the databases if you want to preserve it, and use it later for restoring the data. For information about doing so, see [Manage DQS Databases](../../Topics/TopicNameNotContainA/Manage-DQS-Databases.md).  
  
## Uninstall Data Quality Server from a SQL Server Instance  
 If you are just uninstalling [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] from an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], you must manually delete the following [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] objects from the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance after the [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] uninstall process is complete:  
  
-   DQS_MAIN, DQS_PROJECTS, and DQS_STAGING_DATA databases.  
  
-   \##MS_dqs_db_owner_login## and ##MS_dqs_service_login## logins.  
  
-   DQInitDQS_MAIN stored procedure from the master database.  
  
 You can delete these objects in SQL Server Management Studio by right-clicking the object, and clicking **Delete** in the shortcut menu.  
  
> [!IMPORTANT]  
>  If you just uninstall [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] from a SQL server instance using the `–uninstall` command line parameter from the command prompt, all the DQS objects are deleted as part of the uninstall process. You do not have to delete them manually after uninstalling [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)]. To uninstall [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] from command prompt, type the following command at the command prompt, and press ENTER:   
> `dqsinstaller.exe -uninstall`  
  
## Uninstall SQL Server Instance Containing Data Quality Server  
 If you are completely uninstalling the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance that has [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)], you must manually delete the DQS_MAIN, DQS_PROJECTS, and DQS_STAGING_DATA databases from your computer after the uninstall process is complete. For a default [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] installation, the DQS_MAIN, DQS_PROJECTS, and DQS_STAGING_DATA databases files are available at C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA.  
  
## See Also  
 [Uninstall an Existing Instance of SQL Server (Setup)](../../Topics/TopicNameNotContainA/Uninstall-an-Existing-Instance-of-SQL-Server--Setup-.md)   
 [Uninstall SQL Server 2016](../../Topics/TopicNameNotContainA/Uninstall-SQL-Server-2016.md)