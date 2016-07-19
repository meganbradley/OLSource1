---
title: Incremental Update Dialog Box (Analysis Services - Multidimensional Data)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d5a5ae27-44e7-4179-b9e2-efbf21d6c5f5
manager: mblythe
---
# Incremental Update Dialog Box (Analysis Services - Multidimensional Data)
Use the **Incremental Update** dialog box in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] and [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] to define the settings that are used when measure groups and partitions are incrementally updated. You can display the **Incremental Update** dialog box by clicking **Configure** in the **Settings** column of the **Object list** grid in the **Process** dialog box.  
  
## Options  
  
|Term|Definition|  
|----------|----------------|  
|**Measure Group**|Select the measure group to incrementally update.<br /><br /> Note: This option is enabled only if you are incrementally updating a cube. If you are incrementally updating a measure group or partition, this option is disabled.|  
|**Partition**|Select the partition to update.<br /><br /> Note: This option is enabled only if you are incrementally updating a cube. If you are incrementally updating a measure group or partition, this option is disabled.|  
|**Table**|Click to update the object from a table.|  
|**Data source or view**|Select the data source or data source view in which the source table is located.<br /><br /> Note: This option is enabled only if **Table** is selected.|  
|**Table schema and name**|Select the source table used to retrieve data for incrementally updating the cube, measure group, or partition.<br /><br /> Note: This option is enabled only if **Table** is selected.|  
|**Query**|Click to update the object from a query.|  
|**Data Source**|Select the data source in which the tables to be queried are located.<br /><br /> Note: This option is enabled only if **Query** is selected.|  
|**Text of the query**|Type the text of the query used to retrieve data for incrementally updating the cube, measure group, or partition.<br /><br /> Note: This option is enabled only if **Query** is selected.|  
  
## See Also  
 [Analysis Services Designers and Dialog Boxes (Multidimensional Data)](../../Topics/TopicNameNotContainA/Analysis-Services-Designers-and-Dialog-Boxes--Multidimensional-Data-.md)   
 [Process Dialog Box (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Process-Dialog-Box--Analysis-Services---Multidimensional-Data-.md)