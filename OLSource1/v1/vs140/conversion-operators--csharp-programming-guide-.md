---
title: "Conversion Operators (C# Programming Guide)"
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
  - "C# language, conversion operators"
  - "conversion operators [C#]"
  - "operators [C#], conversion"
  - "user-defined conversions [C#]"
ms.assetid: c5ad73a3-d57b-4d2b-b4c9-24e3c2856efc
caps.latest.revision: 26
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversion Operators (C# Programming Guide)
C# enables programmers to declare conversions on classes or structs so that classes or structs can be converted to and/or from other classes or structs, or basic types. Conversions are defined like operators and are named for the type to which they convert. Either the type of the argument to be converted, or the type of the result of the conversion, but not both, must be the containing type.  
  
 [!code[csProgGuideStatements#10](../vs140/codesnippet/CSharp/conversion-operators--csharp-programming-guide-_1.cs)]  
  
## Conversion Operators Overview  
 Conversion operators have the following properties:  
  
-   Conversions declared as `implicit` occur automatically when it is required.  
  
-   Conversions declared as `explicit` require a cast to be called.  
  
-   All conversions must be declared as `static`.  
  
## Related Sections  
 For more information:  
  
-   [Using Conversion Operators (C#)](../vs140/using-conversion-operators--csharp-programming-guide-.md)  
  
-   [Casting and Type Conversions (C# Programming Guide)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md)  
  
-   [How to: Implement User-Defined Conversions Between Structs (C#)](../vs140/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-.md)  
  
-   [explicit (C# Reference)](../vs140/explicit--csharp-reference-.md)  
  
-   [implicit](../vs140/implicit--csharp-reference-.md)  
  
-   [static (C# Reference)](../vs140/static--csharp-reference-.md)  
  
## See Also  
 <xref:System.Convert*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Chained user-defined explicit conversions in C#](http://go.microsoft.com/fwlink/?LinkId=112384)