---
title: "Cluster Profiles Tab (Mining Model Viewer)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1ebafa1f-74e9-4c05-b278-a690fa8543bd
caps.latest.revision: 24
manager: jhubbard
---
# Cluster Profiles Tab (Mining Model Viewer)
Use the **Cluster Profiles** tab for an overall view of the clusters that the algorithm discovered within a clustering model. The tab displays each attribute, together with the distribution of the attribute in each cluster.  
  
 **For More Information:** [Microsoft Clustering Algorithm](../../Topics/TopicNameNotContainA/Microsoft-Clustering-Algorithm.md), [Browse a Model Using the Microsoft Cluster Viewer](../../Topics/TopicNameContainA/Browse-a-Model-Using-the-Microsoft-Cluster-Viewer.md)  
  
## Options  
 **Refresh viewer content**  
 Reload the mining model in the viewer.  
  
 **Mining Model**  
 Choose a mining model from those in the current mining structure. The mining model will open in its associated viewer.  
  
 **Viewer**  
 Choose a viewer to use to view the selected mining model. You can use the custom viewer for the mining model, or the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Mining Content Viewer. You can also use plug-in viewers if available.  
  
 **Show Legend**  
 Select this option to display a key that shows the mapping of colors in the viewer to values in the **States** column.  
  
 **Histogram Bars**  
 Change this value to control how many states are included in each histogram. If there are more states than you choose to display, the states with the highest probability are shown in the histogram, and the remaining states are grouped together into **Other**.  
  
 **Attributes**  
 Lists the columns that are in the clustering model. The histograms for each attribute show how the attribute is distributed among the clusters identified by the algorithm.  
  
 **States**  
 Provides a key that either denotes what color represents each state in the corresponding row of clusters, or a slider with diamond that indicates the distribution of continuous numeric values. You can show or hide this column by using the **Show Legend** check box.  
  
 **Cluster Profiles**  
 This section contains a column for each cluster in the model. For each attribute, the histogram shows the distribution of the values in the attribute for just that cluster. The chart also has a column for **Population**, which also uses histograms to display the distribution of values for each attribute, but for all cases in the model.  
  
## See Also  
 [Data Mining Algorithms (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Data-Mining-Algorithms--Analysis-Services---Data-Mining-.md)   
 [Mining Model Viewers (Data Mining Model Designer)](../../Topics/TopicNameNotContainA/Mining-Model-Viewers--Data-Mining-Model-Designer-.md)   
 [Data Mining Model Viewers](../../Topics/TopicNameNotContainA/Data-Mining-Model-Viewers.md)