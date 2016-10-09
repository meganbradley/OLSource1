---
title: "let clause (C# Reference)"
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
  - "let_CSharpKeyword"
  - "let"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "let keyword [C#]"
  - "let clause [C#]"
ms.assetid: 13c9c1a4-ce57-48ef-8e1b-4c2a59b99fb4
caps.latest.revision: 15
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
# let clause (C# Reference)
In a query expression, it is sometimes useful to store the result of a sub-expression in order to use it in subsequent clauses. You can do this with the `let` keyword, which creates a new range variable and initializes it with the result of the expression you supply. Once initialized with a value, the range variable cannot be used to store another value. However, if the range variable holds a queryable type, it can be queried.  
  
## Example  
 In the following example `let` is used in two ways:  
  
1.  To create an enumerable type that can itself be queried.  
  
2.  To enable the query to call `ToLower` only one time on the range variable `word`. Without using `let`, you would have to call `ToLower` in each predicate in the `where` clause.  
  
 [!code[cscsrefQueryKeywords#28](../VS_csharp/codesnippet/CSharp/let-clause--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [Query Keywords (LINQ)](../VS_csharp/query-keywords--csharp-reference-.md)   
 [LINQ Query Expressions](../VS_csharp/linq-query-expressions--csharp-programming-guide-.md)   
 [Getting Started with LINQ in C#](../VS_csharp/getting-started-with-linq-in-csharp.md)   
 [How to: Handle Exceptions in Query Expressions](../VS_csharp/how-to--handle-exceptions-in-query-expressions--csharp-programming-guide-.md)