---
title: "From Clause (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.QueryFrom"
  - "vb.QueryFromIn"
  - "vb.QueryFromLet"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "queries [Visual Basic], From"
  - "From clause"
  - "From statement"
ms.assetid: 83e3665e-68a0-4540-a3a3-3d777a0f95d5
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# From Clause (Visual Basic)
Specifies one or more range variables and a collection to query.  
  
## Syntax  
  
```  
From element [ As type ] In collection [ _ ]  
  [, element2 [ As type2 ] In collection2 [, ... ] ]  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`element`|Required. A *range variable* used to iterate through the elements of the collection. A range variable is used to refer to each member of the `collection` as the query iterates through the `collection`. Must be an enumerable type.|  
|`type`|Optional. The type of `element`. If no `type` is specified, the type of `element` is inferred from `collection`.|  
|`collection`|Required. Refers to the collection to be queried. Must be an enumerable type.|  
  
## Remarks  
 The `From` clause is used to identify the source data for a query and the variables that are used to refer to an element from the source collection. These variables are called *range variables*. The `From` clause is required for a query, except when the `Aggregate` clause is used to identify a query that returns only aggregated results. For more information, see [Aggregate Clause (Visual Basic)](../VS_csharp/aggregate-clause--visual-basic-.md).  
  
 You can specify multiple `From` clauses in a query to identify multiple collections to be joined. When multiple collections are specified, they are iterated over independently, or you can join them if they are related. You can join collections implicitly by using the `Select` clause, or explicitly by using the `Join` or `Group Join` clauses. As an alternative, you can specify multiple range variables and collections in a single `From` clause, with each related range variable and collection separated from the others by a comma. The following code example shows both syntax options for the `From` clause.  
  
 [!code[VbSimpleQuerySamples#21](../VS_csharp/codesnippet/VisualBasic/from-clause--visual-basic-_1.vb)]  
  
 The `From` clause defines the scope of a query, which is similar to the scope of a `For` loop. Therefore, each `element` range variable in the scope of a query must have a unique name. Because you can specify multiple `From` clauses for a query, subsequent `From` clauses can refer to range variables in the `From` clause, or they can refer to range variables in a previous `From` clause. For example, the following example shows a nested `From` clause where the collection in the second clause is based on a property of the range variable in the first clause.  
  
 [!code[VbSimpleQuerySamples#22](../VS_csharp/codesnippet/VisualBasic/from-clause--visual-basic-_2.vb)]  
  
 Each `From` clause can be followed by any combination of additional query clauses to refine the query. You can refine the query in the following ways:  
  
-   Combine multiple collections implicitly by using the `From` and `Select` clauses, or explicitly by using the `Join` or `Group Join` clauses.  
  
-   Use the `Where` clause to filter the query result.  
  
-   Sort the result by using the `Order By` clause.  
  
-   Group similar results together by using the `Group By` clause.  
  
-   Use the `Aggregate` clause to identify aggregate functions to evaluate for the whole query result.  
  
-   Use the `Let` clause to introduce an iteration variable whose value is determined by an expression instead of a collection.  
  
-   Use the `Distinct` clause to ignore duplicate query results.  
  
-   Identify parts of the result to return by using the `Skip`, `Take`, `Skip While`, and `Take While` clauses.  
  
## Example  
 The following query expression uses a `From` clause to declare a range variable `cust` for each `Customer` object in the `customers` collection. The `Where` clause uses the range variable to restrict the output to customers from the specified region. The `For Each` loop displays the company name for each customer in the query result.  
  
 [!code[VbSimpleQuerySamples#23](../VS_csharp/codesnippet/VisualBasic/from-clause--visual-basic-_3.vb)]  
  
## See Also  
 [Queries (Visual Basic)](../VS_csharp/queries--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../VS_csharp/introduction-to-linq-in-visual-basic.md)   
 [For Each...Next Statement (Visual Basic)](../VS_csharp/for-each...next-statement--visual-basic-.md)   
 [For...Next Statement (Visual Basic)](../VS_csharp/for...next-statement--visual-basic-.md)   
 [Select Clause](../VS_csharp/select-clause--visual-basic-.md)   
 [Where Clause](../VS_csharp/where-clause--visual-basic-.md)   
 [Aggregate Clause (Visual Basic)](../VS_csharp/aggregate-clause--visual-basic-.md)   
 [Distinct Clause (Visual Basic)](../VS_csharp/distinct-clause--visual-basic-.md)   
 [Join Clause (Visual Basic)](../VS_csharp/join-clause--visual-basic-.md)   
 [Group Join Clause (Visual Basic)](../VS_csharp/group-join-clause--visual-basic-.md)   
 [Order By Clause (Visual Basic)](../VS_csharp/order-by-clause--visual-basic-.md)   
 [Let Clause (Visual Basic)](../VS_csharp/let-clause--visual-basic-.md)   
 [Skip Clause (Visual Basic)](../VS_csharp/skip-clause--visual-basic-.md)   
 [Take Clause (Visual Basic)](../VS_csharp/take-clause--visual-basic-.md)   
 [Skip While Clause (Visual Basic)](../VS_csharp/skip-while-clause--visual-basic-.md)   
 [Take While Clause (Visual Basic)](../VS_csharp/take-while-clause--visual-basic-.md)