---
title: "Make a Copy of a Mining Model"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7975bb02-f188-49a0-b7de-5b9b216254ad
caps.latest.revision: 13
manager: paulettm
---
# Make a Copy of a Mining Model
Creating a copy of a mining model is useful when you want to quickly create several mining models that are based on the same data. After you copy the model, you can then edit the new copy by changing parameters or adding a filter.  
  
 For example, if you have a Customers table that is linked to a table of purchases, you could create copies to generate separate mining models for each customer demographic, filtering on attributes such as age or region.  
  
 For information about how to copy the content of the model (such as the graphical representation or the model patterns) to the Clipboard for use in other programs, see [Copy a View of a Mining Model](../../Topics/TopicNameContainA/Copy-a-View-of-a-Mining-Model.md).  
  
### To create a related mining model  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], in Solution Explorer, click the mining structure that contains the mining model.  
  
2.  Click the **Mining Models** tab.  
  
3.  Select the model, and right-click to open the shortcut menu.  
  
     –or–  
  
     Select the model. On the **Mining Model** menu, select **New Mining Model**.  
  
4.  Type a name for the new mining model, and select an algorithm. [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
### To edit the filter on the copied mining model  
  
1.  Select the mining model.  
  
2.  In the **Properties** window, click the text box for the **Filter** property, and the click the build **(…)** button.  
  
3.  Change the filter conditions.  
  
     For more information about how to use the filter editor dialog boxes, see [Apply a Filter to a Mining Model](../../Topics/TopicNameContainA/Apply-a-Filter-to-a-Mining-Model.md).  
  
4.  In the **Properties** window, in the **AlgorithmParameters** text box, click **Setalgorithm parameters**, and change algorithm parameters, if desired.  
  
5.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
## See Also  
 [Filters for Mining Models (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Filters-for-Mining-Models--Analysis-Services---Data-Mining-.md)   
 [Mining Model Tasks and How-tos](../../Topics/TopicNameNotContainA/Mining-Model-Tasks-and-How-tos.md)   
 [Delete a Filter from a Mining Model](../../Topics/TopicNameContainA/Delete-a-Filter-from-a-Mining-Model.md)