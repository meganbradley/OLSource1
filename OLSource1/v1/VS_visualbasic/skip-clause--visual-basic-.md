---
title: "Skip Clause (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.QuerySkip"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "queries [Visual Basic], Skip"
  - "Skip statement"
  - "Skip clause"
ms.assetid: f00eb172-3907-4c43-9745-d8546ab86234
caps.latest.revision: 17
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Skip Clause (Visual Basic)
Bypasses a specified number of elements in a collection and then returns the remaining elements.  
  
## Syntax  
  
```  
Skip count  
```  
  
## Parts  
 `count`  
 Required. A value or an expression that evaluates to the number of elements of the sequence to skip.  
  
## Remarks  
 The `Skip` clause causes a query to bypass elements at the beginning of a results list and return the remaining elements. The number of elements to skip is identified by the `count` parameter.  
  
 You can use the `Skip` clause with the `Take` clause to return a range of data from any segment of a query. To do this, pass the index of the first element of the range to the `Skip` clause and the size of the range to the `Take` clause.  
  
 When you use the `Skip` clause in a query, you may also need to ensure that the results are returned in an order that will enable the `Skip` clause to bypass the intended results. For more information about ordering query results, see [Order By Clause](../VS_visualbasic/order-by-clause--visual-basic-.md).  
  
 You can use the `SkipWhile` clause to specify that only certain elements are ignored, depending on a supplied condition.  
  
## Example  
 The following code example uses the `Skip` clause together with the `Take` clause to return data from a query in pages. The `GetCustomers` function uses the `Skip` clause to bypass the customers in the list until the supplied starting index value, and uses the `Take` clause to return a page of customers starting from that index value.  
  
 [!code[VbSimpleQuerySamples#1](../VS_visualbasic/codesnippet/VisualBasic/skip-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../VS_visualbasic/introduction-to-linq-in-visual-basic.md)   
 [Queries](../VS_visualbasic/queries--visual-basic-.md)   
 [Select Clause](../VS_visualbasic/select-clause--visual-basic-.md)   
 [From Clause](../VS_visualbasic/from-clause--visual-basic-.md)   
 [Order By Clause](../VS_visualbasic/order-by-clause--visual-basic-.md)   
 [Skip While Clause](../VS_visualbasic/skip-while-clause--visual-basic-.md)   
 [Take Clause](../VS_visualbasic/take-clause--visual-basic-.md)