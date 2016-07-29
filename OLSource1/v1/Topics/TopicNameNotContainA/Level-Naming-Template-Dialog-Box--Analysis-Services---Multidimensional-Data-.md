---
title: "Level Naming Template Dialog Box (Analysis Services - Multidimensional Data)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 96cad715-213e-4eac-9003-130a2f5fc985
caps.latest.revision: 21
manager: mblythe
---
# Level Naming Template Dialog Box (Analysis Services - Multidimensional Data)
Use the **Level Naming Template** dialog box in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] to construct the level naming template for a parent attribute in a dimension. For more information about level naming templates, see [Translations (Dimension Designer) (Analysis Services - Multidimensional Data)](assetId:///d68d765c-f012-40c1-acd4-32741ee2eadf). You can display the **Level Naming Template** dialog box by clicking the ellipsis button (**...**) on the **NamingTemplate** value of a translation for an attribute in the **Translation Details** pane on the **Translations** tab of **Dimension Designer**.  
  
## Options  
  
|Term|Definition|  
|----------|----------------|  
|**Define the level template**|Displays a grid in which you can design the hierarchy of levels in the parent attribute. The grid contains the following columns:<br /><br /> **Level**:<br />                      Displays the ordinal position of the level for which the name specified in **Name** is used. To add a new naming template for a level, select **Name** on the row that contains an asterisk (\*) in **Level**.<br /><br /> **Name**:<br />                      Contains the naming template used for the level indicated in **Level**. To add a placeholder for the level ordinal position in the naming template, add a single asterisk (*). To add an asterisk as part of the name created by the naming template, add two asterisks (\*\*).|  
|**Clear All**|Select to remove all rows in **Define the level template**.|  
|**Result**|Displays the level naming template constructed by the dialog box.|  
  
## See Also  
 [Analysis Services Designers and Dialog Boxes (Multidimensional Data)](../../Topics/TopicNameNotContainA/Analysis-Services-Designers-and-Dialog-Boxes--Multidimensional-Data-.md)   
 [Translations (Dimension Designer) (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Translations--Dimension-Designer---Analysis-Services---Multidimensional-Data-.md)