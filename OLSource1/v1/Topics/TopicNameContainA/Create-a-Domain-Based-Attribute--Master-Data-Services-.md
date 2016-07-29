---
title: "Create a Domain-Based Attribute (Master Data Services)"
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
ms.assetid: 11c31c9f-e6cc-47b7-b76a-d691f84c93c6
caps.latest.revision: 13
manager: jhubbard
---
# Create a Domain-Based Attribute (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], create a domain-based attribute to populate an attribute's values with members from an entity.  
  
## Prerequisites  
 To perform this procedure:  
  
-   You must have permission to access the **System Administration** functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
-   An entity must exist to use as the source of the attribute values. For example, to create a domain-based attribute based on the Color entity, you must first create the Color entity. For more information, see [Create an Entity (Master Data Services)](../../Topics/TopicNameNotContainA/Create-an-Entity--Master-Data-Services-.md).  
  
-   An entity must exist to create the attribute for. For more information, see [Create an Entity (Master Data Services)](../../Topics/TopicNameNotContainA/Create-an-Entity--Master-Data-Services-.md).  
  
## Attribute Information  
 For each created attribute, a row with seven columns is added to the grid. The following table describes the columns.  
  
|Column|Description|  
|------------|-----------------|  
|Status|The attribute status.<br /><br /> When you click Save, the ![Icon for updating status](../../Topics/TopicNameContainA/media/mds_StatusIcon_Updating.png "mds_StatusIcon_Updating") image displays, indicating that the attribute is updating.<br /><br /> If there are errors when creating or editing an attribute, the ![Icon for error status](../../Topics/TopicNameContainA/media/mds_StatusIcon_Error.png "mds_StatusIcon_Error") image displays.<br /><br /> Otherwise, the status is OK and the ![Icon for OK status](../../Topics/TopicNameContainA/media/mds_StatusIcon_OK.png "mds_StatusIcon_OK") image displays.|  
|Name|The attribute name.|  
|Display Name|The attribute display name.|  
|Description|The attribute description.|  
|Display Pixel Width|The attribute width.|  
|Type and Properties|The type and data type information of the attribute.|  
|Enable Change Tracking|Specifies whether the attribute is enabled for change tracking and shows the group number in parentheses.|  
  
 When you click an attribute, the following information displays.  
  
-   **Created By**: The name of the user who created the attribute.  
  
-   **On**: The date and time when the attribute was created.  
  
-   **Updated By**: the name of the user who last updated the attribute.  
  
-   **On**: The date and time when the attribute was last updated.  
  
### To create a domain-based attribute  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **System Administration**.  
  
2.  On the **Manage Models** page, click a model, and then click **Entities**.  
  
3.  On the **Manage Entities** page, select the row for the entity that you want to create an attribute for.  
  
4.  Click **Attributes**.  
  
5.  On the **Manage Attributes** page, do one of the following and then click **Add**.  
  
    -   If the attribute is for leaf members, select **Leaf** from the **Member Types** list box.  
  
    -   If the attribute is for consolidated members, select **Consolidated** from the **Member Types** list box.  
  
    -   If the attribute is for collections, select **Collection** from the **Member Types** list box.  
  
6.  In the **Name** box, type a name for the attribute. For a list of words that should not be used as attribute names, see [Reserved Words (Master Data Services)](../../Topics/TopicNameNotContainA/Reserved-Words--Master-Data-Services-.md)  
  
7.  Optionally, type a display name, and type a description in the **Description** box.  
  
8.  In the **Display pixel width** box, type the width of the attribute column to be displayed in the **Explorer** grid.  
  
9. From the **Attribute type** list, select **Domain-based**.  
  
10. From the **Domain Entity** list, choose the entity to be used to populate the attribute values.  
  
11. **Optional, for domain-based attributes for leaf members.** Select a filter parent attribute that is used to constrain the allowed values for the domain-based attribute.  
  
     The filter parent attribute must be another domain-based attribute for a leaf member, within the same entity. A derived hierarchy must exist with a level that defines the parent-child relationship between the domain entities of the two attributes.  
  
     For information about constraining the allowed values, see [How to filter Domain Based Attribute drop down lists](https://blogs.msdn.microsoft.com/mds/2015/12/03/in-sql-server-2016-master-data-services-how-to-filter-domain-based-attribute-drop-down-lists/), on the Master Data Services blog.  
  
12. **Optional.** Select **Enable change tracking** to track changes to groups of attributes. For more information, see [Add Attributes to a Change Tracking Group (Master Data Services)](../../Topics/TopicNameContainA/Add-Attributes-to-a-Change-Tracking-Group--Master-Data-Services-.md).  
  
13. Click **Save**.  
  
## See Also  
 [Domain-Based Attributes (Master Data Services)](../../Topics/TopicNameNotContainA/Domain-Based-Attributes--Master-Data-Services-.md)   
 [Create a Derived Hierarchy (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Derived-Hierarchy--Master-Data-Services-.md)   
 [Change an Attribute Name and Data Type (Master Data Services)](../../Topics/TopicNameNotContainA/Change-an-Attribute-Name-and-Data-Type--Master-Data-Services-.md)   
 [Delete an Attribute (Master Data Services)](../../Topics/TopicNameNotContainA/Delete-an-Attribute--Master-Data-Services-.md)