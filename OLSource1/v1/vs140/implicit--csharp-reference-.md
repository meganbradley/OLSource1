---
title: "implicit (C# Reference)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - implicit
  - implicit_CSharpKeyword
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - implicit keyword [C#]
ms.assetid: 34db590e-eb3a-4f11-88d0-ffb3cd753dab
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# implicit (C# Reference)
The `implicit` keyword is used to declare an implicit user-defined type conversion operator. Use it to enable implicit conversions between a user-defined type and another type, if the conversion is guaranteed not to cause a loss of data.  
  
## Example  
 [!code[csrefKeywordsConversion#5](../vs140/codesnippet/CSharp/implicit--csharp-reference-_1.cs)]
  
  
 By eliminating unnecessary casts, implicit conversions can improve source code readability. However, because implicit conversions do not require programmers to explicitly cast from one type to the other, care must be taken to prevent unexpected results. In general, implicit conversion operators should never throw exceptions and never lose information so that they can be used safely without the programmer's awareness. If a conversion operator cannot meet those criteria, it should be marked `explicit`. For more information, see [Using Conversion Operators](../vs140/using-conversion-operators--csharp-programming-guide-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [explicit](../vs140/explicit--csharp-reference-.md)   
 [operator (C# Reference)](../vs140/operator--csharp-reference-2.md)   
 [How to: Implement User-Defined Conversions Between Structs (C#)](../vs140/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-.md)