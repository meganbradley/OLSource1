---
title: Review Aggregation Usage (Aggregation Design Wizard)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 107ee872-3df2-4931-b56c-af11e38f6745
---
# Review Aggregation Usage (Aggregation Design Wizard)
  Use the **Review Aggregation Usage** page to configure aggregation usage settings.  
  
## Options  
 **Default**  
 Select to set the aggregation usage setting for the attribute to Default. By using this setting, the designer applies a default rule based on the type of attribute and dimension.  
  
 **Full**  
 Select to set the aggregation usage setting for the attribute to **Full**. By using this setting, every aggregation for the cube must include this attribute or a related attribute that is lower in the attribute chain. The **Full** aggregation usage setting should be avoided when an attribute contains many members. If specified for multiple attributes or attributes that have many members, this setting might prevent aggregations from being designed because of excessive size.  
  
 **None**  
 Select to set the aggregation usage setting for the attribute to None. By using this setting, no aggregation for the cube can include this attribute.  
  
 **Unrestricted**  
 Select to set the aggregation usage setting for the attribute to **Unrestricted**. By using this setting, no restrictions are put on the aggregation designer; however, the attribute must still be evaluated to determine whether it is a valuable aggregation candidate.  
  
 **Set All to Default**  
 Select to set the aggregation usage settings for all attributes to Default.  
  
## See Also  
 [Aggregation Design Wizard F1 Help](../../Topics\TopicNameNotContainA/Aggregation-Design-Wizard-F1-Help.md)   
 [Analysis Services Wizards &#40;Multidimensional Data&#41;](../Topic/Analysis%20Services%20Wizards%20\(Multidimensional%20Data\).md)  
  
  