---
title: "let clause (C# Reference)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - let_CSharpKeyword
  - let
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - let keyword [C#]
  - let clause [C#]
ms.assetid: 13c9c1a4-ce57-48ef-8e1b-4c2a59b99fb4
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# let clause (C# Reference)
In a query expression, it is sometimes useful to store the result of a sub-expression in order to use it in subsequent clauses. You can do this with the `let` keyword, which creates a new range variable and initializes it with the result of the expression you supply. Once initialized with a value, the range variable cannot be used to store another value. However, if the range variable holds a queryable type, it can be queried.  
  
## Example  
 In the following example `let` is used in two ways:  
  
1.  To create an enumerable type that can itself be queried.  
  
2.  To enable the query to call `ToLower` only one time on the range variable `word`. Without using `let`, you would have to call `ToLower` in each predicate in the `where` clause.  
  
 [!code[cscsrefQueryKeywords#28](../vs140/codesnippet/CSharp/let-clause--csharp-reference-_1.cs)]
  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md)   
 [How To: Avoid Exceptions in Query Expressions](../vs140/how-to--handle-exceptions-in-query-expressions--csharp-programming-guide-.md)