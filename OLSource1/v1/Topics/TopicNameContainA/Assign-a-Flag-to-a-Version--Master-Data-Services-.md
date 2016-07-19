---
title: Assign a Flag to a Version (Master Data Services)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6629ec7e-32e7-4a1e-8b31-eb43c5923766
manager: jhubbard
---
# Assign a Flag to a Version (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], assign a flag to a version to indicate the version that users or subscribing systems should use.  
  
> [!NOTE]  
>  Version flags can be assigned to only one version at a time. If you assign a flag that is already assigned to another version, the flag is moved to the version you selected.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **Version Management** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
-   You must have created a version flag to assign. For more information, see [Create a Version Flag (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Version-Flag--Master-Data-Services-.md).  
  
-   You must have permission to access the Version Management functional area. For more information, see [Functional Area Permissions (Master Data Services)](../../Topics/TopicNameNotContainA/Functional-Area-Permissions--Master-Data-Services-.md).  
  
### To assign a flag to a version  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **Version Management**.  
  
2.  On the **Manage Versions** page, in the row for the version to which you want to assign a flag, double-click the cell in the **Flag** column.  
  
3.  From the list, select the flag you want to assign.  
  
    > [!NOTE]  
    >  If the flag you want is not available, the flag might be available for **Committed** versions only. To confirm, go to the **Manage Version Flags** page and view the **Committed Versions Only** field for the flag.  
  
4.  Press ENTER to save the change.  
  
## See Also  
 [Create a Version Flag (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Version-Flag--Master-Data-Services-.md)   
 [Versions (Master Data Services)](../../Topics/TopicNameNotContainA/Versions--Master-Data-Services-.md)