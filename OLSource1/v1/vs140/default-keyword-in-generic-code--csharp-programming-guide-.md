---
title: "default Keyword in Generic Code (C# Programming Guide)"
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
  - generics [C#], default keyword
  - default keyword [C#], generic programming
ms.assetid: b9daf449-4e64-496e-8592-6ed2c8875a98
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# default Keyword in Generic Code (C# Programming Guide)
In generic classes and methods, one issue that arises is how to assign a default value to a parameterized type T when you do not know the following in advance:  
  
-   Whether T will be a reference type or a value type.  
  
-   If T is a value type, whether it will be a numeric value or a struct.  
  
 Given a variable t of a parameterized type T, the statement t = null is only valid if T is a reference type and t = 0 will only work for numeric value types but not for structs. The solution is to use the `default` keyword, which will return null for reference types and zero for numeric value types. For structs, it will return each member of the struct initialized to zero or null depending on whether they are value or reference types. For nullable value types, default returns a <xref:System.Nullable`1?qualifyHint=True>, which is initialized like any struct.  
  
 The following example from the `GenericList<T>` class shows how to use the `default` keyword. For more information, see [Generics Overview](../vs140/introduction-to-generics--csharp-programming-guide-.md).  
  
 [!code[csProgGuideGenerics#41](../vs140/codesnippet/CSharp/default-keyword-in-generic-code--csharp-programming-guide-_1.cs)]
  
  
## See Also  
 <xref:System.Collections.Generic?qualifyHint=False>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics (C# Programmer's Reference)](../vs140/generics--csharp-programming-guide-.md)   
 [Generic Methods (C#)](../vs140/generic-methods--csharp-programming-guide-.md)   
 [Generics in the .NET Framework](assetId:///2994d786-c5c7-4666-ab23-4c83129fe39c)