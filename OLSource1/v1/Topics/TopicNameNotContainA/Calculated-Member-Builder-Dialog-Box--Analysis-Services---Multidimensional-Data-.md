---
title: "Calculated Member Builder Dialog Box (Analysis Services - Multidimensional Data)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 73b89a9f-f403-4ab8-99f7-e3ceb870c260
caps.latest.revision: 11
manager: mblythe
---
# Calculated Member Builder Dialog Box (Analysis Services - Multidimensional Data)
Use the **Calculated Member Builder** dialog box in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] to build a calculated member.  
  
## Options  
  
|Term|Definition|  
|----------|----------------|  
|**Name**|Type the name of the calculated member.|  
|**Parent Hierarchy**|Select the hierarchy in which to create the calculated member.|  
|**Parent Member**|This option is enabled if you select a parent hierarchy (other than the **Measures** dimension) that has more than one level. Click the ellipsis (**…**) button to select a parent member. The parent member determines the location of the calculated member in the dimension structure.|  
|**Expression**|Type the MDX expression that will be used.|  
|**Check**|Click **Check** to test the MDX expression defined in **Expression**.|  
|**Metadata**|Displays metadata for the current [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] object that can be included in the MDX expression defined in **Expression**.<br /><br /> You can copy the MDX syntax for the selected item by right-clicking the item and selecting **Copy**, or by dragging the selected item to **Expression**.|  
|**Functions**|Displays the available MDX functions for the current [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] instance. The items listed are retrieved from the MDSCHEMA_FUNCTIONS schema rowset.<br /><br /> You can copy the MDX syntax for the selected item by right-clicking the item and selecting **Copy**, or by dragging the selected item to **Expression**.|  
  
## See Also  
 [Multidimensional Expressions (MDX) Reference](assetId:///7e1cb1fb-2a50-41c2-9c70-b853ad6b6c3f)