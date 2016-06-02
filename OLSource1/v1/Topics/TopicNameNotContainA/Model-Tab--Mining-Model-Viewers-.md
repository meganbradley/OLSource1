---
title: Model Tab (Mining Model Viewers)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 50570bb4-fcac-411e-b530-0398437efda7
---
# Model Tab (Mining Model Viewers)
  The **Model** tab in the Microsoft Time Series Viewer displays a representation of a time series as a node in a graph, similar to those used in decision tree models.  
  
 Use this view of a time series model to extract useful information about the time series analysis, including the equation for the graph, the ARIMA terms, and the coefficients.  
  
 **For More Information:** [Microsoft Time Series Algorithm](../../Topics\TopicNameNotContainA/Microsoft-Time-Series-Algorithm.md), [Browse a Model Using the Microsoft Time Series Viewer](../../Topics\TopicNameContainA/Browse-a-Model-Using-the-Microsoft-Time-Series-Viewer.md), [Microsoft Time Series Algorithm](../../Topics\TopicNameNotContainA/Microsoft-Time-Series-Algorithm.md)  
  
## Options  
 **Refresh viewer content**  
 Reload the mining model in the viewer.  
  
 **Mining Model**  
 Choose a mining model to view. The mining model will open in its associated viewer.  
  
 **Viewer**  
 Choose a viewer to use to explore the selected mining model. You can use the custom viewer for this model type, or the **Microsoft Generic Content Tree** viewer. You can also use plug\-in viewers, if available.  
  
 **Zoom In**  
 Zoom in to the diagram.  
  
 **Zoom Out**  
 Zoom out from the diagram.  
  
 **Copy Graph View**  
 Copy the visible section of the diagram to the clipboard.  
  
 **Copy Entire Graph**  
 Copy the complete diagram to the clipboard.  
  
 **Scale diagram to fit window**  
 Zoom out from the diagram until the whole diagram fits within the screen.  
  
 **Tree**  
 Select a tree from the dropdown list to show in the viewer  
  
 If the time series model includes multiple series, each series is represented as a separate tree. For example, if you created predictions over time for both \[Quantity\] and \[Sales Amount\], a separate series is created for each predictable attribute.  
  
 The length of the color highlighting in the list indicates the number of levels in the tree. That is, a time series model that can be represented by a single node would have a single equation to describe the trend and the colored bar would be very short. \(Of course, if the model is a MIXED model, the node will contain both an ARIMA and an ARTXP equation.\)  
  
 If the tree shown in the dropdown list has a longer colored bar, it means the model has many branches in the tree. Branching means the regression is more complex and the model has to be broken into multiple segments, with a different equation \(or pair of equations\) in each node.  
  
 **Background**  
 Use this control to select the state that is represented by the background color in each node.  
  
 **Default Expansion**  
 Adjust the default number of levels that are displayed for all trees in the model.  
  
 **Show Level**  
 Change the number of levels that are shown in the tree.  
  
## See Also  
 [Data Mining Algorithms &#40;Analysis Services - Data Mining&#41;](../Topic/Data%20Mining%20Algorithms%20\(Analysis%20Services%20-%20Data%20Mining\).md)   
 [Mining Model Viewers &#40;Data Mining Model Designer&#41;](../Topic/Mining%20Model%20Viewers%20\(Data%20Mining%20Model%20Designer\).md)   
 [Data Mining Model Viewers](../../Topics\TopicNameNotContainA/Data-Mining-Model-Viewers.md)  
  
  