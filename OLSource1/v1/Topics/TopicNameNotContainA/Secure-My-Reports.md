---
title: Secure My Reports
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3b23a382-13b8-4196-9a93-7fe62d03a63c
---
# Secure My Reports
  The My Reports feature provides a user\-managed workspace for working with reports. In order to serve its intended purpose, the My Reports folder requires less restrictive permissions than other folders that are available for general use. Users who have permissions to only view and run reports in other folders might require an expanded set of permissions to manage their My Reports folders and content that they own. [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] provides a specialized role assignment and role definition for this purpose.  
  
> [!NOTE]  
>  My Reports is available only in Report Manager. It is not available in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)][!INCLUDE[ssManStudio](../../Token\Other/ssManStudio_md.md)].  
  
## Role Assignment for My Reports  
 The role assignment for My Reports has preset elements and is automatically created for each user who activates a My Reports folder. Having the report server automatically assign security is especially useful for organizations that use My Reports widely because administrators do not have to enable access for each My Reports user.  
  
 A **My Reports** role assignment consists of the following elements:  
  
-   The user's My Reports folder, which is located in Users Folders\\*\<username\>*\\My Reports folder.  
  
-   The user account, which is determined when the My Reports folder is activated. A folder is activated when a user clicks a My Reports folder in Report Manager or when publishing a report to a My Reports folder from Report Designer. This folder is also activated when a user requests properties on the My Reports link.  
  
-   The predefined role definition for My Reports.  
  
## Role Definition for My Reports  
 The **My Reports** role definition includes tasks that support content management of a My Reports folder. The **My Reports** role is intended to be a single\-purpose role. Although you can choose it for any item\-level security policy, you should avoid doing so to minimize the chance that you will modify it to accommodate other folder requirements. Reserving the **My Reports** role for the My Reports feature can help you maintain a consistent experience for users.  
  
 By default, only report server administrators modify the **My Reports** role. You can customize the **My Reports** role by changing the tasks it contains. You can also substitute a different role.  
  
## Denying Access to My Reports  
 You can prevent users from accessing My Reports by:  
  
-   Disabling My Reports on the Site Settings page. For more information, see [Enable and Disable My Reports](../../Topics\TopicNameNotContainA/Enable-and-Disable-My-Reports.md).  
  
-   Removing all tasks from the **My Reports** role.  
  
 When you disable My Reports, the link to a My Reports folder is removed from Report Manager. The underlying folder structure that supports My Reports \(that is, the Users Folders folder and subfolders\) is still available and can be accessed if a user knows the folder path. Removing tasks from **My Reports** role ensures that access is prevented.  
  
## See Also  
 [Secure Reports and Resources](../../Topics\TopicNameNotContainA/Secure-Reports-and-Resources.md)   
 [Secure Folders](../../Topics\TopicNameNotContainA/Secure-Folders.md)   
 [Granting Permissions on a Native Mode Report Server](../../Topics\TopicNameContainA/Granting-Permissions-on-a-Native-Mode-Report-Server.md)  
  
  