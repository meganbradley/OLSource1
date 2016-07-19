---
title: Find a Specific Node in a Dependency Network
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 37c54602-ab25-48be-ae7a-59819deea8ed
manager: paulettm
---
# Find a Specific Node in a Dependency Network
A dependency network in a [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] mining model can contain many nodes, making it difficult to locate the data you are interested in. To solve this problem, you can use the **Find Node** dialog box on the **Dependency Network** tab of Data Mining Designer to search for a specific node.  
  
### To find a specific node in a dependency network  
  
1.  On the **Mining Model Viewer** tab of **Data Mining Designer** in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], click **Find Node** on the toolbar of the **Dependency Network** tab of the mining model viewer.  
  
     The **Find Node** dialog box opens.  
  
2.  In the **Node name contains** box, enter part of the name of the node for which you want to search.  
  
     The list of nodes is filtered to display only those nodes that contain part of the search path.  
  
3.  Select the correct node from the list, and then click **OK**.  
  
## See Also  
 [Mining Model Viewer Tasks and How-tos](../../Topics/TopicNameNotContainA/Mining-Model-Viewer-Tasks-and-How-tos.md)