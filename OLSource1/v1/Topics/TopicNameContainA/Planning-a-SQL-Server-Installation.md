---
title: Planning a SQL Server Installation
ms.custom: 
  - SQL2016_New_Updated
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: get-started-article
ms.assetid: b1d56f2f-603f-48f2-b902-c715f14a6db9
manager: jhubbard
---
# Planning a SQL Server Installation
To install [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], follow these steps:  
  
-   Review installation requirements, system configuration checks, and security considerations for a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] installation.  
  
-   Run [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Setup to install or upgrade to a later version. Before upgrading, review [Upgrade to SQL Server 2016](../../Topics/TopicNameNotContainA/Upgrade-to-SQL-Server-2016.md).  
  
-   Use [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] utilities to configure [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
 Regardless of the installation method, you are required to confirm acceptance of the software license terms as an individual or on behalf of an entity, unless your use of the software is governed by a separate agreement such as a [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] volume licensing agreement or a third-party agreement with an ISV or OEM.  
  
 The license terms are displayed for review and acceptance in the Setup user interface. Unattended installations (using the /Q or /QS parameters) must include the /IAcceptSQLServerLicenseTerms parameter. You can review the license terms separately at [Microsoft Software License Terms](http://go.microsoft.com/fwlink/?LinkID=148209).  
  
> [!NOTE]  
>  Depending on how you received the software (for example, through [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] volume licensing), your use of the software may be subject to additional terms and conditions.  
  
## In This Section  
 [What's New in SQL Server Installation](assetId:///c8642a96-3a09-4ec7-a9c3-c539147e6330)  
 This topic describes the details about the new or improved features of installation in this version of [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)].  
  
 [Hardware and Software Requirements for Installing SQL Server 2016](../../Topics/TopicNameNotContainA/Hardware-and-Software-Requirements-for-Installing-SQL-Server-2016.md)  
 This topic lists the minimum hardware and software requirements to install and run an instance of [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)].  
  
 [Security Considerations for a SQL Server Installation](../../Topics/TopicNameContainA/Security-Considerations-for-a-SQL-Server-Installation.md)  
 This topic describes some security best practices that you should consider before you install [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] and after you install [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
 [Configure Windows Service Accounts and Permissions](../../Topics/TopicNameNotContainA/Configure-Windows-Service-Accounts-and-Permissions.md)  
 This topic describes the default configuration of services in this release of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], and configuration options for [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] services that you can set during and after [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] installation.  
  
 [Network Protocols and Network Libraries](../../Topics/TopicNameNotContainA/Network-Protocols-and-Network-Libraries.md)  
 This topic describes the default configuration of network protocols in this release of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], and the configuration options available.  
  
 [Work with Multiple Versions and Instances of SQL Server](../../Topics/TopicNameNotContainA/Work-with-Multiple-Versions-and-Instances-of-SQL-Server.md)  
 This topic describes the considerations for installing multiple versions and instances of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
 [Local Language Versions in SQL Server](../../Topics/TopicNameNotContainA/Local-Language-Versions-in-SQL-Server.md)  
 This topic describes about the localized versions of [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)].  
  
## Related Sections  
 [Install SQL Server 2016](../../Topics/TopicNameNotContainA/Install-SQL-Server-2016.md)  
 This section provides an overview of different installation options we have for installing [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)].  
  
 [Install SQL Server 2016 Business Intelligence Features](../../Topics/TopicNameNotContainA/Install-SQL-Server-2016-Business-Intelligence-Features.md)  
 This section of the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Setup documentation explains how to install [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] features that are part of the Microsoft BI platform.  
  
 [Upgrade to SQL Server 2016](../../Topics/TopicNameNotContainA/Upgrade-to-SQL-Server-2016.md)  
 The section provides an overview of upgrading instances of previous [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] versions to [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)].  
  
 [Uninstall SQL Server 2016](../../Topics/TopicNameNotContainA/Uninstall-SQL-Server-2016.md)  
 Refer this section to uninstall an existing instance of [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] completely, and prepare the system so that you can reinstall [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
 [SQL Server Failover Cluster Installation](../../Topics/TopicNameNotContainA/SQL-Server-Failover-Cluster-Installation.md)  
 This section of the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Setup documentation explains how to install, and configure [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] failover cluster.  
  
## See Also  
 [Install SQL Server 2016 from the Command Prompt](../../Topics/TopicNameNotContainA/Install-SQL-Server-2016-from-the-Command-Prompt.md)   
 [High Availability Solutions (SQL Server)](../../Topics/TopicNameNotContainA/High-Availability-Solutions--SQL-Server-.md)   
 [Before Installing Failover Clustering](../../Topics/TopicNameNotContainA/Before-Installing-Failover-Clustering.md)   
 [Upgrade to SQL Server 2016 Using the Installation Wizard (Setup)](../../Topics/TopicNameNotContainA/Upgrade-to-SQL-Server-2016-Using-the-Installation-Wizard--Setup-.md)