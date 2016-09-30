---
title: "into (C# Reference)"
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
  - "into_CSharpKeyword"
  - "into"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "into keyword [C#]"
ms.assetid: 81ec62c1-f0b1-4755-8a31-959876e77f65
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# into (C# Reference)
The `into` contextual keyword can be used to create a temporary identifier to store the results of a [group](../vs140/group-clause--csharp-reference-.md), [join](../vs140/join-clause--csharp-reference-.md) or [select](../vs140/select-clause--csharp-reference-.md) clause into a new identifier. This identifier can itself be a generator for additional query commands. When used in a `group` or `select` clause, the use of the new identifier is sometimes referred to as a *continuation*.  
  
## Example  
 The following example shows the use of the `into` keyword to enable a temporary identifier `fruitGroup` which has an inferred type of `IGrouping`. By using the identifier, you can invoke the \<xref:System.Linq.Enumerable.Count*> method on each group and select only those groups that contain two or more words.  
  
 [!code[cscsrefQueryKeywords#18](../vs140/codesnippet/CSharp/into--csharp-reference-_1.cs)]  
  
 The use of `into` in a `group` clause is only necessary when you want to perform additional query operations on each group. For more information, see [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md).  
  
 For an example of the use of `into` in a `join` clause, see [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md).  
  
## See Also  
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md)