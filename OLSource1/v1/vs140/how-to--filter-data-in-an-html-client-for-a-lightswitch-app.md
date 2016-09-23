---
title: "How to: Filter Data in an HTML Client for a LightSwitch App"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f7668663-3c53-4eb1-8048-1b74a2616cb6
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Filter Data in an HTML Client for a LightSwitch App
By filtering the data that appears in your HTML client for a Visual Studio LightSwitch application, you can help users identify the most relevant data for their tasks. For example, you can create or modify a **Browse Data** screen to help salespeople identify customers who ordered a particular product from your company in the last three months. To display a specific set of data on a screen, you create or customize a query that determines what data appears on a screen, and you associate the query with a new or existing screen.  
  
## Modifying the Query of an Existing Screen  
 You can repurpose an existing screen if you modify the query that defines the subset of data that the screen displays. For example, you might already have a screen that shows data based on the `Select * from Customers` query. By using the Query Designer, you can filter the data that appears in only that screen, even if that query defines the data set for other screens.  
  
#### To filter the data in an existing screen  
  
1.  In the **Screen Members List** of the **Screen Designer**, choose the collection of data that you want to filter, and then choose the **Edit Query** link.  
  
2.  In the **Query Designer**, modify the query.  
  
     For more information, see [How to: Design a Query by Using the Query Designer](../vs140/how-to--design-a-query-by-using-the-query-designer.md).  
  
3.  When you finish, choose the back arrow in the top-left corner of the **Query Designer** to return to the **Screen Designer**.  
  
## Filtering Data in a New Screen  
 If you already have a query in your LightSwitch solution, you can create a **Browse Data** screen that’s based on that query.  
  
 For information about how to add a query to your solution, see [How to: Add, Remove, and Modify a Query](../vs140/how-to--add--remove--and-modify-a-query.md).  
  
 For information about how to design a query, see [How to: Design a Query by Using the Query Designer](../vs140/how-to--design-a-query-by-using-the-query-designer.md).  
  
#### To create a screen that shows filtered data  
  
1.  In **Solution Explorer**, open the shortcut menu for the **HTML Client** node, and then choose **Add Screen**.  
  
     The **Add New Screen** dialog box appears.  
  
2.  In the **Select a screen template** list, choose **Browse Data Screen**.  
  
3.  In the **Screen Name** text box, enter a name for the screen.  
  
4.  In the **Screen Data** list, choose a query, and then choose the **OK** button.  
  
     The screen will display only the data that meets the conditions that are the query specifies.  
  
## See Also  
 [HTML Client Screens](../vs140/html-client-screens-for-lightswitch-apps.md)   
 [Queries: Retrieving Information From a Data Source](../vs140/queries--retrieving-information-from-a-data-source.md)