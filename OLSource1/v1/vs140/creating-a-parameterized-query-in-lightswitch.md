---
title: "Creating a Parameterized Query in LightSwitch"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - Visual Studio LightSwitch, parameterized queries
ms.assetid: a138baf2-b2c5-4af2-b717-16f948ac13a6
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Creating a Parameterized Query in LightSwitch
This lesson shows how to create a parameterized query in a LightSwitch application.  
  
## Create a Parameterized Query  
 A parameterized query determines what data to return by evaluating one or more values (parameters) when the application runs. For example, if you set the query parameter to a product category, your query would return a list of products in that category. You can set the parameter programmatically, but most applications use parameters that reflect values that a user sets.  
  
#### To create a parameterized query  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Products.lsml** node, and then choose **Add Query**.  
  
     The **Query Editor** opens.  
  
2.  In the **Properties** window, name the query `ProductsByCategory`.  
  
3.  In the **Query Designer**, choose the **Add Filter** link.  
  
4.  In the first list, choose **Where**.  
  
5.  In the second list, choose **CategoryID**.  
  
6.  In the third list, choose **= (equals)**.  
  
7.  In the fourth list, choose **Parameter**.  
  
8.  In the final list, choose **Add New**.  
  
     ![The ProductsByCategory parameterized query](../vs140/media/ls_tour29.PNG "LS_Tour29")  
  
     A parameter that's named `CategoryID`, of type `Integer` is created and added to the **Parameters** section of the **Query Editor**.  
  
## Closer Look  
 This lesson showed how to create a parameterized query that returns a subset of products. At run time, a **CategoryID** box is provided on a screen based on this query so that a user can specify a numeric value for the `CategoryID` parameter. For example, if the user specifies `1` in the box, all products in the Beverages category will be returned. If the user specifies `2`, Condiments will be returned.  
  
 The user can type the parameter value into a text box or select it from a list. It can also be provided by another entity on a screen. For example, when a product is selected on a screen, you could use its **CategoryID** as a parameter to return all other products in the same category.  
  
## Next Steps  
 In the next lesson, you’ll learn how to use the parameterized query that you just created on a screen.  
  
 Next lesson: [Using a Parameterized Query on a Screen](../vs140/using-a-parameterized-query-on-a-lightswitch-screen.md)  
  
## See Also  
 [Filtering Data with Queries](../vs140/filtering-data-with-queries-in-lightswitch.md)   
 [How to: Provide a Value to a Query Parameter](../vs140/how-to--provide-a-value-to-a-query-parameter.md)   
 [How to: Extend a Query by Using Code](../vs140/how-to--extend-a-query-by-using-code.md)   
 [Queries: Retrieving Information From a Data Source](../vs140/queries--retrieving-information-from-a-data-source.md)