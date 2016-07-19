---
title: Uninstall and Remove Master Data Services
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: efc2431c-588b-42e7-b23b-c875145a33f6
manager: jhubbard
---
# Uninstall and Remove Master Data Services
To uninstall the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] feature from an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], follow the steps in [Uninstall an Existing Instance of SQL Server (Setup)](../../Topics/TopicNameNotContainA/Uninstall-an-Existing-Instance-of-SQL-Server--Setup-.md) and specify [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] as a feature to remove on the **Select Features** page. The uninstall process removes [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] folders and files, and uninstalls [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)] from the local computer.  
  
 To prevent data loss and avoid affecting other computers in the system, some items are not removed or changed by the uninstall process. Review the following table to determine whether to leave or remove items.  
  
|Item|Description|  
|----------|-----------------|  
|Folders and files|The uninstall process removes most folders and files from the installation path.<br /><br /> The uninstall process does not remove the Master Data Services and MDSTempDir folders from the installation location. After the uninstall process is complete, you can manually delete these folders from the file system. For more information, see [Folder and File Permissions (Master Data Services)](../../Topics/TopicNameNotContainA/Folder-and-File-Permissions--Master-Data-Services-.md).|  
|[!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] assemblies|The uninstall process removes [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] assemblies from the Global Assembly Cache (GAC).|  
|Database|The uninstall process does not affect the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database. The database remains intact in the instance of [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] so that you do not lose any data, including master data, model objects, user and group permissions, business rules, and so on.<br /><br /> If you do not need the database, and do not anticipate connecting it to another [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] web site or application in the future, you might want to delete the database from the instance of [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] that hosts it. For more information, see [Delete a Database](../../Topics/TopicNameContainA/Delete-a-Database.md).|  
|[!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] and Web.config|The uninstall process removes the WebApplication folder from the file system. The WebApplication folder contains the web application files and Web.config file for [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)].<br /><br /> **\*\* Important \*\*** Before you uninstall, you might want to copy the Web.config file to another location to preserve any custom settings or other information in the file. After the uninstall process completes, the Web.config file is not recoverable.|  
|Internet Information Services (IIS) items|The uninstall process does not affect any application pools, web sites, or web applications in IIS on the local computer. Because the uninstall process removes the WebApplication folder and Web.config file for [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], any [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] web applications that require those files will no longer serve content. If users try to access the web application, they will receive HTTP Error 500.19-Internal Server Error: "The requested page cannot be accessed because the related configuration data for the page is invalid."<br /><br /> If you no longer require the web site or application, and the application pool serving your site or application, you can use an IIS tool to delete them. For more information, see [IIS 7 Operations Guide](http://go.microsoft.com/fwlink/?LinkId=184885) on [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] TechNet.|  
|**MDS_ServiceAccounts** group|After the uninstall process is complete, the **MDS_ServiceAccounts** Windows group and any service accounts added to the group remain. If you no longer need the group and accounts, you can remove them.|  
|Registry|The uninstall process removes all [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] registry keys from the Windows registry.|  
  
## See Also  
 [Install Master Data Services](../../Topics/TopicNameNotContainA/Install-Master-Data-Services.md)