---
title: "Create an Entity (Master Data Services)"
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
ms.assetid: d9a6a51e-7b53-4785-a118-3baeb7ca2d48
caps.latest.revision: 10
manager: jhubbard
---
# Create an Entity (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], create an entity to contain members and their attributes.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
-   A model must exist. For more information, see [Create a Model (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Model--Master-Data-Services-.md).  
  
### To create an entity  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **System Administration**.  
  
2.  On the **Manage Model** page, from the grid, select the model that you want to create entity for and then click **Entities**.  
  
3.  On the **Manage Entity** page, click **Add**.  
  
4.  In the **Name** box, type the name of the entity.  
  
5.  Optionally, in the **Description** field, type the entity description.  
  
6.  Optionally, in the **Name for staging tables** box, type a name for the staging table.  
  
     If you do not complete this field, the entity name is used.  
  
    > [!TIP]  
    >  Use the model name as part of the staging table name, for example *Modelname_Entityname*. This makes the tables easier to find in the database. For more information about the staging tables, see [Overview: Importing Data from Tables (Master Data Services)](../Topic/Overview:%20Importing%20Data%20from%20Tables%20\(Master%20Data%20Services\).md).  
  
7.  For the **Transaction Log Type** field, choose the transaction log type in the drop-down list.  
  
     For more information, see [Change the Entity Transaction Log Type (Master Data Services)](../../Topics/TopicNameNotContainA/Change-the-Entity-Transaction-Log-Type--Master-Data-Services-.md)  
  
8.  Optional. Select the **Create Code values automatically** check box. For more information, see [Automatic Code Creation (Master Data Services)](../../Topics/TopicNameNotContainA/Automatic-Code-Creation--Master-Data-Services-.md).  
  
9. Optional. Select the **Enable data Compression** checkbox. By default the row compression is turned on. For more information , see [Data Compression](../../Topics/TopicNameNotContainA/Data-Compression.md).  
  
10. Click **Save**.  
  
## Grid Columns  
 For each created entity, a row with thirteen columns is added to the grid. The following are the columns.  
  
|Name|Description|  
|----------|-----------------|  
|Status|The entity status. When you click **Save** the following image is displayed that indicates that the entity is updating.<br /><br /> ![Icon for updating status](../../Topics/TopicNameContainA/media/mds_StatusIcon_Updating.png "mds_StatusIcon_Updating")<br /><br /> If there are errors when creating or editing an entity, the following image is displayed.<br /><br /> ![Icon for error status](../../Topics/TopicNameContainA/media/mds_StatusIcon_Error.png "mds_StatusIcon_Error")<br /><br /> If the status is OK, then the following image is displayed.<br /><br /> ![Icon for OK status](../../Topics/TopicNameContainA/media/mds_StatusIcon_OK.png "mds_StatusIcon_OK")|  
|Name|The entity name.|  
|Description|The entity description.|  
|Staging Table|The prefix name of the table that is used for storing data.|  
|Transaction Log Type|The transaction log type of the entity.|  
|Automatic Code Creation|Specifies whether automatic code creation is enabled.|  
|Data Compression|Specifies whether data compression is enabled for the entity.|  
|Is Sync Target|Specifies if the entity is the target of a sync relationship.|  
|Is Hierarchy Enabled|Specifies if the entity is enabled for explicit hierarchies. This column shows Yes if at least one explicit hierarchy is created for the entity.|  
|Created By|The username of the user who created the entity.|  
|Created On|The date and time when the entity was created.|  
|Updated By|The username of the user who last updated the entity.|  
|Updated On|The date and time when the entity was last updated.|  
  
## Next Steps  
  
-   [Create a Text Attribute (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Text-Attribute--Master-Data-Services-.md)  
  
-   [Create a Domain-Based Attribute (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Domain-Based-Attribute--Master-Data-Services-.md)  
  
-   [Create a File Attribute (Master Data Services)](../../Topics/TopicNameContainA/Create-a-File-Attribute--Master-Data-Services-.md)  
  
## See Also  
 [Entities (Master Data Services)](../../Topics/TopicNameNotContainA/Entities--Master-Data-Services-.md)   
 [Explicit Hierarchies (Master Data Services)](../../Topics/TopicNameNotContainA/Explicit-Hierarchies--Master-Data-Services-.md)   
 [Edit an Entity (Master Data Services)](../../Topics/TopicNameNotContainA/Edit-an-Entity--Master-Data-Services-.md)   
 [Delete an Entity (Master Data Services)](../../Topics/TopicNameNotContainA/Delete-an-Entity--Master-Data-Services-.md)