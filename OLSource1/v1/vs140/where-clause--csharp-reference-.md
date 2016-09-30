---
title: "where clause (C# Reference)"
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
  - "whereclause_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "where keyword [C#]"
  - "where clause [C#]"
ms.assetid: 7f9bf952-7744-4f91-b676-cddb55d107c3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# where clause (C# Reference)
The `where` clause is used in a query expression to specify which elements from the data source will be returned in the query expression. It applies a Boolean condition (*predicate*) to each source element (referenced by the range variable) and returns those for which the specified condition is true. A single query expression may contain multiple `where` clauses and a single clause may contain multiple predicate subexpressions.  
  
## Example  
 In the following example, the `where` clause filters out all numbers except those that are less than five. If you remove the `where` clause, all numbers from the data source would be returned. The expression `num < 5` is the predicate that is applied to each element.  
  
 [!code[cscsrefQueryKeywords#5](../vs140/codesnippet/CSharp/where-clause--csharp-reference-_1.cs)]  
  
## Example  
 Within a single `where` clause, you can specify as many predicates as necessary by using the [&&](../vs140/---operator--csharp-reference-.md) and [&#124;&#124;](../vs140/---operator--csharp-reference-.md) operators. In the following example, the query specifies two predicates in order to select only the even numbers that are less than five.  
  
 [!code[cscsrefQueryKeywords#6](../vs140/codesnippet/CSharp/where-clause--csharp-reference-_2.cs)]  
  
## Example  
 A `where` clause may contain one or more methods that return Boolean values. In the following example, the `where` clause uses a method to determine whether the current value of the range variable is even or odd.  
  
 [!code[cscsrefQueryKeywords#7](../vs140/codesnippet/CSharp/where-clause--csharp-reference-_3.cs)]  
  
## Remarks  
 The `where` clause is a filtering mechanism. It can be positioned almost anywhere in a query expression, except it cannot be the first or last clause. A `where` clause may appear either before or after a [group](../vs140/group-clause--csharp-reference-.md) clause depending on whether you have to filter the source elements before or after they are grouped.  
  
 If a specified predicate is not valid for the elements in the data source, a compile-time error will result. This is one benefit of the strong type-checking provided by [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)].  
  
 At compile time the `where` keyword is converted into a call to the \<xref:System.Linq.Enumerable.Where*> Standard Query Operator method.  
  
## See Also  
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)   
 [from (C# Reference)](../vs140/from-clause--csharp-reference-.md)   
 [select (C# Reference)](../vs140/select-clause--csharp-reference-.md)   
 [Filtering Data](../vs140/filtering-data.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md)