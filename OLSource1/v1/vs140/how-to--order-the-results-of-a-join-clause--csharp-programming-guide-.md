---
title: "How to: Order the Results of a Join Clause (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - join clause [C#]
  - joins [C#], ordering results
  - query expressions [LINQ in C#], joins
  - queries [LINQ in C#], joins
ms.assetid: 83f36f16-2ba3-453f-8b9f-7d02b415610e
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Order the Results of a Join Clause (C# Programming Guide)
This example shows how to order the results of a join operation. Note that the ordering is performed after the join. Although you can use an `orderby` clause with one or more of the source sequences before the join, generally we do not recommend it. Some [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] providers might not preserve that ordering after the join.  
  
## Example  
 This query creates a group join, and then sorts the groups based on the category element, which is still in scope. Inside the anonymous type initializer, a sub-query orders all the matching elements from the products sequence.  
  
 [!code[csProgGuideLINQ#81](../vs140/codesnippet/CSharp/how-to--order-the-results-of-a-join-clause--csharp-programming-guide-_1.cs)]
  
  
## Compiling the Code  
  
-   Create a [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] project that targets the .NET Framework version 3.5. By default, the project has a reference to System.Core.dll and a `using` directive for the System.Linq namespace.  
  
-   Copy the code into your project.  
  
-   Press F5 to compile and run the program.  
  
-   Press any key to exit the console window.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [orderby clause (C# Reference)](../vs140/orderby-clause--csharp-reference-.md)   
 [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md)   
 [Join Operations](../vs140/join-operations.md)