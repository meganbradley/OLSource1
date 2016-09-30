---
title: "How to: Retrieve Data from a Query by Using Code"
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
  - "queries [Visual Studio LightSwitch], executing"
  - "executing queries [Visual Studio LightSwitch]"
  - "queries [Visual Studio LightSwitch], retrieving data"
ms.assetid: c3393804-5285-4ceb-b4f8-078566a43a23
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Retrieve Data from a Query by Using Code
You can retrieve queries from the model and then execute them in your code. This enables you to work with targeted collections of data in the business logic of your application.  
  
 For example, your model might contain a query named <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. To determine if a product is available, you can write validation code that retrieves the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> query, and then executes the query. After the query executes, your code can iterate over the resulting collection. If a product in this collection matches a product in the current sales order, the user can notify the customer about the delay.  
  
 You can also add code to narrow the results of a query by using a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause. Using a where clause to narrow the results of a query can improve performance because the conditions of the where clause are applied on the server tier. For more information, see [Queries: Providing Targeted Information](../vs140/queries--retrieving-information-from-a-data-source.md).  
  
## Example: Retrieving Data from a Query and Iterating through the Results  
 The following helper method is called when a user adds a new line to a sales order. If you had an entity named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, you might call this method from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method.  
  
 This code retrieves the top ten customers based on sales orders by executing a query named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  If the ID of the customer who placed this order matches the ID of any customers returned by the query, a 10% discount is applied to the line item.  
  
 [!code[LS_Queries#3](../vs140/codesnippet/CSharp/how-to--retrieve-data-from-a-query-by-using-code_1.cs)]
[!code[LS_Queries#3](../vs140/codesnippet/VisualBasic/how-to--retrieve-data-from-a-query-by-using-code_1.vb)]  
  
## Example: Narrowing the Results of a Query by Applying a Where Clause  
 The following code can be used as an alternative to the previous example. This code applies a where clause to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> query and only returns a customer if the customer is placing the current order..  
  
 [!code[LS_Queries#4](../vs140/codesnippet/CSharp/how-to--retrieve-data-from-a-query-by-using-code_2.cs)]
[!code[LS_Queries#4](../vs140/codesnippet/VisualBasic/how-to--retrieve-data-from-a-query-by-using-code_2.vb)]  
  
## Next Steps  
 To learn how to design a query visually by using a designer, see [How to: Design a Query by Using the Query Designer](../vs140/how-to--design-a-query-by-using-the-query-designer.md).  
  
 To learn how to extend a query in the model by using code, see [How to: Extend a Query by Using Code](../vs140/how-to--extend-a-query-by-using-code.md).  
  
## See Also  
 [Queries: Providing Targeted Information](../vs140/queries--retrieving-information-from-a-data-source.md)   
 [How to: Add, Remove, and Modify a Query](../vs140/how-to--add--remove--and-modify-a-query.md)   
 [Walkthrough: The Screen Designer](../vs140/walkthrough--designing-a-silverlight-screen-in-lightswitch.md)   
 [How to: Design a Query by Using the Query Designer](../vs140/how-to--design-a-query-by-using-the-query-designer.md)   
 [How to: Extend a Query by Using Code](../vs140/how-to--extend-a-query-by-using-code.md)