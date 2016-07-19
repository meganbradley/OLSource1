---
title: Filter Dialog Box (MDS Add-in for Excel)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b987b141-5abf-4161-a073-4cfc3e7f5aae
manager: jhubbard
---
# Filter Dialog Box (MDS Add-in for Excel)
In the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)][!INCLUDE[ssMDSXLS](../../Topics/TopicNameContainA/includes/ssMDSXLS_md.md)], use the **Filter** dialog box to narrow the list of MDS-managed data before loading it into Excel.  
  
 This dialog box contains three sections: **Columns**, **Rows**, and **Summary**.  
  
## Columns  
 Use the **Columns** section to determine which attributes (columns) you want to display in Excel.  
  
|Control Name|Description|  
|------------------|-----------------|  
|Attribute type|An attribute type describes the type of members you want to work with. In most cases, this is **Leaf**. For more information about member types, see [Members (Master Data Services)](../../Topics/TopicNameNotContainA/Members--Master-Data-Services-.md).|  
|Explicit hierarchy|If you chose the **Consolidated** attribute type, choose the hierarchy the consolidated members belong to. For more information, see [Explicit Hierarchies (Master Data Services)](../../Topics/TopicNameNotContainA/Explicit-Hierarchies--Master-Data-Services-.md).|  
|Attribute Groups|Attribute groups are a way of grouping subsets of attributes. Choose an attribute group if you want to show a subset of available attributes. For more information about attribute groups, see [Attribute Groups (Master Data Services)](../../Topics/TopicNameNotContainA/Attribute-Groups--Master-Data-Services-.md).|  
|Select All|Click to select all attributes displayed in the list.|  
|Clear All|Click to clear the selected attributes displayed in the list.<br /><br /> You cannot clear **Name** and **Code**.|  
|Up Arrow/Down Arrow|Click to move the selected attribute up and down in the list. The top-to-bottom order corresponds to the left-to-right order the columns are displayed in the worksheet.|  
  
## Rows  
 Use the **Rows** section to determine which members (rows) you want to display in Excel. You do this by defining criteria to filter the rows that will be displayed.  
  
|Control Name|Description|  
|------------------|-----------------|  
|Attribute|Displays an attribute you want to filter by. If no attributes are listed, it’s because they have not been added.<br /><br /> Note: You can filter by attributes that you don’t plan to show in the worksheet.|  
|Operator|Displays operators that correspond to the type of attribute that was selected. For more information, see [Filter Operators (Master Data Services)](../../Topics/TopicNameNotContainA/Filter-Operators--Master-Data-Services-.md).|  
|Criteria|The criteria you want to filter by.|  
|Update Summary|When working with large datasets, click to update the **Summary** section with details of the amount of data that will be loaded.|  
|Add|When you click an attribute in the **Columns** section and then click **Add**, an attribute is added to the list of filters.|  
|Remove All|Removes all filters from the list.|  
|Remove|Removes selected filter from the list.|  
  
## Summary  
 Use the **Summary** section to view details about the amount of data that will be loaded, before loading it.  
  
|Control Name|Description|  
|------------------|-----------------|  
|Model|The name of the model.|  
|Version|The name of the version.|  
|Entity|The name of the entity.|  
|Rows|The number of rows that will be loaded into Excel, based on the filters applied in the **Rows** section.|  
|Columns|The number of columns that will be loaded into Excel, based on the attributes selected in the **Columns** section.|  
  
## See Also  
 [Filter Data before Exporting (MDS Add-in for Excel)](../../Topics/TopicNameNotContainA/Filter-Data-before-Exporting--MDS-Add-in-for-Excel-.md)   
 [Overview: Exporting Data to Excel (MDS Add-in for Excel)](../Topic/Overview:%20Exporting%20Data%20to%20Excel%20\(MDS%20Add-in%20for%20Excel\).md)