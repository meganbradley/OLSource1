---
title: "select clause (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 19
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# select clause (C# Reference)
In a query expression, the `select` clause specifies the type of values that will be produced when the query is executed. The result is based on the evaluation of all the previous clauses and on any expressions in the `select` clause itself. A query expression must terminate with either a `select` clause or a [group](../VS_csharp/group-clause--csharp-reference-.md) clause.  
  
 The following example shows a simple `select` clause in a query expression.  
  
 [!code[cscsrefQueryKeywords#8](../VS_csharp/codesnippet/CSharp/select-clause--csharp-reference-_1.cs)]  
  
 The type of the sequence produced by the `select` clause determines the type of the query variable `queryHighScores`. In the simplest case, the `select` clause just specifies the range variable. This causes the returned sequence to contain elements of the same type as the data source. For more information, see [Type Relationships in LINQ Query Operations](../VS_csharp/type-relationships-in-linq-query-operations--csharp-.md). However, the `select` clause also provides a powerful mechanism for transforming (or *projecting*) source data into new types. For more information, see [Data Transformations with LINQ (C#)](../VS_csharp/data-transformations-with-linq--csharp-.md).  
  
## Example  
 The following example shows all the different forms that a `select` clause may take. In each query, note the relationship between the `select` clause and the type of the *query variable* (`studentQuery1`, `studentQuery2`, and so on).  
  
 [!code[cscsrefQueryKeywords#9](../VS_csharp/codesnippet/CSharp/select-clause--csharp-reference-_2.cs)]  
  
 As shown in `studentQuery8` in the previous example, sometimes you might want the elements of the returned sequence to contain only a subset of the properties of the source elements. By keeping the returned sequence as small as possible you can reduce the memory requirements and increase the speed of the execution of the query. You can accomplish this by creating an anonymous type in the `select` clause and using an object initializer to initialize it with the appropriate properties from the source element. For an example of how to do this, see [Object and Collection Initializers](../VS_csharp/object-and-collection-initializers--csharp-programming-guide-.md).  
  
## Remarks  
 At compile time, the `select` clause is translated to a method call to the \<xref:System.Linq.Enumerable.Select*> standard query operator.  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [Query Keywords (LINQ)](../VS_csharp/query-keywords--csharp-reference-.md)   
 [from clause](../VS_csharp/from-clause--csharp-reference-.md)   
 [partial (Method) (C# Reference)](../VS_csharp/partial--method---csharp-reference-.md)   
 [Anonymous Types](../VS_csharp/anonymous-types--csharp-programming-guide-.md)   
 [LINQ Query Expressions](../VS_csharp/linq-query-expressions--csharp-programming-guide-.md)   
 [Getting Started with LINQ in C#](../VS_csharp/getting-started-with-linq-in-csharp.md)