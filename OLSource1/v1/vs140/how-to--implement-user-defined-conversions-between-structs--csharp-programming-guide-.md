---
title: "How to: Implement User-Defined Conversions Between Structs (C# Programming Guide)"
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
  - "user-defined conversions [C#]"
ms.assetid: 97839aef-8fbc-40d5-9769-6b569bc2710b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Implement User-Defined Conversions Between Structs (C# Programming Guide)
This example defines two structs, `RomanNumeral` and `BinaryNumeral`, and demonstrates conversions between them.  
  
## Example  
 [!code[csProgGuideStatements#13](../vs140/codesnippet/CSharp/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-_1.cs)]  
  
## Robust Programming  
  
-   In the previous example, the statement:  
  
     [!code[csProgGuideStatements#14](../vs140/codesnippet/CSharp/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-_2.cs)]  
  
     performs a conversion from a `RomanNumeral` to a `BinaryNumeral`. Because there is no direct conversion from `RomanNumeral` to `BinaryNumeral`, a cast is used to convert from a `RomanNumeral` to an `int`, and another cast to convert from an `int` to a `BinaryNumeral`.  
  
-   Also the statement  
  
     [!code[csProgGuideStatements#15](../vs140/codesnippet/CSharp/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-_3.cs)]  
  
     performs a conversion from a `BinaryNumeral` to a `RomanNumeral`. Because `RomanNumeral` defines an implicit conversion from `BinaryNumeral`, no cast is required.  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Conversion Operators (C#)](../vs140/conversion-operators--csharp-programming-guide-.md)