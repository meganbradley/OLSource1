---
title: "Distinct Clause (Visual Basic)"
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
  - "vb.QueryDistinct"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Distinct clause"
  - "Distinct statement"
  - "queries [Visual Basic], Distinct"
ms.assetid: 86f42614-0d8f-4ffc-b888-ce8a37a8d36a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Distinct Clause (Visual Basic)
Restricts the values of the current range variable to eliminate duplicate values in subsequent query clauses.  
  
## Syntax  
  
```  
Distinct  
```  
  
## Remarks  
 You can use the `Distinct` clause to return a list of unique items. The `Distinct` clause causes the query to ignore duplicate query results. The `Distinct` clause applies to duplicate values for all return fields specified by the `Select` clause. If no `Select` clause is specified, the `Distinct` clause is applied to the range variable for the query identified in the `From` clause. If the range variable is not an immutable type, the query will only ignore a query result if all members of the type match an existing query result.  
  
## Example  
 The following query expression joins a list of customers and a list of customer orders. The `Distinct` clause is included to return a list of unique customer names and order dates.  
  
 [!code[VbSimpleQuerySamples#20](../vs140/codesnippet/VisualBasic/distinct-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [Where Clause (Visual Basic)](../vs140/where-clause--visual-basic-.md)