---
title: "How to: Extend a Query by Using Code"
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
  - "queries [Visual Studio LightSwitch], extending"
  - "queries [Visual Studio LightSwitch], adding to a query by using code"
ms.assetid: c716fd50-cd3e-46d5-871f-e1cb7d406221
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Extend a Query by Using Code
If you want to modify a query in ways that go beyond the capabilities of the query designer, you can extend the query by writing code.   
[!INCLUDE[smb_current_long](../vs140/includes/smb_current_long_md.md)] combines the conditions that you specify in the query designer with the conditions that you specify in your code to produce the query result. For more information, see [Queries: Retrieving Information From a Data Source by Using a Query](../vs140/queries--retrieving-information-from-a-data-source.md).  
  
> [!NOTE]
>  You cannot extend the query of a screen. You can only extend queries that appear in **Solution Explorer**. For more information about editing the query of a screen, see [How to: Filter Data on a Screen](../vs140/how-to--filter-data-on-a-silverlight-screen.md).  
  
### To extend a query by using code  
  
1.  Open a query in the **Query Designer**. For more information, see [How to: Add, Open, or Modify a Query](../vs140/how-to--add--remove--and-modify-a-query.md).  
  
2.  In the **Properties** window, click **Edit Additional Query Code**.  
  
     The server code file opens in the Code Editor. A method that represents your query appears in the code file. The name of the method starts with the name of your query and ends with the word `_PreprocessQuery`. For example, if the name of your query is `GetCustomers`, the name of the method that appears in Code Editor is `GetCustomers_PreprocessQuery`.  
  
3.  Customize the query by adding code to this method. Use LINQ syntax. For more information about how to write LINQ queries in Visual Basic, see [Getting Started with LINQ in Visual Basic](../vs140/getting-started-with-linq-in-visual-basic.md). For more information about how to write queries in C#, see [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md).  
  
## Examples  
 The following examples show two ways to modify a query by using code.  
  
### Top *N* Customers Based on Sales Orders  
 The following query returns customers who have placed the greatest number of orders. A parameter named `TopN` is passed into the method. The `TopN` parameter specifies the number of customers to return in the result.  
  
> [!NOTE]
>  Add parameters in the query designer.  
  
 [!code[LS_Queries#1](../vs140/codesnippet/CSharp/how-to--extend-a-query-by-using-code_1.cs)][!code[LS_Queries#1](../vs140/codesnippet/VisualBasic/how-to--extend-a-query-by-using-code_1.vb)]  
  
 You cannot design this query by using the query designer for the following reasons:  
  
-   Orders appear on the many side of the customer-order relationship. The query designer prevents you from referencing related entities that have a multiplicity of many.  
  
-   The query counts orders by using the <xref:System.Linq.Queryable.Count*> operation. The query designer does not support the use of operations such as <xref:System.Linq.Queryable.Count*>, <xref:System.Linq.Queryable.Aggregate*>, and <xref:System.Linq.Queryable.Sum*>.  
  
### All Customers Who Purchased a Specific Product  
 The following query returns all customers who purchased a specific product by navigating several one-to-many relationships.  
  
 [!code[LS_Queries#2](../vs140/codesnippet/CSharp/how-to--extend-a-query-by-using-code_2.cs)][!code[LS_Queries#2](../vs140/codesnippet/VisualBasic/how-to--extend-a-query-by-using-code_2.vb)]  
  
 You cannot design this query by using the query designer because the query designer prevents you from referencing related entities that have a multiplicity of many.  
  
## Next Steps  
 To learn how to design a query visually, see [How to: Design a Query by Using the Query Designer](../vs140/how-to--design-a-query-by-using-the-query-designer.md).  
  
 To learn how to use a query in a screen, see [How to: Filter Data in a Screen by Using a Query](../vs140/how-to--filter-data-on-a-silverlight-screen.md).  
  
 To learn how to run a query within custom code that you add to an application, see [How to: Retrieve Data From a Query by Using Code](../vs140/how-to--retrieve-data-from-a-query-by-using-code.md).  
  
## See Also  
 [Queries: Retrieving Information From a Data Source by Using a Query](../vs140/queries--retrieving-information-from-a-data-source.md)   
 [How to: Add, Remove, and Modify a Query](../vs140/how-to--add--remove--and-modify-a-query.md)   
 [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md)   
 [Getting Started with LINQ in Visual Basic](../vs140/getting-started-with-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)