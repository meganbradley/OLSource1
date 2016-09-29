---
title: "Take Clause (Visual Basic)"
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
  - "vb.QueryTake"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Take statement"
  - "queries [Visual Basic], Take"
  - "Take clause"
ms.assetid: 77bf87b2-1476-4456-957f-fee922fbad8c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Take Clause (Visual Basic)
Returns a specified number of contiguous elements from the start of a collection.  
  
## Syntax  
  
```  
Take count  
```  
  
## Parts  
 `count`  
 Required. A value or an expression that evaluates to the number of elements of the sequence to return.  
  
## Remarks  
 The `Take` clause causes a query to include a specified number of contiguous elements from the start of a results list. The number of elements to include is specified by the `count` parameter.  
  
 You can use the `Take` clause with the `Skip` clause to return a range of data from any segment of a query. To do this, pass the index of the first element of the range to the `Skip` clause and the size of the range to the `Take` clause. In this case, the `Take` clause must be specified after the `Skip` clause.  
  
 When you use the `Take` clause in a query, you may also need to ensure that the results are returned in an order that will enable the `Take` clause to include the intended results. For more information about ordering query results, see [Order By Clause (Visual Basic)](../VS_csharp/order-by-clause--visual-basic-.md).  
  
 You can use the `TakeWhile` clause to specify that only certain elements be returned, depending on a supplied condition.  
  
## Example  
 The following code example uses the `Take` clause together with the `Skip` clause to return data from a query in pages. The GetCustomers function uses the `Skip` clause to bypass the customers in the list until the supplied starting index value, and uses the `Take` clause to return a page of customers starting from that index value.  
  
 [!code[VbSimpleQuerySamples#1](../VS_csharp/codesnippet/VisualBasic/take-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../VS_csharp/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../VS_csharp/queries--visual-basic-.md)   
 [Select Clause](../VS_csharp/select-clause--visual-basic-.md)   
 [From Clause](../VS_csharp/from-clause--visual-basic-.md)   
 [Order By Clause (Visual Basic)](../VS_csharp/order-by-clause--visual-basic-.md)   
 [Take While Clause (Visual Basic)](../VS_csharp/take-while-clause--visual-basic-.md)   
 [Skip Clause (Visual Basic)](../VS_csharp/skip-clause--visual-basic-.md)