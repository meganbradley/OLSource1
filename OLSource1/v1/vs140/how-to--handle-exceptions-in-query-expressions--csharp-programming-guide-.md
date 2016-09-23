---
title: "How to: Handle Exceptions in Query Expressions (C# Programming Guide)"
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
  - exceptions [C#], LINQ queries
  - query expressions [LINQ in C#], exceptions
  - queries [LINQ in C#], exceptions
ms.assetid: 4ce6c081-7731-4b8f-b4fa-d947f165a18a
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Handle Exceptions in Query Expressions (C# Programming Guide)
It is possible to call any method in the context of a query expression. However, we recommend that you avoid calling any method in a query expression that can create a side effect such as modifying the contents of the data source or throwing an exception. This example shows how to avoid raising exceptions when you call methods in a query expression without violating the general [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] guidelines on exception handling. Those guidelines state that it is acceptable to catch a specific exception when you understand why it will be thrown in a given context. For more information, see [Best Practices for Handling Exceptions](assetId:///f06da765-235b-427a-bfb6-47cd219af539).  
  
 The final example shows how to handle those cases when you must throw an exception during execution of a query.  
  
## Example  
 The following example shows how to move exception handling code outside a query expression. This is only possible when the method does not depend on any variables local to the query.  
  
 [!code[csProgGuideLINQ#10](../vs140/codesnippet/CSharp/how-to--handle-exceptions-in-query-expressions--csharp-programming-guide-_1.cs)]
  
  
## Example  
 In some cases, the best response to an exception that is thrown from within a query might be to stop the query execution immediately. The following example shows how to handle exceptions that might be thrown from inside a query body. Assume that `SomeMethodThatMightThrow` can potentially cause an exception that requires the query execution to stop.  
  
 Note that the `try` block encloses the `foreach` loop, and not the query itself. This is because the `foreach` loop is the point at which the query is actually executed. For more information, see [The Three Parts of a LINQ Query](../vs140/introduction-to-linq-queries--csharp-.md).  
  
 [!code[csProgGuideLINQ#12](../vs140/codesnippet/CSharp/how-to--handle-exceptions-in-query-expressions--csharp-programming-guide-_2.cs)]
  
  
## Compiling the Code  
  
-   Create a [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] project that targets the .NET Framework version 3.5. By default, the project has a reference to System.Core.dll and a `using` directive for the System.Linq namespace.  
  
-   Copy the code into your project.  
  
-   Press F5 to compile and run the program.  
  
 Press any key to exit the console window.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)