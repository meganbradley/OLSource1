---
title: "Creating a LightSwitch Screen Based on a Query"
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
  - "Visual Studio LightSwitch, query-based screens"
ms.assetid: fee01115-e17e-40d7-b100-76c194aee3d2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating a LightSwitch Screen Based on a Query
In this lesson, you'll create a LightSwitch screen that's based on a query. By creating the query first, you can limit the amount of data that the associated screen shows.  
  
## Create a Screen Based on a Query  
 An earlier lesson, [Creating a Basic Query](../vs140/creating-a-basic-query-in-lightswitch.md), showed how to use a query to filter the results on a screen that was originally created from the **Orders** entity. By creating a screen that's directly based on a query, you can restrict the amount of data that appears and control the sort order.  
  
#### To create a screen from a query  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Products.lsml** node, and then choose **Add Query**.  
  
     The **Query Editor** appears.  
  
2.  In the **Properties** window, name the query <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
3.  In the **Query Designer**, choose the **Add Filter** link.  
  
4.  In the first list, choose **Where**.  
  
5.  In the second list, choose **Discontinued**.  
  
     Notice that the final list value changes to **False**.  
  
6.  In the **Query Designer**, choose the **Add Sort** link.  
  
7.  In the first list, choose **ProductName**.  
  
8.  In **Solution Explorer**, open the shortcut menu for the **Screens** node, and then choose **Add Screen**.  
  
     The **Add New Screen** dialog box appears.  
  
9. In the **Select a screen template** list, choose **Browse Data Screen**.  
  
10. In the **Screen Name** text box, enter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
11. In the **Screen Data** list, choose **– CurrentProducts**, and then choose the **OK** button.  
  
12. In the center pane of the **Screen Designer**, choose the **Rows Layout &#124; rows** node. In the **Add** list, choose **Discontinued**.  
  
13. Run the application and open the **Current Product List** screen.  
  
     Notice that only products that haven't been discontinued (the discontinued field displays false) appear and that they're listed in alphabetical order.  
  
## Closer Look  
 This lesson showed how to create a query to select products that haven’t been discontinued, and then to create a screen to display the results of that query. If you had created the screen from the **Products** entity, the results would have included all products, including discontinued ones. By creating a query first, you limited the data that’s shown on the associated screen.  
  
 This type of query is known as a global query; it can be reused on multiple screens. A global query can also be used as the source for a new global query as long as both return the same entity type.  
  
## Next Steps  
 In the next lesson, you’ll learn how to create a parameterized query.  
  
 Next lesson: [Creating a Parameterized Query](../vs140/creating-a-parameterized-query-in-lightswitch.md)  
  
## See Also  
 [Filtering Data with Queries](../vs140/filtering-data-with-queries-in-lightswitch.md)   
 [How to: Extend a Query by Using Code](../vs140/how-to--extend-a-query-by-using-code.md)   
 [Queries: Retrieving Information From a Data Source](../vs140/queries--retrieving-information-from-a-data-source.md)