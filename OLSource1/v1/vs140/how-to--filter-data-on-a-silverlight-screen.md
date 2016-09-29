---
title: "How to: Filter Data on a Silverlight Screen"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "screens [Visual Studio LightSwitch], filtering data"
  - "limiting data on a screen [Visual Studio LightSwitch]"
  - "filtering data on a screen [Visual Studio LightSwitch]"
  - "screens [Visual Studio LightSwitch], restricting data"
  - "screens [[Visual Studio LightSwitch], limiting data"
  - "restricting data on a screen [Visual Studio LightSwitch]"
ms.assetid: 3cf4aa92-a6cb-46f8-bde6-cf10e1d1c9d7
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Filter Data on a Silverlight Screen
You can filter the data that appears in **List and Details**, **Editable Grid**, and **Search Data** screens. For example, you could filter so that only customers who are located in the United States are displayed. To filter data, modify the query of a collection on a screen, or write a custom query and then use it to create a screen.  
  
 ![link to video](../vs140/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Sort and Filter Data on a Screen in a LightSwitch Application?](http://go.microsoft.com/fwlink/?LinkID=205130).  
  
## Modifying the Query of a Screen  
 **List and Details**, **Editable Grid**, and **Search Data** screens contain collections that are based on queries. For example, a collection that is based on the Customer entity uses this query by default: `Select * from Customers`. You can customize the conditions of the query. Your changes apply only to the collection on the screen and do not affect the query globally.  
  
#### To modify the query of a screen collection  
  
1.  On the **Screen Members List**, next to the collection you want to modify, click **Edit Query**.  
  
2.  In the Query Designer, modify the query.  
  
     For more information, see [How to: Design a Query by Using the Query Designer](../vs140/how-to--design-a-query-by-using-the-query-designer.md).  
  
3.  When you have finished modifying the query, click the back arrow at the top-left corner of the Query Designer to return to the **Screen Designer**.  
  
## Creating a Screen by Using a Query in the Solution  
 You can create a **List and Details**, **Editable Grid**, or **Search Data** screen based on a query in your [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] solution.  
  
 For more information about how to add a query to your solution, see [How to: Add, Remove, and Modify a Query](../vs140/how-to--add--remove--and-modify-a-query.md).  
  
 For more information about how to design a query, see [How to: Design a Query by Using the Query Designer](../vs140/how-to--design-a-query-by-using-the-query-designer.md).  
  
#### To create a screen by using a query in the solution  
  
1.  Create a screen. In the **Add New Screen** dialog box, for the **Screen Data** field, select a query. For more information about how to create a screen, see [How to: Create a Screen](../vs140/how-to--create-a-silverlight-screen.md).  
  
     Only data that meets the conditions that are defined by the query will appear in the screen.  
  
#### To create a screen by using a query that accepts a parameter  
  
1.  Create a screen. In the **Add New Screen** dialog box, for the **Screen Data** field, select a query that accepts a parameter. For more information about how to create a screen, see [How to: Create a Screen](../vs140/how-to--create-a-silverlight-screen.md).  
  
2.  Because the query requires a parameter value, the new screen does not appear in the navigation menu of the running application. The screen is displayed when a user provides a value in a field in another screen. You must add that field to the other screen.  
  
     In the **Screen Designer**, in the other screen, click **Add Data Item**.  
  
3.  In the **Add Screen Item** dialog box, select **Local Property**. In the **Type** list, select a type for the local property.  
  
4.  In the **Name** box, provide a name for the local property, for example, `CityName`, and then click **OK**.  
  
5.  From the **Screen Members List**, drag the new local property to the **Screen Content Tree**.  
  
6.  In the **Screen Content Tree**, right-click the local property and then click **Add Button**.  
  
7.  In the **Add Button** dialog box, select **New Method** and then click **OK**.  
  
8.  In the **Screen Content Tree**, right-click the button and then click **Edit Execute Code**.  
  
9. In the Code Editor, write code that displays the parameterized query screen. The following example displays the ShowCustomerByCity screen by passing the value of the local property named `CityName`.  
  
     [!code[LS_Screens#3](../vs140/codesnippet/CSharp/how-to--filter-data-on-a-silverlight-screen_1.cs)]
[!code[LS_Screens#3](../vs140/codesnippet/VisualBasic/how-to--filter-data-on-a-silverlight-screen_1.vb)]  
  
## See Also  
 [Screens: What the User Sees](../vs140/screens--the-user-interface-of-your-lightswitch-application.md)   
 [Queries: Retrieving Information From a Data Source](../vs140/queries--retrieving-information-from-a-data-source.md)   
 [How to: Provide a Value to a Query Parameter](../vs140/how-to--provide-a-value-to-a-query-parameter.md)