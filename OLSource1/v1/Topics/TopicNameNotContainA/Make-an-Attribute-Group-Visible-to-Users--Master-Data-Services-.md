---
title: Make an Attribute Group Visible to Users (Master Data Services)
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
ms.assetid: b2f6cc27-dbc9-4f3f-961e-e81e76375248
manager: jhubbard
---
# Make an Attribute Group Visible to Users (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], make an attribute group visible to users or groups when you want users to have tabs above the grid in the **Explorer** functional area.  
  
 When you create an attribute group, it is automatically hidden from all users except the one who created it.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
-   At least one attribute group must exist. For more information, see [Create an Attribute Group (Master Data Services)](../../Topics/TopicNameNotContainA/Create-an-Attribute-Group--Master-Data-Services-.md).  
  
### To make an attribute group visible to users  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **System Administration**.  
  
2.  On the **Manage Model** page, select a model from the grid and then click **Entities**.  
  
3.  On the **Manage Entity** page, from the grid, select the row for the entity that you want to edit the attribute group.  
  
4.  Click **Attribute Groups**.  
  
5.  On the **Manage Attribute Groups** page, select member type from the **Member Types** drop-down list box to expand **Leaf**, **Consolidated** or **Collection**, depending on the type of group you want to make visible.  
  
6.  Select the attribute group you want to edit from the grid, and then click **Edit**.  
  
7.  Click a user or group in the **Available** box and click the **Add** arrow. To add all, click the **Add All** arrow.  
  
8.  Click **Save**.  
  
## See Also  
 [Attribute Groups (Master Data Services)](../../Topics/TopicNameNotContainA/Attribute-Groups--Master-Data-Services-.md)   
 [Create an Attribute Group (Master Data Services)](../../Topics/TopicNameNotContainA/Create-an-Attribute-Group--Master-Data-Services-.md)