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
 The following example demonstrates how to use a lambda expression in a method-based query by using the <xref:System.Linq.Enumerable.Where*?displayProperty=fullName> standard query operator. Note that the <xref:System.Linq.Enumerable.Where*> method in this example has an input parameter of the delegate type <xref:System.Func`1*> and that delegate takes an integer as input and returns a Boolean. The lambda expression can be converted to that delegate. If this were a [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] query that used the <xref:System.Linq.Queryable.Where*?displayProperty=fullName> method, the parameter type would be an `Expression<Func<int,bool>>` but the lambda expression would look exactly the same. For more information on the Expression type, see <xref:System.Linq.Expressions.Expression*?displayProperty=fullName>.  
  
 [!code[csProgGuideLINQ#1](../vs140/codesnippet/CSharp/how-to--use-lambda-expressions-in-a-query--csharp-programming-guide-_1.cs)]  
  
## Example  
 The following example demonstrates how to use a lambda expression in a method call of a query expression. The lambda is necessary because the <xref:System.Linq.Enumerable.Sum*> standard query operator cannot be invoked by using query syntax.  
  
 The query first groups the students according to their grade level, as defined in the `GradeLevel` enum. Then for each group it adds the total scores for each student. This requires two `Sum` operations. The inner `Sum` calculates the total score for each student, and the outer `Sum` keeps a running, combined total for all students in the group.  
  
 [!code[csProgGuideLINQ#2](../vs140/codesnippet/CSharp/how-to--use-lambda-expressions-in-a-query--csharp-programming-guide-_2.cs)]  
  
## Compiling the Code  
 To run this code, copy and paste the method into the `StudentClass` that is provided in [How to: Query a Collection of Objects (C# Programming Guide)](../vs140/how-to--query-a-collection-of-objects--csharp-programming-guide-.md) and call it from the `Main` method.  
  
## See Also  
 [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md)   
 [Expression Trees](../vs140/expression-trees--csharp-and-visual-basic-.md)