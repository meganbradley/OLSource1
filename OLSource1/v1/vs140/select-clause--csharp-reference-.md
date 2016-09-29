---
title: "select clause (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "select_CSharpKeyword"
  - "select"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "select keyword [C#]"
  - "select clause [C#]"
ms.assetid: df01e266-5781-4aaa-80c4-67cf28ea093f
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# select clause (C# Reference)
In a query expression, the `select` clause specifies the type of values that will be produced when the query is executed. The result is based on the evaluation of all the previous clauses and on any expressions in the `select` clause itself. A query expression must terminate with either a `select` clause or a [group](../vs140/group-clause--csharp-reference-.md) clause.  
  
 The following example shows a simple `select` clause in a query expression.  
  
 [!code[cscsrefQueryKeywords#8](../vs140/codesnippet/CSharp/select-clause--csharp-reference-_1.cs)]  
  
 The type of the sequence produced by the `select` clause determines the type of the query variable `queryHighScores`. In the simplest case, the `select` clause just specifies the range variable. This causes the returned sequence to contain elements of the same type as the data source. For more information, see [Type Relationships in Query Operations (LINQ)](../vs140/type-relationships-in-linq-query-operations--csharp-.md). However, the `select` clause also provides a powerful mechanism for transforming (or *projecting*) source data into new types. For more information, see [Data Transformations with LINQ](../vs140/data-transformations-with-linq--csharp-.md).  
  
## Example  
 The following example shows all the different forms that a `select` clause may take. In each query, note the relationship between the `select` clause and the type of the *query variable* (`studentQuery1`, `studentQuery2`, and so on).  
  
 [!code[cscsrefQueryKeywords#9](../vs140/codesnippet/CSharp/select-clause--csharp-reference-_2.cs)]  
  
 As shown in `studentQuery8` in the previous example, sometimes you might want the elements of the returned sequence to contain only a subset of the properties of the source elements. By keeping the returned sequence as small as possible you can reduce the memory requirements and increase the speed of the execution of the query. You can accomplish this by creating an anonymous type in the `select` clause and using an object initializer to initialize it with the appropriate properties from the source element. For an example of how to do this, see [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md).  
  
## Remarks  
 At compile time, the `select` clause is translated to a method call to the <xref:System.Linq.Enumerable.Select*> standard query operator.  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)   
 [from clause(C# Reference)](../vs140/from-clause--csharp-reference-.md)   
 [where clause (C# Reference)](../vs140/partial--method---csharp-reference-.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md)