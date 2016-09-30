---
title: "How to: Use Lambda Expressions in a Query (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "lambda expressions [C#], in LINQ"
ms.assetid: 3cac4d25-d11f-4abd-9e7c-0f02e97ae06d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Lambda Expressions in a Query (C# Programming Guide)
You do not use lambda expressions directly in query syntax, but you do use them in method calls, and query expressions can contain method calls. In fact, some query operations can only be expressed in method syntax. For more information about the difference between query syntax and method syntax, see [Query Syntax versus Method Syntax (LINQ)](../vs140/query-syntax-and-method-syntax-in-linq--csharp-.md).  
  
## Example  
 The following example demonstrates how to use a lambda expression in a method-based query by using the \<xref:System.Linq.Enumerable.Where*?displayProperty=fullName> standard query operator. Note that the \<xref:System.Linq.Enumerable.Where*> method in this example has an input parameter of the delegate type <xref:System.Func<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>Expression<Func\<int,bool>><CodeContentPlaceHolder>1\</CodeContentPlaceHolder>GradeLevel<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>Sum<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>Sum<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Sum<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>StudentClass<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>Main` method.  
  
## See Also  
 [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md)   
 [Expression Trees](../vs140/expression-trees--csharp-and-visual-basic-.md)