---
title: "Cluster Characteristics Tab (Mining Model Viewer)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8e33ed1d-1ce4-405d-895b-7e995b2c910d
caps.latest.revision: 24
manager: jhubbard
---
# Cluster Characteristics Tab (Mining Model Viewer)
The **Cluster Characteristics** tab lets you explore the characteristics of a cluster in a clustering model, or the set of all cases in the model. The graph shows the importance of each attribute-value pair as a characteristic that defines the cluster, in comparison with other clusters.  
  
 **For More Information:** [Microsoft Clustering Algorithm](../../Topics/TopicNameNotContainA/Microsoft-Clustering-Algorithm.md), [Browse a Model Using the Microsoft Cluster Viewer](../../Topics/TopicNameContainA/Browse-a-Model-Using-the-Microsoft-Cluster-Viewer.md)  
  
## Options  
 **Refresh viewer content**  
 Reload the mining model in the viewer.  
  
 **Mining Model**  
 Choose a mining model from those in the current mining structure. The mining model will open in the custom viewer.  
  
 **Viewer**  
 Choose a viewer to use to explore the selected mining model. You can use the custom viewer associated with this model type, or the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Mining Content Viewer. You can also use any plug-in viewers that are available.  
  
 **Cluster**  
 Choose the cluster you want to view, or choose **Population (All)** to see the distribution of attributes for the model as a whole.  
  
 **Characteristics for <cluster\>**  
 The graph contains the following columns, which describe the characteristics of the selected cluster.  
  
|Value|Description|  
|-----------|-----------------|  
|**Variable**|Lists the attributes from the mining model that are found in the selected cluster.|  
|**Values**|Lists the values of the current attributes that are found in the currently selected cluster.|  
|**Probability**|The bar indicates the strength of the attribute-value pair as a distinguishing feature of this cluster. If you hover the mouse over the bar, you can see the probability value, represented as a percentage. What this indicates is, given this attribute and value combination in any particular case, what is the probability that the case would belong in this cluster.|  
  
## See Also  
 [Data Mining Algorithms (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Data-Mining-Algorithms--Analysis-Services---Data-Mining-.md)   
 [Mining Model Viewers (Data Mining Model Designer)](../../Topics/TopicNameNotContainA/Mining-Model-Viewers--Data-Mining-Model-Designer-.md)   
 [Data Mining Model Viewers](../../Topics/TopicNameNotContainA/Data-Mining-Model-Viewers.md)