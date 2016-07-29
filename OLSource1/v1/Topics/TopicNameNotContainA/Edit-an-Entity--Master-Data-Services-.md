---
title: "Edit an Entity (Master Data Services)"
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
ms.assetid: 6a5b9f14-6dfc-49d7-a771-e96461d4feae
caps.latest.revision: 9
manager: jhubbard
---
# Edit an Entity (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], you can edit an entity.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
### To edit an entity  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **System Administration**.  
  
2.  On the **Manage Model** page, select a model from the grid and then click **Entities**.  
  
3.  On the **Manage Entity** page, from the grid, select the row for the entity that you want to change and then click **Edit**.  
  
4.  In the **Name** box, type the updated name of the entity..  
  
5.  In the **Description** field, type the updated description of the entity.  
  
6.  In the **Name for staging tables** field, type the updated name for the staging table.  
  
7.  For the **Transaction Log Type** field, choose the updated transaction log type in the drop-down list.  
  
     For more information, see [Change the Entity Transaction Log Type (Master Data Services)](../../Topics/TopicNameNotContainA/Change-the-Entity-Transaction-Log-Type--Master-Data-Services-.md)  
  
8.  Select or unselect the **Create code values automatically** checkbox.  
  
     For more information, see [Automatic Code Creation (Master Data Services)](../../Topics/TopicNameNotContainA/Automatic-Code-Creation--Master-Data-Services-.md)  
  
9. Select or unselect the **Enable data Compression** checkbox. By default the row compression is turned on.  
  
     For more information, see [Data Compression](../../Topics/TopicNameNotContainA/Data-Compression.md)  
  
## Status  
 The status column in the grid shows the status of the operation on the entity. When you click **Save entity**, the following image displays that indicates that the entity is updating.  
  
 ![Icon for updating status](../../Topics/TopicNameContainA/media/mds_StatusIcon_Updating.png "mds_StatusIcon_Updating")  
  
 If there are errors when creating or editing an entity, the following image displays.  
  
 ![Icon for error status](../../Topics/TopicNameContainA/media/mds_StatusIcon_Error.png "mds_StatusIcon_Error")  
  
 When the status is OK, the following image displays.  
  
 ![Icon for OK status](../../Topics/TopicNameContainA/media/mds_StatusIcon_OK.png "mds_StatusIcon_OK")  
  
## See Also  
 [Explicit Hierarchies (Master Data Services)](../../Topics/TopicNameNotContainA/Explicit-Hierarchies--Master-Data-Services-.md)   
 [Delete an Entity (Master Data Services)](../../Topics/TopicNameNotContainA/Delete-an-Entity--Master-Data-Services-.md)   
 [Entities (Master Data Services)](../../Topics/TopicNameNotContainA/Entities--Master-Data-Services-.md)