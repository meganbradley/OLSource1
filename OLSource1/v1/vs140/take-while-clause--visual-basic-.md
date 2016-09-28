---
title: "Take While Clause (Visual Basic)"
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
  - "vb.QueryTakeWhile"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "queries [Visual Basic], Take While"
  - "Take While clause"
  - "Take While statement"
ms.assetid: db8f9f2f-fc9f-4a6c-b0b8-1bf048147e11
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Take While Clause (Visual Basic)
Includes elements in a collection as long as a specified condition is `true` and bypasses the remaining elements.  
  
## Syntax  
  
```  
Take While expression  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`expression`|Required. An expression that represents a condition to test elements for. The expression must return a `Boolean` value or a functional equivalent, such as an `Integer` to be evaluated as a `Boolean`.|  
  
## Remarks  
 The `Take While` clause includes elements from the start of a query result until the supplied `expression` returns `false`. After the `expression` returns `false`, the query will bypass all remaining elements. The `expression` is ignored for the remaining results.  
  
 The `Take While` clause differs from the `Where` clause in that the `Where` clause can be used to include all elements from a query that meet a particular condition. The `Take While` clause includes elements only until the first time that the condition is not satisfied. The `Take While` clause is most useful when you are working with an ordered query result.  
  
## Example  
 The following code example uses the `Take While` clause to retrieve results until the first customer without any orders is found.  
  
 [!code[VbSimpleQuerySamples#2](../vs140/codesnippet/VisualBasic/take-while-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Take Clause](../vs140/take-clause--visual-basic-.md)   
 [Skip While Clause](../vs140/skip-while-clause--visual-basic-.md)   
 [Where Clause](../vs140/where-clause--visual-basic-.md)