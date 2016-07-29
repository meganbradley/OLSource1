---
title: "View or Change Algorithm Parameters"
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
ms.assetid: 151b899b-c27a-4a09-bcf5-5c9f0ec24168
caps.latest.revision: 16
manager: paulettm
---
# View or Change Algorithm Parameters
You can change the parameters provided with the algorithms that you use to build data mining models to customize the results of the model.  
  
 The algorithm parameters provided in [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] change much more than just properties on the model: they can be used to fundamentally alter the way that data is processed, grouped, and displayed. For example, you can use algorithm parameters to do the following:  
  
-   Change the method of analysis, such as the clustering method.  
  
-   Control feature selection behavior.  
  
-   Specify the size of itemsets or the probability of rules.  
  
-   Control branching and depth of decision trees.  
  
-   Specify a seed value or the size of the internal holdout set used for model creation.  
  
 The parameters provided for each algorithm vary greatly; for a list of the parameters that you can set for each algorithm, see the technical reference topics in this section: [Data Mining Algorithms (Analysis Services - Data Mining)](../../Topics/TopicNameNotContainA/Data-Mining-Algorithms--Analysis-Services---Data-Mining-.md).  
  
### Change an algorithm parameter  
  
1.  On the **Mining Models** tab of Data Mining Designer in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], right-click the algorithm type of the mining model for which you want to tune the algorithm, and select **Set Algorithm Parameters**.  
  
     The **Algorithm Parameters** dialog box opens.  
  
2.  In the **Value** column, set a new value for the algorithm that you want to change.  
  
     If you do not enter a value in the **Value** column, [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] uses the default parameter value. The **Range** column describes the possible values that you can enter.  
  
3.  Click **OK**.  
  
     The algorithm parameter is set with the new value. The parameter change will not be reflected in the mining model until you reprocess the model.  
  
### View the parameters used in an existing model  
  
1.  In [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], open a DMX Query window.  
  
2.  Type a query like this one:  
  
    ```  
    select MINING_PARAMETERS   
    from $system.DMSCHEMA_MINING_MODELS  
    WHERE MODEL_NAME = '<model name>'  
  
    ```  
  
## See Also  
 [Mining Model Tasks and How-tos](../../Topics/TopicNameNotContainA/Mining-Model-Tasks-and-How-tos.md)