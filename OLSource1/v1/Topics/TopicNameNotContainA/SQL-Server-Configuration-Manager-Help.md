---
title: SQL Server Configuration Manager Help
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6e909911-39a6-469b-b22a-3afdfd08a30b
manager: jhubbard
---
# SQL Server Configuration Manager Help
Use [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager to configure [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] services and configure network connectivity. To create or manage database objects, configure security, and write [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] queries, use [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]. For more information about [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], see [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Books Online.  
  
 This section contains the F1 Help topics for the dialogs in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager.  
  
> [!NOTE]  
>  [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager cannot configure versions of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] earlier than [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)][!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)].  
  
## Services  
 [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager manages services that are related to [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. Although many of these tasks can be accomplished using the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Windows Services dialog, is important to note that [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager performs additional operations on the services it manages, such as applying the correct permissions when the service account is changed. Using the normal Windows Services dialog to configure any of the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] services might cause the service to malfunction.  
  
 Use [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager for the following tasks for services:  
  
-   Start, stop, and pause services  
  
-   Configure services to start automatically or manually, disable the services, or change other service settings  
  
-   Change the passwords for the accounts used by the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] services  
  
-   Start [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] using trace flags (command line parameters)  
  
-   View the properties of services  
  
## SQL Server Network Configuration  
 Use [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager for the following tasks related to the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] services on this computer:  
  
-   Enable or disable a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] network protocol  
  
-   Configure a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] network protocol  
  
> [!NOTE]  
>  For a short tutorial about how to configure protocols and connect to the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)], see [Tutorial: Getting Started with the Database Engine](assetId:///655e709b-346b-469c-bddc-a5a0238d07e0).  
  
## SQL Server Native Client Configuration  
 [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] clients connect to [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] by using the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Native Client network library. Use [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Configuration Manager for the following tasks related to client applications on this computer:  
  
-   For [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] client applications on this computer, specify the protocol order, when connecting to instances of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
-   Configure client connection protocols.  
  
-   For [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] client applications, create aliases for instances of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], so that clients can connect using a custom connection string.  
  
 For more information about each of these tasks, see F1 help for each task.  
  
#### To open SQL Server Configuration Manager  
  
-   On the **Start** menu, point to **All Programs**, point to **Microsoft SQL Server** (version), point to **Configuration Tools**, and then click **SQL Server Configuration Manager**.  
  
## See Also  
 [SQL Server Services](../../Topics/TopicNameNotContainA/SQL-Server-Services.md)   
 [SQL Server Network Configuration](../../Topics/TopicNameNotContainA/SQL-Server-Network-Configuration.md)   
 [SQL Native Client 11.0 Configuration](../../Topics/TopicNameNotContainA/SQL-Native-Client-11.0-Configuration.md)   
 [Choosing a Network Protocol](assetId:///6565fb7d-b076-4447-be90-e10d0dec359a)