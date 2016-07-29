---
title: "Manually Edit a Prediction Query"
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
ms.assetid: 9f6a9298-49d5-4675-ad49-977a47dff5a6
caps.latest.revision: 18
manager: paulettm
---
# Manually Edit a Prediction Query
After you have designed a query by using the Prediction Query Builder, you can modify the query by switching to Query Text view on the **Mining Model Prediction** tab of Data Mining Designer. A text editor appears at the bottom of the screen to display the query that the query builder created.  
  
 Switching to Query Text view is useful for making additions to the query. For example, you can add a WHERE clause or ORDER BY clause.  
  
 Use the grid in the Prediction Query Builder to insert the names of objects and columns and set up the syntax for individual prediction functions, and then switch to manual editing mode to change parameter values.  
  
> [!NOTE]  
>  If you switch back to **Design** view from **Query Text** view, any changes that you made in **Query Text** view will be lost.  
  
### Modify a query  
  
1.  On the **Mining Model Prediction** tab in Data Mining Designer in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], click **SQL**.  
  
     The grid at the bottom of the screen is replaced by a text editor that contains the query. You can type changes to the query in this editor.  
  
2.  To run the query, on the **Mining Model** menu, select **Result**, or click the button to switch to query results.  
  
    > [!NOTE]  
    >  If the query that you have created is invalid, the Results window does not display an error and does not display any results. Click the **Design** button, or select **Design** or **Query** from the **Mining Model** menu to correct the problem and run the query again.  
  
## See Also  
 [Data Mining Queries](../../Topics/TopicNameNotContainA/Data-Mining-Queries.md)   
 [Prediction Query Builder (Data Mining)](../../Topics/TopicNameNotContainA/Prediction-Query-Builder--Data-Mining-.md)   
 [tutorial](assetId:///b213cb58-2c40-4c89-b08b-d3c36a4afad3)