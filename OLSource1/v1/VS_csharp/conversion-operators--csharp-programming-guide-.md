---
title: "Conversion Operators (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 22
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Conversion Operators (C# Programming Guide)
C# enables programmers to declare conversions on classes or structs so that classes or structs can be converted to and/or from other classes or structs, or basic types. Conversions are defined like operators and are named for the type to which they convert. Either the type of the argument to be converted, or the type of the result of the conversion, but not both, must be the containing type.  
  
 [!code[csProgGuideStatements#10](../VS_csharp/codesnippet/CSharp/conversion-operators--csharp-programming-guide-_1.cs)]  
  
## Conversion Operators Overview  
 Conversion operators have the following properties:  
  
-   Conversions declared as `implicit` occur automatically when it is required.  
  
-   Conversions declared as `explicit` require a cast to be called.  
  
-   All conversions must be declared as `static`.  
  
## Related Sections  
 For more information:  
  
-   [Using Conversion Operators](../VS_csharp/using-conversion-operators--csharp-programming-guide-.md)  
  
-   [Casting and Type Conversions](../VS_csharp/casting-and-type-conversions--csharp-programming-guide-.md)  
  
-   [How to: Implement User-Defined Conversions Between Structs](../VS_csharp/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-.md)  
  
-   [explicit](../VS_csharp/explicit--csharp-reference-.md)  
  
-   [implicit](../VS_csharp/implicit--csharp-reference-.md)  
  
-   [static](../VS_csharp/static--csharp-reference-.md)  
  
## See Also  
 \<xref:System.Convert>   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Chained user-defined explicit conversions in C#](http://go.microsoft.com/fwlink/?LinkId=112384)