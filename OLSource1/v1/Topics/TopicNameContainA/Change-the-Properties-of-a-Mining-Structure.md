---
title: Change the Properties of a Mining Structure
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 03b16897-2e36-42b8-9f7d-db1b9b898401
---
# Change the Properties of a Mining Structure
  There are two kinds of properties on a mining structure, both of which can be modified:  
  
-   Properties of the mining structure that affect the entire structure  
  
-   Properties on individual columns in the structure  
  
 Note that some properties are dependent on other property settings. For example, you cannot set properties that control binning behavior \(such as [DiscretizationMethod](assetId:///P:Microsoft.AnalysisServices.ScalarMiningStructureColumn.DiscretizationMethod) or [DiscretizationBucketCount](assetId:///P:Microsoft.AnalysisServices.ScalarMiningStructureColumn.DiscretizationBucketCount)\) until you have set the data type of the column to **Discretized**.  
  
 For more information about mining structure properties, see [Mining Structure Columns](../../Topics\TopicNameNotContainA/Mining-Structure-Columns.md).  
  
### To change the properties of a mining structure  
  
1.  On the **Mining Structure** tab in Data Mining Designer, right\-click either the mining structure or a column in the mining structure, and then select **Properties**.  
  
     The **Properties** window opens on the right side of the screen, if it was not already visible.  
  
2.  In the **Properties** window, select the value that corresponds to the property that you want to change, and then enter the new value.  
  
     The new value will take effect when you select a different element in the designer.  
  
## See Also  
 [Mining Structure Tasks and How-tos](../../Topics\TopicNameNotContainA/Mining-Structure-Tasks-and-How-tos.md)  
  
  