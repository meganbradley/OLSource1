---
title: "How to: Return a Query from a Method (C# Programming Guide)"
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
  - "queries [LINQ in C#], method returns query"
  - "query expressions [LINQ in C#], method returns query"
  - "method returns query [C#]"
ms.assetid: 9d6f20a7-f085-44cf-9df3-71948255ec68
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Return a Query from a Method (C# Programming Guide)
This example shows how to return a query from a method as the return value and as an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> parameter.  
  
 Any query must have a type of \<xref:System.Collections.IEnumerable*> or <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*>. Therefore any return value or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter of a method that returns a query must also have that type. If a method materializes a query into a concrete <xref:System.Collections.Generic.List<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>out<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>using` directive for the System.Linq namespace.  
  
-   Replace the class with the code in the example.  
  
-   Press F5 to compile and run the program.  
  
-   Press any key to exit the console window.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)