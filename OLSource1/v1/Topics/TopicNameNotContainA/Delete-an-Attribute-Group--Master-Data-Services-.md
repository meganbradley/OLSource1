---
title: Delete an Attribute Group (Master Data Services)
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
ms.assetid: f915e89b-629d-4725-aea6-a7f051978244
manager: jhubbard
---
# Delete an Attribute Group (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], delete an attribute group when you no longer need the tab to display in the **Explorer** functional area of [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)].  
  
-   **Note** When attribute groups exist, attributes that do not belong to an attribute group are not displayed in **Explorer**. When no attribute groups exist, all attributes are displayed.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
### To delete an attribute group  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **System Administration**.  
  
2.  On the **Manage Model** page, select a model from the grid and then click **Entities**.  
  
3.  On the **Manage Entity** page, from the grid, select the row for the entity that you want to edit an attribute group.  
  
4.  Click **Attribute Groups**.  
  
5.  On the **Manage Attribute Groups** page, select member type from the **Member Types** drop-down list to expand **Leaf**, **Consolidated**, or **Collection**, depending on the type of group you want to delete.  
  
6.  Click the attribute group you want to delete.  
  
7.  Click **Delete**.  
  
8.  In the confirmation dialog box, click **OK**.  
  
## See Also  
 [Attribute Groups (Master Data Services)](../../Topics/TopicNameNotContainA/Attribute-Groups--Master-Data-Services-.md)   
 [Create an Attribute Group (Master Data Services)](../../Topics/TopicNameNotContainA/Create-an-Attribute-Group--Master-Data-Services-.md)