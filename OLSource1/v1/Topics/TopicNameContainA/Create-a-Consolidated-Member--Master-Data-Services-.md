---
title: Create a Consolidated Member (Master Data Services)
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
ms.assetid: 431ab2d2-5517-4372-9980-142b05427c08
manager: jhubbard
---
# Create a Consolidated Member (Master Data Services)
In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], create a consolidated member when you want a parent node for an explicit hierarchy. If you want to add data in bulk, use the staging tables instead. For more information, see  [Import Data from Tables (Master Data Services)](../../Topics/TopicNameNotContainA/Import-Data-from-Tables--Master-Data-Services-.md).  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **Explorer** functional area.  
  
-   You must have a minimum of **Update** permission to the consolidated model object for the entity you are adding a member to, as well as **Create permission** to Consolidated Type under the entity.  
  
### To create a consolidated member  
  
1.  On the [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] home page, from the **Model** list, select a model.  
  
2.  From the **Version** list, select a version.  
  
3.  Click **Explorer**.  
  
4.  From the menu bar, point to **Hierarchies** and click the name of the hierarchy you want to add a consolidated member to.  
  
5.  Above the grid, select either the **Consolidated members** or the **All consolidated members in hierarchy** option.  
  
6.  In the left-hand pane, select either a Root node or a consolidated member under which you want to create a consolidated member.  
  
7.  Click **Add**.  
  
8.  In the pane on the right, complete the fields.  
  
9. Optional. In the **Annotations** box, type a comment about why the member was added. All users who have access to the member can view the annotation.  
  
10. Click **OK**.  
  
## Next Steps  
  
-   [Move Members within a Hierarchy (Master Data Services)](assetId:///049c9a15-89c1-478c-8438-028fffc9e187)  
  
## See Also  
 [Create an Explicit Hierarchy (Master Data Services)](../../Topics/TopicNameNotContainA/Create-an-Explicit-Hierarchy--Master-Data-Services-.md)   
 [Create a Leaf Member (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Leaf-Member--Master-Data-Services-.md)   
 [Members (Master Data Services)](../../Topics/TopicNameNotContainA/Members--Master-Data-Services-.md)   
 [Explicit Hierarchies (Master Data Services)](../../Topics/TopicNameNotContainA/Explicit-Hierarchies--Master-Data-Services-.md)