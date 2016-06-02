---
title: System Role Properties (Management Studio)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0210fc2a-74fb-41dd-8e39-4830047ec417
---
# System Role Properties (Management Studio)
  Use the System Roles page to view the system role definitions that are currently defined for the report server. A system role definition contains a named collection of tasks that are performed relative to the entire site, instead of an individual item. Role definitions are assigned to a user or groups to create a resulting role assignment. The tasks in the role definition specify what the user or group can do.  
  
 [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] has two predefined system role definitions: **System Administrator** and **System User**. You can modify these role definitions by changing the task list, or you can create a new system role that supports a different combination of tasks. Editing a role definition affects all role assignments that include the role definition.  
  
> [!NOTE]  
>  System role assignments are used only on a report server that runs in native mode. If the report server is configured for SharePoint integration, this page is not available.  
  
## Options  
 **Name**  
 Specifies the name of the system role definition.  
  
 **Description**  
 Shows a description of the system role definition. In [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssManStudio](../../Token\Other/ssManStudio_md.md)], this description is only visible in this page. Users who view this item through Report Manager may see this description when browsing the folder hierarchy.  
  
 **Task**  
 Lists all system\-level tasks that can be selected for this role definition. You can add or remove items from the predefined task list to define how users access a given item through this role. You cannot create new tasks, and you cannot modify existing tasks.  
  
 **Description**  
 Provides information about each task. You cannot modify task descriptions.  
  
## See Also  
 [Report Server in Management Studio F1 Help](../../Topics\TopicNameNotContainA/Report-Server-in-Management-Studio-F1-Help.md)   
 [System-Level Tasks](../../Topics\TopicNameNotContainA/System-Level-Tasks.md)   
 [Tasks and Permissions](../../Topics\TopicNameNotContainA/Tasks-and-Permissions.md)   
 [Predefined Roles](../../Topics\TopicNameNotContainA/Predefined-Roles.md)  
  
  