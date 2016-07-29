---
title: "Versions (Master Data Services)"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 752ec96d-53d7-4160-8ed2-92e0324645f3
caps.latest.revision: 10
manager: jhubbard
---
# Versions (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], you can create multiple versions of the master data within a model. Versions can be locked while you validate your data and committed after the data is validated. Committed versions form an auditable record of changes. Each version you create contains all members, attribute values, hierarchy members, hierarchy relationships, and collections for the model.  
  
## When to Use Versions  
 Use versions to:  
  
-   Maintain an auditable record of your master data as it changes over time.  
  
-   Prevent users from making changes while you ensure all data validates successfully against business rules.  
  
-   Lock down a model for use by subscribing systems.  
  
-   Test different hierarchies without implementing them right away.  
  
> [!NOTE]  
>  When you change the structure of your model, such as when you create a new entity or domain-based attribute, the change applies to all versions. If you view an earlier version of the model, the entity or attribute is displayed, but no data exists.  
  
## Version Flags  
 When a version is ready for users or for a subscribing system, you can set a flag to identify the version. You can move this flag from version to version as needed. Flags help users and subscribing systems identify which version of a model to use.  
  
## Workflow for Version Management  
 Use the following workflow for version management:  
  
1.  An initial version is created automatically when you create a model and populate the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database with your company's master data. Based on permissions, users can make changes to this version as needed.  
  
2.  When you want to commit a version of a model, lock the version so that only model administrators can update the data. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md). If notifications are configured, an email notification is sent to model administrators each time the version's status changes. For more information, see [Configure Email Notifications (Master Data Services)](../../Topics/TopicNameNotContainA/Configure-Email-Notifications--Master-Data-Services-.md).  
  
3.  Apply business rules to the locked version's data and review any validation issues. If necessary, you can fill in missing information or revert the transaction that caused the issue. You can also unlock the version for users to make changes.  
  
4.  When all the data passes validation, commit the version and flag it for use by subscribing systems. Changes cannot be made to a committed version.  
  
5.  Copy the committed version and notify users that they can begin working in a new version of the model.  
  
## Sequential or Simultaneous Versions  
 You can create sequential or simultaneous versions of your model.  
  
-   **Sequential versions.** Each time you commit a version, create a new copy and give the version the next sequential number. For example, you can copy **Version 7** of your model and name the copy **Version 8**.  
  
-   **Simultaneous versions.** Create simultaneous versions of your model when you want to work on two or more versions of your data at once. This is useful when your company has reorganizations or mergers that coincide with the normal course of business and you want to determine how the new master data might fit into your existing structures.  
  
    > [!NOTE]  
    >  A setting in [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)] determines whether or not you can copy all versions or only those that are committed. To create simultaneous versions you must configure [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] to allow you to copy all versions. This setting is also available in the System Settings table. For more information, see [System Settings (Master Data Services)](../../Topics/TopicNameNotContainA/System-Settings--Master-Data-Services-.md).  
  
## Related Tasks  
  
|Task Description|Topic|  
|----------------------|-----------|  
|Change the name of an existing version.|[Change a Version Name (Master Data Services)](../../Topics/TopicNameContainA/Change-a-Version-Name--Master-Data-Services-.md)|  
|Lock a version so only administrators can edit its data.|[Lock a Version (Master Data Services)](../../Topics/TopicNameContainA/Lock-a-Version--Master-Data-Services-.md)|  
|Unlock a version so users can edit its data.|[Unlock a Version (Master Data Services)](../../Topics/TopicNameContainA/Unlock-a-Version--Master-Data-Services-.md)|  
|Commit a version after all data is validated.|[Commit a Version (Master Data Services)](../../Topics/TopicNameContainA/Commit-a-Version--Master-Data-Services-.md)|  
|Create a new flag to mark a version.|[Create a Version Flag (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Version-Flag--Master-Data-Services-.md)|  
|Change the name of an existing version flag.|[Change a Version Flag Name (Master Data Services)](../../Topics/TopicNameContainA/Change-a-Version-Flag-Name--Master-Data-Services-.md)|  
|Assign an existing flag to a version.|[Assign a Flag to a Version (Master Data Services)](../../Topics/TopicNameContainA/Assign-a-Flag-to-a-Version--Master-Data-Services-.md)|  
|Create a new copy of an existing version|[Copy a Version (Master Data Services)](../../Topics/TopicNameContainA/Copy-a-Version--Master-Data-Services-.md)|  
|Delete an existing version.|[Delete a Version (Master Data Services)](../../Topics/TopicNameContainA/Delete-a-Version--Master-Data-Services-.md)|  
|Purge soft-deleted members from a version|[Purge Version Members (Master Data Services)](../../Topics/TopicNameNotContainA/Purge-Version-Members--Master-Data-Services-.md)|  
  
## Related Content  
  
-   [Reverse a Transaction (Master Data Services)](../../Topics/TopicNameContainA/Reverse-a-Transaction--Master-Data-Services-.md)  
  
-   [Notifications (Master Data Services)](../../Topics/TopicNameNotContainA/Notifications--Master-Data-Services-.md)  
  
-   [Business Rules (Master Data Services)](../../Topics/TopicNameNotContainA/Business-Rules--Master-Data-Services-.md)