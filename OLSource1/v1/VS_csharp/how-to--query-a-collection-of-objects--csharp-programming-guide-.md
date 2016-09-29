---
title: "How to: Query a Collection of Objects (C# Programming Guide)"
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
  - "query expressions [LINQ in C#], object collections"
  - "object collection querying [C#]"
  - "queries [LINQ in C#], object collections"
ms.assetid: 122d1e3b-1604-4add-b6b4-b84530a77b6b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Query a Collection of Objects (C# Programming Guide)
This example shows how to perform a simple query over a list of `Student` objects. Each `Student` object contains some basic information about the student, and a list that represents the student's scores on four examinations.  
  
 This application serves as the framework for many other examples in this section that use the same `students` data source.  
  
## Example  
 The following query returns the students who received a score of 90 or greater on their first exam.  
  
 [!code[csProgGuideLINQ#15](../VS_csharp/codesnippet/CSharp/how-to--query-a-collection-of-objects--csharp-programming-guide-_1.cs)]  
  
 This query is intentionally simple to enable you to experiment. For example, you can try more predicates in the `where` clause, or use an `orderby` clause to sort the results.  
  
## Compiling the Code  
  
-   Create a [!INCLUDE[vs_current_short](../VS_csharp/includes/vs_current_short_md.md)] project that targets the .NET Framework version 3.5. By default, the project has a reference to System.Core.dll and a `using` directive for the System.Linq namespace.  
  
-   Copy the code into your project.  
  
-   Press F5 to compile and run the program.  
  
-   Press any key to exit the console window.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../VS_csharp/linq-query-expressions--csharp-programming-guide-.md)